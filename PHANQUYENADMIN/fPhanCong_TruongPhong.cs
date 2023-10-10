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
    public partial class fPhanCong_TruongPhong : Form
    {
        public static string manv;
        public static string mada;
        public fPhanCong_TruongPhong()
        {
            InitializeComponent();
            LabelLoad_FontDTG();
            PhanCongLoad();
            DeAnLoad();
        }
        private void LabelLoad_FontDTG()
        {
            //LABEL 4
            String query1 = "Select * from ADMIN01.vw_NHANVIEN_XemThongTinCaNhan";
            DataTable dt1 = DataProvider.Instance.ExecuteQuery(query1);
            this.label4.Text = dt1.Rows[0]["MANV"].ToString();
            //Change font and color DTGV
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView2.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
            this.dataGridView2.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void DeAnLoad()
        {
            String query2 = "Select * from ADMIN01.DEAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query2);
            dataGridView2.DataSource = data;
        }

        private void PhanCongLoad()
        {
            String query1 = "Select * from ADMIN01.PHANCONG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query1);
            dataGridView1.DataSource = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String manhanvien = label9.Text.ToString();
            String madean=label10.Text.ToString();
            String check = NhanVienDAO.Execute_pr_CheckNhanVien(label9.Text).ToString();
            if (check=="1")
            {
                String query = "DELETE FROM ADMIN01.PHANCONG WHERE MANV='" + manhanvien + "' AND MADA='" + madean + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show("Xóa phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PhanCongLoad();
                fTablePhanCong.loadtablePC();
            }
            else
            {
                MessageBox.Show("Nhân viên trên không thuộc phòng ban của trưởng phòng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string manhanvien = textBox1.Text.ToString();
            String query4= "Select * from ADMIN01.PHANCONG WHERE MANV='"+manhanvien+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query4);
            dataGridView1.DataSource = data;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PhanCongLoad();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                label9.Text = dataGridView1.Rows[e.RowIndex].Cells["MANV"].FormattedValue.ToString();
                label10.Text = dataGridView1.Rows[e.RowIndex].Cells["MADA"].FormattedValue.ToString();
                label11.Text = dataGridView1.Rows[e.RowIndex].Cells["THOIGIAN"].FormattedValue.ToString();
                manv = label9.Text;
                mada = label10.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fThemPhanCong themphancong=new fThemPhanCong();
            themphancong.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String check = NhanVienDAO.Execute_pr_CheckNhanVien(manv).ToString();
            if(check=="1")
            {
                fEditPhanCong chinhsuaphancong = new fEditPhanCong();
                chinhsuaphancong.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nhân viên này không thể cập nhật do không thuộc phòng ban của trưởng phòng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
