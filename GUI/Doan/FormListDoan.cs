using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Doan
{
    public partial class FormListDoan : Form
    {
        public FormListDoan()
        {
            InitializeComponent();
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            FormAddDoan addDoan = new FormAddDoan();
            addDoan.Show();
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            FormEditDoan editDoan = new FormEditDoan();
            editDoan.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormDoanDetail detailDoan = new FormDoanDetail();
            detailDoan.Show();
        }
    }
}
