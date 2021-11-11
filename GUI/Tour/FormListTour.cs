using AutoMapper;
using BUS;
using BUS.Dtos;
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
        private List<DAL.Entities.Tour> listTour = new List<DAL.Entities.Tour>();
        private BUS_Tour bTour = new BUS_Tour();
        public FrmMainMenu FrmMainMenu { get; set; }
        public FrmListTour(FrmMainMenu frmMain)
        {
            FrmMainMenu = frmMain;
            InitializeComponent();
        }
        private void frmListTour_Load(object sender, EventArgs e)
        {
            listTour = bTour.GetAll();
            var tours = bTour.mapper.Map<List<DAL.Entities.Tour>, List<DTO_Tour>>(listTour);
            dtgvTour.DataSource = tours;

            dtgvTour.Columns[1].Width = 300;
            dtgvTour.Columns[2].Width = 300;
            dtgvTour.Columns[3].Width = 200;
            dtgvTour.Columns[4].Width = 200;
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            int currentTourIndex = dtgvTour.CurrentCell.RowIndex;

            FrmTourDetails detailstour = new FrmTourDetails(listTour[currentTourIndex], FrmMainMenu);
            FrmMainMenu.OpenChildForm(detailstour);
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

        private void dtgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentTourIndex = dtgvTour.CurrentCell.RowIndex;

            FrmTourDetails detailstour = new FrmTourDetails(listTour[currentTourIndex], FrmMainMenu);
            FrmMainMenu.OpenChildForm(detailstour);
        }
    }    
}
