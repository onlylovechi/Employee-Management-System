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
    public partial class fThemPhongBan : Form
    {
        public fThemPhongBan()
        {
            InitializeComponent();
        }

        private void fThemPhongBan_Load(object sender, EventArgs e)
        {
            if (fTablePhongBan.button == "Them")
            {
                label1.Text = "THÊM PHÒNG BAN MỚI";
                btnOK.Text = "OK";
            }   
            else if (fTablePhongBan.button == "Sua")
            {
                label1.Text = "CẬP NHẬT THÔNG TIN PHÒNG BAN";
                btnOK.Text = "Lưu thay đổi";
                txtMAPB.ReadOnly = true;
                txtMAPB.Text = fTablePhongBan.MAPB;
                txtTEN.Text = fTablePhongBan.TEN;
                txtTRPH.Text = fTablePhongBan.TRPHG;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (fTablePhongBan.button == "Them")
            {
                if (AdminstratorDAO.checkMaPHONGBAN(txtMAPB.Text) == 1) MessageBox.Show("Mã phòng ban đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    if (AdminstratorDAO.createPHONGBAN(txtMAPB.Text, txtTEN.Text, txtTRPH.Text) == 1)
                        MessageBox.Show("Tạo phòng ban mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fTablePhongBan.loadtablePB();
                }

            }
            else if (fTablePhongBan.button == "Sua")
            {

                if (AdminstratorDAO.updatePHONGBAN(txtMAPB.Text, txtTEN.Text, txtTRPH.Text) == 1)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTablePhongBan.loadtablePB();
            }
        }
    }
}
