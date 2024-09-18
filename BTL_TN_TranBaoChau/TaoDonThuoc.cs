using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BTL_TN_TranBaoChau
{
    

    public partial class TaoDonThuoc : Form
    {
        DataAccess dataAccess = new DataAccess();

        public TaoDonThuoc()
        {
            InitializeComponent();
            bunifuFormDock1.SubscribeControlToDragEvents(panel1);
         
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_NgayTao_ValueChanged(object sender, EventArgs e)
        {
            txt_TaoDon_NgayTao.CustomFormat = "dd/MM/yyyy";
        }

        private void TaoDonThuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TaoDon' table. You can move, or remove it, as needed.
            this.taoDonTableAdapter.Fill(this.dataSet1.TaoDon);

        }
        private bool IsExists_DT(string value, string columnName)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM DonThuoc WHERE {columnName} = @Value";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Value", value);
                    return (int)command.ExecuteScalar() > 0;
                }
            }
        }
        private bool IsExists_T(string value, string columnName)
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
        private void data_TaoDon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow _dr = data_TaoDon.SelectedRows[0];
            
            string ngayTao = _dr.Cells["NgayKe"].Value.ToString();
            string soLuong = _dr.Cells["SoLuong"].Value.ToString();

            txt_TaoDon_NgayTao.Text = ngayTao;
            txt_TaoDon_SoLuong.Text = soLuong;
           
        }   
        
        private void btn_TD_Them_Click(object sender, EventArgs e)
        {
            Home home = Application.OpenForms["Home"] as Home;
            string BacSiId = home._publicBS;
            string BenhNhanId = home._publicBN;
            string idDonThuoc = txt_TaoDon_idDonThuoc.Text;
            string idThuoc = txt_TaoDon_idThuoc.Text;

            
            if (!IsExists_T(idThuoc, "IDThuoc"))
            {
                MessageBox.Show("ID thuốc không tồn tại. Vui lòng chọn ID khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Định dạng lại ngày sinh
            string ngayFormatted = DateTime.ParseExact(txt_TaoDon_NgayTao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy");

            string s = string.Format("INSERT INTO DonThuoc VALUES " +
                "('{0}', '{1}',0, N'Chưa thanh toán', '{2}','{3}')", idDonThuoc,ngayFormatted, BenhNhanId, BacSiId );
            string t = string.Format("INSERT INTO ChiTietDonThuoc VALUES " +
                "('{0}', '{1}', '{2}',0)", idDonThuoc, idThuoc, txt_TaoDon_SoLuong.Text);
            dataAccess.UpdateData(s);
            dataAccess.UpdateData(t);

            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void btn_TD_Search_Click(object sender, EventArgs e)
        {
            string searchKeyword = txt_TaoDon_idDonThuoc.Text;

            string td = string.Format("SELECT DonThuoc.NgayKe, DonThuoc.TongHoaDon, ChiTietDonThuoc.SoLuong, ChiTietDonThuoc.TongTien, Thuoc.TenThuoc, Thuoc.GiaThuoc, Thuoc.DonViTinh "+
            "FROM DonThuoc INNER JOIN "+
                  "ChiTietDonThuoc ON DonThuoc.IDDonThuoc = ChiTietDonThuoc.IDDonThuoc INNER JOIN " +
                  "Thuoc ON ChiTietDonThuoc.IDThuoc = Thuoc.IDThuoc where " +
                "DonThuoc.IDDonThuoc like '%"+searchKeyword+"%'");

            data_TaoDon.DataSource = dataAccess.GetDataTable(td);

            DataGridViewRow _dr = data_TaoDon.SelectedRows[0];
            string _TongHoaDon = _dr.Cells["TongHoaDon"].Value.ToString();
            txt_TongHoaDon.Text = _TongHoaDon;
        }


        private void btn_TD_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult _result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (_result == DialogResult.Yes)
            {
                DataGridViewRow _dr = data_TaoDon.SelectedRows[0];
                string _IDThuoc = txt_TaoDon_idThuoc.Text;
                MessageBox.Show("Đã xóa thuốc có mã " + _IDThuoc);

                dataAccess.UpdateData(string.Format("delete from ChiTietDonThuoc where IDThuoc ='{0}';" ,_IDThuoc));
                
            }
        }
    }
}
