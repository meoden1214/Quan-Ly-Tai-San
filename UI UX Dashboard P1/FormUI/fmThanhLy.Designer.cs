namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmThanhLy
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
            this.ccbNguoiThanhLy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenTaiSan = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.btnXuatPhieu = new XanderUI.XUIButton();
            this.btnThanhLy = new XanderUI.XUIButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiMua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ccbNguoiThanhLy
            // 
            this.ccbNguoiThanhLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ccbNguoiThanhLy.FormattingEnabled = true;
            this.ccbNguoiThanhLy.Location = new System.Drawing.Point(10, 243);
            this.ccbNguoiThanhLy.Name = "ccbNguoiThanhLy";
            this.ccbNguoiThanhLy.Size = new System.Drawing.Size(299, 29);
            this.ccbNguoiThanhLy.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(11, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Người Thanh Lý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã - Tên Tài Sản:";
            // 
            // lbTenTaiSan
            // 
            this.lbTenTaiSan.AutoSize = true;
            this.lbTenTaiSan.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTenTaiSan.ForeColor = System.Drawing.Color.Red;
            this.lbTenTaiSan.Location = new System.Drawing.Point(172, 88);
            this.lbTenTaiSan.Name = "lbTenTaiSan";
            this.lbTenTaiSan.Size = new System.Drawing.Size(28, 25);
            this.lbTenTaiSan.TabIndex = 1;
            this.lbTenTaiSan.Text = "lb";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(16, 316);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(638, 29);
            this.txtThanhTien.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(11, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Thành Tiền";
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDonGia.ForeColor = System.Drawing.Color.Red;
            this.lbDonGia.Location = new System.Drawing.Point(107, 148);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(28, 25);
            this.lbDonGia.TabIndex = 1;
            this.lbDonGia.Text = "lb";
            // 
            // btnXuatPhieu
            // 
            this.btnXuatPhieu.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btnXuatPhieu.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_print_80px;
            this.btnXuatPhieu.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnXuatPhieu.ButtonText = "Xuất Phiếu";
            this.btnXuatPhieu.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnXuatPhieu.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnXuatPhieu.CornerRadius = 5;
            this.btnXuatPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuatPhieu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXuatPhieu.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnXuatPhieu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnXuatPhieu.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnXuatPhieu.Location = new System.Drawing.Point(328, 365);
            this.btnXuatPhieu.Name = "btnXuatPhieu";
            this.btnXuatPhieu.Size = new System.Drawing.Size(117, 36);
            this.btnXuatPhieu.TabIndex = 4;
            this.btnXuatPhieu.TextColor = System.Drawing.Color.White;
            this.btnXuatPhieu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnThanhLy
            // 
            this.btnThanhLy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnThanhLy.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.thanhly;
            this.btnThanhLy.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnThanhLy.ButtonText = "Thanh Lý";
            this.btnThanhLy.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnThanhLy.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnThanhLy.CornerRadius = 5;
            this.btnThanhLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhLy.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThanhLy.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.btnThanhLy.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.btnThanhLy.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThanhLy.Location = new System.Drawing.Point(205, 365);
            this.btnThanhLy.Name = "btnThanhLy";
            this.btnThanhLy.Size = new System.Drawing.Size(117, 36);
            this.btnThanhLy.TabIndex = 4;
            this.btnThanhLy.TextColor = System.Drawing.Color.White;
            this.btnThanhLy.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThanhLy.Click += new System.EventHandler(this.btnThanhLy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(321, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người Mua";
            // 
            // txtNguoiMua
            // 
            this.txtNguoiMua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNguoiMua.ForeColor = System.Drawing.Color.Black;
            this.txtNguoiMua.Location = new System.Drawing.Point(327, 243);
            this.txtNguoiMua.Name = "txtNguoiMua";
            this.txtNguoiMua.Size = new System.Drawing.Size(327, 29);
            this.txtNguoiMua.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(198, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 42);
            this.label5.TabIndex = 5;
            this.label5.Text = "PHIẾU THANH LÝ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn Giá:";
            // 
            // fmThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXuatPhieu);
            this.Controls.Add(this.btnThanhLy);
            this.Controls.Add(this.txtNguoiMua);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbTenTaiSan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ccbNguoiThanhLy);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmThanhLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Lý Tài Sản";
            this.Load += new System.EventHandler(this.fmThanhLy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ccbNguoiThanhLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenTaiSan;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDonGia;
        private XanderUI.XUIButton btnThanhLy;
        private XanderUI.XUIButton btnXuatPhieu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiMua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}