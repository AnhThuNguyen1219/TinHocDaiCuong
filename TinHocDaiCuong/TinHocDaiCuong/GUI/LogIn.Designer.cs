namespace TinHocDaiCuong.GUI
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV_LI = new System.Windows.Forms.TextBox();
            this.txtMatKhau_LI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel_LI = new System.Windows.Forms.Button();
            this.btnLogIn_LI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(229, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtMSSV_LI
            // 
            this.txtMSSV_LI.Location = new System.Drawing.Point(352, 125);
            this.txtMSSV_LI.Name = "txtMSSV_LI";
            this.txtMSSV_LI.Size = new System.Drawing.Size(251, 22);
            this.txtMSSV_LI.TabIndex = 2;
            // 
            // txtMatKhau_LI
            // 
            this.txtMatKhau_LI.Location = new System.Drawing.Point(352, 194);
            this.txtMatKhau_LI.Name = "txtMatKhau_LI";
            this.txtMatKhau_LI.PasswordChar = '*';
            this.txtMatKhau_LI.Size = new System.Drawing.Size(251, 22);
            this.txtMatKhau_LI.TabIndex = 3;
            this.txtMatKhau_LI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhau_LI_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(110, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(673, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "THI KẾT THÚC HỌC PHẦN TIN HỌC ĐẠI CƯƠNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel_LI
            // 
            this.btnCancel_LI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancel_LI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel_LI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_LI.Location = new System.Drawing.Point(659, 263);
            this.btnCancel_LI.Name = "btnCancel_LI";
            this.btnCancel_LI.Size = new System.Drawing.Size(145, 55);
            this.btnCancel_LI.TabIndex = 5;
            this.btnCancel_LI.Text = "Thoát";
            this.btnCancel_LI.UseVisualStyleBackColor = false;
            this.btnCancel_LI.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogIn_LI
            // 
            this.btnLogIn_LI.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLogIn_LI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogIn_LI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn_LI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogIn_LI.Location = new System.Drawing.Point(116, 263);
            this.btnLogIn_LI.Name = "btnLogIn_LI";
            this.btnLogIn_LI.Size = new System.Drawing.Size(145, 55);
            this.btnLogIn_LI.TabIndex = 4;
            this.btnLogIn_LI.Text = "Đăng Nhập";
            this.btnLogIn_LI.UseVisualStyleBackColor = false;
            this.btnLogIn_LI.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TinHocDaiCuong.Properties.Resources.Best_Website_Background_Images29;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 368);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel_LI);
            this.Controls.Add(this.btnLogIn_LI);
            this.Controls.Add(this.txtMatKhau_LI);
            this.Controls.Add(this.txtMSSV_LI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV_LI;
        private System.Windows.Forms.TextBox txtMatKhau_LI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel_LI;
        private System.Windows.Forms.Button btnLogIn_LI;
    }
}