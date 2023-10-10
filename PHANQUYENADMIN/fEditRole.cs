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

    public partial class fEditRole : Form
    {
        private Dictionary<String,GrantTableForm> newGrantTable = new Dictionary<String, GrantTableForm>();
        private Dictionary<String, GrantRoleForm> newGrantRole = new Dictionary<String, GrantRoleForm>();
        private Dictionary<String, GrantRoleForm> newGrantPrivilege = new Dictionary<String, GrantRoleForm>();
        public fEditRole()
        {
            InitializeComponent();
        }

        private void fEditRole_Load(object sender, EventArgs e)
        {
            label4.Text = fAdministrator.curRole;
            // Load user role
            DataTable roleTable = AdminstratorDAO.loadUserRole();
            dgvRole.AutoGenerateColumns = false;
            dgvRole.DataSource = roleTable;
            dgvRole.Columns["colRole"].DataPropertyName = "R";
            // Load user privilege
            DataTable privilegeTable = AdminstratorDAO.loadUserPrivilege();
            dgvSystemPrivilege.AutoGenerateColumns = false;
            dgvSystemPrivilege.DataSource = privilegeTable;
            dgvSystemPrivilege.Columns["colPrivilege"].DataPropertyName = "PRIVILEGE";
            // Load table
            DataTable tbTable = AdminstratorDAO.loadTable();
            dgvSecurable.AutoGenerateColumns = false;
            dgvSecurable.DataSource = tbTable;
            dgvSecurable.Columns["colTableSecurable"].DataPropertyName = "TABLE_NAME";
        }

        private void dgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRole.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvRole.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvRole.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvRole.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvRole.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvRole.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                }
                GrantRoleForm form = getValue(dgvRole.Rows[e.RowIndex]);
                newGrantRole.Remove(form.RoleName);
                newGrantRole.Add(form.RoleName,form);
            }
        }

        private void dgvSystemPrivilege_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSystemPrivilege.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvSystemPrivilege.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {
                    cell.Value = cell.FalseValue;
                    if (e.ColumnIndex == 1)
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                }
                else
                {
                    if (e.ColumnIndex == 1)
                    {
                        cell.Value = cell.TrueValue;
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[3].Value = cell.FalseValue;

                    }
                    else if (e.ColumnIndex == 2 && dgvSystemPrivilege.Rows[e.RowIndex].Cells[1].Value == cell.TrueValue)
                    {
                        cell.Value = cell.TrueValue;
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[1].Value = cell.FalseValue;
                        dgvSystemPrivilege.Rows[e.RowIndex].Cells[2].Value = cell.FalseValue;
                        cell.Value = cell.TrueValue;
                    }
                    GrantRoleForm form = getValue(dgvSystemPrivilege.Rows[e.RowIndex]);
                    newGrantPrivilege.Remove(form.RoleName);
                    newGrantPrivilege.Add(form.RoleName,form);
                }
            }
        }

        private void dgvSecurable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSecurable.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)dgvSecurable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value == cell.TrueValue)
                {

                    cell.Value = cell.FalseValue;

                }
                else
                {
                  
                        cell.Value = cell.TrueValue;

                }
                GrantTableForm form= getTableValue(dgvSecurable.Rows[e.RowIndex]);
                newGrantTable.Remove(form.TableName);
                newGrantTable.Add(form.TableName,form);
            }
        }
        private GrantRoleForm getValue(DataGridViewRow dataGridViewRow)
        {
            String rolename = dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell=(DataGridViewCheckBoxCell)dataGridViewRow.Cells[1];
            bool Grant = cell.Value == cell.TrueValue;
            cell= (DataGridViewCheckBoxCell)dataGridViewRow.Cells[2];
            bool AdminOption = cell.Value == cell.TrueValue;
            cell= (DataGridViewCheckBoxCell)dataGridViewRow.Cells[3];
            bool Revoke = cell.Value == cell.TrueValue;
            GrantRoleForm result = new GrantRoleForm(rolename, Grant, AdminOption, Revoke);
            return result;
        }
        private GrantTableForm getTableValue(DataGridViewRow dataGridViewRow)
        {
            string RoleName = dataGridViewRow.Cells[0].Value.ToString();
            DataGridViewCheckBoxCell cell=new DataGridViewCheckBoxCell();
            bool Select = dataGridViewRow.Cells[1].Value != cell.TrueValue;
            bool Update = dataGridViewRow.Cells[2].Value != cell.TrueValue;
            bool Insert = dataGridViewRow.Cells[3].Value != cell.TrueValue;
            bool Delete = dataGridViewRow.Cells[4].Value != cell.TrueValue;
            bool Revoke= dataGridViewRow.Cells[5].Value != cell.TrueValue;
            GrantTableForm result = new GrantTableForm(RoleName, Select, Update, Insert, Delete, Revoke);
            return result;
        }


        private void btnApply_Click_1(object sender, EventArgs e)
        {
            AdminstratorDAO.Role2Role(fAdministrator.curRole,newGrantRole.Values.ToList());
            AdminstratorDAO.Privilege2Role(fAdministrator.curRole,newGrantPrivilege.Values.ToList());
            AdminstratorDAO.Table2User(fAdministrator.curUser, newGrantTable.Values.ToList());
            newGrantRole.Clear();
            newGrantPrivilege.Clear();
            newGrantTable.Clear();
            MessageBox.Show("Edit sucessfully!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
