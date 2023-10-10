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
    public partial class fTablePhanCong : Form
    {
        public fTablePhanCong()
        {
            InitializeComponent();
        }
        public static void loadtablePC()
        {
            DataTable dt = NhanVienDAO.loadTasks();
            if (dt.Rows.Count != 0)
            {
                lbNoti.Visible = false;
                dgvPhanCong.DataSource = dt;
            }
        }
        private void fTablePhanCong_Load(object sender, EventArgs e)
        {
            DataTable dt = NhanVienDAO.loadTasks();
            if (dt.Rows.Count != 0)
            {
                lbNoti.Visible = false;
                dgvPhanCong.DataSource = dt;
            }
            if (fLogin.ROLE != "Truong phong")
            {
                btnEdit.Visible = false;
            }
            int x = label1.Size.Width / 2;
            int y = label1.Size.Height;
            label1.Location = new Point(panel2.Size.Width / 2 - x, panel2.Size.Height - y);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPhanCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            fPhanCong_TruongPhong form = new fPhanCong_TruongPhong();
            form.ShowDialog();
        }
    }
}
