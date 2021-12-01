﻿
namespace GUI
{
    partial class FrmTourDetails
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbLocation = new System.Windows.Forms.ComboBox();
            this.btnDeleteLocation = new FontAwesome.Sharp.IconButton();
            this.btnUpdateLocation = new FontAwesome.Sharp.IconButton();
            this.dtgvLocation = new System.Windows.Forms.DataGridView();
            this.btnAddLocation = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelelePrice = new FontAwesome.Sharp.IconButton();
            this.btnUpdatePrice = new FontAwesome.Sharp.IconButton();
            this.dtpickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpickerStart = new System.Windows.Forms.DateTimePicker();
            this.btnAddPrice = new FontAwesome.Sharp.IconButton();
            this.dtgvPrice = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTourName = new System.Windows.Forms.TextBox();
            this.btnSaveNV = new FontAwesome.Sharp.IconButton();
            this.btnBackTourList = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLocation)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSerial);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbbLocation);
            this.groupBox3.Controls.Add(this.btnDeleteLocation);
            this.groupBox3.Controls.Add(this.btnUpdateLocation);
            this.groupBox3.Controls.Add(this.dtgvLocation);
            this.groupBox3.Controls.Add(this.btnAddLocation);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(17, 398);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(880, 388);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quản lý địa điểm";
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(180, 135);
            this.txtSerial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(173, 33);
            this.txtSerial.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Thứ tự";
            // 
            // cbbLocation
            // 
            this.cbbLocation.FormattingEnabled = true;
            this.cbbLocation.Location = new System.Drawing.Point(180, 65);
            this.cbbLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.Size = new System.Drawing.Size(171, 36);
            this.cbbLocation.TabIndex = 52;
            // 
            // btnDeleteLocation
            // 
            this.btnDeleteLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLocation.FlatAppearance.BorderSize = 0;
            this.btnDeleteLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteLocation.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteLocation.IconColor = System.Drawing.Color.Black;
            this.btnDeleteLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteLocation.IconSize = 19;
            this.btnDeleteLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteLocation.Location = new System.Drawing.Point(131, 308);
            this.btnDeleteLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteLocation.Name = "btnDeleteLocation";
            this.btnDeleteLocation.Size = new System.Drawing.Size(114, 48);
            this.btnDeleteLocation.TabIndex = 50;
            this.btnDeleteLocation.Text = "Xóa";
            this.btnDeleteLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteLocation.UseVisualStyleBackColor = true;
            this.btnDeleteLocation.Click += new System.EventHandler(this.btnDeleteLocation_Click);
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateLocation.FlatAppearance.BorderSize = 0;
            this.btnUpdateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateLocation.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdateLocation.IconColor = System.Drawing.Color.Black;
            this.btnUpdateLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateLocation.IconSize = 19;
            this.btnUpdateLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateLocation.Location = new System.Drawing.Point(246, 308);
            this.btnUpdateLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(114, 48);
            this.btnUpdateLocation.TabIndex = 51;
            this.btnUpdateLocation.Text = "Sửa ";
            this.btnUpdateLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateLocation.UseVisualStyleBackColor = true;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // dtgvLocation
            // 
            this.dtgvLocation.AllowUserToAddRows = false;
            this.dtgvLocation.AllowUserToDeleteRows = false;
            this.dtgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLocation.Location = new System.Drawing.Point(386, 25);
            this.dtgvLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvLocation.Name = "dtgvLocation";
            this.dtgvLocation.ReadOnly = true;
            this.dtgvLocation.RowHeadersVisible = false;
            this.dtgvLocation.RowHeadersWidth = 62;
            this.dtgvLocation.RowTemplate.Height = 25;
            this.dtgvLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLocation.Size = new System.Drawing.Size(486, 292);
            this.dtgvLocation.TabIndex = 25;
            this.dtgvLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLocation_CellClick);
            this.dtgvLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLocation_CellContentClick);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddLocation.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddLocation.IconColor = System.Drawing.Color.Black;
            this.btnAddLocation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddLocation.IconSize = 19;
            this.btnAddLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLocation.Location = new System.Drawing.Point(16, 308);
            this.btnAddLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(114, 48);
            this.btnAddLocation.TabIndex = 49;
            this.btnAddLocation.Text = "Thêm ";
            this.btnAddLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Danh sách địa điểm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelelePrice);
            this.groupBox2.Controls.Add(this.btnUpdatePrice);
            this.groupBox2.Controls.Add(this.dtpickerEnd);
            this.groupBox2.Controls.Add(this.dtpickerStart);
            this.groupBox2.Controls.Add(this.btnAddPrice);
            this.groupBox2.Controls.Add(this.dtgvPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(17, 20);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(880, 368);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản lý giá";
            // 
            // btnDelelePrice
            // 
            this.btnDelelePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelelePrice.FlatAppearance.BorderSize = 0;
            this.btnDelelePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelelePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelelePrice.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelelePrice.IconColor = System.Drawing.Color.Black;
            this.btnDelelePrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelelePrice.IconSize = 19;
            this.btnDelelePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelelePrice.Location = new System.Drawing.Point(124, 257);
            this.btnDelelePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelelePrice.Name = "btnDelelePrice";
            this.btnDelelePrice.Size = new System.Drawing.Size(114, 48);
            this.btnDelelePrice.TabIndex = 47;
            this.btnDelelePrice.Text = "Xóa";
            this.btnDelelePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelelePrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelelePrice.UseVisualStyleBackColor = true;
            this.btnDelelePrice.Click += new System.EventHandler(this.btnDelelePrice_Click);
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdatePrice.FlatAppearance.BorderSize = 0;
            this.btnUpdatePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdatePrice.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnUpdatePrice.IconColor = System.Drawing.Color.Black;
            this.btnUpdatePrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdatePrice.IconSize = 19;
            this.btnUpdatePrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePrice.Location = new System.Drawing.Point(239, 257);
            this.btnUpdatePrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(114, 48);
            this.btnUpdatePrice.TabIndex = 48;
            this.btnUpdatePrice.Text = "Sửa ";
            this.btnUpdatePrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // dtpickerEnd
            // 
            this.dtpickerEnd.CustomFormat = "dd/MM";
            this.dtpickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerEnd.Location = new System.Drawing.Point(180, 173);
            this.dtpickerEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpickerEnd.Name = "dtpickerEnd";
            this.dtpickerEnd.Size = new System.Drawing.Size(173, 33);
            this.dtpickerEnd.TabIndex = 38;
            // 
            // dtpickerStart
            // 
            this.dtpickerStart.CustomFormat = "dd/MM";
            this.dtpickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpickerStart.Location = new System.Drawing.Point(180, 103);
            this.dtpickerStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpickerStart.Name = "dtpickerStart";
            this.dtpickerStart.Size = new System.Drawing.Size(173, 33);
            this.dtpickerStart.TabIndex = 37;
            this.dtpickerStart.ValueChanged += new System.EventHandler(this.dtpickerStart_ValueChanged);
            // 
            // btnAddPrice
            // 
            this.btnAddPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddPrice.FlatAppearance.BorderSize = 0;
            this.btnAddPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddPrice.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddPrice.IconColor = System.Drawing.Color.Black;
            this.btnAddPrice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPrice.IconSize = 19;
            this.btnAddPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrice.Location = new System.Drawing.Point(9, 257);
            this.btnAddPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddPrice.Name = "btnAddPrice";
            this.btnAddPrice.Size = new System.Drawing.Size(114, 48);
            this.btnAddPrice.TabIndex = 46;
            this.btnAddPrice.Text = "Thêm ";
            this.btnAddPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddPrice.UseVisualStyleBackColor = true;
            this.btnAddPrice.Click += new System.EventHandler(this.btnAddPrice_Click_1);
            // 
            // dtgvPrice
            // 
            this.dtgvPrice.AllowUserToAddRows = false;
            this.dtgvPrice.AllowUserToDeleteRows = false;
            this.dtgvPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPrice.Location = new System.Drawing.Point(386, 25);
            this.dtgvPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvPrice.Name = "dtgvPrice";
            this.dtgvPrice.ReadOnly = true;
            this.dtgvPrice.RowHeadersVisible = false;
            this.dtgvPrice.RowHeadersWidth = 62;
            this.dtgvPrice.RowTemplate.Height = 25;
            this.dtgvPrice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPrice.Size = new System.Drawing.Size(486, 303);
            this.dtgvPrice.TabIndex = 24;
            this.dtgvPrice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPrice_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(11, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Thời gian kết thúc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(11, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Thời gian bắt đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Giá tour";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(180, 40);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(173, 31);
            this.txtPrice.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbCategory);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTourName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(906, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(569, 767);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chính";
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(130, 103);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(417, 36);
            this.cbbCategory.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mô tả";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(130, 185);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(417, 507);
            this.txtDescription.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Loại hình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên tour";
            // 
            // txtTourName
            // 
            this.txtTourName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTourName.Location = new System.Drawing.Point(130, 40);
            this.txtTourName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.Size = new System.Drawing.Size(417, 31);
            this.txtTourName.TabIndex = 29;
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.FlatAppearance.BorderSize = 0;
            this.btnSaveNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveNV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveNV.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveNV.IconColor = System.Drawing.Color.Black;
            this.btnSaveNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveNV.IconSize = 19;
            this.btnSaveNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNV.Location = new System.Drawing.Point(1379, 797);
            this.btnSaveNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(96, 57);
            this.btnSaveNV.TabIndex = 44;
            this.btnSaveNV.Text = "Lưu";
            this.btnSaveNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveNV.UseVisualStyleBackColor = true;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // btnBackTourList
            // 
            this.btnBackTourList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackTourList.FlatAppearance.BorderSize = 0;
            this.btnBackTourList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackTourList.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackTourList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackTourList.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnBackTourList.IconColor = System.Drawing.Color.Black;
            this.btnBackTourList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBackTourList.IconSize = 19;
            this.btnBackTourList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTourList.Location = new System.Drawing.Point(26, 797);
            this.btnBackTourList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBackTourList.Name = "btnBackTourList";
            this.btnBackTourList.Size = new System.Drawing.Size(119, 57);
            this.btnBackTourList.TabIndex = 45;
            this.btnBackTourList.Text = "Quay lại";
            this.btnBackTourList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackTourList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackTourList.UseVisualStyleBackColor = true;
            this.btnBackTourList.Click += new System.EventHandler(this.btnBackTourList_Click);
            // 
            // FrmTourDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 873);
            this.Controls.Add(this.btnBackTourList);
            this.Controls.Add(this.btnSaveNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmTourDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLocation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvLocation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTourName;
        private System.Windows.Forms.DateTimePicker dtpickerEnd;
        private System.Windows.Forms.DateTimePicker dtpickerStart;
        private FontAwesome.Sharp.IconButton btnSaveNV;
        private FontAwesome.Sharp.IconButton btnBackTourList;
        private FontAwesome.Sharp.IconButton btnDeleteLocation;
        private FontAwesome.Sharp.IconButton btnUpdateLocation;
        private FontAwesome.Sharp.IconButton btnAddLocation;
        private FontAwesome.Sharp.IconButton btnDelelePrice;
        private FontAwesome.Sharp.IconButton btnUpdatePrice;
        private FontAwesome.Sharp.IconButton btnAddPrice;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbLocation;
    }
}