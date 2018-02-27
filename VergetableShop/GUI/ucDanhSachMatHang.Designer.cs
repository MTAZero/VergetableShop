﻿namespace BookShop.GUI
{
    partial class ucDanhSachMatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachMatHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMATHANGMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMATHANG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.cbxNhaCungCap = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxNhaSanXuat = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxNXB = new DevExpress.XtraEditors.LookUpEdit();
            this.txtThongTinMATHANG = new DevExpress.XtraEditors.MemoEdit();
            this.txtNamXuatBan = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMATHANG = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.txtTitleTacGia = new System.Windows.Forms.Label();
            this.txtTitleTenMATHANG = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinMATHANG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXuatBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMATHANG.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 548);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 546);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvMATHANGMain);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 446);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đầu sách";
            // 
            // dgvMATHANGMain
            // 
            this.dgvMATHANGMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMATHANGMain.Location = new System.Drawing.Point(3, 20);
            this.dgvMATHANGMain.MainView = this.dgvMATHANG;
            this.dgvMATHANGMain.Name = "dgvMATHANGMain";
            this.dgvMATHANGMain.Size = new System.Drawing.Size(470, 423);
            this.dgvMATHANGMain.TabIndex = 0;
            this.dgvMATHANGMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMATHANG});
            // 
            // dgvMATHANG
            // 
            this.dgvMATHANG.Appearance.HeaderPanel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseFont = true;
            this.dgvMATHANG.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.dgvMATHANG.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.dgvMATHANG.Appearance.Row.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.dgvMATHANG.Appearance.Row.Options.UseFont = true;
            this.dgvMATHANG.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.dgvMATHANG.ColumnPanelRowHeight = 30;
            this.dgvMATHANG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.STT,
            this.Ten,
            this.GiaBan});
            this.dgvMATHANG.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.dgvMATHANG.GridControl = this.dgvMATHANGMain;
            this.dgvMATHANG.Name = "dgvMATHANG";
            this.dgvMATHANG.OptionsBehavior.Editable = false;
            this.dgvMATHANG.OptionsBehavior.ReadOnly = true;
            this.dgvMATHANG.OptionsCustomization.AllowColumnMoving = false;
            this.dgvMATHANG.OptionsCustomization.AllowColumnResizing = false;
            this.dgvMATHANG.OptionsCustomization.AllowFilter = false;
            this.dgvMATHANG.OptionsCustomization.AllowGroup = false;
            this.dgvMATHANG.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvMATHANG.OptionsFind.AllowFindPanel = false;
            this.dgvMATHANG.OptionsView.ShowGroupPanel = false;
            this.dgvMATHANG.PaintStyleName = "UltraFlat";
            this.dgvMATHANG.RowHeight = 30;
            this.dgvMATHANG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvDauMATHANG_FocusedRowChanged);
            // 
            // STT
            // 
            this.STT.Caption = "TT";
            this.STT.FieldName = "STT";
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 0;
            this.STT.Width = 66;
            // 
            // Ten
            // 
            this.Ten.Caption = "Tên sách";
            this.Ten.FieldName = "Ten";
            this.Ten.Name = "Ten";
            this.Ten.Visible = true;
            this.Ten.VisibleIndex = 1;
            this.Ten.Width = 417;
            // 
            // GiaBan
            // 
            this.GiaBan.Caption = "Giá bán";
            this.GiaBan.FieldName = "GiaBan";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Visible = true;
            this.GiaBan.VisibleIndex = 2;
            this.GiaBan.Width = 216;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtTimKiem);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 56);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(109, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(316, 24);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 502);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 42);
            this.panel3.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(257, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 31);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(130, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(119, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(119, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(478, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(828, 546);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.cbxNhaCungCap);
            this.panel7.Controls.Add(this.cbxNhaSanXuat);
            this.panel7.Controls.Add(this.cbxNXB);
            this.panel7.Controls.Add(this.txtThongTinMATHANG);
            this.panel7.Controls.Add(this.txtNamXuatBan);
            this.panel7.Controls.Add(this.txtGiaBan);
            this.panel7.Controls.Add(this.txtTenMATHANG);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(824, 370);
            this.panel7.TabIndex = 2;
            // 
            // cbxNhaCungCap
            // 
            this.cbxNhaCungCap.Location = new System.Drawing.Point(535, 92);
            this.cbxNhaCungCap.Name = "cbxNhaCungCap";
            this.cbxNhaCungCap.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNhaCungCap.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhaCungCap.Properties.Appearance.Options.UseFont = true;
            this.cbxNhaCungCap.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhaCungCap.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNhaCungCap.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNhaCungCap.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhaCungCap.Properties.ShowHeader = false;
            this.cbxNhaCungCap.Size = new System.Drawing.Size(247, 26);
            this.cbxNhaCungCap.TabIndex = 4;
            // 
            // cbxNhaSanXuat
            // 
            this.cbxNhaSanXuat.Location = new System.Drawing.Point(535, 28);
            this.cbxNhaSanXuat.Name = "cbxNhaSanXuat";
            this.cbxNhaSanXuat.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNhaSanXuat.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhaSanXuat.Properties.Appearance.Options.UseFont = true;
            this.cbxNhaSanXuat.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNhaSanXuat.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNhaSanXuat.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhaSanXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNhaSanXuat.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNhaSanXuat.Properties.ShowHeader = false;
            this.cbxNhaSanXuat.Size = new System.Drawing.Size(247, 26);
            this.cbxNhaSanXuat.TabIndex = 2;
            // 
            // cbxNXB
            // 
            this.cbxNXB.Location = new System.Drawing.Point(142, 92);
            this.cbxNXB.Name = "cbxNXB";
            this.cbxNXB.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cbxNXB.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNXB.Properties.Appearance.Options.UseFont = true;
            this.cbxNXB.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.cbxNXB.Properties.AppearanceDropDown.Options.UseFont = true;
            this.cbxNXB.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNXB.Properties.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.cbxNXB.Properties.ShowHeader = false;
            this.cbxNXB.Size = new System.Drawing.Size(247, 26);
            this.cbxNXB.TabIndex = 3;
            // 
            // txtThongTinMATHANG
            // 
            this.txtThongTinMATHANG.Location = new System.Drawing.Point(142, 287);
            this.txtThongTinMATHANG.Name = "txtThongTinMATHANG";
            this.txtThongTinMATHANG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtThongTinMATHANG.Properties.Appearance.Options.UseFont = true;
            this.txtThongTinMATHANG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtThongTinMATHANG.Size = new System.Drawing.Size(640, 68);
            this.txtThongTinMATHANG.TabIndex = 7;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(142, 220);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtNamXuatBan.Properties.Appearance.Options.UseFont = true;
            this.txtNamXuatBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNamXuatBan.Size = new System.Drawing.Size(169, 26);
            this.txtNamXuatBan.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(142, 156);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtGiaBan.Properties.Appearance.Options.UseFont = true;
            this.txtGiaBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGiaBan.Size = new System.Drawing.Size(208, 26);
            this.txtGiaBan.TabIndex = 5;
            // 
            // txtTenMATHANG
            // 
            this.txtTenMATHANG.Location = new System.Drawing.Point(142, 28);
            this.txtTenMATHANG.Name = "txtTenMATHANG";
            this.txtTenMATHANG.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtTenMATHANG.Properties.Appearance.Options.UseFont = true;
            this.txtTenMATHANG.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtTenMATHANG.Size = new System.Drawing.Size(275, 26);
            this.txtTenMATHANG.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Thông tin sách :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Năm xuất bản :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nhà xuất bản :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thể loại :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá bán :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tác giả :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sách  :";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightGray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.imgAnh);
            this.panel6.Controls.Add(this.txtTitleTacGia);
            this.panel6.Controls.Add(this.txtTitleTenMATHANG);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(824, 172);
            this.panel6.TabIndex = 1;
            // 
            // imgAnh
            // 
            this.imgAnh.BackColor = System.Drawing.Color.White;
            this.imgAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgAnh.Location = new System.Drawing.Point(19, 3);
            this.imgAnh.Name = "imgAnh";
            this.imgAnh.Size = new System.Drawing.Size(120, 160);
            this.imgAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAnh.TabIndex = 3;
            this.imgAnh.TabStop = false;
            this.imgAnh.WaitOnLoad = true;
            this.imgAnh.Click += new System.EventHandler(this.imgAnh_Click);
            // 
            // txtTitleTacGia
            // 
            this.txtTitleTacGia.AutoSize = true;
            this.txtTitleTacGia.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleTacGia.ForeColor = System.Drawing.Color.Black;
            this.txtTitleTacGia.Location = new System.Drawing.Point(168, 102);
            this.txtTitleTacGia.Name = "txtTitleTacGia";
            this.txtTitleTacGia.Size = new System.Drawing.Size(143, 21);
            this.txtTitleTacGia.TabIndex = 2;
            this.txtTitleTacGia.Text = "Nguyễn Nhật Ánh";
            // 
            // txtTitleTenMATHANG
            // 
            this.txtTitleTenMATHANG.AutoSize = true;
            this.txtTitleTenMATHANG.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleTenMATHANG.ForeColor = System.Drawing.Color.Black;
            this.txtTitleTenMATHANG.Location = new System.Drawing.Point(164, 54);
            this.txtTitleTenMATHANG.Name = "txtTitleTenMATHANG";
            this.txtTitleTenMATHANG.Size = new System.Drawing.Size(426, 39);
            this.txtTitleTenMATHANG.TabIndex = 1;
            this.txtTitleTenMATHANG.Text = "Tôi thấy hoa vàng trên cỏ xanh";
            // 
            // ucDanhMATHANGDauMATHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhMATHANGDauMATHANG";
            this.Size = new System.Drawing.Size(1308, 548);
            this.Load += new System.EventHandler(this.ucDanhMATHANGDauMATHANG_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThongTinMATHANG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXuatBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMATHANG.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtTitleTacGia;
        private System.Windows.Forms.Label txtTitleTenMATHANG;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTenMATHANG;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtNamXuatBan;
        private DevExpress.XtraEditors.MemoEdit txtThongTinMATHANG;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl dgvMATHANGMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMATHANG;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.PictureBox imgAnh;
        private DevExpress.XtraGrid.Columns.GridColumn GiaBan;
        private DevExpress.XtraEditors.LookUpEdit cbxNXB;
        private DevExpress.XtraEditors.LookUpEdit cbxNhaCungCap;
        private DevExpress.XtraEditors.LookUpEdit cbxNhaSanXuat;
    }
}