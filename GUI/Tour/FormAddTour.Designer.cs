
namespace GUI
{
    partial class FormAddTour
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
            this.txt_TourName = new System.Windows.Forms.TextBox();
            this.lbl_TourName = new System.Windows.Forms.Label();
            this.lbl_TourDescription = new System.Windows.Forms.Label();
            this.txt_TourDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_TourType = new System.Windows.Forms.ComboBox();
            this.btnAddTour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_TourName
            // 
            this.txt_TourName.Location = new System.Drawing.Point(212, 75);
            this.txt_TourName.Name = "txt_TourName";
            this.txt_TourName.Size = new System.Drawing.Size(200, 23);
            this.txt_TourName.TabIndex = 0;
            // 
            // lbl_TourName
            // 
            this.lbl_TourName.AutoSize = true;
            this.lbl_TourName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TourName.Location = new System.Drawing.Point(82, 78);
            this.lbl_TourName.Name = "lbl_TourName";
            this.lbl_TourName.Size = new System.Drawing.Size(65, 20);
            this.lbl_TourName.TabIndex = 1;
            this.lbl_TourName.Text = "Tên gọi :";
            // 
            // lbl_TourDescription
            // 
            this.lbl_TourDescription.AutoSize = true;
            this.lbl_TourDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TourDescription.Location = new System.Drawing.Point(82, 174);
            this.lbl_TourDescription.Name = "lbl_TourDescription";
            this.lbl_TourDescription.Size = new System.Drawing.Size(48, 20);
            this.lbl_TourDescription.TabIndex = 3;
            this.lbl_TourDescription.Text = "Mô tả";
            // 
            // txt_TourDescription
            // 
            this.txt_TourDescription.Location = new System.Drawing.Point(212, 174);
            this.txt_TourDescription.Multiline = true;
            this.txt_TourDescription.Name = "txt_TourDescription";
            this.txt_TourDescription.Size = new System.Drawing.Size(200, 80);
            this.txt_TourDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(82, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Loại hình du lịch :";
            // 
            // cbb_TourType
            // 
            this.cbb_TourType.FormattingEnabled = true;
            this.cbb_TourType.Location = new System.Drawing.Point(212, 124);
            this.cbb_TourType.Name = "cbb_TourType";
            this.cbb_TourType.Size = new System.Drawing.Size(200, 23);
            this.cbb_TourType.TabIndex = 6;
            // 
            // btnAddTour
            // 
            this.btnAddTour.Location = new System.Drawing.Point(212, 287);
            this.btnAddTour.Name = "btnAddTour";
            this.btnAddTour.Size = new System.Drawing.Size(122, 40);
            this.btnAddTour.TabIndex = 7;
            this.btnAddTour.Text = "Thêm";
            this.btnAddTour.UseVisualStyleBackColor = true;
            this.btnAddTour.Click += new System.EventHandler(this.btnAddTour_Click);
            // 
            // FrmAddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddTour);
            this.Controls.Add(this.cbb_TourType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_TourDescription);
            this.Controls.Add(this.txt_TourDescription);
            this.Controls.Add(this.lbl_TourName);
            this.Controls.Add(this.txt_TourName);
            this.Name = "FrmAddTour";
            this.Text = "FrmAddTour";
            this.Load += new System.EventHandler(this.FrmAddTour_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TourName;
        private System.Windows.Forms.Label lbl_TourName;
        private System.Windows.Forms.Label lbl_TourDescription;
        private System.Windows.Forms.TextBox txt_TourDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_TourType;
        private System.Windows.Forms.Button btnAddTour;
    }
}