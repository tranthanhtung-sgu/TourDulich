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
        private FrmMainMenu FrmMainMenu;

        public FrmAddTour(FrmMainMenu frmMain)
        {
            InitializeComponent();
            FrmMainMenu = frmMain;
        }
    }
}
