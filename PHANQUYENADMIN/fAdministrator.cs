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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PHANQUYENADMIN
{
    public partial class fAdministrator : Form
    {
        public static String curRole;
        public static String curUser;
        string ROLE;
        string USER;
        public fAdministrator()
        {
            InitializeComponent();
            loadInfo();
            
        }
        private void loadInfo()
        {
            DataTable dtRole = new DataTable();
            DataTable dtUser = new DataTable();
            dtRole = AdminstratorDAO.loadUserRole();
            dtUser = AdminstratorDAO.loadUser();
            dgvRole.DataSource = dtRole;
            dgvUser.DataSource = dtUser;
            txtRole.Text = "Role: ";
            txtUser.Text = "User: ";
            ROLE = "";
            USER = "";
            cbbRolePrivs.Items.Clear();
            cbbUserPrivs.Items.Clear();
            string[] items = new string[] { "System Privileges", "Table Privileges", "Role Privileges" };
            cbbRolePrivs.Items.AddRange(items);
            cbbUserPrivs.Items.AddRange(items);
            dgvPrivilegeRoleInfo.DataSource = null;
            dgvPrivilegeInfo.DataSource = null;
            dgvUsersys.DataSource = AdminstratorDAO.readUsersys();
        }
        

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            fEditRole editRole = new fEditRole();
            this.Hide();
            editRole.ShowDialog();
            this.Show();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            fEditUser editUser = new fEditUser();
            this.Hide();
            editUser.ShowDialog();
            this.Show();
        }



        private void btnEditRole_Click_1(object sender, EventArgs e)
        {
            fEditRole editRole = new fEditRole();
            this.Hide();
            editRole.ShowDialog();
            this.Show();
        }

        private void btnEditUser_Click_1(object sender, EventArgs e)
        {
            fEditUser editUser = new fEditUser();
            this.Hide();
            editUser.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbbUserPrivs.Text == "System Privileges") dt = AdminstratorDAO.readSYSprivs(USER);
            else if (cbbUserPrivs.Text == "Table Privileges") dt = AdminstratorDAO.readTABprivs(USER);
            else if (cbbUserPrivs.Text == "Role Privileges") dt = AdminstratorDAO.readROLEprivs(USER);
            dgvPrivilegeInfo.DataSource = dt;
        }

        private void btnCreateUser_Click_1(object sender, EventArgs e)
        {
            fCreateUser createUser = new fCreateUser();
            this.Hide();
            createUser.ShowDialog();
            this.Show();
        }

        private void btnCreateRole_Click_1(object sender, EventArgs e)
        {
            fCreateRole createRole = new fCreateRole();
            this.Hide();
            createRole.ShowDialog();
            this.Show();
        }

        private void btnDropRole_Click_1(object sender, EventArgs e)
        {
            if (ROLE != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc xóa role " + ROLE + "?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    AdminstratorDAO.dropRole(ROLE);
                    MessageBox.Show("Xóa role " + ROLE + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInfo();
                }
            }
            else MessageBox.Show("Bạn chưa chọn role!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRefreshRole_Click_1(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void dgvRole_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int VT = dgvRole.CurrentCell.RowIndex;
            ROLE = dgvRole.Rows[VT].Cells[0].Value.ToString();
            curRole=ROLE;
            txtRole.Text = "Role: " + ROLE;
        }

        private void btnPvlRoleInfo_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cbbRolePrivs.Text == "System Privileges") dt = AdminstratorDAO.readSYSprivs(ROLE);
            else if (cbbRolePrivs.Text == "Table Privileges") dt = AdminstratorDAO.readTABprivs(ROLE);
            else if (cbbRolePrivs.Text == "Role Privileges") dt = AdminstratorDAO.readROLEprivs(ROLE);
            dgvPrivilegeRoleInfo.DataSource = dt;
        }

        private void dgvUser_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int VT = dgvUser.CurrentCell.RowIndex;
            USER = dgvUser.Rows[VT].Cells[0].Value.ToString();
            curUser= USER;
            txtUser.Text = "User: " + USER;
        }

        private void btnDropUser_Click(object sender, EventArgs e)
        {
            if (USER != "")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc xóa user " + USER + "?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    AdminstratorDAO.dropUser(USER);
                    MessageBox.Show("Xóa role " + USER + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadInfo();
                }

                    
            }
            else MessageBox.Show("Bạn chưa chọn user!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRefreshUser_Click_1(object sender, EventArgs e)
        {
            loadInfo();
        }

        private void fAdministrator_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsersys_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
