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
using DAL.Entities;

namespace GUI.DiaDiem
{
    public partial class LocationForm : Form
    {
        private List<Location> locations;
        private readonly BUS_Location bLocation = new BUS_Location();
        private List<DTO_Location> dtoLocations = new List<DTO_Location>();
        private Location currentLocation = new Location();
        public LocationForm()
        {
            locations = (List<Location>)bLocation.GetAll();
            InitializeComponent();
            this.Load += LocationForm_Load;
        }
        
        private void LocationForm_Load(object sender, EventArgs e)
        {
            dtoLocations = bLocation.mapper.Map<List<DTO_Location>>(locations);
            dtgvLocation.DataSource = dtoLocations;
            dtgvLocation.Columns[0].Width = dtgvLocation.Width / 5;
            dtgvLocation.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvLocation.Columns[1].Width = dtgvLocation.Width - dtgvLocation.Columns[0].Width + SystemInformation.VerticalScrollBarWidth - 1;
        }

        private void dtgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLocation.Text = "";
            int index = dtgvLocation.CurrentCell.RowIndex;

            //get item in list locations
            currentLocation = locations[index];
            txtLocation.SelectedText = currentLocation.LocationName;
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //checl if txtLocation is empty
            if (txtLocation.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm");
                return;
            }
            Location location = new Location(){
                LocationName = txtLocation.Text,
            };
            bLocation.Insert(location);
            locations.Add(location);
            var dto = bLocation.mapper.Map<List<Location>, List<DTO_Location>>(locations);
            dtgvLocation.DataSource = dto.ToList();
            //message box success
            MessageBox.Show("Thêm thành công");
        }

       
        private void btnUpdateLocation_Click(object sender, EventArgs e)
        {
            //check if txtLocation is empty
            if (txtLocation.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên địa điểm");
                return;
            }
            int index = dtgvLocation.CurrentCell.RowIndex;
            //get item in list locations
            currentLocation = locations[index];
            currentLocation.LocationName = txtLocation.Text;
            bLocation.Update(currentLocation);
            var dto = bLocation.mapper.Map<List<Location>, List<DTO_Location>>(locations);
            dtgvLocation.DataSource = dto.ToList();
            //message box success
            MessageBox.Show("Cập nhật thành công");
        }
    }
}
