using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_TN_TranBaoChau
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
            Logo.BackColor = System.Drawing.Color.Transparent;
            PK_Cahu.BackColor = System.Drawing.Color.Transparent;
        }
        private void txt_MatKhau_OnValueChanged(object sender, EventArgs e)
        {
            txt_MatKhau.isPassword = true;
        }
        private void Thoat_DN_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void pic_HienMK_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.isPassword == true)
            {
                pic_AnMK.BringToFront();
                txt_MatKhau.isPassword = false;
            }
        }

        private void pic_AnMK_Click(object sender, EventArgs e)
        {
            if (txt_MatKhau.isPassword == false)
            {
                pic_HienMK.BringToFront();
                txt_MatKhau.isPassword = true;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            // Lấy thông tin từ các ô nhập liệu
            string tentk = txt_TenDangNhap.Text;
            string matkhau = txt_MatKhau.Text;

            // Kiểm tra nếu tên tài khoản hoặc mật khẩu trống
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Tạo truy vấn SQL để kiểm tra tài khoản
                string query = "Select * from NguoiDung where TaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                // Nếu tìm thấy tài khoản trong cơ sở dữ liệu
                if (modify.TaiKhoans(query).Count != 0)
                {
                    // Hiển thị thông báo đăng nhập thành công
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ẩn form hiện tại và hiển thị form Home
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    // Hiển thị thông báo tên tài khoản hoặc mật khẩu không chính xác
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void LinkDky_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void QuenMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuenMK quenMatKhau = new QuenMK();
            quenMatKhau.ShowDialog();
        }
    }
}
