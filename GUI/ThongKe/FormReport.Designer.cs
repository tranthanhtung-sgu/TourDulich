
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.ThongKe
{
    partial class FormReport
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
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTour = new System.Windows.Forms.ComboBox();
            this.cboxDoan = new System.Windows.Forms.CheckBox();
            this.cboxKhach = new System.Windows.Forms.CheckBox();
            this.cboxLoiNhuan = new System.Windows.Forms.CheckBox();
            this.timepickerYear = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(12, 78);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1020, 434);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tour du lịch";
            // 
            // cbbTour
            // 
            this.cbbTour.FormattingEnabled = true;
            this.cbbTour.Location = new System.Drawing.Point(91, 24);
            this.cbbTour.Name = "cbbTour";
            this.cbbTour.Size = new System.Drawing.Size(174, 23);
            this.cbbTour.TabIndex = 2;
            this.cbbTour.SelectedIndexChanged += new System.EventHandler(this.cbbTour_SelectedIndexChanged);
            // 
            // cboxDoan
            // 
            this.cboxDoan.AutoSize = true;
            this.cboxDoan.Location = new System.Drawing.Point(318, 26);
            this.cboxDoan.Name = "cboxDoan";
            this.cboxDoan.Size = new System.Drawing.Size(54, 19);
            this.cboxDoan.TabIndex = 6;
            this.cboxDoan.Text = "Đoàn";
            this.cboxDoan.UseVisualStyleBackColor = true;
            this.cboxDoan.CheckedChanged += new System.EventHandler(this.cboxDoan_CheckedChanged);
            // 
            // cboxKhach
            // 
            this.cboxKhach.AutoSize = true;
            this.cboxKhach.Location = new System.Drawing.Point(438, 26);
            this.cboxKhach.Name = "cboxKhach";
            this.cboxKhach.Size = new System.Drawing.Size(59, 19);
            this.cboxKhach.TabIndex = 7;
            this.cboxKhach.Text = "Khách";
            this.cboxKhach.UseVisualStyleBackColor = true;
            this.cboxKhach.CheckedChanged += new System.EventHandler(this.cboxKhach_CheckedChanged);
            // 
            // cboxLoiNhuan
            // 
            this.cboxLoiNhuan.AutoSize = true;
            this.cboxLoiNhuan.Location = new System.Drawing.Point(554, 26);
            this.cboxLoiNhuan.Name = "cboxLoiNhuan";
            this.cboxLoiNhuan.Size = new System.Drawing.Size(79, 19);
            this.cboxLoiNhuan.TabIndex = 8;
            this.cboxLoiNhuan.Text = "Lợi nhuận";
            this.cboxLoiNhuan.UseVisualStyleBackColor = true;
            this.cboxLoiNhuan.CheckedChanged += new System.EventHandler(this.cboxLoiNhuan_CheckedChanged);
            // 
            // timepickerYear
            // 
            this.timepickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepickerYear.Location = new System.Drawing.Point(664, 24);
            this.timepickerYear.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.timepickerYear.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.timepickerYear.Name = "timepickerYear";
            this.timepickerYear.Size = new System.Drawing.Size(95, 23);
            this.timepickerYear.TabIndex = 9;
            this.timepickerYear.ValueChanged += new System.EventHandler(this.timepickerYear_ValueChanged);
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 524);
            this.Controls.Add(this.timepickerYear);
            this.Controls.Add(this.cboxLoiNhuan);
            this.Controls.Add(this.cboxKhach);
            this.Controls.Add(this.cboxDoan);
            this.Controls.Add(this.cbbTour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "FormReport";
            this.Text = "Thống kê";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTour;
        private System.Windows.Forms.CheckBox cboxDoan;
        private System.Windows.Forms.CheckBox cboxKhach;
        private System.Windows.Forms.CheckBox cboxLoiNhuan;
        private System.Windows.Forms.DateTimePicker timepickerYear;
    }
}