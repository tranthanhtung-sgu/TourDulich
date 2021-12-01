﻿using BUS;
using DAL.Entities;
using GUI.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.KhachHoang
{
    public partial class FormListKH : Form
    {
        Customer customer;
        BUS_Customer bCustomer = new BUS_Customer();
        List<Customer> listCustomer = new List<Customer>();
        public FormListKH()
        {
            listCustomer = (List<Customer>)bCustomer.GetAll();
            InitializeComponent();
            this.Load += FormListKH_Load;
        }

        private void FormListKH_Load(object sender, EventArgs e)
        {
            dtgvCustomer.DataSource = listCustomer;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddKH addKH = new FormAddKH();
            addKH.Show();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            int currentCustonerIndex = dtgvCustomer.CurrentCell.RowIndex;
            customer = new Customer();
            customer = listCustomer[currentCustonerIndex];
            bCustomer.Delete(customer.Id);
            listCustomer.Remove(customer);
            dtgvCustomer.DataSource = (List<Customer>)bCustomer.GetAll();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {

            int currentCustomerIndex = dtgvCustomer.CurrentCell.RowIndex;
            customer = listCustomer[currentCustomerIndex];
            FormEditKH editKH = new FormEditKH(customer);
            editKH.Show();
        }

        private void btnViewCustomerDetails_Click(object sender, EventArgs e)
        {
            int currentCustomerIndex = dtgvCustomer.CurrentCell.RowIndex;
            customer = listCustomer[currentCustomerIndex];
            FormKHDetail detailKH = new FormKHDetail(customer);
            detailKH.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

     
    }
}
