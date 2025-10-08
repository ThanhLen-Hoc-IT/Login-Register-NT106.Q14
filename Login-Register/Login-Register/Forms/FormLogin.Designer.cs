namespace Login_Register.Forms
{
    partial class s
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
            this.TenDangNhap = new System.Windows.Forms.TextBox();
            this.EmailDangNhap = new System.Windows.Forms.TextBox();
            this.MatKhau = new System.Windows.Forms.TextBox();
            this.XacNhanMatkhau = new System.Windows.Forms.TextBox();
            this.Dangky = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.Location = new System.Drawing.Point(165, 96);
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.Size = new System.Drawing.Size(100, 20);
            this.TenDangNhap.TabIndex = 0;
            // 
            // EmailDangNhap
            // 
            this.EmailDangNhap.Location = new System.Drawing.Point(171, 138);
            this.EmailDangNhap.Name = "EmailDangNhap";
            this.EmailDangNhap.Size = new System.Drawing.Size(100, 20);
            this.EmailDangNhap.TabIndex = 1;
            // 
            // MatKhau
            // 
            this.MatKhau.Location = new System.Drawing.Point(171, 175);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(100, 20);
            this.MatKhau.TabIndex = 2;
            // 
            // XacNhanMatkhau
            // 
            this.XacNhanMatkhau.Location = new System.Drawing.Point(171, 213);
            this.XacNhanMatkhau.Name = "XacNhanMatkhau";
            this.XacNhanMatkhau.Size = new System.Drawing.Size(100, 20);
            this.XacNhanMatkhau.TabIndex = 3;
            // 
            // Dangky
            // 
            this.Dangky.Location = new System.Drawing.Point(186, 268);
            this.Dangky.Name = "Dangky";
            this.Dangky.Size = new System.Drawing.Size(75, 23);
            this.Dangky.TabIndex = 4;
            this.Dangky.Text = "dang ky";
            this.Dangky.UseVisualStyleBackColor = true;
            this.Dangky.Click += new System.EventHandler(this.Dangky_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mat Khau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Xac Nhan Mat khau";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dangky);
            this.Controls.Add(this.XacNhanMatkhau);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.EmailDangNhap);
            this.Controls.Add(this.TenDangNhap);
            this.Name = "s";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TenDangNhap;
        private System.Windows.Forms.TextBox EmailDangNhap;
        private System.Windows.Forms.TextBox MatKhau;
        private System.Windows.Forms.TextBox XacNhanMatkhau;
        private System.Windows.Forms.Button Dangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}