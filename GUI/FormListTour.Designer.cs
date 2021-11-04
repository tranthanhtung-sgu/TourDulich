
namespace GUI
{
    partial class FormListTour
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addTourBtn = new System.Windows.Forms.Button();
            this.updateTourBtn = new System.Windows.Forms.Button();
            this.delTourBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgvListTour = new System.Windows.Forms.DataGridView();
            this.refreshTourBtn = new System.Windows.Forms.Button();
            this.findTourBtn = new System.Windows.Forms.Button();
            this.searchTourTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTour)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTourBtn
            // 
            this.addTourBtn.Location = new System.Drawing.Point(157, 37);
            this.addTourBtn.Name = "addTourBtn";
            this.addTourBtn.Size = new System.Drawing.Size(96, 30);
            this.addTourBtn.TabIndex = 0;
            this.addTourBtn.Text = "Thêm";
            this.addTourBtn.UseVisualStyleBackColor = true;
            this.addTourBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateTourBtn
            // 
            this.updateTourBtn.Location = new System.Drawing.Point(370, 37);
            this.updateTourBtn.Name = "updateTourBtn";
            this.updateTourBtn.Size = new System.Drawing.Size(96, 30);
            this.updateTourBtn.TabIndex = 1;
            this.updateTourBtn.Text = "Sửa";
            this.updateTourBtn.UseVisualStyleBackColor = true;
            // 
            // delTourBtn
            // 
            this.delTourBtn.Location = new System.Drawing.Point(594, 37);
            this.delTourBtn.Name = "delTourBtn";
            this.delTourBtn.Size = new System.Drawing.Size(96, 30);
            this.delTourBtn.TabIndex = 2;
            this.delTourBtn.Text = "Xóa";
            this.delTourBtn.UseVisualStyleBackColor = true;
            this.delTourBtn.AutoSizeChanged += new System.EventHandler(this.FormListTour_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.dtgvListTour);
            this.groupBox3.Controls.Add(this.refreshTourBtn);
            this.groupBox3.Controls.Add(this.findTourBtn);
            this.groupBox3.Controls.Add(this.searchTourTxt);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 100);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(879, 458);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách Tour ";
            // 
            // dtgvListTour
            // 
            this.dtgvListTour.AllowUserToAddRows = false;
            this.dtgvListTour.AllowUserToDeleteRows = false;
            this.dtgvListTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListTour.Location = new System.Drawing.Point(12, 59);
            this.dtgvListTour.Name = "dtgvListTour";
            this.dtgvListTour.ReadOnly = true;
            this.dtgvListTour.RowTemplate.Height = 25;
            this.dtgvListTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListTour.Size = new System.Drawing.Size(855, 387);
            this.dtgvListTour.TabIndex = 3;
            this.dtgvListTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvListTour_CellContentClick);
            // 
            // refreshTourBtn
            // 
            this.refreshTourBtn.Location = new System.Drawing.Point(571, 20);
            this.refreshTourBtn.Name = "refreshTourBtn";
            this.refreshTourBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshTourBtn.TabIndex = 2;
            this.refreshTourBtn.Text = "Làm mới";
            this.refreshTourBtn.UseVisualStyleBackColor = true;
            // 
            // findTourBtn
            // 
            this.findTourBtn.Location = new System.Drawing.Point(425, 20);
            this.findTourBtn.Name = "findTourBtn";
            this.findTourBtn.Size = new System.Drawing.Size(75, 23);
            this.findTourBtn.TabIndex = 1;
            this.findTourBtn.Text = "Tìm kiếm";
            this.findTourBtn.UseVisualStyleBackColor = true;
            this.findTourBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchTourTxt
            // 
            this.searchTourTxt.Location = new System.Drawing.Point(49, 19);
            this.searchTourTxt.Multiline = true;
            this.searchTourTxt.Name = "searchTourTxt";
            this.searchTourTxt.Size = new System.Drawing.Size(318, 25);
            this.searchTourTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delTourBtn);
            this.groupBox2.Controls.Add(this.updateTourBtn);
            this.groupBox2.Controls.Add(this.addTourBtn);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hoạt động";
            // 
            // FormListTour
            // 
            this.ClientSize = new System.Drawing.Size(879, 558);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormListTour";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormListTour_FormClosing);
            this.Load += new System.EventHandler(this.FormListTour_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListTour)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findTourBtn;
        private System.Windows.Forms.TextBox searchTourTxt;
        private System.Windows.Forms.Button refreshTourBtn;
        private System.Windows.Forms.Button addTourBtn;
        private System.Windows.Forms.Button updateTourBtn;
        private System.Windows.Forms.Button delTourBtn;
        public System.Windows.Forms.DataGridView dtgvListTour;
    }
}

