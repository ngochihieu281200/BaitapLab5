namespace Bai3
{
    partial class FormBai3
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxMSNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHTNV = new System.Windows.Forms.TextBox();
            this.rdBtnNVKD = new System.Windows.Forms.RadioButton();
            this.rdBtnNVSX = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxLCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxSLHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxSLSP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLuongNhanVien = new System.Windows.Forms.Label();
            this.btnTinhLuong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã nhân viên";
            // 
            // txtBoxMSNV
            // 
            this.txtBoxMSNV.Location = new System.Drawing.Point(191, 37);
            this.txtBoxMSNV.Name = "txtBoxMSNV";
            this.txtBoxMSNV.Size = new System.Drawing.Size(393, 20);
            this.txtBoxMSNV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập họ tên nhân viên";
            // 
            // txtBoxHTNV
            // 
            this.txtBoxHTNV.Location = new System.Drawing.Point(191, 79);
            this.txtBoxHTNV.Name = "txtBoxHTNV";
            this.txtBoxHTNV.Size = new System.Drawing.Size(393, 20);
            this.txtBoxHTNV.TabIndex = 3;
            // 
            // rdBtnNVKD
            // 
            this.rdBtnNVKD.AutoSize = true;
            this.rdBtnNVKD.Location = new System.Drawing.Point(191, 191);
            this.rdBtnNVKD.Name = "rdBtnNVKD";
            this.rdBtnNVKD.Size = new System.Drawing.Size(134, 17);
            this.rdBtnNVKD.TabIndex = 4;
            this.rdBtnNVKD.TabStop = true;
            this.rdBtnNVKD.Text = "Nhân Viên Kinh Doanh";
            this.rdBtnNVKD.UseVisualStyleBackColor = true;
            this.rdBtnNVKD.CheckedChanged += new System.EventHandler(this.rdBtnNVKD_CheckedChanged);
            // 
            // rdBtnNVSX
            // 
            this.rdBtnNVSX.AutoSize = true;
            this.rdBtnNVSX.Location = new System.Drawing.Point(450, 191);
            this.rdBtnNVSX.Name = "rdBtnNVSX";
            this.rdBtnNVSX.Size = new System.Drawing.Size(122, 17);
            this.rdBtnNVSX.TabIndex = 5;
            this.rdBtnNVSX.TabStop = true;
            this.rdBtnNVSX.Text = "Nhân Viên Sản Xuất";
            this.rdBtnNVSX.UseVisualStyleBackColor = true;
            this.rdBtnNVSX.CheckedChanged += new System.EventHandler(this.rdBtnNVSX_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lương Cơ Bản";
            // 
            // txtBoxLCB
            // 
            this.txtBoxLCB.Location = new System.Drawing.Point(191, 252);
            this.txtBoxLCB.Name = "txtBoxLCB";
            this.txtBoxLCB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLCB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số Lượng Hợp Đồng";
            // 
            // txtBoxSLHD
            // 
            this.txtBoxSLHD.Location = new System.Drawing.Point(191, 323);
            this.txtBoxSLHD.Name = "txtBoxSLHD";
            this.txtBoxSLHD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSLHD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số Lượng Sản Phẩm";
            // 
            // txtBoxSLSP
            // 
            this.txtBoxSLSP.Location = new System.Drawing.Point(452, 252);
            this.txtBoxSLSP.Name = "txtBoxSLSP";
            this.txtBoxSLSP.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSLSP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lương Nhân Viên là:";
            // 
            // lblLuongNhanVien
            // 
            this.lblLuongNhanVien.AutoSize = true;
            this.lblLuongNhanVien.Location = new System.Drawing.Point(187, 357);
            this.lblLuongNhanVien.Name = "lblLuongNhanVien";
            this.lblLuongNhanVien.Size = new System.Drawing.Size(13, 13);
            this.lblLuongNhanVien.TabIndex = 13;
            this.lblLuongNhanVien.Text = "0";
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(284, 399);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(132, 23);
            this.btnTinhLuong.TabIndex = 14;
            this.btnTinhLuong.Text = "Tính Lương Nhân Viên";
            this.btnTinhLuong.UseVisualStyleBackColor = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);
            // 
            // FormBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinhLuong);
            this.Controls.Add(this.lblLuongNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxSLSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxSLHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxLCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdBtnNVSX);
            this.Controls.Add(this.rdBtnNVKD);
            this.Controls.Add(this.txtBoxHTNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMSNV);
            this.Controls.Add(this.label1);
            this.Name = "FormBai3";
            this.Text = "Bai3_Buoi5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxMSNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHTNV;
        private System.Windows.Forms.RadioButton rdBtnNVKD;
        private System.Windows.Forms.RadioButton rdBtnNVSX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxLCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxSLHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSLSP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLuongNhanVien;
        private System.Windows.Forms.Button btnTinhLuong;
    }
}

