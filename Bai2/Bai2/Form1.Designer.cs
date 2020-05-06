namespace Bai2
{
    partial class FormBai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxtusoa = new System.Windows.Forms.TextBox();
            this.txtBoxmausoa = new System.Windows.Forms.TextBox();
            this.txtBoxtusob = new System.Windows.Forms.TextBox();
            this.txtBoxmausob = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCongPhanSo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tử số của phân số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mẫu số của phân số a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập tử số của phân số b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập mẫu số của phân số b";
            // 
            // txtBoxtusoa
            // 
            this.txtBoxtusoa.Location = new System.Drawing.Point(229, 37);
            this.txtBoxtusoa.Name = "txtBoxtusoa";
            this.txtBoxtusoa.Size = new System.Drawing.Size(205, 20);
            this.txtBoxtusoa.TabIndex = 4;
            // 
            // txtBoxmausoa
            // 
            this.txtBoxmausoa.Location = new System.Drawing.Point(229, 80);
            this.txtBoxmausoa.Name = "txtBoxmausoa";
            this.txtBoxmausoa.Size = new System.Drawing.Size(205, 20);
            this.txtBoxmausoa.TabIndex = 5;
            // 
            // txtBoxtusob
            // 
            this.txtBoxtusob.Location = new System.Drawing.Point(229, 113);
            this.txtBoxtusob.Name = "txtBoxtusob";
            this.txtBoxtusob.Size = new System.Drawing.Size(205, 20);
            this.txtBoxtusob.TabIndex = 6;
            // 
            // txtBoxmausob
            // 
            this.txtBoxmausob.Location = new System.Drawing.Point(229, 154);
            this.txtBoxmausob.Name = "txtBoxmausob";
            this.txtBoxmausob.Size = new System.Drawing.Size(205, 20);
            this.txtBoxmausob.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // btnCongPhanSo
            // 
            this.btnCongPhanSo.Location = new System.Drawing.Point(292, 259);
            this.btnCongPhanSo.Name = "btnCongPhanSo";
            this.btnCongPhanSo.Size = new System.Drawing.Size(142, 23);
            this.btnCongPhanSo.TabIndex = 9;
            this.btnCongPhanSo.Text = "Thực hiện phép cộng";
            this.btnCongPhanSo.UseVisualStyleBackColor = true;
            this.btnCongPhanSo.Click += new System.EventHandler(this.btnCongPhanSo_Click);
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 294);
            this.Controls.Add(this.btnCongPhanSo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxmausob);
            this.Controls.Add(this.txtBoxtusob);
            this.Controls.Add(this.txtBoxmausoa);
            this.Controls.Add(this.txtBoxtusoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBai2";
            this.Text = "Bai2_Buoi5";
       
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxtusoa;
        private System.Windows.Forms.TextBox txtBoxmausoa;
        private System.Windows.Forms.TextBox txtBoxtusob;
        private System.Windows.Forms.TextBox txtBoxmausob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCongPhanSo;
    }
}

