using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using BUS.Dtos;
using DAL.Entities;

namespace GUI.Doan
{
    public partial class FormListDoan : Form
    {
        private FrmMainMenu FrmMainMenu;
        private BUS_TouristGroup bTouristGroup = new BUS_TouristGroup();   
        private List<TouristGroup> listTouristGroup = new List<TouristGroup>();
        public FormListDoan(FrmMainMenu frmMainMenu)
        {
            FrmMainMenu = frmMainMenu;
            InitializeComponent();
            // load form
        }

        //load form
        private void FormListDoan_Load(object sender, EventArgs e)
        {
            listTouristGroup = bTouristGroup.GetAll();
            var dto = bTouristGroup.mapper.Map<List<TouristGroup>, List<DTO_TouristGroup>>(listTouristGroup);
            dtgvGroup.DataSource = dto;

            int width = dtgvGroup.Width;

            //set size of column in datagridview 
            dtgvGroup.Columns[0].Width = (int)(width * 0.1);
            dtgvGroup.Columns[1].Width = (int)(width * 0.2);
            dtgvGroup.Columns[2].Width = (int)(width * 0.2);
            dtgvGroup.Columns[3].Width = (int)(width * 0.2);
            dtgvGroup.Columns[4].Width = (int)(width * 0.2);
            dtgvGroup.Columns[5].Width = (int)(width * 0.2);
            dtgvGroup.Columns[6].Width = (int)(width * 0.2);
        }

        private void btnAddTour_Click(object sender, EventArgs e)
        {
            FormDoanDetail detailDoan = new FormDoanDetail(null, FrmMainMenu);
            FrmMainMenu.OpenChildForm(detailDoan);
        }

        private void btnEditTour_Click(object sender, EventArgs e)
        {
            int index = dtgvGroup.CurrentCell.RowIndex;

            FormDoanDetail detailDoan = new FormDoanDetail(listTouristGroup[index], FrmMainMenu);
            FrmMainMenu.OpenChildForm(detailDoan);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            int index = dtgvGroup.CurrentCell.RowIndex;

            FormDoanDetail detailDoan = new FormDoanDetail(listTouristGroup[index], FrmMainMenu);
            FrmMainMenu.OpenChildForm(detailDoan);
        }

        private void btnDeleteTour_Click(object sender, EventArgs e)
        {
            int index = dtgvGroup.CurrentCell.RowIndex;
            bTouristGroup.Delete(listTouristGroup[index].Id);
            listTouristGroup.RemoveAt(index);
            var dto = bTouristGroup.mapper.Map<List<TouristGroup>, List<DTO_TouristGroup>>(listTouristGroup);
            dtgvGroup.DataSource = dto;
        }
    }
}
