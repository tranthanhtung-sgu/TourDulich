using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.NhanVien
{
    public partial class FormListNV : Form
    {
        public FormListNV()
        {
            InitializeComponent();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            FormAddNV addNV = new FormAddNV();
            addNV.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FormDetailsNV detailsNV = new FormDetailsNV();
            detailsNV.Show();
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {

        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            FormEditNV editNV = new FormEditNV();
            editNV.Show();
        }
    }
}
