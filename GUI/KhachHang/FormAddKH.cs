using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.KhachHang
{
    public partial class FormAddKH : Form

    {
        private List<Customer> listCustomer;
        private BUS_Customer bCustomer = new BUS_Customer();
        private Customer customer = new Customer();
        public FormAddKH()
        {
            listCustomer = (List<Customer>)bCustomer.GetAll();
            InitializeComponent();
            this.Load += FormAddKH_Load;
        }
        private void FormAddKH_Load(object sender, EventArgs e)
        {
            loadCountries();
        }

        void loadCountries()
        {
            List<String> countries = new List<string>();
            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            RegionInfo region;
            foreach (CultureInfo item in cultures)
            {
                region = new RegionInfo(item.LCID);
                if (!(countries.Contains(region.EnglishName)))
                {
                    countries.Add(region.EnglishName);
                    cbbNation.Items.Add(region.EnglishName);

                }
            }
            // Sắp xếp tên quốc tịch theo thứ tự từ A-Z
            countries.Sort();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFullName_Keydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtCCCD.Focus();
            }
        }

        private void txtCCCD_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtAddress_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbMale.Focus();
            }
        }

        private void rbMale_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbFemale.Focus();
            }
        }

        private void rbFemale_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }


        private void txtPhone_Keydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbbNation.Focus();
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if(txtFullName.Equals("") || txtCCCD.Equals("")  || txtAddress.Equals("") || txtPhone.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
                return;

            }

            if (checkNumberic(txtFullName.Text))
            {
                MessageBox.Show("Tên khách hàng không được là số");
                return;
            }

            //Kiểm tra định dạng Số căn cước
            if (!checkNumberic(txtCCCD.Text) && txtCCCD.TextLength != 12)
            {
                MessageBox.Show("Số căn cước phải ở dạng 12 chữ số");
              
                txtCCCD.SelectAll();
                txtCCCD.Focus();
                return;
            }

            //Kiểm tra định dạng Số điện thoại
            if (!checkNumberic(txtPhone.Text) && txtPhone.TextLength != 10)
            {
                MessageBox.Show("Số căn cước phải ở dạng 10 chữ số");
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }
            // Kiểm tra giới tính 
            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
                return;
            }


            customer = new Customer()
            {
                FullName = txtFullName.Text,
                IdentityNumber = txtCCCD.Text,
                Address = txtAddress.Text,
                Gender = checkGender(),
                PhoneNumber = txtPhone.Text,
                Nation = cbbNation.SelectedItem.ToString()

            };

            bCustomer.Insert(customer);
            listCustomer.Add(customer);
          //  var dto = bLocation.mapper.Map<List<Location>, List<DTO_Location>>(locations);
        //    dtgvLocation.DataSource = dto.ToList();
            //message box success
            MessageBox.Show("Thêm thành công");
            clearAllData();

        }

        void clearAllData()
        {
            txtFullName.Clear();
            txtCCCD.Clear();
            txtAddress.Clear();
            rbMale.Checked = rbFemale.Checked = false;
            txtPhone.Clear();
            cbbNation.ResetText();

        }
        
        int checkGender()
        {
            if (rbMale.Checked)
                return 1;
            return 0;
        }

         bool checkNumberic(string str)
         {
            int result = 0;
            return int.TryParse(str, out result);
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
