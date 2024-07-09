namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmDoiPass
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
            this.btnOK = new XanderUI.XUIButton();
            this.txtPassword_Old = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword_New = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword_ReNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.ButtonImage = null;
            this.btnOK.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnOK.ButtonText = "Lưu Lại";
            this.btnOK.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnOK.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.CornerRadius = 5;
            this.btnOK.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnOK.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnOK.Location = new System.Drawing.Point(106, 220);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(83, 34);
            this.btnOK.TabIndex = 8;
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtPassword_Old
            // 
            this.txtPassword_Old.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_Old.Location = new System.Drawing.Point(16, 34);
            this.txtPassword_Old.Name = "txtPassword_Old";
            this.txtPassword_Old.Size = new System.Drawing.Size(304, 29);
            this.txtPassword_Old.TabIndex = 6;
            this.txtPassword_Old.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật Khẩu Cũ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mật Khẩu Mới";
            // 
            // txtPassword_New
            // 
            this.txtPassword_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_New.Location = new System.Drawing.Point(16, 104);
            this.txtPassword_New.Name = "txtPassword_New";
            this.txtPassword_New.Size = new System.Drawing.Size(304, 29);
            this.txtPassword_New.TabIndex = 6;
            this.txtPassword_New.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // txtPassword_ReNew
            // 
            this.txtPassword_ReNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPassword_ReNew.Location = new System.Drawing.Point(16, 175);
            this.txtPassword_ReNew.Name = "txtPassword_ReNew";
            this.txtPassword_ReNew.Size = new System.Drawing.Size(304, 29);
            this.txtPassword_ReNew.TabIndex = 6;
            this.txtPassword_ReNew.UseSystemPasswordChar = true;
            // 
            // fmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 278);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword_ReNew);
            this.Controls.Add(this.txtPassword_New);
            this.Controls.Add(this.txtPassword_Old);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDoiPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnOK;
        private System.Windows.Forms.TextBox txtPassword_Old;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword_New;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword_ReNew;
    }
}