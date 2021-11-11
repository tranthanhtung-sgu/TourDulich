﻿
namespace GUI.Doan
{
    partial class FormListDoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new FontAwesome.Sharp.IconButton();
            this.btnEditTour = new FontAwesome.Sharp.IconButton();
            this.btnDeleteTour = new FontAwesome.Sharp.IconButton();
            this.btnAddTour = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTour
            // 
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTour.Location = new System.Drawing.Point(0, 81);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.RowTemplate.Height = 25;
            this.dtgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTour.Size = new System.Drawing.Size(800, 369);
            this.dtgvTour.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnEditTour);
            this.panel1.Controls.Add(this.btnDeleteTour);
            this.panel1.Controls.Add(this.btnAddTour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 7;
            // 
            // btnDetails
            // 
            this.btnDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDetails.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnDetails.IconColor = System.Drawing.Color.Black;
            this.btnDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetails.IconSize = 25;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(540, 21);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(147, 40);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEditTour
            // 
            this.btnEditTour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditTour.FlatAppearance.BorderSize = 0;
            this.btnEditTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditTour.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditTour.IconColor = System.Drawing.Color.Black;
            this.btnEditTour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTour.IconSize = 30;
            this.btnEditTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.Location = new System.Drawing.Point(393, 21);
            this.btnEditTour.Name = "btnEditTour";
            this.btnEditTour.Size = new System.Drawing.Size(147, 40);
            this.btnEditTour.TabIndex = 5;
            this.btnEditTour.Text = "Sửa thông tin";
            this.btnEditTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTour.UseVisualStyleBackColor = true;
            this.btnEditTour.Click += new System.EventHandler(this.btnEditTour_Click);
            // 
            // btnDeleteTour
            // 
            this.btnDeleteTour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTour.FlatAppearance.BorderSize = 0;
            this.btnDeleteTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteTour.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteTour.IconColor = System.Drawing.Color.Black;
            this.btnDeleteTour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteTour.IconSize = 30;
            this.btnDeleteTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.Location = new System.Drawing.Point(246, 21);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(147, 40);
            this.btnDeleteTour.TabIndex = 5;
            this.btnDeleteTour.Text = "Xóa khách hàng";
            this.btnDeleteTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTour.FlatAppearance.BorderSize = 0;
            this.btnAddTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddTour.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTour.IconColor = System.Drawing.Color.Black;
            this.btnAddTour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTour.IconSize = 30;
            this.btnAddTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.Location = new System.Drawing.Point(99, 21);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(147, 40);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "Tạo đoàn khách";
            this.btnAddTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // FormListDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvTour);
            this.Controls.Add(this.panel1);
            this.Name = "FormListDoan";
            this.Text = "Danh sách Đoàn du lịch";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTour;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDetails;
        private FontAwesome.Sharp.IconButton btnEditTour;
        private FontAwesome.Sharp.IconButton btnDeleteTour;
        private FontAwesome.Sharp.IconButton btnAddTour;
    }
}