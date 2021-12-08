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
    public partial class FormKHDetail : Form
    {
        List<Customer> listCustomer;
        BUS_Customer bCustomer = new BUS_Customer();
        Customer currentCustomer = new Customer();


        public FormKHDetail(Customer _currenCustomer)
        {
            currentCustomer = _currenCustomer;
            listCustomer = (List<Customer>)bCustomer.GetAll();
            InitializeComponent();
            this.Load += FormKHDetail_Load;
        }

        private void FormKHDetail_Load(object sender, EventArgs e)
        {
            LoadCountries();
            showCustomerInfo();
            dtgvCustomer.DataSource = listCustomer;
            dtgvCustomer.Columns[4].Visible = false;
            dtgvCustomer.Columns[7].Visible = false;
            readOnlyData();
        }

        void showCustomerInfo()
        {
            txtFullName.Text = currentCustomer.FullName;
            txtCCCD.Text = currentCustomer.IdentityNumber;
            txtAddress.Text = currentCustomer.Address;
            int result = checkGender(currentCustomer);

            if (result != 1)
                rbFemale.Checked = int.TryParse(checkGender(currentCustomer).ToString(), out result);
            rbMale.Checked = int.TryParse(checkGender(currentCustomer).ToString(), out result);

            txtPhone.Text = currentCustomer.PhoneNumber;
            cbbNation.Text = currentCustomer.Nation;
        }

        void LoadCountries()
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

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  txtFullName.Text = "";
            txtCCCD.Text = "";
            txtAddress.Text = "";
            rbMale.Checked = rbFemale.Checked = false;
            txtPhone.Text = "";
            cbbNation.ResetText();
          */

            int index = dtgvCustomer.CurrentCell.RowIndex;
            currentCustomer = listCustomer[index];
            txtFullName.Text = currentCustomer.FullName;
            txtCCCD.Text = currentCustomer.IdentityNumber;
            txtAddress.Text = currentCustomer.Address;
            int result = checkGender(currentCustomer);
            if (result != 1)
            {
                rbFemale.Checked = true;
                rbMale.Checked = false;
            } else
            {
                rbFemale.Checked = false;
                rbMale.Checked = true;
            }
            //rbFemale.Checked = int.TryParse(rbFemale.Text, out result);
            //rbMale.Checked = int.TryParse(rbMale.Text, out result);


            txtPhone.Text = currentCustomer.PhoneNumber;
            cbbNation.Text = currentCustomer.Nation;

        }

        private int checkGender(Customer customer)
        {
            if (customer.Gender == 1)
                return 1;
            return 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
             Close();
        }

        void readOnlyData()
        {
            txtFullName.Enabled = false;
            txtCCCD.Enabled = false;
            txtAddress.Enabled = false;
            rbMale.Enabled = rbFemale.Enabled = false;
            txtPhone.Enabled = false;
            cbbNation.Enabled = false;
            dtgvCustomer.ReadOnly = true;

        }


    }
}
