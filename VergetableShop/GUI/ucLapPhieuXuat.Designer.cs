namespace BookShop.GUI
{
    partial class ucLapPhieuXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucLapPhieuXuat));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnTra = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietHoaDonMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietHoaDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.txtChiPhi = new System.Windows.Forms.Label();
            this.cbxNhanVien = new DevExpress.XtraEditors.LookUpEdit();
            this.dateNgayBan = new DevExpress.XtraEditors.DateEdit();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHoanThanhPhieuNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBan.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 548);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnTra);
            this.panel4.Location = new System.Drawing.Point(482, 23);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 55);
            this.panel4.TabIndex = 13;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(213, 44);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm chi tiết hóa đơn";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTra
            // 
            this.btnTra.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.Appearance.Options.UseFont = true;
            this.btnTra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTra.Image = ((System.Drawing.Image)(resources.GetObject("btnTra.Image")));
            this.btnTra.Location = new System.Drawing.Point(222, 6);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(213, 44);
            this.btnTra.TabIndex = 10;
            this.btnTra.Text = "Xóa chi tiết hóa đơn";
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvChiTietHoaDonMain);
            this.groupBox1.Location = new System.Drawing.Point(479, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 444);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // dgvChiTietHoaDonMain
            // 
            this.dgvChiTietHoaDonMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietHoaDonMain.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTietHoaDonMain.MainView = this.dgvChiTietHoaDon;
            this.dgvChiTietHoaDonMain.Name = "dgvChiTietHoaDonMain";
            this.dgvChiTietHoaDonMain.Size = new System.Drawing.Size(793, 421);
            this.dgvChiTietHoaDonMain.TabIndex = 3;
            this.dgvChiTietHoaDonMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietHoaDon});
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvChiTietHoaDon.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvChiTietHoaDon.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvChiTietHoaDon.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvChiTietHoaDon.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvChiTietHoaDon.Appearance.Row.Options.UseFont = true;
            this.dgvChiTietHoaDon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvChiTietHoaDon.ColumnPanelRowHeight = 30;
            this.dgvChiTietHoaDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvChiTietHoaDon.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvChiTietHoaDon.GridControl = this.dgvChiTietHoaDonMain;
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.OptionsBehavior.Editable = false;
            this.dgvChiTietHoaDon.OptionsBehavior.ReadOnly = true;
            this.dgvChiTietHoaDon.OptionsCustomization.AllowColumnMoving = false;
            this.dgvChiTietHoaDon.OptionsCustomization.AllowColumnResizing = false;
            this.dgvChiTietHoaDon.OptionsCustomization.AllowFilter = false;
            this.dgvChiTietHoaDon.OptionsCustomization.AllowGroup = false;
            this.dgvChiTietHoaDon.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietHoaDon.OptionsFind.AllowFindPanel = false;
            this.dgvChiTietHoaDon.OptionsView.ShowGroupPanel = false;
            this.dgvChiTietHoaDon.PaintStyleName = "UltraFlat";
            this.dgvChiTietHoaDon.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 61;
            // 
            // Ten
            // 
            this.Ten.Caption = "Mặt hàng";
            this.Ten.FieldName = "MatHang";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 244;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn giá";
            this.DonGia.FieldName = "DonGia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            this.DonGia.Width = 124;
            // 
            // SoLuong
            // 
            this.SoLuong.Caption = "Số lượng";
            this.SoLuong.FieldName = "SoLuong";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Visible = true;
            this.SoLuong.VisibleIndex = 3;
            this.SoLuong.Width = 124;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Caption = "Thành tiền";
            this.ThanhTien.FieldName = "ThanhTien";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.Visible = true;
            this.ThanhTien.VisibleIndex = 4;
            this.ThanhTien.Width = 146;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelThongTin);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(15, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 379);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            this.groupBox2.UseCompatibleTextRendering = true;
            // 
            // panelThongTin
            // 
            this.panelThongTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelThongTin.Controls.Add(this.txtTenKhachHang);
            this.panelThongTin.Controls.Add(this.label1);
            this.panelThongTin.Controls.Add(this.txtChiPhi);
            this.panelThongTin.Controls.Add(this.cbxNhanVien);
            this.panelThongTin.Controls.Add(this.dateNgayBan);
            this.panelThongTin.Controls.Add(this.txtMaHoaDon);
            this.panelThongTin.Controls.Add(this.label6);
            this.panelThongTin.Controls.Add(this.label5);
            this.panelThongTin.Controls.Add(this.label4);
            this.panelThongTin.Controls.Add(this.label3);
            this.panelThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThongTin.Location = new System.Drawing.Point(3, 20);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(440, 253);
            this.panelThongTin.TabIndex = 2;
            // 
            // txtChiPhi
            // 
            this.txtChiPhi.AutoSize = true;
            this.txtChiPhi.Location = new System.Drawing.Point(134, 201);
            this.txtChiPhi.Name = "txtChiPhi";
            this.txtChiPhi.Size = new System.Drawing.Size(15, 17);
            this.txtChiPhi.TabIndex = 4;
            this.txtChiPhi.Text = "0";
            // 
            // cbxNhanVien
            // 
            this.cbxNhanVien.Location = new System.Drawing.Point(134, 109);
            this.cbxNhanVien.Name = "cbxNhanVien";
            this.cbxNhanVien.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhanVien.Properties.Appearance.Options.UseFont = true;
            this.cbxNhanVien.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhanVien.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNhanVien.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNhanVien.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhanVien.Properties.ShowHeader = false;
            this.cbxNhanVien.Size = new System.Drawing.Size(247, 26);
            this.cbxNhanVien.TabIndex = 3;
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.EditValue = null;
            this.dateNgayBan.Location = new System.Drawing.Point(134, 62);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateNgayBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateNgayBan.Properties.Appearance.Options.UseFont = true;
            this.dateNgayBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgayBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBan.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateNgayBan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayBan.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayBan.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateNgayBan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateNgayBan.Size = new System.Drawing.Size(157, 26);
            this.dateNgayBan.TabIndex = 2;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(134, 17);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(154, 24);
            this.txtMaHoaDon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng chi phí :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày bán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHoanThanhPhieuNhap);
            this.panel3.Controls.Add(this.btnLapHoaDon);
            this.panel3.Controls.Add(this.btnInHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 103);
            this.panel3.TabIndex = 1;
            // 
            // btnHoanThanhPhieuNhap
            // 
            this.btnHoanThanhPhieuNhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanhPhieuNhap.Appearance.Options.UseFont = true;
            this.btnHoanThanhPhieuNhap.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnHoanThanhPhieuNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanThanhPhieuNhap.Image")));
            this.btnHoanThanhPhieuNhap.Location = new System.Drawing.Point(3, 56);
            this.btnHoanThanhPhieuNhap.Name = "btnHoanThanhPhieuNhap";
            this.btnHoanThanhPhieuNhap.Size = new System.Drawing.Size(432, 44);
            this.btnHoanThanhPhieuNhap.TabIndex = 7;
            this.btnHoanThanhPhieuNhap.Text = "Hoàn thành";
            this.btnHoanThanhPhieuNhap.Click += new System.EventHandler(this.btnHoanThanhPhieuNhap_Click);
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon.Appearance.Options.UseFont = true;
            this.btnLapHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLapHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDon.Image")));
            this.btnLapHoaDon.Location = new System.Drawing.Point(3, 6);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(213, 44);
            this.btnLapHoaDon.TabIndex = 5;
            this.btnLapHoaDon.Text = "Lập hóa đơn";
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapPhieuNhap_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(222, 6);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(213, 44);
            this.btnInHoaDon.TabIndex = 6;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(134, 152);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(154, 24);
            this.txtTenKhachHang.TabIndex = 6;
            // 
            // ucLapPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucLapPhieuXuat";
            this.Size = new System.Drawing.Size(1308, 548);
            this.Load += new System.EventHandler(this.ucLapPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelThongTin.ResumeLayout(false);
            this.panelThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayBan.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelThongTin;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl dgvChiTietHoaDonMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnLapHoaDon;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnTra;
        private DevExpress.XtraEditors.SimpleButton btnHoanThanhPhieuNhap;
        private DevExpress.XtraEditors.DateEdit dateNgayBan;
        private DevExpress.XtraEditors.LookUpEdit cbxNhanVien;
        private System.Windows.Forms.Label txtChiPhi;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label1;
    }
}
