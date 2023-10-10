using PHANQUYENADMIN.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PHANQUYENADMIN
{
    public partial class fTablePhongBan : Form
    {
        public static String button;
        public static String MAPB;
        public static String TEN;
        public static String TRPHG;
        public fTablePhongBan()
        {
            InitializeComponent();
        }

        public static void loadtablePB()
        {
            DataTable dt2 = NhanVienDAO.loadPB();
            dgvPhongBan.DataSource = dt2;
        }
        private void fTablePhongBan_Load(object sender, EventArgs e)
        {
            DataTable dt2 = NhanVienDAO.loadPB();
            dgvPhongBan.DataSource = dt2;
            if(fLogin.ROLE != "Nhan su")
            {
                btnReset.Visible = false;
                btnCreate.Visible = false;
                btnEdit.Visible = false;
            }
            int x = label1.Size.Width / 2;
            int y = label1.Size.Height;
            label1.Location = new Point(panel2.Size.Width/2 - x, panel2.Size.Height - y);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPhongBan.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvPhongBan.CurrentRow.Selected = true;
                MAPB = dgvPhongBan.Rows[e.RowIndex].Cells["MAPB"].FormattedValue.ToString();
                TEN = dgvPhongBan.Rows[e.RowIndex].Cells["TENPB"].FormattedValue.ToString();
                TRPHG = dgvPhongBan.Rows[e.RowIndex].Cells["TRPHG"].FormattedValue.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable dt2 = NhanVienDAO.loadPB();
            dgvPhongBan.DataSource = dt2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            button = "Them";
            fThemPhongBan form = new fThemPhongBan();
            form.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            button = "Sua";          
            fThemPhongBan form = new fThemPhongBan();
            form.ShowDialog();
        }
    }
}
