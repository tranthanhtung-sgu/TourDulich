
namespace GUI.Doan
{
    partial class FormDoanDetail
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
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHotel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReveneu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.TimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTourName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelCustomer = new FontAwesome.Sharp.IconButton();
            this.btnAddCustomer = new FontAwesome.Sharp.IconButton();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelStaff = new FontAwesome.Sharp.IconButton();
            this.txtDuty = new System.Windows.Forms.TextBox();
            this.btnAddStaff = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.btnSaveTouristGroup = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDelCost = new FontAwesome.Sharp.IconButton();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.btnAddCost = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbCost = new System.Windows.Forms.ComboBox();
            this.dtgvCost = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCost)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCancel.IconColor = System.Drawing.Color.Black;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 33;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(15, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 38);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Close";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHotel);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtReveneu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TimePickerEndDate);
            this.groupBox2.Controls.Add(this.TimePickerStartDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbTourName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 460);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tour";
            // 
            // txtHotel
            // 
            this.txtHotel.Location = new System.Drawing.Point(107, 224);
            this.txtHotel.Name = "txtHotel";
            this.txtHotel.Size = new System.Drawing.Size(209, 25);
            this.txtHotel.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(10, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 46;
            this.label6.Text = "Khách sạn";
            // 
            // txtReveneu
            // 
            this.txtReveneu.Location = new System.Drawing.Point(107, 172);
            this.txtReveneu.Name = "txtReveneu";
            this.txtReveneu.Size = new System.Drawing.Size(209, 25);
            this.txtReveneu.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "Lợi nhuận";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(107, 278);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(209, 176);
            this.txtDescription.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mô tả";
            // 
            // TimePickerEndDate
            // 
            this.TimePickerEndDate.Location = new System.Drawing.Point(107, 119);
            this.TimePickerEndDate.Name = "TimePickerEndDate";
            this.TimePickerEndDate.Size = new System.Drawing.Size(209, 25);
            this.TimePickerEndDate.TabIndex = 41;
            this.TimePickerEndDate.ValueChanged += new System.EventHandler(this.TimePickerEndDate_ValueChanged);
            // 
            // TimePickerStartDate
            // 
            this.TimePickerStartDate.Location = new System.Drawing.Point(107, 65);
            this.TimePickerStartDate.Name = "TimePickerStartDate";
            this.TimePickerStartDate.Size = new System.Drawing.Size(209, 25);
            this.TimePickerStartDate.TabIndex = 40;
            this.TimePickerStartDate.ValueChanged += new System.EventHandler(this.TimePickerStartDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ngày khởi hành";
            // 
            // cbbTourName
            // 
            this.cbbTourName.FormattingEnabled = true;
            this.cbbTourName.Location = new System.Drawing.Point(107, 19);
            this.cbbTourName.Name = "cbbTourName";
            this.cbbTourName.Size = new System.Drawing.Size(209, 25);
            this.cbbTourName.TabIndex = 37;
            this.cbbTourName.SelectedIndexChanged += new System.EventHandler(this.cbbTourName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên tour";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelCustomer);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.txtCustomerPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbCustomer);
            this.groupBox1.Controls.Add(this.dtgvCustomer);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(346, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 460);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hành khách";
            // 
            // btnDelCustomer
            // 
            this.btnDelCustomer.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnDelCustomer.IconColor = System.Drawing.Color.Black;
            this.btnDelCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelCustomer.IconSize = 20;
            this.btnDelCustomer.Location = new System.Drawing.Point(75, 121);
            this.btnDelCustomer.Name = "btnDelCustomer";
            this.btnDelCustomer.Size = new System.Drawing.Size(76, 25);
            this.btnDelCustomer.TabIndex = 49;
            this.btnDelCustomer.UseVisualStyleBackColor = true;
            this.btnDelCustomer.Click += new System.EventHandler(this.btnDelCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddCustomer.IconColor = System.Drawing.Color.Black;
            this.btnAddCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCustomer.IconSize = 20;
            this.btnAddCustomer.Location = new System.Drawing.Point(157, 121);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(76, 25);
            this.btnAddCustomer.TabIndex = 48;
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(73, 68);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(181, 25);
            this.txtCustomerPhone.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(7, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Du khách";
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(73, 19);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(181, 25);
            this.cbbCustomer.TabIndex = 1;
            this.cbbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbbCustomer_SelectedIndexChanged);
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AllowUserToAddRows = false;
            this.dtgvCustomer.AllowUserToDeleteRows = false;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(6, 172);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.ReadOnly = true;
            this.dtgvCustomer.RowHeadersVisible = false;
            this.dtgvCustomer.RowTemplate.Height = 25;
            this.dtgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCustomer.Size = new System.Drawing.Size(248, 281);
            this.dtgvCustomer.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelStaff);
            this.groupBox3.Controls.Add(this.txtDuty);
            this.groupBox3.Controls.Add(this.btnAddStaff);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbbStaff);
            this.groupBox3.Controls.Add(this.dtgvStaff);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(614, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 460);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên";
            // 
            // btnDelStaff
            // 
            this.btnDelStaff.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnDelStaff.IconColor = System.Drawing.Color.Black;
            this.btnDelStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelStaff.IconSize = 20;
            this.btnDelStaff.Location = new System.Drawing.Point(65, 121);
            this.btnDelStaff.Name = "btnDelStaff";
            this.btnDelStaff.Size = new System.Drawing.Size(76, 25);
            this.btnDelStaff.TabIndex = 51;
            this.btnDelStaff.UseVisualStyleBackColor = true;
            this.btnDelStaff.Click += new System.EventHandler(this.btnDelStaff_Click);
            // 
            // txtDuty
            // 
            this.txtDuty.Location = new System.Drawing.Point(73, 68);
            this.txtDuty.Name = "txtDuty";
            this.txtDuty.Size = new System.Drawing.Size(169, 25);
            this.txtDuty.TabIndex = 49;
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddStaff.IconColor = System.Drawing.Color.Black;
            this.btnAddStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStaff.IconSize = 20;
            this.btnAddStaff.Location = new System.Drawing.Point(147, 121);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(76, 25);
            this.btnAddStaff.TabIndex = 50;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(7, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nhân viên";
            // 
            // cbbStaff
            // 
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(73, 19);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(169, 25);
            this.cbbStaff.TabIndex = 3;
            this.cbbStaff.SelectedIndexChanged += new System.EventHandler(this.cbbStaff_SelectedIndexChanged);
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(6, 172);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersVisible = false;
            this.dtgvStaff.RowTemplate.Height = 25;
            this.dtgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStaff.Size = new System.Drawing.Size(236, 281);
            this.dtgvStaff.TabIndex = 1;
            // 
            // btnSaveTouristGroup
            // 
            this.btnSaveTouristGroup.FlatAppearance.BorderSize = 0;
            this.btnSaveTouristGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTouristGroup.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveTouristGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveTouristGroup.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSaveTouristGroup.IconColor = System.Drawing.Color.Black;
            this.btnSaveTouristGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveTouristGroup.IconSize = 19;
            this.btnSaveTouristGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTouristGroup.Location = new System.Drawing.Point(1049, 474);
            this.btnSaveTouristGroup.Name = "btnSaveTouristGroup";
            this.btnSaveTouristGroup.Size = new System.Drawing.Size(67, 34);
            this.btnSaveTouristGroup.TabIndex = 65;
            this.btnSaveTouristGroup.Text = "Lưu";
            this.btnSaveTouristGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveTouristGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTouristGroup.UseVisualStyleBackColor = true;
            this.btnSaveTouristGroup.Click += new System.EventHandler(this.btnSaveTouristGroup_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDelCost);
            this.groupBox4.Controls.Add(this.txtMoney);
            this.groupBox4.Controls.Add(this.btnAddCost);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.cbbCost);
            this.groupBox4.Controls.Add(this.dtgvCost);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(868, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 460);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi phí chuyến đi";
            // 
            // btnDelCost
            // 
            this.btnDelCost.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnDelCost.IconColor = System.Drawing.Color.Black;
            this.btnDelCost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelCost.IconSize = 20;
            this.btnDelCost.Location = new System.Drawing.Point(65, 121);
            this.btnDelCost.Name = "btnDelCost";
            this.btnDelCost.Size = new System.Drawing.Size(76, 25);
            this.btnDelCost.TabIndex = 51;
            this.btnDelCost.UseVisualStyleBackColor = true;
            this.btnDelCost.Click += new System.EventHandler(this.btnDelCost_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(73, 68);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(169, 25);
            this.txtMoney.TabIndex = 49;
            // 
            // btnAddCost
            // 
            this.btnAddCost.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnAddCost.IconColor = System.Drawing.Color.Black;
            this.btnAddCost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCost.IconSize = 20;
            this.btnAddCost.Location = new System.Drawing.Point(147, 121);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(76, 25);
            this.btnAddCost.TabIndex = 50;
            this.btnAddCost.UseVisualStyleBackColor = true;
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(7, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 48;
            this.label11.Text = "Mệnh giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Loại";
            // 
            // cbbCost
            // 
            this.cbbCost.FormattingEnabled = true;
            this.cbbCost.Location = new System.Drawing.Point(73, 19);
            this.cbbCost.Name = "cbbCost";
            this.cbbCost.Size = new System.Drawing.Size(169, 25);
            this.cbbCost.TabIndex = 3;
            // 
            // dtgvCost
            // 
            this.dtgvCost.AllowUserToAddRows = false;
            this.dtgvCost.AllowUserToDeleteRows = false;
            this.dtgvCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCost.Location = new System.Drawing.Point(6, 172);
            this.dtgvCost.Name = "dtgvCost";
            this.dtgvCost.ReadOnly = true;
            this.dtgvCost.RowHeadersVisible = false;
            this.dtgvCost.RowTemplate.Height = 25;
            this.dtgvCost.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCost.Size = new System.Drawing.Size(236, 281);
            this.dtgvCost.TabIndex = 1;
            // 
            // FormDoanDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 524);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSaveTouristGroup);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDoanDetail";
            this.Text = "Thông tin đoàn du lịch";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TimePickerEndDate;
        private System.Windows.Forms.DateTimePicker TimePickerStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTourName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReveneu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgvStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDuty;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton btnDelCustomer;
        private FontAwesome.Sharp.IconButton btnAddCustomer;
        private FontAwesome.Sharp.IconButton btnDelStaff;
        private FontAwesome.Sharp.IconButton btnAddStaff;
        private FontAwesome.Sharp.IconButton btnSaveTouristGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton btnDelCost;
        private System.Windows.Forms.TextBox txtMoney;
        private FontAwesome.Sharp.IconButton btnAddCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbCost;
        private System.Windows.Forms.DataGridView dtgvCost;
    }
}