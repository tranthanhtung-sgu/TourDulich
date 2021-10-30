
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
            System.Windows.Forms.Button addTourBtn;
            System.Windows.Forms.Button updateTourBtn;
            System.Windows.Forms.Button delTourBtn;
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewTour = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshTourBtn = new System.Windows.Forms.Button();
            this.findTourBtn = new System.Windows.Forms.Button();
            this.searchTourTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            addTourBtn = new System.Windows.Forms.Button();
            updateTourBtn = new System.Windows.Forms.Button();
            delTourBtn = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addTourBtn
            // 
            addTourBtn.Location = new System.Drawing.Point(157, 37);
            addTourBtn.Name = "addTourBtn";
            addTourBtn.Size = new System.Drawing.Size(96, 30);
            addTourBtn.TabIndex = 0;
            addTourBtn.Text = "Thêm";
            addTourBtn.UseVisualStyleBackColor = true;
            addTourBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateTourBtn
            // 
            updateTourBtn.Location = new System.Drawing.Point(370, 37);
            updateTourBtn.Name = "updateTourBtn";
            updateTourBtn.Size = new System.Drawing.Size(96, 30);
            updateTourBtn.TabIndex = 1;
            updateTourBtn.Text = "Sửa";
            updateTourBtn.UseVisualStyleBackColor = true;
            // 
            // delTourBtn
            // 
            delTourBtn.Location = new System.Drawing.Point(594, 37);
            delTourBtn.Name = "delTourBtn";
            delTourBtn.Size = new System.Drawing.Size(96, 30);
            delTourBtn.TabIndex = 2;
            delTourBtn.Text = "Xóa";
            delTourBtn.UseVisualStyleBackColor = true;
            delTourBtn.AutoSizeChanged += new System.EventHandler(this.FormListTour_Load);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.listViewTour);
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
            // listViewTour
            // 
            this.listViewTour.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewTour.FullRowSelect = true;
            this.listViewTour.GridLines = true;
            this.listViewTour.HideSelection = false;
            this.listViewTour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listViewTour.Location = new System.Drawing.Point(12, 54);
            this.listViewTour.Name = "listViewTour";
            this.listViewTour.Size = new System.Drawing.Size(855, 392);
            this.listViewTour.TabIndex = 3;
            this.listViewTour.UseCompatibleStateImageBehavior = false;
            this.listViewTour.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Tour";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Gói";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mô tả";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Loại hình du lịch";
            this.columnHeader4.Width = 150;
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
            this.groupBox2.Controls.Add(delTourBtn);
            this.groupBox2.Controls.Add(updateTourBtn);
            this.groupBox2.Controls.Add(addTourBtn);
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
        private System.Windows.Forms.ListView listViewTour;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

