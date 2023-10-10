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
    public partial class fTableThongBao : Form
    {
        public fTableThongBao()
        {
            InitializeComponent();
        }

        private void dgvDeAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static void loadTableTB()
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.loadTB();
            dgvThongBao.DataSource = dt;
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            int x = label2.Size.Width / 2;
            int y = label2.Size.Height;
            label2.Location = new Point(panel4.Size.Width / 2 - x, panel4.Size.Height - y);
            DataTable dt = new DataTable();
            if (fLogin.ROLE != "Ban giam doc")
            {
                btnCreate.Visible = false;
            }    
            dt = NhanVienDAO.loadTB();
            dgvThongBao.DataSource = dt;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = NhanVienDAO.loadTB();
            dgvThongBao.DataSource = dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fThemThongBao form = new fThemThongBao();
            form.ShowDialog();
            
        }
    }
}
