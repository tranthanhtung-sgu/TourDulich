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
        private BUS_CostCategory bConst = new BUS_CostCategory();
        private List<CostCategory> _costCategory = new List<CostCategory>();
        private FrmMainMenu FrmMainMenu;
        private DAL.Entities.Tour tour = null;

        private string status = "";

        public FormDoanDetail(TouristGroup? touristGroup, FrmMainMenu frmMain)
        {
            FrmMainMenu = frmMain;
            _tours = bTour.GetAll();
            _staffs = bStaff.GetAllStaff();
            _costCategory = (List<CostCategory>) bConst.GetAll();
            _customers = (List<Customer>)bCustomer.GetAll();
            InitializeComponent();
            if (touristGroup == null)
            {
                _currentTouristGroup = new TouristGroup();
                status = "add";
                TimePickerStartDate.Value = DateTime.Today;
                TimePickerEndDate.Value = DateTime.Today.AddDays(1);
                // load tours to combobox 
                cbbTourName.DataSource = _tours;
                cbbTourName.DisplayMember = "TenGoi";
                cbbTourName.ValueMember = "TourId";
            }
            else
            {
                _currentTouristGroup = touristGroup;
                status = "edit";
                TimePickerStartDate.Value = _currentTouristGroup.StartDate;
                TimePickerEndDate.Value = _currentTouristGroup.EndDate;
                // load tours to combobox 
                cbbTourName.DataSource = _tours.Where(x => x.TourId == _currentTouristGroup.TourId).ToList();
                cbbTourName.DisplayMember = "TenGoi";
                cbbTourName.ValueMember = "TourId";
            }
            this.Load += Form_Load;
        }

        // form load
        private void Form_Load(object sender, EventArgs e)
        {
            txtHotel.SelectedText = _currentTouristGroup.Hotel;
            txtDescription.SelectedText = _currentTouristGroup.Description;

            // set time picker has many range max and min

            //set txt cannot edit
            txtCustomerPhone.ReadOnly = true;
            txtReveneu.ReadOnly = true;
            
            //set Revenue for tourist group 
            UpdateRevenue();

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

            // set dtgvCost just show column Name, Money
            dtgvCost.DataSource = _currentTouristGroup.TouristGroup_Costs.Select(x => new { x.CostCategory.Name, x.Money }).ToList();
            dtgvCost.Columns[0].HeaderText = "Loại";
            dtgvCost.Columns[1].HeaderText = "Mệnh giá";
            dtgvCost.Columns[0].Width = dtgvStaff.Width / 2;
            dtgvCost.Columns[1].Width = dtgvStaff.Width / 2;

            //set cbbCustomer to show all customer
            cbbCustomer.DataSource = _customers;
            cbbCustomer.DisplayMember = "FullName";
            cbbCustomer.ValueMember = "Id";

            //set cbbStaff to show all staff
            cbbStaff.DataSource = _staffs;
            cbbStaff.DisplayMember = "Name";
            cbbStaff.ValueMember = "Id";

            //set cbbCost to show all cost
            cbbCost.DataSource = _costCategory;
            cbbCost.DisplayMember = "Name";
            cbbCost.ValueMember = "Id";
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

            UpdateRevenue();


            // update dtgvCustomer
            dtgvCustomer.DataSource = _currentTouristGroup.TouristGroup_Customers.Select(x => new { x.Customer.FullName, x.Customer.PhoneNumber }).ToList();
        
            //messagebox
            MessageBox.Show("Thêm khách hàng thành công");
        }

        private void btnDelCustomer_Click(object sender, EventArgs e)
        {
            //delete customer from tourist group
            if(dtgvCustomer.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }
            int index = dtgvCustomer.CurrentRow.Index;
            TouristGroup_Customer touristGroup_Customer = _currentTouristGroup.TouristGroup_Customers.ElementAt(index);
            _currentTouristGroup.TouristGroup_Customers.Remove(touristGroup_Customer);

            UpdateRevenue();
           
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

            if(dtgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Chưa chọn nhân viên");
                return;
            }
            int index = dtgvStaff.CurrentRow.Index;
            TouristGroup_Staff touristGroup_Staff = _currentTouristGroup.TouristGroup_Staffs.ElementAt(index);
            _currentTouristGroup.TouristGroup_Staffs.Remove(touristGroup_Staff);

            // update dtgvStaff
            dtgvStaff.DataSource = _currentTouristGroup.TouristGroup_Staffs.Select(x => new { x.Staff.Name, x.Duty }).ToList();

            // messagebox
            MessageBox.Show("Xóa nhân viên thành công");
        }

        private void btnAddCost_Click(object sender, EventArgs e)
        {
            //check if cost is existed in tourist group
            if (_currentTouristGroup.TouristGroup_Costs.Any(x => x.CostCategoryId == ((CostCategory)cbbCost.SelectedItem).Id))
            {
                MessageBox.Show("Chi phí đã tồn tại trong danh sách");
                return;
            }
            // check if money is valid and is number
            if (txtMoney.Text == "" || !double.TryParse(txtMoney.Text, out double money))
            {
                MessageBox.Show("Nhập số tiền hợp lệ");
                return;
            }
            //add cost to tourist group
            CostCategory costCategory = new CostCategory();
            costCategory = ((CostCategory)cbbCost.SelectedItem);
            TouristGroup_Cost cost = new TouristGroup_Cost();
            cost.CostCategory = costCategory;
            cost.CostCategoryId = costCategory.Id;
            cost.TouristGroup = _currentTouristGroup;
            cost.TouristGroupId = _currentTouristGroup.Id;
            cost.Money = Convert.ToInt32(txtMoney.Text);

            _currentTouristGroup.TouristGroup_Costs.Add(cost);
            
            //set revenue textbox 
            UpdateRevenue();

            // update dtgvCost
            dtgvCost.DataSource = _currentTouristGroup.TouristGroup_Costs.Select(x => new { x.CostCategory.Name, x.Money }).ToList();

            //messagebox
            MessageBox.Show("Thêm chi phí thành công");
        }

        private void UpdateRevenue()
        {
            int numberCustomer = _currentTouristGroup.TouristGroup_Customers.Count;
            float TienBanVe = 0;
            // get price in prices of tour depend on the time of tourist group
            if(_currentTouristGroup.Tour != null)
            {
                foreach (var item in _currentTouristGroup.Tour.Prices)
                {
                    if (item.StartDate.Date <= _currentTouristGroup.StartDate.Date && item.EndDate.Date >= _currentTouristGroup.EndDate.Date)
                    {
                        TienBanVe = item.Money * numberCustomer;
                    }
                }
            }
            txtReveneu.Text = TienBanVe - _currentTouristGroup.TouristGroup_Costs.Sum(x => x.Money) + "";
        }

        private void btnDelCost_Click(object sender, EventArgs e)
        {
            // delete cost from tourist group

            

            //check if index is valid
            if (dtgvCost.CurrentRow == null)
            {
                MessageBox.Show("Chọn chi phí cần xóa");
                return;
            }
            int index = dtgvCost.CurrentCell.RowIndex;
            TouristGroup_Cost touristGroup_Cost = _currentTouristGroup.TouristGroup_Costs.ElementAt(index);
            _currentTouristGroup.TouristGroup_Costs.Remove(touristGroup_Cost);

            //set revenue textbox 
            UpdateRevenue();

            // update dtgvCost
            dtgvCost.DataSource = _currentTouristGroup.TouristGroup_Costs.Select(x => new { x.CostCategory.Name, x.Money }).ToList();

            // messagebox
            MessageBox.Show("Xóa chi phí thành công");
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
            _currentTouristGroup.Revenue = float.Parse(txtReveneu.Text);
          

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
            tour = (DAL.Entities.Tour)cbbTourName.SelectedItem;
            _currentTouristGroup.TourId = tour.TourId;

            // set time picker start date and end date depend on price of tour with many min and max date
            if (tour.Prices.Count > 0)
            {
                TimePickerStartDate.MinDate = tour.Prices.Min(x => x.StartDate);
                TimePickerStartDate.MaxDate = tour.Prices.Max(x => x.EndDate);
                TimePickerEndDate.MinDate = tour.Prices.Min(x => x.StartDate);
                TimePickerEndDate.MaxDate = tour.Prices.Max(x => x.EndDate);
            }
            else
            {
                TimePickerStartDate.MinDate = DateTime.Now;
                TimePickerStartDate.MaxDate = DateTime.Now.AddDays(1);
                TimePickerEndDate.MinDate = DateTime.Now;
                TimePickerEndDate.MaxDate = DateTime.Now.AddDays(1);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormListDoan frmListDoan = new FormListDoan(FrmMainMenu);
            FrmMainMenu.OpenChildForm(frmListDoan);
        }

        private void TimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            TimePickerEndDate.MinDate = TimePickerStartDate.Value;
        }

        private void TimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            TimePickerStartDate.MaxDate = TimePickerEndDate.Value;
        }
    }
}
