using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.Dtos;
using DAL.Entities;

namespace GUI.Doan
{
    public partial class FormDoanDetail : Form
    {
        private TouristGroup _currentTouristGroup = new TouristGroup();
        private List<DAL.Entities.Tour> _tours = new List<DAL.Entities.Tour>();
        private BUS_Tour  bTour = new BUS_Tour();
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();
        private List<Customer> _customers = new List<Customer>();
        private BUS_Customer bCustomer = new BUS_Customer();
        private List<Staff> _staffs = new List<Staff>();
        private BUS_Staff bStaff = new BUS_Staff();
        private FrmMainMenu FrmMainMenu;

        private string status = "";

        public FormDoanDetail(TouristGroup? touristGroup, FrmMainMenu frmMain)
        {
            FrmMainMenu = frmMain;
            _tours = bTour.GetAll();
            _staffs = bStaff.GetAllStaff();
            _customers = (List<Customer>)bCustomer.GetAll();
            InitializeComponent();
            if (touristGroup == null)
            {
                _currentTouristGroup = new TouristGroup();
                status = "add";
            }
            else
            {
                _currentTouristGroup = touristGroup;
                status = "edit";
            }
            this.Load += Form_Load;
        }

        // form load
        private void Form_Load(object sender, EventArgs e)
        {
            // load tours to combobox 
            cbbTourName.DataSource = _tours;
            cbbTourName.DisplayMember = "TenGoi";
            cbbTourName.ValueMember = "TourId";

            txtHotel.SelectedText = _currentTouristGroup.Hotel;
            txtDescription.SelectedText = _currentTouristGroup.Description;

            //set txt cannot edit
            txtCustomerPhone.ReadOnly = true;
            txtReveneu.ReadOnly = true;
            
            //set Revenue for tourist group 
            txtReveneu.Text = _currentTouristGroup.Revenue.ToString();

            TimePickerStartDate.Value = _currentTouristGroup.StartDate;
            TimePickerEndDate.Value = _currentTouristGroup.EndDate;

            // set dtgvCustomer just show column CustomerId, CustomerName, CustomerPhone
            dtgvCustomer.DataSource = _currentTouristGroup.TouristGroup_Customers.Select(x => new { x.Customer.FullName, x.Customer.PhoneNumber }).ToList();
            dtgvCustomer.Columns[0].HeaderText = "Họ và tên";
            dtgvCustomer.Columns[1].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[0].Width = dtgvCustomer.Width / 2;
            dtgvCustomer.Columns[1].Width = dtgvCustomer.Width / 2;

            // set dtgvStaff just show column StaffId, StaffName, StaffPhone
            dtgvStaff.DataSource = _currentTouristGroup.TouristGroup_Staffs.Select(x => new { x.Staff.Name, x.Duty }).ToList();
            dtgvStaff.Columns[0].HeaderText = "Tên nhân viên";
            dtgvStaff.Columns[1].HeaderText = "Chức vụ";
            dtgvStaff.Columns[0].Width = dtgvStaff.Width / 2;
            dtgvStaff.Columns[1].Width = dtgvStaff.Width / 2;

            //set cbbCustomer to show all customer
            cbbCustomer.DataSource = _customers;
            cbbCustomer.DisplayMember = "FullName";
            cbbCustomer.ValueMember = "Id";

            //set cbbStaff to show all staff
            cbbStaff.DataSource = _staffs;
            cbbStaff.DisplayMember = "Name";
            cbbStaff.ValueMember = "Id";
        }

        private void cbbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set txtCustomerPhone to show phone number of selected customer
            txtCustomerPhone.Text = ((Customer)cbbCustomer.SelectedItem).PhoneNumber;
        }

        private void cbbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set txtDuty to show duty of selected staff
            Staff staff = (Staff)cbbStaff.SelectedItem;
            txtDuty.Text = staff.TouristGroup_Staffs.FirstOrDefault(x => x.StaffId == staff.Id) 
                == null ?
                "Chưa có chức vụ" : 
                staff.TouristGroup_Staffs.FirstOrDefault(x => x.StaffId == staff.Id).Duty;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            //check if customer is existed in tourist group
            if (_currentTouristGroup.TouristGroup_Customers.Any(x => x.CustomerId == ((Customer)cbbCustomer.SelectedItem).Id))
            {
                MessageBox.Show("Khách hàng đã tồn tại trong danh sách");
                return;
            }

            //add customer to tourist group
            TouristGroup_Customer touristGroup_Customer = new TouristGroup_Customer();
            touristGroup_Customer.Customer = ((Customer)cbbCustomer.SelectedItem);
            touristGroup_Customer.TouristGroup = _currentTouristGroup;
            touristGroup_Customer.CustomerId = ((Customer)cbbCustomer.SelectedItem).Id;
            touristGroup_Customer.TouristGroupId = _currentTouristGroup.Id;
            
            _currentTouristGroup.TouristGroup_Customers.Add(touristGroup_Customer);


            // update dtgvCustomer
            dtgvCustomer.DataSource = _currentTouristGroup.TouristGroup_Customers.Select(x => new { x.Customer.FullName, x.Customer.PhoneNumber }).ToList();
        
            //messagebox
            MessageBox.Show("Thêm khách hàng thành công");
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            //delete customer from tourist group

            int index = dtgvCustomer.CurrentCell.RowIndex;

            //check if index is valid
            if (index < 0)
            {
                MessageBox.Show("Chọn khách hàng cần xóa");
                return;
            }
            TouristGroup_Customer touristGroup_Customer = _currentTouristGroup.TouristGroup_Customers.ElementAt(index);
            _currentTouristGroup.TouristGroup_Customers.Remove(touristGroup_Customer);
           
            // update dtgvCustomer
            dtgvCustomer.DataSource = _currentTouristGroup.TouristGroup_Customers.Select(x => new { x.Customer.FullName, x.Customer.PhoneNumber }).ToList();
        
            // messagebox
            MessageBox.Show("Xóa khách hàng thành công");
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //check if staff is existed in tourist group
            if (_currentTouristGroup.TouristGroup_Staffs.Any(x => x.StaffId == ((Staff)cbbStaff.SelectedItem).Id))
            {
                MessageBox.Show("Nhân viên đã tồn tại trong danh sách");
                return;
            }

            //add staff to tourist group
            TouristGroup_Staff touristGroup_Staff = new TouristGroup_Staff();
            touristGroup_Staff.Staff = ((Staff)cbbStaff.SelectedItem);
            touristGroup_Staff.TouristGroup = _currentTouristGroup;
            touristGroup_Staff.StaffId = ((Staff)cbbStaff.SelectedItem).Id;
            touristGroup_Staff.TouristGroupId = _currentTouristGroup.Id;
            touristGroup_Staff.Duty = txtDuty.Text;

            _currentTouristGroup.TouristGroup_Staffs.Add(touristGroup_Staff);

            // update dtgvStaff
            dtgvStaff.DataSource = _currentTouristGroup.TouristGroup_Staffs.Select(x => new { x.Staff.Name, x.Duty }).ToList();

            //messagebox
            MessageBox.Show("Thêm nhân viên thành công");
        }

        private void btnDelStaff_Click(object sender, EventArgs e)
        {
            //delete staff from tourist group

            int index = dtgvStaff.CurrentCell.RowIndex;

            //check if index is valid
            if (index < 0)
            {
                MessageBox.Show("Chọn nhân viên cần xóa");
                return;
            }
            TouristGroup_Staff touristGroup_Staff = _currentTouristGroup.TouristGroup_Staffs.ElementAt(index);
            _currentTouristGroup.TouristGroup_Staffs.Remove(touristGroup_Staff);

            // update dtgvStaff
            dtgvStaff.DataSource = _currentTouristGroup.TouristGroup_Staffs.Select(x => new { x.Staff.Name, x.Duty }).ToList();

            // messagebox
            MessageBox.Show("Xóa nhân viên thành công");
        }

        private void btnSaveTouristGroup_Click(object sender, EventArgs e)
        {
            //save tourisgroup to database
            // is txtHotelName is empty and txtDescription is empty

            if (string.IsNullOrEmpty(txtHotel.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            
            _currentTouristGroup.Hotel = txtHotel.Text;
            _currentTouristGroup.Description = txtDescription.Text;
            _currentTouristGroup.StartDate = TimePickerStartDate.Value;
            _currentTouristGroup.EndDate = TimePickerEndDate.Value;

            //save to database
            if (status == "add")
            {
                bTouristGroup.InsertTouristGroup(_currentTouristGroup);
                FormListDoan formListDoan = new FormListDoan(FrmMainMenu);
                FrmMainMenu.OpenChildForm(formListDoan);
            }
            else
            {
                bTouristGroup.UpdateTouristGroup(_currentTouristGroup);
                FormListDoan formListDoan = new FormListDoan(FrmMainMenu);
                FrmMainMenu.OpenChildForm(formListDoan);
            }
        }

        private void cbbTourName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get tour selected
            DAL.Entities.Tour tour = (DAL.Entities.Tour)cbbTourName.SelectedItem;
            _currentTouristGroup.TourId = tour.TourId;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormListDoan frmListDoan = new FormListDoan(FrmMainMenu);
            FrmMainMenu.OpenChildForm(frmListDoan);
        }
    }
}
