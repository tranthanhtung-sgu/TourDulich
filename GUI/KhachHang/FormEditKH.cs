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
    public partial class FormEditKH : Form
    {
        Customer currentCustomer;
        BUS_Customer bCustomer = new BUS_Customer();
        public FormEditKH(Customer _customer)
        {
            InitializeComponent();
            currentCustomer = _customer;
        }

        private void FormEditKH_Load(object sender, EventArgs e)
        {
            loadCountries();
            txtFullName.Text = currentCustomer.FullName;
            txtCCCD.Text = currentCustomer.IdentityNumber;
            txtAddress.Text = currentCustomer.Address;
            int result = checkGender();
            if(result != 1)
            rbFemale.Checked = int.TryParse(checkGender().ToString(), out result);
            rbMale.Checked = int.TryParse(checkGender().ToString(), out result);

            txtPhone.Text = currentCustomer.PhoneNumber;
            cbbNation.Text = currentCustomer.Nation;

        }

      
        private void loadCountries()
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
            countries.Sort();
        }


        private int checkGender()
        {
            if (rbMale.Checked)
                return 1;
            return 0;
        }

        bool CheckNumberic(string str)
        {
            int result = 0;
            return int.TryParse(str, out result);
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtFullName.Equals("") || txtCCCD.Equals("") || txtAddress.Equals("") || txtPhone.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin");
                return;

            }
            // Kiểm tra tên khách hàng
            if (CheckNumberic(txtFullName.Text))
            {
                MessageBox.Show("Tên khách hàng bị sai định dạng");
                return;
            }
            //Kiểm tra định dạng Số căn cước
            if (!CheckNumberic(txtCCCD.Text) && txtCCCD.TextLength != 12)
            {
                MessageBox.Show("Số căn cước phải ở dạng 12 chữ số");
                txtCCCD.SelectAll();
                txtCCCD.Focus();
                return;
            }

            //Kiểm tra định dạng Số điện thoại
            if (!CheckNumberic(txtPhone.Text) && txtPhone.TextLength != 10)
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
            // Chỉnh sửa thông tin khách
            currentCustomer.FullName = txtFullName.Text;
            currentCustomer.IdentityNumber = txtCCCD.Text;
            currentCustomer.Address = txtAddress.Text;
            currentCustomer.Gender = checkGender();
            currentCustomer.PhoneNumber = txtPhone.Text;
            currentCustomer.Nation = cbbNation.Text;

            //Cập nhật thông tin khách xuống Database
            bCustomer.Update(currentCustomer);
            MessageBox.Show("Cập nhật thành công");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
