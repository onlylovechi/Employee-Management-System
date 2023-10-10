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
    public partial class fThemDeAn : Form
    {
        
        public fThemDeAn()
        {
            InitializeComponent();
        }

        private void fThemDeAn_Load(object sender, EventArgs e)
        {
            txtMAPB.Items.Clear();
            DataTable dt2 = NhanVienDAO.loadPB();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                txtMAPB.Items.Add(dt2.Rows[i]["MAPB"]);
            }
            if (fTableDeAn.button == "Them")
            {
                label1.Text = "THÊM ĐỀ ÁN MỚI";
                btnOK.Text = "OK";

            }    
            else if (fTableDeAn.button == "Sua")
            {
                label1.Text = "CHỈNH SỬA THÔNG TIN ĐỀ ÁN";
                label1.Location = new Point(150, 29);
                btnOK.Text = "Lưu";
                txtMADA.ReadOnly = true;
                txtMADA.Text = fTableDeAn.MADA;
                txtTen.Text = fTableDeAn.TEN;
                txtNgayBD.Text = fTableDeAn.Time;
                txtMAPB.Text = fTableDeAn.MAPB;
            }    

            txtMAPB.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (fTableDeAn.button == "Them")
            {
                
                DateTime date = Convert.ToDateTime
                    (txtNgayBD.Value);
                String ngaybd = date.ToString("yyyy-MM-dd");
                AdminstratorDAO.TRUONGDEAN_add_DEAN(txtMADA.Text, txtTen.Text, ngaybd, txtMAPB.Text);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTableDeAn.loadTableDA();
            }
            else if (fTableDeAn.button == "Sua")
            {
               
                DateTime date = Convert.ToDateTime
                    (txtNgayBD.Value);
                String ngaybd = date.ToString("yyyy-MM-dd");
                if (AdminstratorDAO.updateDEAN(txtMADA.Text, txtTen.Text, ngaybd, txtMAPB.Text) == 1)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTableDeAn.loadTableDA();
            }
        }
    }
}
