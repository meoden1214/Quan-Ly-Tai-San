﻿namespace UI_UX_Dashboard_P1
{
    partial class ucNhaCungCap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamLai = new XanderUI.XUISuperButton();
            this.btnXoa = new XanderUI.XUISuperButton();
            this.btnSua = new XanderUI.XUISuperButton();
            this.btnThem = new XanderUI.XUISuperButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNhaCungCap = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhaCungCap = new System.Windows.Forms.TextBox();
            this.btnRamdom = new XanderUI.XUISuperButton();
            this.gvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiem = new System.Windows.Forms.ToolStripComboBox();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.xuiCustomToolstrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cbbTimKiem,
            this.txtTimKiem,
            this.btnTimKiem,
            this.btnXuatFile});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1030, 25);
            this.xuiCustomToolstrip1.TabIndex = 1;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.btnLamLai);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaNhaCungCap);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenNhaCungCap);
            this.panel1.Controls.Add(this.btnRamdom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 573);
            this.panel1.TabIndex = 5;
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackgroundColor = System.Drawing.Color.Orange;
            this.btnLamLai.ButtonImage = null;
            this.btnLamLai.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLamLai.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLamLai.ButtonText = "Làm Lại";
            this.btnLamLai.CornerRadius = 5;
            this.btnLamLai.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLamLai.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnLamLai.HoverTextColor = System.Drawing.Color.White;
            this.btnLamLai.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLamLai.Location = new System.Drawing.Point(273, 348);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLamLai.SelectedTextColor = System.Drawing.Color.White;
            this.btnLamLai.Size = new System.Drawing.Size(74, 34);
            this.btnLamLai.SuperSelected = false;
            this.btnLamLai.TabIndex = 8;
            this.btnLamLai.TextColor = System.Drawing.Color.White;
            this.btnLamLai.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.btnXoa.ButtonImage = null;
            this.btnXoa.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnXoa.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnXoa.ButtonText = "Xóa";
            this.btnXoa.CornerRadius = 5;
            this.btnXoa.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnXoa.HoverTextColor = System.Drawing.Color.White;
            this.btnXoa.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnXoa.Location = new System.Drawing.Point(193, 348);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnXoa.SelectedTextColor = System.Drawing.Color.White;
            this.btnXoa.Size = new System.Drawing.Size(74, 34);
            this.btnXoa.SuperSelected = false;
            this.btnXoa.TabIndex = 9;
            this.btnXoa.TextColor = System.Drawing.Color.White;
            this.btnXoa.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnSua.ButtonImage = null;
            this.btnSua.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnSua.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.CornerRadius = 5;
            this.btnSua.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnSua.HoverTextColor = System.Drawing.Color.White;
            this.btnSua.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnSua.Location = new System.Drawing.Point(113, 348);
            this.btnSua.Name = "btnSua";
            this.btnSua.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnSua.SelectedTextColor = System.Drawing.Color.White;
            this.btnSua.Size = new System.Drawing.Size(74, 34);
            this.btnSua.SuperSelected = false;
            this.btnSua.TabIndex = 10;
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnThem.ButtonImage = null;
            this.btnThem.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnThem.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnThem.ButtonText = "Thêm";
            this.btnThem.CornerRadius = 5;
            this.btnThem.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnThem.HoverTextColor = System.Drawing.Color.White;
            this.btnThem.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnThem.Location = new System.Drawing.Point(33, 348);
            this.btnThem.Name = "btnThem";
            this.btnThem.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnThem.SelectedTextColor = System.Drawing.Color.White;
            this.btnThem.Size = new System.Drawing.Size(74, 34);
            this.btnThem.SuperSelected = false;
            this.btnThem.TabIndex = 11;
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập Mã Nhà Cung Cấp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Địa Chỉ Nhà Cung Cấp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nhập Tên Nhà Cung Cấp";
            // 
            // txtMaNhaCungCap
            // 
            this.txtMaNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaNhaCungCap.Location = new System.Drawing.Point(7, 152);
            this.txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            this.txtMaNhaCungCap.Size = new System.Drawing.Size(283, 33);
            this.txtMaNhaCungCap.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaChi.Location = new System.Drawing.Point(7, 294);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(364, 33);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenNhaCungCap
            // 
            this.txtTenNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhaCungCap.Location = new System.Drawing.Point(7, 227);
            this.txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            this.txtTenNhaCungCap.Size = new System.Drawing.Size(364, 33);
            this.txtTenNhaCungCap.TabIndex = 6;
            // 
            // btnRamdom
            // 
            this.btnRamdom.BackgroundColor = System.Drawing.Color.Purple;
            this.btnRamdom.ButtonImage = null;
            this.btnRamdom.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnRamdom.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnRamdom.ButtonText = "Ramdom";
            this.btnRamdom.CornerRadius = 5;
            this.btnRamdom.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdom.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnRamdom.HoverTextColor = System.Drawing.Color.White;
            this.btnRamdom.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnRamdom.Location = new System.Drawing.Point(296, 152);
            this.btnRamdom.Name = "btnRamdom";
            this.btnRamdom.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnRamdom.SelectedTextColor = System.Drawing.Color.White;
            this.btnRamdom.Size = new System.Drawing.Size(74, 34);
            this.btnRamdom.SuperSelected = false;
            this.btnRamdom.TabIndex = 5;
            this.btnRamdom.TextColor = System.Drawing.Color.White;
            this.btnRamdom.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnRamdom.Click += new System.EventHandler(this.btnRamdom_Click);
            // 
            // gvNhaCungCap
            // 
            this.gvNhaCungCap.AllowUserToAddRows = false;
            this.gvNhaCungCap.AllowUserToDeleteRows = false;
            this.gvNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvNhaCungCap.Location = new System.Drawing.Point(394, 25);
            this.gvNhaCungCap.Name = "gvNhaCungCap";
            this.gvNhaCungCap.ReadOnly = true;
            this.gvNhaCungCap.Size = new System.Drawing.Size(636, 573);
            this.gvNhaCungCap.TabIndex = 6;
            this.gvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhaCungCap_CellClick);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton1.Text = "Refesh";
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên",
            "Tìm theo địa chỉ"});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(121, 25);
            this.cbbTimKiem.Text = "Tìm kiếm theo...";
            this.cbbTimKiem.ToolTipText = "Chọn tìm kiếm theo...";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.Cyan;
            this.btnTimKiem.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_search_48px;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(62, 22);
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_export_csv_40px;
            this.btnXuatFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(102, 22);
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // ucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvNhaCungCap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Name = "ucNhaCungCap";
            this.Size = new System.Drawing.Size(1030, 598);
            this.Load += new System.EventHandler(this.ucNhaCungCap_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNhaCungCap;
        private System.Windows.Forms.TextBox txtTenNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiaChi;
        private XanderUI.XUISuperButton btnRamdom;
        private XanderUI.XUISuperButton btnLamLai;
        private XanderUI.XUISuperButton btnXoa;
        private XanderUI.XUISuperButton btnSua;
        private XanderUI.XUISuperButton btnThem;
        private System.Windows.Forms.DataGridView gvNhaCungCap;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
    }
}
