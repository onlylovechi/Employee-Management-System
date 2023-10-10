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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PHANQUYENADMIN
{
    public partial class fThemNhanVien : Form
    {
        public fThemNhanVien()
        {
            InitializeComponent();
        }

        private void fThemNhanVien_Load(object sender, EventArgs e)
        {
            txtPHAI.Items.Clear();
            txtPHG.Items.Clear();
            txtVAITRO.Items.Clear();
            txtPHAI.Items.Add("Nam");
            txtPHAI.Items.Add("Nu");
            txtVAITRO.Items.Add("Nhan vien");
            txtVAITRO.Items.Add("Nhan su");
            txtVAITRO.Items.Add("Tai chinh");
            txtVAITRO.Items.Add("Ban giam doc");
            txtVAITRO.Items.Add("Truong de an");
            txtVAITRO.Items.Add("Truong phong");
            txtVAITRO.Items.Add("QL truc tiep");
            txtVAITRO.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPHAI.DropDownStyle = ComboBoxStyle.DropDownList;
            txtPHG.DropDownStyle = ComboBoxStyle.DropDownList;
            DataTable dt2 = NhanVienDAO.loadPB();
            for (int i=0;i< dt2.Rows.Count; i++)
            {
                txtPHG.Items.Add(dt2.Rows[i]["MAPB"]);
            }    
            if (fTableNhanVien.button == "Them")
            {
                
            }
            else if (fTableNhanVien.button == "Sua")
            {
                label1.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
                btnOK.Text = "Lưu thay đổi";
                txtMANV.ReadOnly = true;
                txtMANV.Text = fTableNhanVien.MANV;
                txtTENNV.Text = fTableNhanVien.TEN;
                txtPHAI.Text = fTableNhanVien.PHAI;
                txtNGAYSINH.Text = fTableNhanVien.NGAYSINH;
                txtSODT.Text = fTableNhanVien.SODT;
                txtDIACHI.Text = fTableNhanVien.DIACHI;
                txtVAITRO.Text = fTableNhanVien.VAITRO;
                txtMAQL.Text = fTableNhanVien.MAQL;
                txtPHG.Text = fTableNhanVien.PHG;  
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (fTableNhanVien.button == "Them")
            {
                if (AdminstratorDAO.checkMaNHANVIEN(txtMANV.Text) == 1) MessageBox.Show("Mã nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DateTime date = Convert.ToDateTime
                    (txtNGAYSINH.Value);
                    String ngaysinh = date.ToString("yyyy-MM-dd");
                    if (AdminstratorDAO.createNHANVIEN(txtMANV.Text, txtTENNV.Text, txtPHAI.Text, ngaysinh, txtDIACHI.Text, txtSODT.Text, txtVAITRO.Text, txtMAQL.Text, txtPHG.Text) == 1)
                        MessageBox.Show("Tạo nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fTableNhanVien.loadTableNV();
                }
            }
            else if (fTableNhanVien.button == "Sua")
            {
                DateTime date = Convert.ToDateTime
                    (txtNGAYSINH.Value);
                String ngaysinh = date.ToString("yyyy-MM-dd");
                if (AdminstratorDAO.updateNHANVIEN(txtMANV.Text, txtTENNV.Text, txtPHAI.Text, ngaysinh, txtDIACHI.Text, txtSODT.Text, txtVAITRO.Text, txtMAQL.Text, txtPHG.Text) == 1)
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTableNhanVien.loadTableNV();
            }
        }
    }
}
