namespace BTL_TN_TranBaoChau
{
    partial class TaoDonThuoc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoDonThuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TaoDon_NgayTao = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_TaoDon_idThuoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_TaoDon_SoLuong = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_TaoDon_idDonThuoc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.data_TaoDon = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taoDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new BTL_TN_TranBaoChau.DataSet1();
            this.Thoat = new System.Windows.Forms.Label();
            this.btn_TD_Xoa = new System.Windows.Forms.PictureBox();
            this.btn_TD_Them = new System.Windows.Forms.PictureBox();
            this.txt_TongHoaDon = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TD_Search = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.taoDonTableAdapter = new BTL_TN_TranBaoChau.DataSet1TableAdapters.TaoDonTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_TaoDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Xoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Them)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_TaoDon_NgayTao);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txt_TaoDon_idThuoc);
            this.groupBox3.Controls.Add(this.txt_TaoDon_SoLuong);
            this.groupBox3.Controls.Add(this.txt_TaoDon_idDonThuoc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(43, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(707, 158);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đơn thuốc";
            // 
            // txt_TaoDon_NgayTao
            // 
            this.txt_TaoDon_NgayTao.BackColor = System.Drawing.Color.Transparent;
            this.txt_TaoDon_NgayTao.BorderRadius = 1;
            this.txt_TaoDon_NgayTao.Color = System.Drawing.Color.Silver;
            this.txt_TaoDon_NgayTao.CustomFormat = " ";
            this.txt_TaoDon_NgayTao.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.txt_TaoDon_NgayTao.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.txt_TaoDon_NgayTao.DisabledColor = System.Drawing.Color.Gray;
            this.txt_TaoDon_NgayTao.DisplayWeekNumbers = false;
            this.txt_TaoDon_NgayTao.DPHeight = 0;
            this.txt_TaoDon_NgayTao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.txt_TaoDon_NgayTao.FillDatePicker = false;
            this.txt_TaoDon_NgayTao.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaoDon_NgayTao.ForeColor = System.Drawing.Color.Black;
            this.txt_TaoDon_NgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_TaoDon_NgayTao.Icon = ((System.Drawing.Image)(resources.GetObject("txt_TaoDon_NgayTao.Icon")));
            this.txt_TaoDon_NgayTao.IconColor = System.Drawing.Color.Black;
            this.txt_TaoDon_NgayTao.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.txt_TaoDon_NgayTao.LeftTextMargin = 5;
            this.txt_TaoDon_NgayTao.Location = new System.Drawing.Point(484, 40);
            this.txt_TaoDon_NgayTao.MinimumSize = new System.Drawing.Size(4, 32);
            this.txt_TaoDon_NgayTao.Name = "txt_TaoDon_NgayTao";
            this.txt_TaoDon_NgayTao.Size = new System.Drawing.Size(205, 32);
            this.txt_TaoDon_NgayTao.TabIndex = 24;
            this.txt_TaoDon_NgayTao.Value = new System.DateTime(2023, 12, 27, 0, 0, 0, 0);
            this.txt_TaoDon_NgayTao.ValueChanged += new System.EventHandler(this.txt_NgayTao_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(391, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "Ngày tạo:";
            // 
            // txt_TaoDon_idThuoc
            // 
            this.txt_TaoDon_idThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TaoDon_idThuoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaoDon_idThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaoDon_idThuoc.HintForeColor = System.Drawing.Color.Empty;
            this.txt_TaoDon_idThuoc.HintText = "";
            this.txt_TaoDon_idThuoc.isPassword = false;
            this.txt_TaoDon_idThuoc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_idThuoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_TaoDon_idThuoc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_idThuoc.LineThickness = 3;
            this.txt_TaoDon_idThuoc.Location = new System.Drawing.Point(131, 103);
            this.txt_TaoDon_idThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaoDon_idThuoc.Name = "txt_TaoDon_idThuoc";
            this.txt_TaoDon_idThuoc.Size = new System.Drawing.Size(190, 34);
            this.txt_TaoDon_idThuoc.TabIndex = 18;
            this.txt_TaoDon_idThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_TaoDon_SoLuong
            // 
            this.txt_TaoDon_SoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TaoDon_SoLuong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaoDon_SoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaoDon_SoLuong.HintForeColor = System.Drawing.Color.Empty;
            this.txt_TaoDon_SoLuong.HintText = "";
            this.txt_TaoDon_SoLuong.isPassword = false;
            this.txt_TaoDon_SoLuong.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_SoLuong.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_TaoDon_SoLuong.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_SoLuong.LineThickness = 3;
            this.txt_TaoDon_SoLuong.Location = new System.Drawing.Point(484, 107);
            this.txt_TaoDon_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaoDon_SoLuong.Name = "txt_TaoDon_SoLuong";
            this.txt_TaoDon_SoLuong.Size = new System.Drawing.Size(205, 30);
            this.txt_TaoDon_SoLuong.TabIndex = 17;
            this.txt_TaoDon_SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_TaoDon_idDonThuoc
            // 
            this.txt_TaoDon_idDonThuoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TaoDon_idDonThuoc.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaoDon_idDonThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TaoDon_idDonThuoc.HintForeColor = System.Drawing.Color.Empty;
            this.txt_TaoDon_idDonThuoc.HintText = "";
            this.txt_TaoDon_idDonThuoc.isPassword = false;
            this.txt_TaoDon_idDonThuoc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_idDonThuoc.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_TaoDon_idDonThuoc.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TaoDon_idDonThuoc.LineThickness = 3;
            this.txt_TaoDon_idDonThuoc.Location = new System.Drawing.Point(159, 43);
            this.txt_TaoDon_idDonThuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaoDon_idDonThuoc.Name = "txt_TaoDon_idDonThuoc";
            this.txt_TaoDon_idDonThuoc.Size = new System.Drawing.Size(162, 30);
            this.txt_TaoDon_idDonThuoc.TabIndex = 16;
            this.txt_TaoDon_idDonThuoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "ID Thuốc:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(391, 115);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 22);
            this.label21.TabIndex = 1;
            this.label21.Text = "Số lượng:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(34, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(122, 22);
            this.label24.TabIndex = 0;
            this.label24.Text = "ID Đơn thuốc:";
            // 
            // data_TaoDon
            // 
            this.data_TaoDon.AllowCustomTheming = false;
            this.data_TaoDon.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.data_TaoDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_TaoDon.AutoGenerateColumns = false;
            this.data_TaoDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_TaoDon.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.data_TaoDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_TaoDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_TaoDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_TaoDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_TaoDon.ColumnHeadersHeight = 40;
            this.data_TaoDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThuoc,
            this.GiaThuoc,
            this.SoLuong,
            this.DonViTinh,
            this.TongTien,
            this.NgayKe,
            this.TongHoaDon});
            this.data_TaoDon.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.data_TaoDon.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.data_TaoDon.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.data_TaoDon.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.data_TaoDon.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data_TaoDon.CurrentTheme.BackColor = System.Drawing.Color.Maroon;
            this.data_TaoDon.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.data_TaoDon.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Maroon;
            this.data_TaoDon.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.data_TaoDon.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_TaoDon.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.data_TaoDon.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data_TaoDon.CurrentTheme.Name = null;
            this.data_TaoDon.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.data_TaoDon.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.data_TaoDon.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.data_TaoDon.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.data_TaoDon.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.data_TaoDon.DataSource = this.taoDonBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_TaoDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_TaoDon.EnableHeadersVisualStyles = false;
            this.data_TaoDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.data_TaoDon.HeaderBackColor = System.Drawing.Color.Maroon;
            this.data_TaoDon.HeaderBgColor = System.Drawing.Color.Empty;
            this.data_TaoDon.HeaderForeColor = System.Drawing.Color.White;
            this.data_TaoDon.Location = new System.Drawing.Point(43, 242);
            this.data_TaoDon.Name = "data_TaoDon";
            this.data_TaoDon.RowHeadersVisible = false;
            this.data_TaoDon.RowHeadersWidth = 51;
            this.data_TaoDon.RowTemplate.Height = 40;
            this.data_TaoDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_TaoDon.Size = new System.Drawing.Size(707, 239);
            this.data_TaoDon.TabIndex = 15;
            this.data_TaoDon.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Maroon;
            this.data_TaoDon.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.data_TaoDon_CellMouseClick);
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            // 
            // GiaThuoc
            // 
            this.GiaThuoc.DataPropertyName = "GiaThuoc";
            this.GiaThuoc.HeaderText = "Giá Thuốc";
            this.GiaThuoc.MinimumWidth = 6;
            this.GiaThuoc.Name = "GiaThuoc";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn Vị Tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            // 
            // NgayKe
            // 
            this.NgayKe.DataPropertyName = "NgayKe";
            this.NgayKe.HeaderText = "NgayKe";
            this.NgayKe.MinimumWidth = 6;
            this.NgayKe.Name = "NgayKe";
            this.NgayKe.Visible = false;
            // 
            // TongHoaDon
            // 
            this.TongHoaDon.DataPropertyName = "TongHoaDon";
            this.TongHoaDon.HeaderText = "TongHoaDon";
            this.TongHoaDon.MinimumWidth = 6;
            this.TongHoaDon.Name = "TongHoaDon";
            this.TongHoaDon.Visible = false;
            // 
            // taoDonBindingSource
            // 
            this.taoDonBindingSource.DataMember = "TaoDon";
            this.taoDonBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Thoat
            // 
            this.Thoat.AutoSize = true;
            this.Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thoat.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.Location = new System.Drawing.Point(766, -1);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(37, 41);
            this.Thoat.TabIndex = 17;
            this.Thoat.Text = "X";
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // btn_TD_Xoa
            // 
            this.btn_TD_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_TD_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TD_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_TD_Xoa.Image")));
            this.btn_TD_Xoa.Location = new System.Drawing.Point(635, 187);
            this.btn_TD_Xoa.Name = "btn_TD_Xoa";
            this.btn_TD_Xoa.Size = new System.Drawing.Size(49, 32);
            this.btn_TD_Xoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TD_Xoa.TabIndex = 20;
            this.btn_TD_Xoa.TabStop = false;
            this.btn_TD_Xoa.Click += new System.EventHandler(this.btn_TD_Xoa_Click);
            // 
            // btn_TD_Them
            // 
            this.btn_TD_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(173)))), ((int)(((byte)(196)))));
            this.btn_TD_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TD_Them.Image = ((System.Drawing.Image)(resources.GetObject("btn_TD_Them.Image")));
            this.btn_TD_Them.Location = new System.Drawing.Point(569, 187);
            this.btn_TD_Them.Name = "btn_TD_Them";
            this.btn_TD_Them.Size = new System.Drawing.Size(49, 32);
            this.btn_TD_Them.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TD_Them.TabIndex = 18;
            this.btn_TD_Them.TabStop = false;
            this.btn_TD_Them.Click += new System.EventHandler(this.btn_TD_Them_Click);
            // 
            // txt_TongHoaDon
            // 
            this.txt_TongHoaDon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_TongHoaDon.HintForeColor = System.Drawing.Color.Empty;
            this.txt_TongHoaDon.HintText = "";
            this.txt_TongHoaDon.isPassword = false;
            this.txt_TongHoaDon.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TongHoaDon.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_TongHoaDon.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(29)))), ((int)(((byte)(87)))));
            this.txt_TongHoaDon.LineThickness = 3;
            this.txt_TongHoaDon.Location = new System.Drawing.Point(174, 500);
            this.txt_TongHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TongHoaDon.Name = "txt_TongHoaDon";
            this.txt_TongHoaDon.Size = new System.Drawing.Size(162, 30);
            this.txt_TongHoaDon.TabIndex = 27;
            this.txt_TongHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 508);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tổng tiền:";
            // 
            // bunifuFormDock1
            // 
            this.bunifuFormDock1.AllowFormDragging = true;
            this.bunifuFormDock1.AllowFormDropShadow = true;
            this.bunifuFormDock1.AllowFormResizing = true;
            this.bunifuFormDock1.AllowHidingBottomRegion = true;
            this.bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderColor = System.Drawing.Color.Silver;
            this.bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            this.bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            this.bunifuFormDock1.ContainerControl = this;
            this.bunifuFormDock1.DockingIndicatorsColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            this.bunifuFormDock1.DockingOptions.DockAll = true;
            this.bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            this.bunifuFormDock1.DockingOptions.DockBottomRight = true;
            this.bunifuFormDock1.DockingOptions.DockFullScreen = true;
            this.bunifuFormDock1.DockingOptions.DockLeft = true;
            this.bunifuFormDock1.DockingOptions.DockRight = true;
            this.bunifuFormDock1.DockingOptions.DockTopLeft = true;
            this.bunifuFormDock1.DockingOptions.DockTopRight = true;
            this.bunifuFormDock1.FormDraggingOpacity = 0.9D;
            this.bunifuFormDock1.ParentForm = this;
            this.bunifuFormDock1.ShowCursorChanges = true;
            this.bunifuFormDock1.ShowDockingIndicators = true;
            this.bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            this.bunifuFormDock1.TitleBarOptions.BunifuFormDock = this.bunifuFormDock1;
            this.bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            this.bunifuFormDock1.TitleBarOptions.TitleBarControl = null;
            this.bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TD_Search);
            this.panel1.Controls.Add(this.btn_TD_Xoa);
            this.panel1.Controls.Add(this.btn_TD_Them);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 559);
            this.panel1.TabIndex = 28;
            // 
            // btn_TD_Search
            // 
            this.btn_TD_Search.BackColor = System.Drawing.Color.Black;
            this.btn_TD_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TD_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_TD_Search.Image")));
            this.btn_TD_Search.Location = new System.Drawing.Point(702, 187);
            this.btn_TD_Search.Name = "btn_TD_Search";
            this.btn_TD_Search.Size = new System.Drawing.Size(49, 32);
            this.btn_TD_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TD_Search.TabIndex = 29;
            this.btn_TD_Search.TabStop = false;
            this.btn_TD_Search.Click += new System.EventHandler(this.btn_TD_Search_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // taoDonTableAdapter
            // 
            this.taoDonTableAdapter.ClearBeforeFill = true;
            // 
            // TaoDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.txt_TongHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.data_TaoDon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaoDonThuoc";
            this.Text = "TaoDonThuoc";
            this.Load += new System.EventHandler(this.TaoDonThuoc_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_TaoDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Xoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Them)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_TD_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TaoDon_idThuoc;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TaoDon_SoLuong;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TaoDon_idDonThuoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private Bunifu.UI.WinForms.BunifuDataGridView data_TaoDon;
        private System.Windows.Forms.Label Thoat;
        private Bunifu.UI.WinForms.BunifuDatePicker txt_TaoDon_NgayTao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox btn_TD_Xoa;
        private System.Windows.Forms.PictureBox btn_TD_Them;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_TongHoaDon;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox btn_TD_Search;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource taoDonBindingSource;
        private DataSet1TableAdapters.TaoDonTableAdapter taoDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongHoaDon;
    }
}