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
    public partial class fCreateUser : Form
    {
        public fCreateUser()
        {
            InitializeComponent();
        }

        private void fCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "") MessageBox.Show("Bạn chưa nhập username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPassword.Text == "") MessageBox.Show("Bạn chưa nhập password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtConfirmPassword.Text == "") MessageBox.Show("Bạn chưa nhập xác nhận lại password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (txtPassword.Text != txtConfirmPassword.Text) MessageBox.Show("Password không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (AdminstratorDAO.checkUserName(txtUserName.Text) == 1) MessageBox.Show("Username đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    AdminstratorDAO.createUser(txtUserName.Text, txtPassword.Text);
                    DialogResult result = MessageBox.Show("Tạo user mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserName.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
