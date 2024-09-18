using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;

namespace BTL_TN_TranBaoChau
{
    public partial class Home : Form
    {
        DataAccess dataAccess = new DataAccess();
        public Home()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
            bunifuFormDock1.SubscribeControlToDragEvents(panel2);
            LoadData();
        }
        
            void LoadData()
        {
            data_BacSi.DataSource = dataAccess.GetDataTable("select * from BacSi");
            data_BenhNhan.DataSource = dataAccess.GetDataTable("select * from BenhNhan");
            data_Thuoc.DataSource = dataAccess.GetDataTable("select * from Thuoc");
            data_DichVu.DataSource = dataAccess.GetDataTable("select * from DichVu");
            data_Benh.DataSource = dataAccess.GetDataTable("select * from Benh");
        }

        private void btn_DanhSach_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            formchinh.SetPage("DanhSach");
        }

        private void btn_BenhNhan_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            formchinh.SetPage("BenhNhan");
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            formchinh.SetPage("ThongKe");
        }

        private void btn_BaoMat_Click(object sender, EventArgs e)
        {
            indicator.Top = ((Control)sender).Top;
            formchinh.SetPage("BaoMat");
        }

        private void btn_BacSi_Click(object sender, EventArgs e)
        {
            indicator2.Left = ((Control)sender).Left;
            FormDanhSach.SetPage("BacSi");

        }

        private void btn_DS_BenhNhan_Click(object sender, EventArgs e)
        {
            indicator2.Left = ((Control)sender).Left;
            FormDanhSach.SetPage("DS_BenhNhan");
        }

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            indicator2.Left = ((Control)sender).Left;
            FormDanhSach.SetPage("Thuoc");
        }

        private void btn_DichVu_Click(object sender, EventArgs e)
        {
            indicator2.Left = ((Control)sender).Left;
            FormDanhSach.SetPage("DichVu");
        }
        private void btn_CacBenh_Click(object sender, EventArgs e)
        {
            indicator2.Left = ((Control)sender).Left;
            FormDanhSach.SetPage("Benh");
        }
        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            indicator4.Left = ((Control)sender).Left;
            FormThongKe.SetPage("HoaDon");
        }
        private void btn_SoLuong_Click(object sender, EventArgs e)
        {
            indicator4.Left = ((Control)sender).Left;
            FormThongKe.SetPage("SoLuong");
        }

        private void Thoat_Home_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet16.SoLuong' table. You can move, or remove it, as needed.
            this.soLuongTableAdapter.Fill(this.dataSet16.SoLuong);
            // TODO: This line of code loads data into the 'dataSet15.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.dataSet15.HoaDon);
            // TODO: This line of code loads data into the 'dataSet1.HoaDon' table. You can move, or remove it, as needed.
            this.hoaDonTableAdapter.Fill(this.dataSet1.HoaDon);
            // TODO: This line of code loads data into the 'dataSet14.ThanhToan2' table. You can move, or remove it, as needed.
            this.thanhToan2TableAdapter.Fill(this.dataSet14.ThanhToan2);
            // TODO: This line of code loads data into the 'dataSet13.ThanhToan2' table. You can move, or remove it, as needed.
            this.thanhToan2TableAdapter.Fill(this.dataSet13.ThanhToan2);
            // TODO: This line of code loads data into the 'dataSet1.ThanhToan' table. You can move, or remove it, as needed.
            this.thanhToanTableAdapter.Fill(this.dataSet1.ThanhToan);
            // TODO: This line of code loads data into the 'dataSet1.LichSuKham' table. You can move, or remove it, as needed.
            this.lichSuKhamTableAdapter.Fill(this.dataSet1.LichSuKham);
            // TODO: This line of code loads data into the 'dataSet12.Benh' table. You can move, or remove it, as needed.
            this.benhTableAdapter.Fill(this.dataSet12.Benh);
            // TODO: This line of code loads data into the 'dataSet1.DichVu' table. You can move, or remove it, as needed.
            this.dichVuTableAdapter.Fill(this.dataSet1.DichVu);
            // TODO: This line of code loads data into the 'dataSet11.Thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.dataSet11.Thuoc);
            // TODO: This line of code loads data into the 'dataSet1.BenhNhan' table. You can move, or remove it, as needed.
            this.benhNhanTableAdapter.Fill(this.dataSet1.BenhNhan);
            // TODO: This line of code loads data into the 'dataSet1.BacSi' table. You can move, or remove it, as needed.
            this.bacSiTableAdapter.Fill(this.dataSet1.BacSi);
            // TODO: This line of code loads data into the 'dataSet1.BacSi' table. You can move, or remove it, as needed.
            this.bacSiTableAdapter.Fill(this.dataSet1.BacSi);

        }
        /// <summary>
        /// Danh sách nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_BacSi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_BacSi.SelectedRows[0];
            string _IDBacSi = _dr.Cells["IDBacSi"].Value.ToString();
            string _HoTen = _dr.Cells["HoTenBS"].Value.ToString();
            string _GioiTinh = _dr.Cells["GioiTinhBS"].Value.ToString();
            string _NgaySinh = _dr.Cells["NgaySinhBS"].Value.ToString();
            string _QueQuan = _dr.Cells["QueQuanBS"].Value.ToString();
            string _SoDienThoai = _dr.Cells["SoDienThoaiBS"].Value.ToString();
            string _Email = _dr.Cells["Email"].Value.ToString();
            string _ChuyenNganh = _dr.Cells["ChuyenNganh"].Value.ToString();

            txt_IDBacSi.Text = _IDBacSi;
            txt_BS_HoTen.Text = _HoTen;
            txt_BS_GioiTinh.Text = _GioiTinh;
            txt_BS_NgaySinh.Text = _NgaySinh;
            txt_BS_QueQuan.Text = _QueQuan;
            txt_BS_SDT.Text = _SoDienThoai;
            txt_BS_Email.Text = _Email;
            txt_BS_ChucVu.Text = _ChuyenNganh;
        }

        private void btn_NV_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_NV_Search.Text;
            string query = "SELECT * FROM BacSi WHERE CONVERT(NVARCHAR(MAX), IDBacSi) LIKE N'%" + searchKeyword + "%' OR CONVERT(NVARCHAR(MAX), HoTen) LIKE N'%" + searchKeyword + "%'";
            data_BacSi.DataSource = dataAccess.GetDataTable(query);
        }

        private void txt_NV_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            txt_BS_NgaySinh.CustomFormat = "dd/MM/yyyy";
        }

        private bool IsExists_NV(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM BacSi WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_NV_Them_Click(object sender, EventArgs e)
        {
            //DangNhap dn = Application.OpenForms["DangNhap"] as DangNhap;
            
            string BacSiId = txt_IDBacSi.Text;
            string email = txt_BS_Email.Text;
            string sdt = txt_BS_SDT.Text;

            if (IsExists_NV(BacSiId, "IDBacSi"))
            {
                MessageBox.Show("ID bác sĩ đã tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsExists_NV(email, "Email"))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng chọn Email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsExists_NV(sdt, "SoDienThoai"))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng chọn số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Định dạng lại ngày sinh
            string ngaySinhFormatted = DateTime.ParseExact(txt_BS_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string s = string.Format("INSERT INTO BacSi VALUES " +
                "('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}', N'{7}')", BacSiId, txt_BS_HoTen.Text, txt_BS_GioiTinh.Text, ngaySinhFormatted, txt_BS_QueQuan.Text, sdt, email, txt_BS_ChucVu.Text);

            dataAccess.UpdateData(s);
            LoadData();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_NV_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = data_BacSi.SelectedRows[0];
                string _IDBacSi = _dr.Cells["IDBacSi"].Value.ToString();
                MessageBox.Show("Đã xóa nhân viên có mã " + _IDBacSi);
                string s = string.Format("DELETE FROM KhamBenh WHERE IDBacSi = '{0}';\r\n" +
                    "DELETE FROM BacSi WHERE IDBacSi = '{0}'" +
                    "DELETE FROM DonThuoc WHERE IDBacSi = '{0}';" +
                    "delete from NguoiDung where IDBenhNhan ='{0}'", _IDBacSi);
                dataAccess.UpdateData(s);
                LoadData();
            }
        }

        private bool IsExistsEmail_NV(string value, string columnName, string currentBacSiId)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM BacSi WHERE {columnName} = @Value AND IDBacSi <> @CurrentBacSiId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.AddWithValue("@CurrentBacSiId", currentBacSiId);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_NV_Sua_Click(object sender, EventArgs e)
        {
            string BacSiId = txt_IDBacSi.Text;
            string email = txt_BS_Email.Text;
            string sdt = txt_BS_SDT.Text;

            if (!IsExists_NV(BacSiId, "IDBacSi"))
            {
                MessageBox.Show("ID bác sĩ chưa tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsExistsEmail_NV(email, "Email", BacSiId))
            {
                MessageBox.Show("Email đã tồn tại. Vui lòng chọn Email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsExistsEmail_NV(sdt, "SoDienThoai", BacSiId))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng chọn số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Định dạng lại ngày sinh
            string ngaySinhFormatted = DateTime.ParseExact(txt_BS_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string updateQuery = string.Format("UPDATE BacSi SET " +
            "HoTen = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', QueQuan = N'{3}', SoDienThoai = '{4}', Email = '{5}', ChuyenNganh = N'{6}' WHERE IDBacSi = '{7}'",
            txt_BS_HoTen.Text, txt_BS_GioiTinh.Text, ngaySinhFormatted, txt_BS_QueQuan.Text, sdt, email, txt_BS_ChucVu.Text, BacSiId);
            dataAccess.UpdateData(updateQuery);
            LoadData();
            MessageBox.Show("Đã sửa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Danh sách bệnh nhân
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_BenhNhan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_BenhNhan.SelectedRows[0];
            string _IDBenhNhan = _dr.Cells["IDBenhNhan"].Value.ToString();
            string _HoTen = _dr.Cells["HoTenBN"].Value.ToString();
            string _GioiTinh = _dr.Cells["GioiTinhBN"].Value.ToString();
            string _NgaySinh = _dr.Cells["NgaySinhBN"].Value.ToString();
            string _QueQuan = _dr.Cells["QueQuanBN"].Value.ToString();
            string _SoDienThoai = _dr.Cells["SoDienThoaiBN"].Value.ToString();
            string _CCCD = _dr.Cells["CCCD"].Value.ToString();

            txt_IDBenhNhan.Text = _IDBenhNhan;
            txt_BN_HoTen.Text = _HoTen;
            txt_BN_GioiTinh.Text = _GioiTinh;
            txt_BN_NgaySinh.Text = _NgaySinh;
            txt_BN_QueQuan.Text = _QueQuan;
            txt_BN_SDT.Text = _SoDienThoai;
            txt_BN_CCCD.Text = _CCCD;
        }

        private void btn_BN_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_BN_Search.Text;
            string query = "SELECT * FROM BenhNhan WHERE CONVERT(NVARCHAR(MAX), IDBenhNhan) LIKE N'%" + searchKeyword + "%' OR CONVERT(NVARCHAR(MAX), HoTen) LIKE N'%" + searchKeyword + "%'";
            data_BenhNhan.DataSource = dataAccess.GetDataTable(query);
        }

        private void txt_BN_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            txt_BN_NgaySinh.CustomFormat = "dd/MM/yyyy";
        }
        private bool IsExists_BN(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM BenhNhan WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_BN_Them_Click(object sender, EventArgs e)
        {
            string IDBenhNhan = txt_IDBenhNhan.Text;
            string cccd = txt_BN_CCCD.Text;
            string sdt = txt_BN_SDT.Text;

            if (IsExists_BN(IDBenhNhan, "IDBenhNhan"))
            {
                MessageBox.Show("ID bệnh nhân đã tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsExists_BN(cccd, "CCCD"))
            {
                MessageBox.Show("Số CCCD đã tồn tại. Vui lòng chọn số CCCD khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsExists_BN(sdt, "SoDienThoai"))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng chọn số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Định dạng lại ngày sinh
            string ngaySinhFormatted = DateTime.ParseExact(txt_BN_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string s = string.Format("INSERT INTO BenhNhan VALUES " +
                "('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}')", IDBenhNhan, txt_BN_HoTen.Text, txt_BN_GioiTinh.Text, ngaySinhFormatted, txt_BN_QueQuan.Text, txt_BN_SDT.Text, cccd);

            dataAccess.UpdateData(s);
            LoadData();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_BN_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = data_BenhNhan.SelectedRows[0];
                string _IDBenhNhan = _dr.Cells["IDBenhNhan"].Value.ToString();
                MessageBox.Show("Đã xóa bệnh nhân có mã " + _IDBenhNhan);

                dataAccess.UpdateData(string.Format("delete from NguoiDung where IDBenhNhan ='{0}';" +
                    "delete from KhamBenh where IDBenhNhan ='{0}';" +
                    "delete from ThongTinSucKhoe where IDBenhNhan ='{0}';" +
                    "delete from DonThuoc where IDBenhNhan ='{0}';" +
                    "delete from BenhNhan where IDBenhNhan ='{0}'", _IDBenhNhan));
                LoadData();
            }
        }

        private bool IsExistsCCCD_BN(string value, string columnName, string currentIDBenhNhan)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM BenhNhan WHERE {columnName} = @Value AND IDBenhNhan <> @CurrentIDBenhNhan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    command.Parameters.AddWithValue("@CurrentIDBenhNhan", currentIDBenhNhan);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_BN_Sua_Click(object sender, EventArgs e)
        {
            string IDBenhNhan = txt_IDBenhNhan.Text;
            string cccd = txt_BN_CCCD.Text;
            string sdt = txt_BN_SDT.Text;

            if (!IsExists_BN(IDBenhNhan, "IDBenhNhan"))
            {
                MessageBox.Show("ID bệnh nhân chưa tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsExistsCCCD_BN(cccd, "CCCD", IDBenhNhan))
            {
                MessageBox.Show("Số CCCD đã tồn tại. Vui lòng chọn số CCCD khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsExistsCCCD_BN(sdt, "SoDienThoai", IDBenhNhan))
            {
                MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng chọn số điện thoại khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Định dạng lại ngày sinh
            string ngaySinhFormatted = DateTime.ParseExact(txt_BN_NgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string updateQuery = string.Format("UPDATE BenhNhan SET " +
            "HoTen = N'{0}', GioiTinh = N'{1}', NgaySinh = '{2}', QueQuan = N'{3}', SoDienThoai = '{4}', CCCD = '{5}' WHERE IDBenhNhan = '{6}'",
            txt_BN_HoTen.Text, txt_BN_GioiTinh.Text, ngaySinhFormatted, txt_BN_QueQuan.Text, txt_BN_SDT.Text, cccd, IDBenhNhan);
            dataAccess.UpdateData(updateQuery);
            LoadData();
            MessageBox.Show("Đã sửa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// danh sách thuốc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_Thuoc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_Thuoc.SelectedRows[0];
            string _IDThuoc = _dr.Cells["IDThuoc"].Value.ToString();
            string _TenThuoc = _dr.Cells["TenThuoc"].Value.ToString();
            string _GiaThuoc = _dr.Cells["GiaThuoc"].Value.ToString();
            string _DonViTinh = _dr.Cells["DonViTinh"].Value.ToString();

            txt_IDThuoc.Text = _IDThuoc;
            txt_TenThuoc.Text = _TenThuoc;
            txt_GiaThuoc.Text = _GiaThuoc;
            txt_DViTinh.Text = _DonViTinh;
        }

        private void btn_Thuoc_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_Thuoc_Search.Text;
            string query = "SELECT * FROM Thuoc WHERE CONVERT(NVARCHAR(MAX), IDThuoc) LIKE N'%" + searchKeyword + "%' OR CONVERT(NVARCHAR(MAX), TenThuoc) LIKE N'%" + searchKeyword + "%'";
            data_Thuoc.DataSource = dataAccess.GetDataTable(query);
        }
        private bool IsExists_Thuoc(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM Thuoc WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_Thuoc_Them_Click(object sender, EventArgs e)
        {
            string IDThuoc = txt_IDThuoc.Text;

            if (IsExists_Thuoc(IDThuoc, "IDThuoc"))
            {
                MessageBox.Show("ID thuốc đã tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string s = string.Format("INSERT INTO Thuoc VALUES " +
                "('{0}', N'{1}', {2}, N'{3}')", IDThuoc, txt_TenThuoc.Text, txt_GiaThuoc.Text, txt_DViTinh.Text);

            dataAccess.UpdateData(s);
            LoadData();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_Thuoc_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = data_Thuoc.SelectedRows[0];
                string _IDThuoc = _dr.Cells["IDThuoc"].Value.ToString();
                MessageBox.Show("Đã xóa thuốc có mã " + _IDThuoc);

                dataAccess.UpdateData(string.Format("delete from ChiTietDonThuoc where IDThuoc ='{0}';" +
                    "delete from Thuoc where IDThuoc ='{0}'", _IDThuoc));
                LoadData();
            }
        }

        private void btn_Thuoc_Sua_Click(object sender, EventArgs e)
        {
            string IDThuoc = txt_IDThuoc.Text;

            if (!IsExists_Thuoc(IDThuoc, "IDThuoc"))
            {
                MessageBox.Show("ID thuốc chưa tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = string.Format("UPDATE Thuoc SET " +
            "TenThuoc = N'{0}', GiaThuoc = {1}, DonViTinh = N'{2}' WHERE IDThuoc = '{3}'",
            txt_TenThuoc.Text, txt_GiaThuoc.Text, txt_DViTinh.Text, IDThuoc);
            dataAccess.UpdateData(updateQuery);
            LoadData();
            MessageBox.Show("Đã sửa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Danh sách dịch vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_DichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_DichVu.SelectedRows[0];
            string _IDDichVu = _dr.Cells["IDDichVu"].Value.ToString();
            string _TenDichVu = _dr.Cells["TenDichVu"].Value.ToString();
            string _GiaTien = _dr.Cells["GiaTien"].Value.ToString();

            txt_IDDichVu.Text = _IDDichVu;
            txt_TenDV.Text = _TenDichVu;
            txt_GiaTien.Text = _GiaTien;
        }

        private void btn_DV_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_DV_Search.Text;
            string query = "SELECT * FROM DichVu WHERE CONVERT(NVARCHAR(MAX), IDDichVu) LIKE N'%" + searchKeyword + "%' OR CONVERT(NVARCHAR(MAX), TenDichVu) LIKE N'%" + searchKeyword + "%'";
            data_DichVu.DataSource = dataAccess.GetDataTable(query);
        }
        private bool IsExists_DichVu(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM DichVu WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }

        private void btn_DV_Them_Click(object sender, EventArgs e)
        {
            string IDDichVu = txt_IDDichVu.Text;

            if (IsExists_DichVu(IDDichVu, "IDDichVu"))
            {
                MessageBox.Show("ID dịch vụ đã tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string s = string.Format("INSERT INTO DichVu VALUES " +
                "('{0}', N'{1}', {2})", IDDichVu, txt_TenDV.Text, txt_GiaTien.Text);

            dataAccess.UpdateData(s);
            LoadData();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_DV_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = data_DichVu.SelectedRows[0];
                string _IDDichVu = _dr.Cells["IDDichVu"].Value.ToString();
                MessageBox.Show("Đã xóa dịch vụ có mã " + _IDDichVu);

                dataAccess.UpdateData(string.Format("delete from KhamBenh where IDDichVu ='{0}';" +
                    "delete from DichVu where IDDichVu ='{0}", _IDDichVu));
                LoadData();
            }
        }

        private void btn_DV_Sua_Click(object sender, EventArgs e)
        {
            string IDDichVu = txt_IDDichVu.Text;

            if (!IsExists_DichVu(IDDichVu, "IDDichVu"))
            {
                MessageBox.Show("ID dịch vụ chưa tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = string.Format("UPDATE DichVu SET " +
            "TenDichVu = N'{0}', GiaTien = {1} WHERE IDDichVu = '{2}'",
            txt_TenDV.Text, txt_GiaTien.Text, IDDichVu);
            dataAccess.UpdateData(updateQuery);
            LoadData();
            MessageBox.Show("Đã sửa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Danh sách bệnh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void data_Benh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_Benh.SelectedRows[0];
            string _IDBenh = _dr.Cells["IDBenh"].Value.ToString();
            string _TenBenh = _dr.Cells["TenBenh"].Value.ToString();

            txt_IDBenh.Text = _IDBenh;
            txt_TenBenh.Text = _TenBenh;
        }
        private void btn_B_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_B_Search.Text;
            string query = "SELECT * FROM Benh WHERE CONVERT(NVARCHAR(MAX), IDBenh) LIKE N'%" + searchKeyword + "%' OR CONVERT(NVARCHAR(MAX), TenBenh) LIKE N'%" + searchKeyword + "%'";
            data_Benh.DataSource = dataAccess.GetDataTable(query);
        }
        private bool IsExists_Benh(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM Benh WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }
        private void btn_B_Them_Click(object sender, EventArgs e)
        {
            string IDBenh = txt_IDBenh.Text;

            if (IsExists_Benh(IDBenh, "IDBenh"))
            {
                MessageBox.Show("ID bệnh đã tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string s = string.Format("INSERT INTO Benh VALUES " +
                "('{0}', N'{1}')", IDBenh, txt_TenBenh.Text);

            dataAccess.UpdateData(s);
            LoadData();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btn_B_Sua_Click(object sender, EventArgs e)
        {
            string IDBenh = txt_IDBenh.Text;

            if (!IsExists_Benh(IDBenh, "IDBenh"))
            {
                MessageBox.Show("ID bệnh chưa tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = string.Format("UPDATE Benh SET " +
            "TenBenh = N'{0}' WHERE IDBenh = '{1}'",
            txt_TenBenh.Text, IDBenh);
            dataAccess.UpdateData(updateQuery);
            LoadData();
            MessageBox.Show("Đã sửa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_LichSuKham_Click(object sender, EventArgs e)
        {
            indicator3.Left = ((Control)sender).Left;
            PageBenhNhan.SetPage("LichSuKham");
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            indicator3.Left = ((Control)sender).Left;
            PageBenhNhan.SetPage("ThanhToan");
        }
        public string _publicBN, _publicBS;
        private void data_LichSuKham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_LichSuKham1.SelectedRows[0];
            string _KetQua = _dr.Cells["KetQua"].Value.ToString();
            _publicBS = _dr.Cells["IDBacSi2"].Value.ToString();
            _publicBN = _dr.Cells["IDBenhNhan2"].Value.ToString();

            txt_KetQua.Text = _KetQua;
        }

        private void btn_search_lsk_Click(object sender, EventArgs e)
        {

            DataGridViewRow dr = data_LichSuKham1.Rows[0];
            string _Tuoi = dr.Cells["Tuoi"].Value.ToString();
            string _CanNang = dr.Cells["CanNang"].Value.ToString();
            string _ChieuCao = dr.Cells["ChieuCao"].Value.ToString();
            string _NhomMau = dr.Cells["NhomMau"].Value.ToString();
            string _TienSuBenh = dr.Cells["TienSuBenh"].Value.ToString();

            txt_Tuoi.Text = _Tuoi;
            txt_CanNang.Text = _CanNang;
            txt_ChieuCao.Text = _ChieuCao;
            txt_NhomMau.Text = _NhomMau;
            txt_TienSuBenh.Text = _TienSuBenh;


            string lsKham = string.Format("select dv.*, kb.*, nv.*,tt.* " +
                " FROM KhamBenh AS kb\r\n" +
                "INNER JOIN DichVu AS dv ON kb.IDDichVu = dv.IDDichVu\r\n" +
                "INNER JOIN BacSi AS nv ON kb.IDBacSi = nv.IDBacSi\r\n" +
                "INNER JOIN ThongTinSucKhoe AS tt ON kb.IDBenhNhan = tt.IDBenhNhan where " +
           "kb.IDBenhNhan like '%{0}%'", txt_search_lsk.Text);
            data_LichSuKham1.DataSource = dataAccess.GetDataTable(lsKham);

            string thanhToan = string.Format("select kb.NgayKham, dv.TenDichVu, dv.GiaTien, kb.TinhTrangThanhToan " +
                " FROM KhamBenh AS kb\r\n" +
                "INNER JOIN DichVu AS dv ON kb.IDDichVu = dv.IDDichVu where " +
           "kb.IDBenhNhan like '%{0}%'", txt_search_lsk.Text);
            data_ThanhToan.DataSource = dataAccess.GetDataTable(thanhToan);

            string thanhToan2 = string.Format("select*FROM DonThuoc where IDBenhNhan like '%{0}%'", txt_search_lsk.Text);
            data_ThanhToan2.DataSource = dataAccess.GetDataTable(thanhToan2);
        }


        private void btn_TaoDonThuoc_Click(object sender, EventArgs e)
        {
            TaoDonThuoc tdt = new TaoDonThuoc();
            tdt.ShowDialog();
        }

        private void data_LichSuKham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == data_LichSuKham1.Columns["NgayKham"].Index && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void data_ThanhToan2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == data_ThanhToan2.Columns["NgayKe"].Index && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }


        private void data_ThanhToan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == data_ThanhToan.Columns["NgayKham_TT"].Index && e.Value != null)
            {
                // Check if the cell value is a valid DateTime
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    // Format the date as "dd/MM/yyyy"
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }
        private void btn_DoiMK_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            string sdt = txt_NhapSDT.Text;
            string mkht = txt_MKHT.Text;
            string mkm = txt_MKM.Text;
            string xnmkm = txt_XNMKM.Text;

            if (sdt.Trim() == "" || mkht.Trim() == "" || mkm.Trim() == "" || xnmkm.Trim() == "")
            {
                MessageBox.Show("Không được để trống các mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string query = "Select * from NguoiDung where SoDienThoai = '" + sdt + "' and MatKhau = '" + mkht + "'";

                if (modify.TaiKhoans(query).Count == 0)
                {
                    // Hiển thị thông báo tên tài khoản hoặc mật khẩu không chính xác
                    MessageBox.Show("Số điện thoại hoặc mật khẩu hiện tại không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (mkm != xnmkm)
                    {
                        MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        this.Hide();
                        DangNhap dn = new DangNhap();
                        dn.ShowDialog();
                    }
                }
            }
        }
        private void txt_Ngaybd_ValueChanged(object sender, EventArgs e)
        {
            txt_Ngaybd.CustomFormat = "dd/MM/yyyy";
        }
        private void txt_NgayKT_ValueChanged(object sender, EventArgs e)
        {
            txt_NgayKT.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_Search_TK_Click(object sender, EventArgs e)
        {
            string ngaybd = DateTime.ParseExact(txt_Ngaybd.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");
            string ngaykt = DateTime.ParseExact(txt_NgayKT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string td = string.Format("SELECT BenhNhan.HoTen, KhamBenh.IDBenhNhan, DichVu.IDDichVu, DichVu.TenDichVu, KhamBenh.NgayKham " +
                "FROM DichVu " +
                "INNER JOIN KhamBenh ON DichVu.IDDichVu = KhamBenh.IDDichVu " +
                "INNER JOIN BenhNhan ON KhamBenh.IDBenhNhan = BenhNhan.IDBenhNhan " +
                "WHERE KhamBenh.NgayKham BETWEEN '" + ngaybd + "' AND '" + ngaykt + "'");

            data_soLuong.DataSource = dataAccess.GetDataTable(td);
        }

        private void data_HoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == data_HoaDon.Columns["NgayKe_HD"].Index && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        private void data_soLuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == data_soLuong.Columns["NgayKham_SL"].Index && e.Value != null)
            {
                if (DateTime.TryParse(e.Value.ToString(), out DateTime dateValue))
                {
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
        }

        
    }
}
