using GUI.Tour;
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
    public partial class FrmListTour : Form
    {
        public FrmListTour()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FrmTourDetails detailstour = new FrmTourDetails();
            detailstour.Show();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            FrmAddTour addtour = new FrmAddTour();
            addtour.Show();
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            FormEditTour editTour = new FormEditTour();
            editTour.Show();
        }
    }    
}
