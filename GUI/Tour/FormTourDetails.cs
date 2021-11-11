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
        private readonly BUS_Category bCategory = new BUS_Category();
        private List<Category> _listCategory;
        private readonly BUS_Price bPrice = new BUS_Price();
        private readonly BUS_Location bLoation = new BUS_Location();
        private readonly BUS_TourDeltail bLocationDetail = new BUS_TourDeltail();
        private FrmMainMenu FrmMainMenu;
        public FrmTourDetails(DAL.Entities.Tour currentSelectedTour,FrmMainMenu frmMain)
        {
            InitializeComponent();
            FrmMainMenu = frmMain;
            _currentTour = currentSelectedTour;
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
        }

        private void btnAddPrice_Click(object sender, EventArgs e)
        {
            Price giaTour = new Price();
            giaTour.Money = ConvertStringToFloat(txtPrice.Text);
            giaTour.TourId = _currentTour.TourId;
            giaTour.StartDate = dtpickerStart.Value;
            giaTour.EndDate = dtpickerEnd.Value;
            // insert to database
            bPrice.Insert(giaTour);

            _currentTour.Prices.Add(giaTour);
            var priceDto = bPrice.mapper.Map<List<Price>, List<DTO_Price>>(_currentTour.Prices.ToList());
            dtgvPrice.DataSource = priceDto;
        }

        // convert string to float
        private float ConvertStringToFloat(string str)
        {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (CheckNumberic(txtSerial.Text))
            {
                TourDetail chiTiet = new TourDetail()
                {
                    LocationId = Int32.Parse(cbbLocation.SelectedValue.ToString()),
                    TourId   = _currentTour.TourId,
                    Serial = Convert.ToInt32(txtSerial.Text)
                };
                bLocationDetail.Insert(chiTiet);
                chiTiet.Location = new Location() { LocationName = cbbLocation.Text };
                _currentTour.TourDetails.Add(chiTiet);
            }
            else
            {
                // Call message box
                MessageBox.Show("Serial must be numberic");
            }
            var locationDto = bLoation.mapper.Map<List<TourDetail>, List<DTO_ChiTietTour>>(_currentTour.TourDetails.ToList());
            dtgvLocation.DataSource = locationDto;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmListTour frmListTour = new FrmListTour(FrmMainMenu);
            FrmMainMenu.OpenChildForm(frmListTour);
        }

        private bool CheckNumberic(string str)
        {
            int result = 0;
            return int.TryParse(str, out result);
        }
    }
}
