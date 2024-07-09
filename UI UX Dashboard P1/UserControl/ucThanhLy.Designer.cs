namespace UI_UX_Dashboard_P1
{
    partial class ucThanhLy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucThanhLy));
            this.xuiCustomToolstrip1 = new XanderUI.XUICustomToolstrip();
            this.toolStripBTNRefesh = new System.Windows.Forms.ToolStripButton();
            this.cbbTimKiem = new System.Windows.Forms.ToolStripComboBox();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnXuatFile = new System.Windows.Forms.ToolStripButton();
            this.gvDanhSachThanhLy = new System.Windows.Forms.DataGridView();
            this.ContextMenuStrip_ThanhLy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_LuuKH = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBTNXuatBaoCao = new System.Windows.Forms.ToolStripButton();
            this.xuiCustomToolstrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThanhLy)).BeginInit();
            this.ContextMenuStrip_ThanhLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiCustomToolstrip1
            // 
            this.xuiCustomToolstrip1.BackColor = System.Drawing.Color.White;
            this.xuiCustomToolstrip1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomToolstrip1.ForeColor = System.Drawing.Color.Black;
            this.xuiCustomToolstrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.xuiCustomToolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBTNRefesh,
            this.cbbTimKiem,
            this.txtTimKiem,
            this.btnTimKiem,
            this.btnXuatFile,
            this.toolStripBTNXuatBaoCao});
            this.xuiCustomToolstrip1.Location = new System.Drawing.Point(0, 0);
            this.xuiCustomToolstrip1.Name = "xuiCustomToolstrip1";
            this.xuiCustomToolstrip1.Size = new System.Drawing.Size(1030, 25);
            this.xuiCustomToolstrip1.TabIndex = 3;
            this.xuiCustomToolstrip1.Text = "xuiCustomToolstrip1";
            // 
            // toolStripBTNRefesh
            // 
            this.toolStripBTNRefesh.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px1;
            this.toolStripBTNRefesh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBTNRefesh.Name = "toolStripBTNRefesh";
            this.toolStripBTNRefesh.Size = new System.Drawing.Size(74, 22);
            this.toolStripBTNRefesh.Text = "Làm Mới";
            this.toolStripBTNRefesh.ToolTipText = "Load Data";
            this.toolStripBTNRefesh.Click += new System.EventHandler(this.toolStripBTNRefesh_Click);
            // 
            // cbbTimKiem
            // 
            this.cbbTimKiem.Items.AddRange(new object[] {
            "Tìm theo mã",
            "Tìm theo tên",
            "Tìm theo người thanh lý",
            "Tìm theo ngày"});
            this.cbbTimKiem.Name = "cbbTimKiem";
            this.cbbTimKiem.Size = new System.Drawing.Size(121, 25);
            this.cbbTimKiem.Text = "Tìm kiếm theo...";
            this.cbbTimKiem.ToolTipText = "Chọn tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(300, 25);
            this.txtTimKiem.ToolTipText = "Tìm Kiếm";
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTimKiem_KeyPress);
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
            this.btnXuatFile.Image = global::UI_UX_Dashboard_P1.Properties.Resources.thoat1;
            this.btnXuatFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(102, 22);
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // gvDanhSachThanhLy
            // 
            this.gvDanhSachThanhLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDanhSachThanhLy.ContextMenuStrip = this.ContextMenuStrip_ThanhLy;
            this.gvDanhSachThanhLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachThanhLy.Location = new System.Drawing.Point(0, 25);
            this.gvDanhSachThanhLy.Name = "gvDanhSachThanhLy";
            this.gvDanhSachThanhLy.Size = new System.Drawing.Size(1030, 573);
            this.gvDanhSachThanhLy.TabIndex = 4;
            this.gvDanhSachThanhLy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDanhSachThanhLy_CellClick);
            this.gvDanhSachThanhLy.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvDanhSachThanhLy_CellMouseDown);
            this.gvDanhSachThanhLy.SelectionChanged += new System.EventHandler(this.gvDanhSachThanhLy_SelectionChanged);
            // 
            // ContextMenuStrip_ThanhLy
            // 
            this.ContextMenuStrip_ThanhLy.BackColor = System.Drawing.Color.Lavender;
            this.ContextMenuStrip_ThanhLy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Xoa,
            this.toolStripSeparator8,
            this.ToolStripMenuItem_LuuKH});
            this.ContextMenuStrip_ThanhLy.Name = "contextMenuStrip1";
            this.ContextMenuStrip_ThanhLy.Size = new System.Drawing.Size(125, 54);
            // 
            // ToolStripMenuItem_Xoa
            // 
            this.ToolStripMenuItem_Xoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Xoa.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItem_Xoa.Image")));
            this.ToolStripMenuItem_Xoa.Name = "ToolStripMenuItem_Xoa";
            this.ToolStripMenuItem_Xoa.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Xoa.Text = "Xóa ";
            this.ToolStripMenuItem_Xoa.Click += new System.EventHandler(this.ToolStripMenuItem_Xoa_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(121, 6);
            // 
            // ToolStripMenuItem_LuuKH
            // 
            this.ToolStripMenuItem_LuuKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_LuuKH.ForeColor = System.Drawing.Color.MediumBlue;
            this.ToolStripMenuItem_LuuKH.Image = global::UI_UX_Dashboard_P1.Properties.Resources.icons8_update_left_rotation_64px;
            this.ToolStripMenuItem_LuuKH.Name = "ToolStripMenuItem_LuuKH";
            this.ToolStripMenuItem_LuuKH.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_LuuKH.Text = "Làm mới";
            this.ToolStripMenuItem_LuuKH.Click += new System.EventHandler(this.ToolStripMenuItem_LuuKH_Click);
            // 
            // toolStripBTNXuatBaoCao
            // 
            this.toolStripBTNXuatBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStripBTNXuatBaoCao.Image = global::UI_UX_Dashboard_P1.Properties.Resources.kiemke;
            this.toolStripBTNXuatBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBTNXuatBaoCao.Name = "toolStripBTNXuatBaoCao";
            this.toolStripBTNXuatBaoCao.Size = new System.Drawing.Size(107, 22);
            this.toolStripBTNXuatBaoCao.Text = "Xuất Báo Cáo";
            this.toolStripBTNXuatBaoCao.ToolTipText = "Xuất Báo Cáo";
            this.toolStripBTNXuatBaoCao.Click += new System.EventHandler(this.toolStripBTNXuatBaoCao_Click);
            // 
            // ucThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachThanhLy);
            this.Controls.Add(this.xuiCustomToolstrip1);
            this.Name = "ucThanhLy";
            this.Size = new System.Drawing.Size(1030, 598);
            this.Load += new System.EventHandler(this.ucThanhLy_Load);
            this.xuiCustomToolstrip1.ResumeLayout(false);
            this.xuiCustomToolstrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachThanhLy)).EndInit();
            this.ContextMenuStrip_ThanhLy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICustomToolstrip xuiCustomToolstrip1;
        private System.Windows.Forms.ToolStripButton toolStripBTNRefesh;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripButton btnXuatFile;
        private System.Windows.Forms.ToolStripComboBox cbbTimKiem;
        private System.Windows.Forms.DataGridView gvDanhSachThanhLy;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_ThanhLy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Xoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LuuKH;
        private System.Windows.Forms.ToolStripButton toolStripBTNXuatBaoCao;
    }
}
