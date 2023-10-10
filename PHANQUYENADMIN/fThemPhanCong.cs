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
    public partial class fThemPhanCong : Form
    {
        public fThemPhanCong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String manhanvien=textBox1.Text.ToString();
            String madean=txtMADA.Text.ToString();

            String check = NhanVienDAO.Execute_pr_CheckNhanVien(manhanvien).ToString();
            if (manhanvien == "" || madean == "" )
            {
                MessageBox.Show("Nhập thiếu thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                if (check=="1")
                {
                    DateTime date = Convert.ToDateTime
                    (txtNGAYBD.Value);
                    String ngaybd = date.ToString("yyyy-MM-dd");
                    String query = "INSERT INTO ADMIN01.PHANCONG(MANV,MADA,THOIGIAN) VALUES ('" + manhanvien + "','" + madean + "',TO_DATE('" + ngaybd + "','YYYY-MM-DD'))";
                    int result = DataProvider.Instance.ExecuteNonQuery(query);
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fTablePhanCong.loadtablePC();
                    this.Hide();
                }    
                else
                {
                    MessageBox.Show("Nhân viên này không thể thêm do không thuộc phòng ban của trưởng phòng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }    
            }
        }

        private void fThemPhanCong_Load(object sender, EventArgs e)
        {
            String query2 = "Select * from ADMIN01.DEAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query2);
            txtMADA.DataSource = data;
            txtMADA.DisplayMember = "MADA";
            txtMADA.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
