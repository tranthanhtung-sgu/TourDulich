using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDulich
{
    public partial class FormInterface : Form
    {
        public FormInterface()
        {
            InitializeComponent();
        }

        private void FormInterface_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
