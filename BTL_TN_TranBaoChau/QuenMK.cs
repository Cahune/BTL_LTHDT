using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_TN_TranBaoChau
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
            Logo.BackColor = System.Drawing.Color.Transparent;
            PK_Cahu.BackColor = System.Drawing.Color.Transparent;
        }

        private void Thoat_QMK_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }

        private void btn_LLTK_Click(object sender, EventArgs e)
        {
            Modify modify = new Modify();

            string sdt = txt_QMK_SDT.Text;
            if (sdt.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT * FROM NguoiDung WHERE SoDienThoai ='" + sdt + "'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    var taiKhoan = modify.TaiKhoans(query)[0];
                    label_ketqua.ForeColor = Color.DeepSkyBlue;
                    label_ketqua.Text = $"Mật khẩu: {taiKhoan.Matkhau}";
                }
                else
                {
                    label_ketqua.ForeColor = Color.Red;
                    label_ketqua.Text = "Số điện thoại này chưa được đăng ký";
                }
            }
        }

        private void btn_QMK_QVDN_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
    }
}
