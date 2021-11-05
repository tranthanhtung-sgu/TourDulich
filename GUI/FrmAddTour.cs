using BUS;
using BUS.Dtos;
using DAL;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
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
        //private readonly FormListTour _formListTour;
        public FrmAddTour()
        {
            InitializeComponent();
            //_formListTour = formListTour;
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
            var loaihinh = _Category.GetById(cbb_TourType.SelectedIndex);
            Tour tour = new Tour
            {
                TenGoi = txt_TourName.Text,
                MoTa = txt_TourDescription.Text,
                LoaiHinhDuLichId = loaihinh.LoaiHinhDuLichId,
            };
            _Tour.Insert(tour);
            tour.LoaiHinhDuLich = loaihinh;
            //_formListTour.UpdateGridView(tour);
           
        }
    }
}
