using BUS;
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
    public partial class FrmAddTour : Form
    {
        BUS_Category _Category = new BUS_Category();
        BUS_Tour _Tour = new BUS_Tour();
        public FrmAddTour()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddTour_Load(object sender, EventArgs e)
        {
            cbb_TourType.Items.Insert(0, "---Chọn loại hình---");
            cbb_TourType.SelectedItem = 0;
            cbb_TourType.SelectedIndex = 0;
            foreach (var category in _Category.GetAll())
            {
                cbb_TourType.Items.Add(category.TenLoaiHinh);
            }
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            Tour tour = new Tour
            {
                TenGoi = txt_TourName.Text,
                MoTa = txt_TourDescription.Text,
                loaiHinhDuLich = new LoaiHinhDuLich { MaLoaiHinh = 3 }
            };
            _Tour.Insert(tour);
        }
    }
}
