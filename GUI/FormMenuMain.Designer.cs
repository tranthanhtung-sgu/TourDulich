
namespace GUI
{
    partial class FrmMainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDiaDiem = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnDoan = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnListTour = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMini = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.btnmax = new FontAwesome.Sharp.IconButton();
            this.lblTitleChilForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnDiaDiem);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnNhanVien);
            this.panelMenu.Controls.Add(this.btnDoan);
            this.panelMenu.Controls.Add(this.btnKhachHang);
            this.panelMenu.Controls.Add(this.btnListTour);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDiaDiem
            // 
            this.btnDiaDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiaDiem.FlatAppearance.BorderSize = 0;
            this.btnDiaDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaDiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDiaDiem.IconChar = FontAwesome.Sharp.IconChar.MapPin;
            this.btnDiaDiem.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDiaDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiaDiem.IconSize = 32;
            this.btnDiaDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiaDiem.Location = new System.Drawing.Point(0, 440);
            this.btnDiaDiem.Name = "btnDiaDiem";
            this.btnDiaDiem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDiaDiem.Size = new System.Drawing.Size(220, 60);
            this.btnDiaDiem.TabIndex = 7;
            this.btnDiaDiem.Text = "Địa điểm";
            this.btnDiaDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiaDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiaDiem.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.btnReport.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 32;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 380);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReport.Size = new System.Drawing.Size(220, 60);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Thống kê";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.IconSize = 32;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 320);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(220, 60);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnDoan
            // 
            this.btnDoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoan.FlatAppearance.BorderSize = 0;
            this.btnDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoan.IconChar = FontAwesome.Sharp.IconChar.BusAlt;
            this.btnDoan.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoan.IconSize = 32;
            this.btnDoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.Location = new System.Drawing.Point(0, 260);
            this.btnDoan.Name = "btnDoan";
            this.btnDoan.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDoan.Size = new System.Drawing.Size(220, 60);
            this.btnDoan.TabIndex = 4;
            this.btnDoan.Text = "Đoàn du lịch";
            this.btnDoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoan.UseVisualStyleBackColor = true;
            this.btnDoan.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.IconSize = 32;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 200);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(220, 60);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnListTour
            // 
            this.btnListTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListTour.FlatAppearance.BorderSize = 0;
            this.btnListTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListTour.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListTour.IconChar = FontAwesome.Sharp.IconChar.MapMarked;
            this.btnListTour.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListTour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListTour.IconSize = 32;
            this.btnListTour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTour.Location = new System.Drawing.Point(0, 140);
            this.btnListTour.Name = "btnListTour";
            this.btnListTour.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListTour.Size = new System.Drawing.Size(220, 60);
            this.btnListTour.TabIndex = 1;
            this.btnListTour.Text = "Danh sách tour";
            this.btnListTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListTour.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListTour.UseVisualStyleBackColor = true;
            this.btnListTour.Click += new System.EventHandler(this.btnListTour_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::GUI.Properties.Resources.logo2;
            this.btnHome.Location = new System.Drawing.Point(16, 13);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(183, 112);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lblTitleChilForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(844, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnmax);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(724, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnMini
            // 
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMini.IconColor = System.Drawing.Color.White;
            this.btnMini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMini.IconSize = 15;
            this.btnMini.Location = new System.Drawing.Point(55, -1);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(26, 23);
            this.btnMini.TabIndex = 5;
            this.btnMini.UseVisualStyleBackColor = true;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 17;
            this.btnClose.Location = new System.Drawing.Point(96, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnmax
            // 
            this.btnmax.FlatAppearance.BorderSize = 0;
            this.btnmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnmax.IconColor = System.Drawing.Color.White;
            this.btnmax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnmax.IconSize = 15;
            this.btnmax.Location = new System.Drawing.Point(76, 0);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(26, 23);
            this.btnmax.TabIndex = 4;
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // lblTitleChilForm
            // 
            this.lblTitleChilForm.AutoSize = true;
            this.lblTitleChilForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleChilForm.Location = new System.Drawing.Point(57, 35);
            this.lblTitleChilForm.Name = "lblTitleChilForm";
            this.lblTitleChilForm.Size = new System.Drawing.Size(40, 15);
            this.lblTitleChilForm.TabIndex = 1;
            this.lblTitleChilForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 26);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(844, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(844, 522);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::GUI.Properties.Resources.logo2;
            this.pictureBox1.Location = new System.Drawing.Point(333, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMainMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainMenu_FormClosing);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnListTour;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private FontAwesome.Sharp.IconButton btnDoan;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnReport;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChilForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMini;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnmax;
        private FontAwesome.Sharp.IconButton btnDiaDiem;
    }
}