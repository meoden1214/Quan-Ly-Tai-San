namespace UI_UX_Dashboard_P1.FormUI
{
    partial class fmBaoHanh
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
            this.txtMaSuaChua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenTaiSan = new System.Windows.Forms.TextBox();
            this.btnRamdo = new XanderUI.XUISuperButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaSuaChua = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbNguoiSua = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbHinhThucSua = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDangChoSua = new System.Windows.Forms.RadioButton();
            this.rdbDaSua = new System.Windows.Forms.RadioButton();
            this.rtbGhiChu = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new XanderUI.XUIButton();
            this.btnThoat = new XanderUI.XUIButton();
            this.cbbTenTaiSan = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSuaChua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BẢO HÀNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Bảo Hành / Sửa Chữa";
            // 
            // txtMaSuaChua
            // 
            this.txtMaSuaChua.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSuaChua.Location = new System.Drawing.Point(16, 120);
            this.txtMaSuaChua.Name = "txtMaSuaChua";
            this.txtMaSuaChua.Size = new System.Drawing.Size(305, 26);
            this.txtMaSuaChua.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(387, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Tài Sản";
            // 
            // txtTenTaiSan
            // 
            this.txtTenTaiSan.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiSan.Location = new System.Drawing.Point(391, 120);
            this.txtTenTaiSan.Name = "txtTenTaiSan";
            this.txtTenTaiSan.Size = new System.Drawing.Size(305, 26);
            this.txtTenTaiSan.TabIndex = 1;
            this.txtTenTaiSan.Visible = false;
            // 
            // btnRamdo
            // 
            this.btnRamdo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRamdo.ButtonImage = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_process_48px;
            this.btnRamdo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.btnRamdo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRamdo.ButtonText = "";
            this.btnRamdo.CornerRadius = 5;
            this.btnRamdo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRamdo.HoverTextColor = System.Drawing.Color.White;
            this.btnRamdo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRamdo.Location = new System.Drawing.Point(327, 120);
            this.btnRamdo.Name = "btnRamdo";
            this.btnRamdo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRamdo.SelectedTextColor = System.Drawing.Color.White;
            this.btnRamdo.Size = new System.Drawing.Size(27, 27);
            this.btnRamdo.SuperSelected = false;
            this.btnRamdo.TabIndex = 2;
            this.btnRamdo.TextColor = System.Drawing.Color.White;
            this.btnRamdo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdo.Click += new System.EventHandler(this.btnRamdo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Sửa Chữa";
            // 
            // txtGiaSuaChua
            // 
            this.txtGiaSuaChua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaSuaChua.Location = new System.Drawing.Point(16, 196);
            this.txtGiaSuaChua.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtGiaSuaChua.Name = "txtGiaSuaChua";
            this.txtGiaSuaChua.Size = new System.Drawing.Size(305, 27);
            this.txtGiaSuaChua.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(387, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Người Mang Đi Sửa";
            // 
            // cbbNguoiSua
            // 
            this.cbbNguoiSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNguoiSua.FormattingEnabled = true;
            this.cbbNguoiSua.Location = new System.Drawing.Point(391, 202);
            this.cbbNguoiSua.Name = "cbbNguoiSua";
            this.cbbNguoiSua.Size = new System.Drawing.Size(305, 28);
            this.cbbNguoiSua.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(387, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hình Thức Sửa";
            // 
            // cbbHinhThucSua
            // 
            this.cbbHinhThucSua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbHinhThucSua.FormattingEnabled = true;
            this.cbbHinhThucSua.Items.AddRange(new object[] {
            "Bảo Hành",
            "Sửa Mất Tiền"});
            this.cbbHinhThucSua.Location = new System.Drawing.Point(391, 285);
            this.cbbHinhThucSua.Name = "cbbHinhThucSua";
            this.cbbHinhThucSua.Size = new System.Drawing.Size(305, 28);
            this.cbbHinhThucSua.TabIndex = 4;
            this.cbbHinhThucSua.Text = "Choose item...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDangChoSua);
            this.groupBox1.Controls.Add(this.rdbDaSua);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng Thái";
            // 
            // rdbDangChoSua
            // 
            this.rdbDangChoSua.AutoSize = true;
            this.rdbDangChoSua.Location = new System.Drawing.Point(151, 39);
            this.rdbDangChoSua.Name = "rdbDangChoSua";
            this.rdbDangChoSua.Size = new System.Drawing.Size(141, 25);
            this.rdbDangChoSua.TabIndex = 0;
            this.rdbDangChoSua.TabStop = true;
            this.rdbDangChoSua.Text = "Đang Chờ Sửa";
            this.rdbDangChoSua.UseVisualStyleBackColor = true;
            // 
            // rdbDaSua
            // 
            this.rdbDaSua.AutoSize = true;
            this.rdbDaSua.Location = new System.Drawing.Point(6, 39);
            this.rdbDaSua.Name = "rdbDaSua";
            this.rdbDaSua.Size = new System.Drawing.Size(84, 25);
            this.rdbDaSua.TabIndex = 0;
            this.rdbDaSua.TabStop = true;
            this.rdbDaSua.Text = "Đã Sửa";
            this.rdbDaSua.UseVisualStyleBackColor = true;
            // 
            // rtbGhiChu
            // 
            this.rtbGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbGhiChu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbGhiChu.Location = new System.Drawing.Point(16, 358);
            this.rtbGhiChu.Name = "rtbGhiChu";
            this.rtbGhiChu.Size = new System.Drawing.Size(605, 137);
            this.rtbGhiChu.TabIndex = 6;
            this.rtbGhiChu.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(18, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ghi Chú";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.ButtonImage = null;
            this.btnLuu.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnLuu.ButtonText = "Lưu";
            this.btnLuu.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.CornerRadius = 5;
            this.btnLuu.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLuu.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnLuu.Location = new System.Drawing.Point(638, 379);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 26);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.TextColor = System.Drawing.Color.White;
            this.btnLuu.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnThoat.ButtonImage = null;
            this.btnThoat.ButtonStyle = XanderUI.XUIButton.Style.Material;
            this.btnThoat.ButtonText = "Thoát";
            this.btnThoat.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.CornerRadius = 5;
            this.btnThoat.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThoat.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnThoat.Location = new System.Drawing.Point(638, 411);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(68, 26);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbTenTaiSan
            // 
            this.cbbTenTaiSan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbbTenTaiSan.FormattingEnabled = true;
            this.cbbTenTaiSan.Location = new System.Drawing.Point(391, 120);
            this.cbbTenTaiSan.Name = "cbbTenTaiSan";
            this.cbbTenTaiSan.Size = new System.Drawing.Size(305, 28);
            this.cbbTenTaiSan.TabIndex = 4;
            this.cbbTenTaiSan.Visible = false;
            // 
            // fmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 525);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.rtbGhiChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbHinhThucSua);
            this.Controls.Add(this.cbbTenTaiSan);
            this.Controls.Add(this.cbbNguoiSua);
            this.Controls.Add(this.txtGiaSuaChua);
            this.Controls.Add(this.btnRamdo);
            this.Controls.Add(this.txtTenTaiSan);
            this.Controls.Add(this.txtMaSuaChua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Bảo Hành / Sửa Chữa";
            this.Load += new System.EventHandler(this.fmBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSuaChua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSuaChua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenTaiSan;
        private XanderUI.XUISuperButton btnRamdo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtGiaSuaChua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbNguoiSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbHinhThucSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDangChoSua;
        private System.Windows.Forms.RadioButton rdbDaSua;
        private System.Windows.Forms.RichTextBox rtbGhiChu;
        private System.Windows.Forms.Label label7;
        private XanderUI.XUIButton btnLuu;
        private XanderUI.XUIButton btnThoat;
        private System.Windows.Forms.ComboBox cbbTenTaiSan;
    }
}