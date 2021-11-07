using GUI.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.KhachHoang
{
    public partial class FormListKH : Form
    {
        public FormListKH()
        {
            InitializeComponent();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            FormAddKH addKH = new FormAddKH();
            addKH.Show();
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {

        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            FormEditKH editKH = new FormEditKH();
            editKH.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormKHDetail detailKH = new FormKHDetail();
            detailKH.Show();
        }
    }
}
