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
    
    public partial class fTableNhanVien : Form
    {
        public static String button;
        public static String MANV;
        public static String TEN;
        public static String PHAI;
        public static String NGAYSINH;
        public static String SODT;
        public static String DIACHI;
        public static String VAITRO;
        public static String MAQL;
        public static String PHG;
        public static String LUONG;
        public static String PHUCAP;
        public fTableNhanVien()
        {
            InitializeComponent();
        }
        public static void loadTableNV()
        {
            DataTable data = NhanVienDAO.readNHANVIEN();
            dgvNhanvien.DataSource = data;
        }
        private void fTableNhanVien_Load(object sender, EventArgs e)
        {
            DataTable data = NhanVienDAO.readNHANVIEN();
            dgvNhanvien.DataSource = data;
            if (fLogin.ROLE != "Nhan su")
            {
                btnCreate.Visible = false;
                if (fLogin.ROLE != "Tai chinh") { btnEdit.Visible = false; }
            }

            int x = label1.Size.Width / 2;
            int y = label1.Size.Height;
            label1.Location = new Point(panel2.Size.Width / 2 - x, panel2.Size.Height - y);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
                dgvNhanvien.DataSource = NhanVienDAO.filteredNHANVIEN(txtMANV.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataTable data = NhanVienDAO.readNHANVIEN();
            dgvNhanvien.DataSource = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            button = "Them";
            fThemNhanVien form = new fThemNhanVien();
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            button = "Sua";
            if (fLogin.ROLE == "Nhan su")
            {
                fThemNhanVien form = new fThemNhanVien();
                form.ShowDialog();
            }
            else if (fLogin.ROLE == "Tai chinh")
            {
                fChinhsuaLuongPC form = new fChinhsuaLuongPC();
                form.ShowDialog();
            }    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanvien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvNhanvien.CurrentRow.Selected = true;
                MANV = dgvNhanvien.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
                TEN = dgvNhanvien.Rows[e.RowIndex].Cells["TENNV"].FormattedValue.ToString();
                PHAI = dgvNhanvien.Rows[e.RowIndex].Cells["PHAI"].FormattedValue.ToString();
                NGAYSINH = dgvNhanvien.Rows[e.RowIndex].Cells["NGAYSINH"].FormattedValue.ToString();
                DIACHI = dgvNhanvien.Rows[e.RowIndex].Cells["DIACHI"].FormattedValue.ToString();
                SODT = dgvNhanvien.Rows[e.RowIndex].Cells["SODT"].FormattedValue.ToString();
                VAITRO = dgvNhanvien.Rows[e.RowIndex].Cells["VAITRO"].FormattedValue.ToString();
                MAQL = dgvNhanvien.Rows[e.RowIndex].Cells["MANQL"].FormattedValue.ToString();
                PHG = dgvNhanvien.Rows[e.RowIndex].Cells["PHG"].FormattedValue.ToString();
                if (fLogin.ROLE != "QL truc tiep")
                {
                    LUONG = dgvNhanvien.Rows[e.RowIndex].Cells["LUONG"].FormattedValue.ToString();
                    PHUCAP = dgvNhanvien.Rows[e.RowIndex].Cells["PHUCAP"].FormattedValue.ToString();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
