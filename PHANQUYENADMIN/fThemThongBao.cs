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
    public partial class fThemThongBao : Form
    {
        public fThemThongBao()
        {
            InitializeComponent();
        }

        private void fThemThongBao_Load(object sender, EventArgs e)
        {
            txtDT.Items.Clear();
            txtDT.Items.Add("TP:ALL:ALL");
            txtDT.Items.Add("TP:SX:MB");
            txtDT.Items.Add("TP:SX:MN");
            txtDT.Items.Add("TP:ALL:MB");
            txtDT.Items.Add("GD:SX:ALL");
            txtDT.Items.Add("TP:MB:ALL");
            txtDT.Items.Add("TP:SX:MT");
            txtDT.Items.Add("TP:MB:MN");
            txtDT.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GiamDocDAO.checkMaTB(txtMaTB.Text)==1) MessageBox.Show("Mã thông báo đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                GiamDocDAO.createThongBao(txtMaTB.Text, txtDT.Text, textBox2.Text);
                MessageBox.Show("Tạo thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fTableThongBao.loadTableTB();
            } 
                
        }
    }
}
