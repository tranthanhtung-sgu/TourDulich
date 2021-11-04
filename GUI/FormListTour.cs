﻿using BUS;
using BUS.Dtos;
using DAL.Entities;
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
    public partial class FormListTour : Form
    {
        private static List<DTO_Tour> tours = new List<DTO_Tour>();
        BUS_Tour bus_Tour = new BUS_Tour();
        private static DTO_Tour currentSelectedTour = new DTO_Tour();
        public FormListTour()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedTour = (DTO_Tour)dtgvListTour.CurrentRow.DataBoundItem;
        }

        private void FormListTour_Load(object sender, EventArgs e)
        {
            tours = bus_Tour.GetAll();
            dtgvListTour.DataSource = tours;
            dtgvListTour.Columns[0].Width = 220;
            dtgvListTour.Columns[1].Width = 200;
            dtgvListTour.Columns[2].Width = 200;
            dtgvListTour.Columns[3].Width = 200;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAddTour frmAddTour = new FrmAddTour(this);
            frmAddTour.Show();
        }

        public void UpdateGridView(Tour tour)
        {
            var newTour = bus_Tour.mapper.Map<Tour, DTO_Tour>(tour);
            tours.Add(newTour);
            dtgvListTour.DataSource = tours.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void FormListTour_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dtgvListTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentSelectedTour = (DTO_Tour)dtgvListTour.CurrentRow.DataBoundItem;
            FormTourDetails formTourDetails = new FormTourDetails(this, currentSelectedTour);
            formTourDetails.Show();
        }
    }
}
