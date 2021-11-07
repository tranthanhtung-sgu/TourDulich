
namespace GUI.NhanVien
{
    partial class FormListNV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetails = new FontAwesome.Sharp.IconButton();
            this.btnEditNV = new FontAwesome.Sharp.IconButton();
            this.btnDeleteNV = new FontAwesome.Sharp.IconButton();
            this.btnAddNV = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(800, 369);
            this.dataGridView1.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDetails);
            this.panel1.Controls.Add(this.btnEditNV);
            this.panel1.Controls.Add(this.btnDeleteNV);
            this.panel1.Controls.Add(this.btnAddNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 5;
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
            this.btnDetails.Location = new System.Drawing.Point(531, 21);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(136, 40);
            this.btnDetails.TabIndex = 7;
            this.btnDetails.Text = "Xem Chi Tiết";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditNV.FlatAppearance.BorderSize = 0;
            this.btnEditNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditNV.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditNV.IconColor = System.Drawing.Color.Black;
            this.btnEditNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditNV.IconSize = 30;
            this.btnEditNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNV.Location = new System.Drawing.Point(395, 21);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(136, 40);
            this.btnEditNV.TabIndex = 5;
            this.btnEditNV.Text = "Sửa Thông Tin";
            this.btnEditNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteNV.FlatAppearance.BorderSize = 0;
            this.btnDeleteNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteNV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteNV.IconColor = System.Drawing.Color.Black;
            this.btnDeleteNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteNV.IconSize = 30;
            this.btnDeleteNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.Location = new System.Drawing.Point(259, 21);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(136, 40);
            this.btnDeleteNV.TabIndex = 5;
            this.btnDeleteNV.Text = "Xóa Nhân Viên";
            this.btnDeleteNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteNV.UseVisualStyleBackColor = true;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddNV.FlatAppearance.BorderSize = 0;
            this.btnAddNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddNV.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddNV.IconColor = System.Drawing.Color.Black;
            this.btnAddNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNV.IconSize = 30;
            this.btnAddNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.Location = new System.Drawing.Point(123, 21);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(136, 40);
            this.btnAddNV.TabIndex = 0;
            this.btnAddNV.Text = "Thêm Nhân Viên";
            this.btnAddNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNV.UseVisualStyleBackColor = true;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // FormListNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormListNV";
            this.Text = "Danh sách nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEditNV;
        private FontAwesome.Sharp.IconButton btnDetails;
        private FontAwesome.Sharp.IconButton btnDeleteNV;
        private FontAwesome.Sharp.IconButton btnAddNV;
    }
}