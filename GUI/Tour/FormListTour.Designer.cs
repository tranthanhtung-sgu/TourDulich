
namespace GUI
{
    partial class FrmListTour
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new FontAwesome.Sharp.IconButton();
            this.btnDeleteTour = new FontAwesome.Sharp.IconButton();
            this.btnAddTour = new FontAwesome.Sharp.IconButton();
            this.dtgvTour = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnDeleteTour);
            this.panel1.Controls.Add(this.btnAddTour);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 135);
            this.panel1.TabIndex = 3;
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
            this.btnDetails.Location = new System.Drawing.Point(649, 35);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(157, 67);
            this.btnDetails.TabIndex = 5;
            this.btnDetails.Text = "Chi Tiết";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
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
            this.btnDeleteTour.Location = new System.Drawing.Point(483, 35);
            this.btnDeleteTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTour.Name = "btnDeleteTour";
            this.btnDeleteTour.Size = new System.Drawing.Size(157, 67);
            this.btnDeleteTour.TabIndex = 5;
            this.btnDeleteTour.Text = "Xóa Tour";
            this.btnDeleteTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTour.UseVisualStyleBackColor = true;
            this.btnDeleteTour.Click += new System.EventHandler(this.btnDeleteTour_Click);
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
            this.btnAddTour.Location = new System.Drawing.Point(326, 35);
            this.btnAddTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(157, 67);
            this.btnAddTour.TabIndex = 0;
            this.btnAddTour.Text = "Thêm Tour";
            this.btnAddTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // dtgvTour
            // 
            this.dtgvTour.AllowUserToAddRows = false;
            this.dtgvTour.AllowUserToDeleteRows = false;
            this.dtgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvTour.Location = new System.Drawing.Point(0, 135);
            this.dtgvTour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvTour.Name = "dtgvTour";
            this.dtgvTour.ReadOnly = true;
            this.dtgvTour.RowHeadersVisible = false;
            this.dtgvTour.RowHeadersWidth = 62;
            this.dtgvTour.RowTemplate.Height = 25;
            this.dtgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTour.Size = new System.Drawing.Size(1159, 690);
            this.dtgvTour.TabIndex = 4;
            this.dtgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTour_CellContentClick);
            // 
            // FrmListTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1159, 825);
            this.Controls.Add(this.dtgvTour);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListTour";
            this.Text = "Danh sách tour";
            this.Load += new System.EventHandler(this.frmListTour_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnDeleteTour;
        private FontAwesome.Sharp.IconButton btnAddTour;
        private System.Windows.Forms.DataGridView dtgvTour;
        private FontAwesome.Sharp.IconButton btnDetails;
    }
}