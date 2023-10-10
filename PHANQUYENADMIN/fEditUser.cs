using PHANQUYENADMIN.DAO;
using PHANQUYENADMIN.DTO;
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
    public partial class fEditUser : Form
    {
        private Dictionary<String,GrantTableForm> newGrantTable=new Dictionary<String, GrantTableForm>();
        private Dictionary<String, GrantRoleForm> newGrantRole = new Dictionary<String, GrantRoleForm>();
        private Dictionary<String, GrantRoleForm> newGrantPrivilege = new Dictionary<String, GrantRoleForm>();
        public fEditUser()
        {
            InitializeComponent();
        }

        private void fEditUser_Load(object sender, EventArgs e)
        {
            MessageBox.Show(fAdministrator.curUser);
            label4.Text = fAdministrator.curUser;
            // Load user role
            DataTable roleTable= AdminstratorDAO.loadUserRole();
            dgvtabRole.AutoGenerateColumns = false;
            dgvtabRole.DataSource=roleTable;
            dgvtabRole.Columns["colRole"].DataPropertyName = "R";
            // Load user privilege
            DataTable privilegeTable= AdminstratorDAO.loadUserPrivilege();
            dgvTabSystemPrivilege.AutoGenerateColumns = false;
            dgvTabSystemPrivilege.DataSource=privilegeTable;
            dgvTabSystemPrivilege.Columns["colPrivilege"].DataPropertyName = "PRIVILEGE";
            // Load table
            DataTable tbTable = AdminstratorDAO.loadTable();
            dgvTabSecurable.AutoGenerateColumns = false;
            dgvTabSecurable.DataSource = tbTable;
            dgvTabSecurable.Columns["colTableSecurable"].DataPropertyName = "TABLE_NAME";
        }

        private void dgvtabRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvtabRole.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvtabRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvtabRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvtabRole.Rows[e.RowIndex].Cells[3].Value=cell.FalseValue; 

                    }
                    else if (e.ColumnIndex == 2 && dgvtabRole.Rows[e.RowIndex].Cells[1].Value== cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if(e.ColumnIndex==3)
                    {
                        dgvtabRole.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue ;
                        dgvtabRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                }
                GrantRoleForm form = getValue(dgvtabRole.Rows[e.RowIndex]);
                newGrantRole.Remove(form.RoleName);
                newGrantRole.Add(form.RoleName,form);
            }
        }



        private void dgvTabSystemPrivilege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTabSystemPrivilege.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvTabSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                    GrantRoleForm form = getValue(dgvtabRole.Rows[e.RowIndex]);
                    newGrantPrivilege.Remove(form.RoleName);
                    newGrantPrivilege.Add(form.RoleName,getValue(dgvTabSystemPrivilege.Rows[e.RowIndex]));
                }
            }
        }

        private void dgvTabSecurable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTabSecurable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvTabSecurable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    if (cell.Value == cell.TrueValue)
                    {
                       
                        cell.Value = cell.FalseValue;

                    }
                    else
                    {
                       
                            cell.Value = cell.TrueValue;
                        
                    }


                    GrantTableForm form = getTableValue(dgvTabSecurable.Rows[e.RowIndex]);
                    newGrantTable.Remove(form.TableName);
                    newGrantTable.Add(form.TableName, getTableValue(dgvTabSecurable.Rows[e.RowIndex]));
                }
                catch (Exception t)
                {
                    MessageBox.Show(t.Message);
                }
            }
        }
        private GrantRoleForm getValue(DataGridViewRow dataGridViewRow)
        {
            String rolename = dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
            bool Grant = dataGridViewRow.Cells[1].Value == cell.TrueValue;
            bool AdminOption = dataGridViewRow.Cells[2].Value == cell.TrueValue;
            bool Revoke = dataGridViewRow.Cells[3].Value == cell.TrueValue;
            GrantRoleForm result = new GrantRoleForm(rolename, Grant, AdminOption, Revoke);
            return result;
        }
        private GrantTableForm getTableValue(DataGridViewRow dataGridViewRow)
        {
            string RoleName= dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell = new DataGridViewCheckBoxCell();
            bool Select = dataGridViewRow.Cells[1].Value != cell.TrueValue;
            bool Update= dataGridViewRow.Cells[2].Value != cell.TrueValue;
            bool Insert= dataGridViewRow.Cells[3].Value != cell.TrueValue;
            bool Delete= dataGridViewRow.Cells[4].Value != cell.TrueValue;      
            bool Revoke= dataGridViewRow.Cells[5].Value != cell.TrueValue;
            GrantTableForm result = new GrantTableForm(RoleName, Select, Update, Insert, Delete,Revoke);
            return result;
        }

        private void btnApply_Click(object sender, EventArgs e)
        { 
            AdminstratorDAO.Role2User(fAdministrator.curUser, newGrantRole.Values.ToList());
            AdminstratorDAO.Privilege2User(fAdministrator.curUser, newGrantPrivilege.Values.ToList());
            AdminstratorDAO.Table2User(fAdministrator.curUser, newGrantTable.Values.ToList());
            if(txtPassword.Text!=null)
            AdminstratorDAO.changeUserPassword(fAdministrator.curUser,txtPassword.Text,txtConfirmPassword.Text);
            MessageBox.Show("Edit sucessfully!");
            newGrantRole.Clear();
            newGrantPrivilege.Clear();
            newGrantTable.Clear();
            this.Close();
        }

        private void tabUser_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
