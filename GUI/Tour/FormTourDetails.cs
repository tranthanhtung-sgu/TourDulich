using BUS;
using BUS.Dtos;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmTourDetails : Form
    {
        private readonly DAL.Entities.Tour _currentTour = null;
        private readonly BUS_Tour _busTour = new BUS_Tour();
        private readonly BUS_Category bCategory = new BUS_Category();
        private List<Category> _listCategory;
        private readonly BUS_Price bPrice = new BUS_Price();
        private readonly BUS_Location bLoation = new BUS_Location();
        private readonly BUS_TourDeltail bLocationDetail = new BUS_TourDeltail();
        private FrmMainMenu FrmMainMenu;
        private string status = "";
        public FrmTourDetails(DAL.Entities.Tour? currentSelectedTour, FrmMainMenu frmMain)
        {
            InitializeComponent();
            FrmMainMenu = frmMain;
            //is currentSelectedTour null
            if (currentSelectedTour == null)
            {
                _currentTour = new DAL.Entities.Tour();
                status = "add";
            }
            else
            {
                _currentTour = currentSelectedTour;
                status = "edit";
            }
            this.Load += Frm_Load;
        }
        private void Frm_Load(object sender, EventArgs e)
        {
            var priceDto = bPrice.mapper.Map<List<Price>, List<DTO_Price>>(_currentTour.Prices.ToList());
            var locationDto = bLoation.mapper.Map<List<TourDetail>, List<DTO_ChiTietTour>>(_currentTour.TourDetails.ToList());

            txtTourName.SelectedText = _currentTour.TenGoi;
            txtDescription.SelectedText = _currentTour.MoTa;
            _listCategory = bCategory.GetAll().ToList();
            cbbCategory.DataSource = bCategory.GetAll();
            cbbCategory.DisplayMember = "CategoryName";
            cbbCategory.ValueMember = "Id";

            cbbLocation.DataSource = bLoation.GetAll();
            cbbLocation.DisplayMember = "LocationName";
            cbbLocation.ValueMember = "Id";

            dtgvLocation.DataSource = locationDto;
            dtgvLocation.Columns[0].Width = dtgvLocation.Width / 2;
            dtgvLocation.Columns[1].Width = dtgvLocation.Width / 2;

            dtgvPrice.DataSource = priceDto;
            dtgvPrice.Columns[1].DefaultCellStyle.Format = "MM/dd/yyyy";
            dtgvPrice.Columns[2].DefaultCellStyle.Format = "MM/dd/yyyy";
            dtgvPrice.Columns[0].Width = (int)(dtgvPrice.Width / 2.7);
            dtgvPrice.Columns[1].Width = dtgvPrice.Width / 3;
            dtgvPrice.Columns[2].Width = dtgvPrice.Width / 3;

            //invisible btnUpdate if dtgv is empty
            btnUpdateLocation.Visible = dtgvLocation.Rows.Count > 0 ? true : false;
            btnUpdatePrice.Visible = dtgvPrice.Rows.Count > 0 ? true : false;

            dtpickerEnd.MinDate = dtpickerStart.Value.AddDays(1);
        }

        // convert string to float
        private float ConvertStringToFloat(string str)
        {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }

        private bool CheckNumberic(string str)
        {
            int result = 0;
            return int.TryParse(str, out result);
        }

        private void btnAddPrice_Click_1(object sender, EventArgs e)
        {
            // check if all fields are filled
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please input price");
                return;
            }
            // check if price is numberic
            if (!CheckNumberic(txtPrice.Text))
            {
                MessageBox.Show("Price must be numberic");
                return;
            }
            // check if start date and end date in range of any price in tour
            if (dtpickerStart.Value < dtpickerEnd.Value)
            {
                foreach (var item in _currentTour.Prices)
                {
                    if (dtpickerStart.Value >= item.StartDate && dtpickerStart.Value <= item.EndDate)
                    {
                        MessageBox.Show("Start date is in range of a price in tour");
                        return;
                    }
                    if (dtpickerEnd.Value >= item.StartDate && dtpickerEnd.Value <= item.EndDate)
                    {
                        MessageBox.Show("End date is in range of a price in tour");
                        return;
                    }
                }
            }
            Price giaTour = new Price();
            giaTour.Money = ConvertStringToFloat(txtPrice.Text);
            giaTour.TourId = _currentTour.TourId;
            giaTour.StartDate = dtpickerStart.Value;
            giaTour.EndDate = dtpickerEnd.Value;
            // insert to database
            //bPrice.Insert(giaTour);

            _currentTour.Prices.Add(giaTour);
            var priceDto = bPrice.mapper.Map<List<Price>, List<DTO_Price>>(_currentTour.Prices.ToList());
            dtgvPrice.DataSource = priceDto;
            // message susscess
            MessageBox.Show("Add price success");
            //invisible btnUpdate if dtgv is empty
            btnUpdatePrice.Visible = dtgvPrice.Rows.Count > 0 ? true : false;
        }

        private void btnBackTourList_Click(object sender, EventArgs e)
        {
            FrmListTour frmListTour = new FrmListTour(FrmMainMenu);
            FrmMainMenu.OpenChildForm(frmListTour);
        }

        private void btnAddLocation_Click_1(object sender, EventArgs e)
        {
            // check is txtSerial is filled
            if (txtSerial.Text == "")
            {
                MessageBox.Show("Please input serial");
                return;
            }
            // check if serial is numberic
            if (!CheckNumberic(txtSerial.Text))
            {
                MessageBox.Show("Serial must be numberic");
                return;
            }
            // check is serial exit in _currentTour.TourDetails
            if (_currentTour.TourDetails.Where(x => x.Serial == Convert.ToInt32(txtSerial.Text)).Count() > 0)
            {
                MessageBox.Show("Serial is exit");
                return;
            }
            TourDetail chiTiet = new TourDetail()
            {
                LocationId = Int32.Parse(cbbLocation.SelectedValue.ToString()),
                TourId   = _currentTour.TourId,
                Serial = Convert.ToInt32(txtSerial.Text)
            };
            //bLocationDetail.Insert(chiTiet);
            chiTiet.Location = new Location() { LocationName = cbbLocation.Text };
            _currentTour.TourDetails.Add(chiTiet);
        
            var locationDto = bLoation.mapper.Map<List<TourDetail>, List<DTO_ChiTietTour>>(_currentTour.TourDetails.ToList());
            dtgvLocation.DataSource = locationDto;
            //message suscess
            MessageBox.Show("Add location success");
            //invisible btnUpdate if dtgv is empty
            btnUpdateLocation.Visible = dtgvLocation.Rows.Count > 0 ? true : false;
        }

        private void dtpickerStart_ValueChanged(object sender, EventArgs e)
        {
            dtpickerEnd.MinDate = dtpickerStart.Value.AddDays(1);
        }
        private void dtpickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dtpickerStart.MaxDate = dtpickerEnd.Value.AddDays(-1);
        }

        private void dtgvPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // is dtgvPrice is empty
            if (dtgvPrice.Rows.Count == 0)
            {
                return;
            }
            int index = dtgvPrice.CurrentCell.RowIndex;
            //get price of current row
            Price price = _currentTour.Prices.ElementAt(index);
            txtPrice.Text = price.Money.ToString();
            dtpickerStart.Value = price.StartDate; 
            dtpickerEnd.Value = price.EndDate;
        }

        private void btnDelelePrice_Click(object sender, EventArgs e)
        {
            //is dtgvPrice is empty
            if (dtgvPrice.Rows.Count == 0)
            {
                return;
            }
            int index = dtgvPrice.CurrentCell.RowIndex;
            Price price = _currentTour.Prices.ElementAt(index);
            //bPrice.Delete(price.Id);
            _currentTour.Prices.Remove(price);
            var priceDto = bPrice.mapper.Map<List<Price>, List<DTO_Price>>(_currentTour.Prices.ToList());
            dtgvPrice.DataSource = priceDto;
            txtPrice.Clear();
            //message box susscess 
            MessageBox.Show("Delete success");

            //invisible btnUpdate if dtgv is empty
            btnUpdatePrice.Visible = dtgvPrice.Rows.Count > 0 ? true : false;
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            // check if all fields are filled
            if (txtPrice.Text == "")
            {
                MessageBox.Show("Please input price");
                return;
            }
            // check if price is numberic
            if (!CheckNumberic(txtPrice.Text))
            {
                MessageBox.Show("Price must be numberic");
                return;
            }
            // check if start date and end date in range of any price in tour
            if (dtpickerStart.Value < dtpickerEnd.Value)
            {
                foreach (var item in _currentTour.Prices)
                {
                    if (dtpickerStart.Value >= item.StartDate && dtpickerStart.Value <= item.EndDate)
                    {
                        MessageBox.Show("Start date is in range of a price in tour");
                        return;
                    }
                    if (dtpickerEnd.Value >= item.StartDate && dtpickerEnd.Value <= item.EndDate)
                    {
                        MessageBox.Show("End date is in range of a price in tour");
                        return;
                    }
                }
            }
            int index = dtgvPrice.CurrentCell.RowIndex;
            Price price = _currentTour.Prices.ElementAt(index);
            price.Money = ConvertStringToFloat(txtPrice.Text);
            price.StartDate = dtpickerStart.Value;
            price.EndDate = dtpickerEnd.Value;
            //bPrice.Update(price);
            var priceDto = bPrice.mapper.Map<List<Price>, List<DTO_Price>>(_currentTour.Prices.ToList());
            dtgvPrice.DataSource = priceDto;
            txtPrice.Clear();
            //message box susscess
            MessageBox.Show("Update success");
        }

        private void dtgvLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if dtgv is empty
            if (dtgvLocation.Rows.Count == 0)
            {
                return;
            }
            int index = dtgvLocation.CurrentCell.RowIndex;
            TourDetail chiTiet = _currentTour.TourDetails.ElementAt(index);
            cbbLocation.SelectedValue = chiTiet.LocationId;
            txtSerial.Text = chiTiet.Serial.ToString();
        }

        private void btnDeleteLocation_Click(object sender, EventArgs e)
        {
            //is dtgvLocation is empty
            if (dtgvLocation.Rows.Count == 0)
            {
                return;
            }
            int index = dtgvLocation.CurrentCell.RowIndex;
            TourDetail chiTiet = _currentTour.TourDetails.ElementAt(index);
            //bLocationDetail.Delete(chiTiet.Id);
            _currentTour.TourDetails.Remove(chiTiet);
            var locationDto = bLoation.mapper.Map<List<TourDetail>, List<DTO_ChiTietTour>>(_currentTour.TourDetails.ToList());
            dtgvLocation.DataSource = locationDto;
            txtSerial.Clear();
            this.Load += Frm_Load;
            //message box susscess
            MessageBox.Show("Delete success");

            //invisible btnUpdate if dtgv is empty
            btnUpdateLocation.Visible = dtgvLocation.Rows.Count > 0 ? true : false;
        }

        //update location
        private void btnUpdateLocation_Click(object sender, EventArgs e)
        {
            // check is txtSerial is filled
            if (txtSerial.Text == "")
            {
                MessageBox.Show("Please input serial");
                return;
            }
            // check if serial is numberic
            if (!CheckNumberic(txtSerial.Text))
            {
                MessageBox.Show("Serial must be numberic");
                return;
            }
            // check is serial exit in _currentTour.TourDetails
            if (_currentTour.TourDetails.Where(x => x.Serial == Convert.ToInt32(txtSerial.Text)).Count() > 0)
            {
                MessageBox.Show("Serial is exit");
                return;
            }
            int index = dtgvLocation.CurrentCell.RowIndex;
            TourDetail chiTiet = _currentTour.TourDetails.ElementAt(index);
            
            _currentTour.TourDetails.Remove(chiTiet);

            chiTiet.LocationId = Int32.Parse(cbbLocation.SelectedValue.ToString());
            chiTiet.Serial = Convert.ToInt32(txtSerial.Text);

            _currentTour.TourDetails.Insert(index, chiTiet);
            _currentTour.TourDetails.OrderBy(x => x.Serial);

            //bLocationDetail.UpdateDetails(_currentTour.TourDetails);
            _currentTour.TourDetails.FirstOrDefault(x=>x.Id == chiTiet.Id).Location = new Location() { LocationName = cbbLocation.Text };
            var locationDto = bLoation.mapper.Map<List<TourDetail>, List<DTO_ChiTietTour>>(_currentTour.TourDetails.ToList());
            dtgvLocation.DataSource = locationDto;
            //message box susscess
            MessageBox.Show("Update success");
        }

        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            //save tour to database
            // is txtTourName is empty
            if (txtTourName.Text == "")
            {
                MessageBox.Show("Tour name is empty");
                return;
            }
            _currentTour.TenGoi = txtTourName.Text;
            _currentTour.MoTa = txtDescription.Text;
            _currentTour.CategoryId = Int32.Parse(cbbCategory.SelectedValue.ToString());
            if (status == "add")
            {
                _busTour.InsertTour(_currentTour);
                FrmListTour frmListTour = new FrmListTour(FrmMainMenu);
                FrmMainMenu.OpenChildForm(frmListTour);
            }
            else
            {
                _busTour.UpdateTour(_currentTour);
                FrmListTour frmListTour = new FrmListTour(FrmMainMenu);
                FrmMainMenu.OpenChildForm(frmListTour);
            }
        }
    }
}
