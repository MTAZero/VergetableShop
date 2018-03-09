namespace BookShop.GUI
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
            this.cbxNhaSanXuat = new DevExpress.XtraEditors.LookUpEdit();
            this.txtNamXuatBan = new DevExpress.XtraEditors.TextEdit();
            this.txtGiaBan = new DevExpress.XtraEditors.TextEdit();
            this.txtTenMATHANG = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.imgAnh = new System.Windows.Forms.PictureBox();
            this.txtTitleTacGia = new System.Windows.Forms.Label();
            this.txtTitleTenMATHANG = new System.Windows.Forms.Label();
            this.txtGiaSi = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaShip = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANGMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMATHANG)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaSanXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXuatBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMATHANG.Properties)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaShip.Properties)).BeginInit();
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
            this.groupBox1.Text = "Danh sách mặt hàng";
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
            this.Ten.Caption = "Mặt hàng";
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
            this.panel7.Controls.Add(this.txtGiaShip);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.txtGiaSi);
            this.panel7.Controls.Add(this.cbxNhaSanXuat);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.txtNamXuatBan);
            this.panel7.Controls.Add(this.txtGiaBan);
            this.panel7.Controls.Add(this.txtTenMATHANG);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(824, 370);
            this.panel7.TabIndex = 2;
            // 
            // cbxNhaSanXuat
            // 
            this.cbxNhaSanXuat.Location = new System.Drawing.Point(142, 83);
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
            this.cbxNhaSanXuat.Size = new System.Drawing.Size(344, 26);
            this.cbxNhaSanXuat.TabIndex = 2;
            // 
            // txtNamXuatBan
            // 
            this.txtNamXuatBan.Location = new System.Drawing.Point(142, 193);
            this.txtNamXuatBan.Name = "txtNamXuatBan";
            this.txtNamXuatBan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtNamXuatBan.Properties.Appearance.Options.UseFont = true;
            this.txtNamXuatBan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtNamXuatBan.Size = new System.Drawing.Size(169, 26);
            this.txtNamXuatBan.TabIndex = 6;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(142, 138);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Ngày tháng năm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Giá bán :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhà sản xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên mặt hàng :";
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
            this.imgAnh.Size = new System.Drawing.Size(174, 160);
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
            this.txtTitleTacGia.Location = new System.Drawing.Point(216, 104);
            this.txtTitleTacGia.Name = "txtTitleTacGia";
            this.txtTitleTacGia.Size = new System.Drawing.Size(23, 21);
            this.txtTitleTacGia.TabIndex = 2;
            this.txtTitleTacGia.Text = "N";
            // 
            // txtTitleTenMATHANG
            // 
            this.txtTitleTenMATHANG.AutoSize = true;
            this.txtTitleTenMATHANG.Font = new System.Drawing.Font("Sitka Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitleTenMATHANG.ForeColor = System.Drawing.Color.Black;
            this.txtTitleTenMATHANG.Location = new System.Drawing.Point(213, 54);
            this.txtTitleTenMATHANG.Name = "txtTitleTenMATHANG";
            this.txtTitleTenMATHANG.Size = new System.Drawing.Size(0, 39);
            this.txtTitleTenMATHANG.TabIndex = 1;
            // 
            // txtGiaSi
            // 
            this.txtGiaSi.Location = new System.Drawing.Point(142, 248);
            this.txtGiaSi.Name = "txtGiaSi";
            this.txtGiaSi.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtGiaSi.Properties.Appearance.Options.UseFont = true;
            this.txtGiaSi.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGiaSi.Size = new System.Drawing.Size(208, 26);
            this.txtGiaSi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá sỉ: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtGiaShip
            // 
            this.txtGiaShip.Location = new System.Drawing.Point(142, 303);
            this.txtGiaShip.Name = "txtGiaShip";
            this.txtGiaShip.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtGiaShip.Properties.Appearance.Options.UseFont = true;
            this.txtGiaShip.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txtGiaShip.Size = new System.Drawing.Size(208, 26);
            this.txtGiaShip.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá ship:";
            // 
            // ucDanhSachMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucDanhSachMatHang";
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
            ((System.ComponentModel.ISupportInitialize)(this.cbxNhaSanXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamXuatBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenMATHANG.Properties)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaSi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaShip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label txtTitleTacGia;
        private System.Windows.Forms.Label txtTitleTenMATHANG;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtTenMATHANG;
        private DevExpress.XtraEditors.TextEdit txtGiaBan;
        private DevExpress.XtraEditors.TextEdit txtNamXuatBan;
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
        private DevExpress.XtraEditors.LookUpEdit cbxNhaSanXuat;
        private DevExpress.XtraEditors.TextEdit txtGiaShip;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtGiaSi;
        private System.Windows.Forms.Label label2;
    }
}
