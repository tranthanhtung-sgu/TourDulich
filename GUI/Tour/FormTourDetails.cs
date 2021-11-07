using BUS.Dtos;
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
        //private readonly FormListTour _formListTour;
        private DTO_Tour currentTour;

        public FrmTourDetails()
        {
        }

        public FrmTourDetails(DTO_Tour currentSelectedTour)
        {
            InitializeComponent();
            //_formListTour = formListTour;
            currentTour = currentSelectedTour;
        }

    }
}
