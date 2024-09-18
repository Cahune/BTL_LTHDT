using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_TN_TranBaoChau
{
    public partial class DangKy : Form
    {
        
        public DangKy()
        {
            InitializeComponent();
            Logo.BackColor = System.Drawing.Color.Transparent;
            PK_Cahu.BackColor = System.Drawing.Color.Transparent;
        }

        private void txt_Dky_MK_OnValueChanged(object sender, EventArgs e)
        {
            txt_Dky_MK.isPassword = true;
        }

        private void txt_XNMK_OnValueChanged(object sender, EventArgs e)
        {
            txt_XNMK.isPassword = true;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void DK_AnMK_Click(object sender, EventArgs e)
        {
            if (txt_Dky_MK.isPassword == false)
            {
                DK_HienMK.BringToFront();
                txt_Dky_MK.isPassword = true;
            }
        }

        private void DK_HienMK_Click(object sender, EventArgs e)
        {
            if (txt_Dky_MK.isPassword == true)
            {
                DK_AnMK.BringToFront();
                txt_Dky_MK.isPassword = false;
            }
        }
        private void DK_AnXNMK_Click(object sender, EventArgs e)
        {
            if (txt_XNMK.isPassword == false)
            {
                DK_HienXNMK.BringToFront();
                txt_XNMK.isPassword = true;
            }
        }

        private void DK_HienXNMK_Click(object sender, EventArgs e)
        {
            if (txt_XNMK.isPassword == true)
            {
                DK_AnXNMK.BringToFront();
                txt_XNMK.isPassword = false;
            }
        }       

        private void btn_QVDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, @"^[A-Za-z0-9]{8,20}$");
        }
        public bool CheckSDT(string em)
        {
            return Regex.IsMatch(em, @"^[0-9]{7,15}$");
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            string tentk = txt_Dky_TenDN.Text;
            string matkhau = txt_Dky_MK.Text;
            string xnmatkhau = txt_XNMK.Text;
            string soDienThoai = txt_Dky_SDT.Text;

            if (tentk.Trim() == "" || matkhau.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 8-20 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from NguoiDung where TaiKhoan = '" + tentk + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, vui lòng đăng ký tên tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 8-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhau != xnmatkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (soDienThoai.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckSDT(soDienThoai))
            {
                MessageBox.Show("Số điện thoại không tồn tại. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(CheckDK.Checked == false)
            {
                MessageBox.Show("Vui lòng đồng ý với điều khoản đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from NguoiDung where SoDienThoai = '" + soDienThoai + "'").Count != 0)
            {
                MessageBox.Show("Số điện thoại này đã được đăng ký, vui lòng đăng ký số điện thoại khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = $"INSERT INTO NguoiDung (TaiKhoan, MatKhau, SoDienThoai) VALUES ('{tentk}', '{matkhau}', '{soDienThoai}')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, vui lòng đăng ký tên tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
