using PHANQUYENADMIN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHANQUYENADMIN
{
    public partial class fInformation : Form
    {
        private int control = 1;
        public fInformation()
        {
            InitializeComponent();
        }

        private void fInformation_Load(object sender, EventArgs e)
        {


            DataTable dt = NhanVienDAO.loadStaff();
            lbTen.Text = dt.Rows[0]["TENNV"].ToString();
            lbGioiTinh.Text = dt.Rows[0]["PHAI"].ToString();
            DateTime myDateTimeValue = Convert.ToDateTime
                (dt.Rows[0]["NGAYSINH"].ToString());
            lbNgaySinh.Text = myDateTimeValue.ToString("dd/MM/yyyy");
            lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            lbVaiTro.Text = dt.Rows[0]["VAITRO"].ToString();
            lbMaNQL.Text = dt.Rows[0]["MANQL"].ToString();
            lbLuong.Text = dt.Rows[0]["LUONG"].ToString();
            lbPhuCap.Text = dt.Rows[0]["PHUCAP"].ToString();
            lbSDT.Text = dt.Rows[0]["SODT"].ToString();
            lbMaNV.Text = dt.Rows[0]["MANV"].ToString();

            txtNgaySinh.Text = myDateTimeValue.ToString("MM/dd/yyyy");
            
            txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
            txtSDT.Text = dt.Rows[0]["SODT"].ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            control = (control + 3) % 2;
            if (control == 0)
            {
                btnCancel.Visible = true;
                btnChange.Text = "Lưu";
                lbNgaySinh.Visible = false;
                lbDiaChi.Visible = false;
                lbSDT.Visible = false;
                txtNgaySinh.Visible = true;
                txtDiaChi.Visible = true;
                txtSDT.Visible = true;
            }
            else
            {
                try
                {
                    DateTime date = Convert.ToDateTime
                    (txtNgaySinh.Value);
                    String ngaysinh = date.ToString("yyyy-MM-dd");
                    NhanVienDAO.update_Inf(ngaysinh, txtDiaChi.Text, txtSDT.Text);

                    MessageBox.Show("Cập nhật thông tin thành công");
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.Message);
                    MessageBox.Show("Có lỗi xảy ra vui lòng thử lại sau");
                    return;
                }
                btnCancel.Visible = false;
                btnChange.Text = "Thay Đổi";
                lbNgaySinh.Visible = true;
                lbDiaChi.Visible = true;
                lbSDT.Visible = true;
                txtNgaySinh.Visible = false;
                txtDiaChi.Visible = false;
                txtSDT.Visible = false;
                DataTable dt = NhanVienDAO.loadStaff();
                lbTen.Text = dt.Rows[0]["TENNV"].ToString();
                lbGioiTinh.Text = dt.Rows[0]["PHAI"].ToString();
                DateTime myDateTimeValue = Convert.ToDateTime
                (dt.Rows[0]["NGAYSINH"].ToString());
                lbNgaySinh.Text = myDateTimeValue.ToString("MM/dd/yyyy");
                lbDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                lbVaiTro.Text = dt.Rows[0]["VAITRO"].ToString();
                lbMaNQL.Text = dt.Rows[0]["MANQL"].ToString();
                lbLuong.Text = dt.Rows[0]["LUONG"].ToString();
                lbPhuCap.Text = dt.Rows[0]["PHUCAP"].ToString();
                lbSDT.Text = dt.Rows[0]["SODT"].ToString();
                lbMaNV.Text = dt.Rows[0]["MANV"].ToString();
                //
                txtNgaySinh.Text = txtNgaySinh.Text = lbNgaySinh.Text;
                txtDiaChi.Text = dt.Rows[0]["DIACHI"].ToString();
                txtSDT.Text = dt.Rows[0]["SODT"].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = false;
            btnChange.Text = "Thay Đổi";
            lbNgaySinh.Visible = true;
            lbDiaChi.Visible = true;
            lbSDT.Visible = true;
            txtNgaySinh.Visible = false;
            txtDiaChi.Visible = false;
            txtSDT.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
