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
    public partial class fCreateRole : Form
    {
        public fCreateRole()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (txtRoleName.Text == "") MessageBox.Show("Tên của role trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                int check = AdminstratorDAO.checkRoleName(txtRoleName.Text);
                if (check == 1) MessageBox.Show("Tên role đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    AdminstratorDAO.createRole(txtRoleName.Text);
                    DialogResult result = MessageBox.Show("Tạo role mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRoleName.Text = "";
                }
            }
        }
    }
}
