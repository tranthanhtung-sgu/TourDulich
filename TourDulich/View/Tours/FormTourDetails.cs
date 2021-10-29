using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDulich.View.Tour
{
    public partial class FormTourDetails : Form
    {
        public FormTourDetails()
        {
            InitializeComponent();
        }

        private void FormTourDetails_Load(object sender, EventArgs e)
        {

        }

        private void FormTourDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
