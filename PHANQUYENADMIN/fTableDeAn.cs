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

namespace PHANQUYENADMIN
{
    public partial class fTableDeAn : Form
    {
        public static String button;
        public static String MADA;
        public static String TEN;
        public static String Time;
        public static String MAPB;
        public fTableDeAn()
        {
            InitializeComponent();
        }

        private void fTableDeAn_Load(object sender, EventArgs e)
        {
            DataTable dt3 = NhanVienDAO.loadDA();
            dgvDeAn.DataSource = dt3;
            if (fLogin.ROLE != "Truong de an")
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnCreate.Visible = false;
                btnReset.Visible = false;
            }
            int x = label2.Size.Width / 2;
            int y = label2.Size.Height;
            label2.Location = new Point(panel4.Size.Width / 2 - x, panel4.Size.Height - y);
        }
        public static void loadTableDA()
        {
            DataTable dt3 = NhanVienDAO.loadDA();
            dgvDeAn.DataSource = dt3;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void dgvDeAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeAn.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvDeAn.CurrentRow.Selected = true;
                MADA = dgvDeAn.Rows[e.RowIndex].Cells["MADA"].FormattedValue.ToString(); 
                TEN = dgvDeAn.Rows[e.RowIndex].Cells["TENDA"].FormattedValue.ToString();
                Time = dgvDeAn.Rows[e.RowIndex].Cells["NGAYBD"].FormattedValue.ToString();
                MAPB = dgvDeAn.Rows[e.RowIndex].Cells["PHONG"].FormattedValue.ToString();
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DataTable dt3 = NhanVienDAO.loadDA();
            dgvDeAn.DataSource = dt3;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
            button = "Them";
            fThemDeAn form = new fThemDeAn();
            form.ShowDialog();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            button = "Sua";
            fThemDeAn form = new fThemDeAn();
            form.ShowDialog();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            AdminstratorDAO.TRUONGDEAN_remove_DEAN(MADA, TEN, Time, MAPB);
            MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadTableDA();
        }
    }
}
