namespace BookShop.GUI
{
    partial class ucNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNhapHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongGiaTri = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateKetThuc = new DevExpress.XtraEditors.DateEdit();
            this.dateBatDau = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvChiTietNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTongChiPhi = new System.Windows.Forms.Label();
            this.txtNhanVien = new System.Windows.Forms.Label();
            this.dateNgayBan = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuNhapMain = new DevExpress.XtraGrid.GridControl();
            this.dgvPhieuNhap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTongGiaTri);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 548);
            this.panel1.TabIndex = 0;
            // 
            // txtTongGiaTri
            // 
            this.txtTongGiaTri.AutoSize = true;
            this.txtTongGiaTri.Location = new System.Drawing.Point(16, 137);
            this.txtTongGiaTri.Name = "txtTongGiaTri";
            this.txtTongGiaTri.Size = new System.Drawing.Size(141, 17);
            this.txtTongGiaTri.TabIndex = 3;
            this.txtTongGiaTri.Text = "Tổng giá trị : 1,500,000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateKetThuc);
            this.groupBox3.Controls.Add(this.dateBatDau);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(16, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 120);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bộ lọc phiếu nhập";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(97, 27);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(428, 24);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tím kiếm :";
            // 
            // dateKetThuc
            // 
            this.dateKetThuc.EditValue = null;
            this.dateKetThuc.Location = new System.Drawing.Point(368, 70);
            this.dateKetThuc.Name = "dateKetThuc";
            this.dateKetThuc.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateKetThuc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateKetThuc.Properties.Appearance.Options.UseFont = true;
            this.dateKetThuc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateKetThuc.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateKetThuc.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateKetThuc.Size = new System.Drawing.Size(157, 26);
            this.dateKetThuc.TabIndex = 5;
            this.dateKetThuc.EditValueChanged += new System.EventHandler(this.dateKetThuc_EditValueChanged);
            // 
            // dateBatDau
            // 
            this.dateBatDau.EditValue = null;
            this.dateBatDau.Location = new System.Drawing.Point(97, 70);
            this.dateBatDau.Name = "dateBatDau";
            this.dateBatDau.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateBatDau.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.dateBatDau.Properties.Appearance.Options.UseFont = true;
            this.dateBatDau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dateBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateBatDau.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateBatDau.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateBatDau.Size = new System.Drawing.Size(157, 26);
            this.dateBatDau.TabIndex = 4;
            this.dateBatDau.EditValueChanged += new System.EventHandler(this.dateKetThuc_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(603, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 513);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietNhapMain);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(682, 251);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dgvChiTietNhapMain
            // 
            this.dgvChiTietNhapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietNhapMain.Location = new System.Drawing.Point(3, 20);
            this.dgvChiTietNhapMain.MainView = this.dgvChiTietNhap;
            this.dgvChiTietNhapMain.Name = "dgvChiTietNhapMain";
            this.dgvChiTietNhapMain.Size = new System.Drawing.Size(676, 228);
            this.dgvChiTietNhapMain.TabIndex = 2;
            this.dgvChiTietNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvChiTietNhap});
            // 
            // dgvChiTietNhap
            // 
            this.dgvChiTietNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvChiTietNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvChiTietNhap.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvChiTietNhap.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvChiTietNhap.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvChiTietNhap.Appearance.Row.Options.UseFont = true;
            this.dgvChiTietNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvChiTietNhap.ColumnPanelRowHeight = 30;
            this.dgvChiTietNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.DonGia,
            this.SoLuong,
            this.ThanhTien});
            this.dgvChiTietNhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvChiTietNhap.GridControl = this.dgvChiTietNhapMain;
            this.dgvChiTietNhap.Name = "dgvChiTietNhap";
            this.dgvChiTietNhap.OptionsBehavior.Editable = false;
            this.dgvChiTietNhap.OptionsBehavior.ReadOnly = true;
            this.dgvChiTietNhap.OptionsCustomization.AllowColumnMoving = false;
            this.dgvChiTietNhap.OptionsCustomization.AllowColumnResizing = false;
            this.dgvChiTietNhap.OptionsCustomization.AllowFilter = false;
            this.dgvChiTietNhap.OptionsCustomization.AllowGroup = false;
            this.dgvChiTietNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvChiTietNhap.OptionsFind.AllowFindPanel = false;
            this.dgvChiTietNhap.OptionsView.ShowGroupPanel = false;
            this.dgvChiTietNhap.PaintStyleName = "UltraFlat";
            this.dgvChiTietNhap.RowHeight = 30;
            // 
            // STT
            // 
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 50;
            // 
            // Ten
            // 
            this.Ten.Caption = "Mặt hàng";
            this.Ten.FieldName = "MatHang";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 247;
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
            this.ThanhTien.Width = 154;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnInHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 206);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(682, 53);
            this.panel3.TabIndex = 1;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.Appearance.Options.UseFont = true;
            this.btnInHoaDon.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnInHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnInHoaDon.Image")));
            this.btnInHoaDon.Location = new System.Drawing.Point(3, 3);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(164, 44);
            this.btnInHoaDon.TabIndex = 10;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtTongChiPhi);
            this.panel2.Controls.Add(this.txtNhanVien);
            this.panel2.Controls.Add(this.dateNgayBan);
            this.panel2.Controls.Add(this.txtMaPhieuNhap);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 186);
            this.panel2.TabIndex = 0;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.AutoSize = true;
            this.txtTongChiPhi.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChiPhi.Location = new System.Drawing.Point(167, 133);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.Size = new System.Drawing.Size(12, 17);
            this.txtTongChiPhi.TabIndex = 7;
            this.txtTongChiPhi.Text = " ";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.AutoSize = true;
            this.txtNhanVien.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Location = new System.Drawing.Point(167, 82);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(12, 17);
            this.txtNhanVien.TabIndex = 6;
            this.txtNhanVien.Text = " ";
            // 
            // dateNgayBan
            // 
            this.dateNgayBan.AutoSize = true;
            this.dateNgayBan.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayBan.Location = new System.Drawing.Point(499, 31);
            this.dateNgayBan.Name = "dateNgayBan";
            this.dateNgayBan.Size = new System.Drawing.Size(12, 17);
            this.dateNgayBan.TabIndex = 5;
            this.dateNgayBan.Text = " ";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.AutoSize = true;
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(167, 31);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(12, 17);
            this.txtMaPhieuNhap.TabIndex = 4;
            this.txtMaPhieuNhap.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng chi phí :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày nhập :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhân viên nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã phiếu nhập :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dgvPhieuNhapMain);
            this.groupBox1.Location = new System.Drawing.Point(16, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hóa đơn :";
            // 
            // dgvPhieuNhapMain
            // 
            this.dgvPhieuNhapMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhapMain.Location = new System.Drawing.Point(3, 20);
            this.dgvPhieuNhapMain.MainView = this.dgvPhieuNhap;
            this.dgvPhieuNhapMain.Name = "dgvPhieuNhapMain";
            this.dgvPhieuNhapMain.Size = new System.Drawing.Size(562, 336);
            this.dgvPhieuNhapMain.TabIndex = 2;
            this.dgvPhieuNhapMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvPhieuNhap});
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvPhieuNhap.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvPhieuNhap.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvPhieuNhap.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvPhieuNhap.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvPhieuNhap.Appearance.Row.Options.UseFont = true;
            this.dgvPhieuNhap.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvPhieuNhap.ColumnPanelRowHeight = 30;
            this.dgvPhieuNhap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaHoaDon,
            this.Ngay,
            this.NhanVien,
            this.ID,
            this.TongTien});
            this.dgvPhieuNhap.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvPhieuNhap.GridControl = this.dgvPhieuNhapMain;
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.OptionsBehavior.Editable = false;
            this.dgvPhieuNhap.OptionsBehavior.ReadOnly = true;
            this.dgvPhieuNhap.OptionsCustomization.AllowColumnMoving = false;
            this.dgvPhieuNhap.OptionsCustomization.AllowColumnResizing = false;
            this.dgvPhieuNhap.OptionsCustomization.AllowFilter = false;
            this.dgvPhieuNhap.OptionsCustomization.AllowGroup = false;
            this.dgvPhieuNhap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvPhieuNhap.OptionsFind.AllowFindPanel = false;
            this.dgvPhieuNhap.OptionsView.ShowGroupPanel = false;
            this.dgvPhieuNhap.PaintStyleName = "UltraFlat";
            this.dgvPhieuNhap.RowHeight = 30;
            this.dgvPhieuNhap.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvHoaDon_FocusedRowChanged);
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.Caption = "Mã hóa đơn";
            this.MaHoaDon.FieldName = "MaHoaDon";
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.Visible = true;
            this.MaHoaDon.VisibleIndex = 0;
            this.MaHoaDon.Width = 140;
            // 
            // Ngay
            // 
            this.Ngay.Caption = "Ngày";
            this.Ngay.FieldName = "Ngay";
            this.Ngay.Name = "Ngay";
            this.Ngay.Visible = true;
            this.Ngay.VisibleIndex = 1;
            this.Ngay.Width = 124;
            // 
            // NhanVien
            // 
            this.NhanVien.Caption = "Nhân viên bán hàng";
            this.NhanVien.FieldName = "NhanVien";
            this.NhanVien.Name = "NhanVien";
            this.NhanVien.Visible = true;
            this.NhanVien.VisibleIndex = 2;
            this.NhanVien.Width = 289;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.Name = "ID";
            // 
            // TongTien
            // 
            this.TongTien.AppearanceCell.Options.UseTextOptions = true;
            this.TongTien.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.TongTien.AppearanceHeader.Options.UseTextOptions = true;
            this.TongTien.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TongTien.Caption = "Tổng chi phí";
            this.TongTien.FieldName = "TongChiPhi";
            this.TongTien.Name = "TongTien";
            this.TongTien.Visible = true;
            this.TongTien.VisibleIndex = 3;
            this.TongTien.Width = 146;
            // 
            // ucNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucNhapHang";
            this.Size = new System.Drawing.Size(1308, 548);
            this.Load += new System.EventHandler(this.ucBanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateKetThuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateBatDau.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietNhap)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraGrid.GridControl dgvChiTietNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvChiTietNhap;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.GridControl dgvPhieuNhapMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn MaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn ThanhTien;
        private DevExpress.XtraGrid.Columns.GridColumn Ngay;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateKetThuc;
        private DevExpress.XtraEditors.DateEdit dateBatDau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnInHoaDon;
        private System.Windows.Forms.Label txtTongChiPhi;
        private System.Windows.Forms.Label txtNhanVien;
        private System.Windows.Forms.Label dateNgayBan;
        private System.Windows.Forms.Label txtMaPhieuNhap;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TongTien;
        private System.Windows.Forms.Label txtTongGiaTri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
