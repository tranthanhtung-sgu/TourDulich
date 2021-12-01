
namespace GUI.DiaDiem
{
    partial class LocationForm
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
            this.dtgvLocation = new System.Windows.Forms.DataGridView();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLocationDelete = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdateLocation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvLocation
            // 
            this.dtgvLocation.AllowUserToAddRows = false;
            this.dtgvLocation.AllowUserToDeleteRows = false;
            this.dtgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLocation.Location = new System.Drawing.Point(17, 238);
            this.dtgvLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvLocation.Name = "dtgvLocation";
            this.dtgvLocation.RowHeadersVisible = false;
            this.dtgvLocation.RowHeadersWidth = 62;
            this.dtgvLocation.RowTemplate.Height = 25;
            this.dtgvLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLocation.Size = new System.Drawing.Size(621, 615);
            this.dtgvLocation.TabIndex = 0;
            this.dtgvLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLocation_CellContentClick);
            this.dtgvLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLocation_CellContentClick_1);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(103, 48);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(534, 31);
            this.txtLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Địa điểm";
            // 
            // btnLocationDelete
            // 
            this.btnLocationDelete.Location = new System.Drawing.Point(531, 190);
            this.btnLocationDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLocationDelete.Name = "btnLocationDelete";
            this.btnLocationDelete.Size = new System.Drawing.Size(107, 38);
            this.btnLocationDelete.TabIndex = 3;
            this.btnLocationDelete.Text = "Xoá";
            this.btnLocationDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(530, 95);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(109, 38);
            this.btnAddLocation.TabIndex = 4;
            this.btnAddLocation.Text = "Thêm";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(737, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(737, 758);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Location = new System.Drawing.Point(413, 97);
            this.btnUpdateLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(109, 38);
            this.btnUpdateLocation.TabIndex = 6;
            this.btnUpdateLocation.Text = "Cập nhật";
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 873);
            this.Controls.Add(this.btnUpdateLocation);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.btnLocationDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.dtgvLocation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LocationForm";
            this.Text = "LocationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLocationDelete;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUpdateLocation;
    }
}