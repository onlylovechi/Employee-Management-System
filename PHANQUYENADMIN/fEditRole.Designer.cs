namespace PHANQUYENADMIN
{
    partial class fEditRole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabEditUser = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.dgvRole = new System.Windows.Forms.DataGridView();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSystemPrivilege = new System.Windows.Forms.TabPage();
            this.dgvSystemPrivilege = new System.Windows.Forms.DataGridView();
            this.tabSecurable = new System.Windows.Forms.TabPage();
            this.dgvSecurable = new System.Windows.Forms.DataGridView();
            this.colTableSecurable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdateSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsertSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTabDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTabRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPrivilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrantPrevilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdminPrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevokePrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabEditUser.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
            this.tabSystemPrivilege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemPrivilege)).BeginInit();
            this.tabSecurable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(741, 485);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 41);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(588, 485);
            this.btnApply.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(102, 41);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click_1);
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.tabUser);
            this.tabEditUser.Controls.Add(this.tabRole);
            this.tabEditUser.Controls.Add(this.tabSystemPrivilege);
            this.tabEditUser.Controls.Add(this.tabSecurable);
            this.tabEditUser.Location = new System.Drawing.Point(35, 36);
            this.tabEditUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.SelectedIndex = 0;
            this.tabEditUser.Size = new System.Drawing.Size(830, 441);
            this.tabEditUser.TabIndex = 3;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 29);
            this.tabUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabUser.Size = new System.Drawing.Size(822, 408);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "N\\A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Role Name";
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dgvRole);
            this.tabRole.Location = new System.Drawing.Point(4, 29);
            this.tabRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(730, 324);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // dgvRole
            // 
            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.AllowUserToDeleteRows = false;
            this.dgvRole.AllowUserToResizeColumns = false;
            this.dgvRole.AllowUserToResizeRows = false;
            this.dgvRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRole,
            this.colGrant,
            this.colWithAdmin,
            this.colRevoke});
            this.dgvRole.Location = new System.Drawing.Point(0, 0);
            this.dgvRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvRole.Name = "dgvRole";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRole.RowHeadersVisible = false;
            this.dgvRole.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvRole.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRole.RowTemplate.Height = 24;
            this.dgvRole.Size = new System.Drawing.Size(821, 401);
            this.dgvRole.TabIndex = 0;
            this.dgvRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRole_CellContentClick);
            // 
            // colRole
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colRole.DefaultCellStyle = dataGridViewCellStyle2;
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            this.colRole.Width = 350;
            // 
            // colGrant
            // 
            this.colGrant.FalseValue = " ";
            this.colGrant.HeaderText = "Grant";
            this.colGrant.MinimumWidth = 6;
            this.colGrant.Name = "colGrant";
            this.colGrant.ReadOnly = true;
            this.colGrant.TrueValue = "x";
            this.colGrant.Width = 125;
            // 
            // colWithAdmin
            // 
            this.colWithAdmin.FalseValue = " ";
            this.colWithAdmin.HeaderText = "With Admin";
            this.colWithAdmin.MinimumWidth = 6;
            this.colWithAdmin.Name = "colWithAdmin";
            this.colWithAdmin.ReadOnly = true;
            this.colWithAdmin.TrueValue = "x";
            this.colWithAdmin.Width = 125;
            // 
            // colRevoke
            // 
            this.colRevoke.FalseValue = " ";
            this.colRevoke.HeaderText = "Revoke";
            this.colRevoke.MinimumWidth = 6;
            this.colRevoke.Name = "colRevoke";
            this.colRevoke.ReadOnly = true;
            this.colRevoke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevoke.TrueValue = "x";
            this.colRevoke.Width = 125;
            // 
            // tabSystemPrivilege
            // 
            this.tabSystemPrivilege.Controls.Add(this.dgvSystemPrivilege);
            this.tabSystemPrivilege.Location = new System.Drawing.Point(4, 29);
            this.tabSystemPrivilege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSystemPrivilege.Name = "tabSystemPrivilege";
            this.tabSystemPrivilege.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSystemPrivilege.Size = new System.Drawing.Size(822, 408);
            this.tabSystemPrivilege.TabIndex = 2;
            this.tabSystemPrivilege.Text = "System Privilege";
            this.tabSystemPrivilege.UseVisualStyleBackColor = true;
            // 
            // dgvSystemPrivilege
            // 
            this.dgvSystemPrivilege.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemPrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSystemPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrivilege,
            this.colGrantPrevilege,
            this.colWithAdminPrivilege,
            this.colRevokePrivilege});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSystemPrivilege.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSystemPrivilege.Location = new System.Drawing.Point(0, 2);
            this.dgvSystemPrivilege.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSystemPrivilege.Name = "dgvSystemPrivilege";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSystemPrivilege.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSystemPrivilege.RowHeadersVisible = false;
            this.dgvSystemPrivilege.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvSystemPrivilege.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSystemPrivilege.RowTemplate.Height = 24;
            this.dgvSystemPrivilege.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemPrivilege.Size = new System.Drawing.Size(821, 401);
            this.dgvSystemPrivilege.TabIndex = 1;
            this.dgvSystemPrivilege.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystemPrivilege_CellContentClick_1);
            // 
            // tabSecurable
            // 
            this.tabSecurable.Controls.Add(this.dgvSecurable);
            this.tabSecurable.Location = new System.Drawing.Point(4, 29);
            this.tabSecurable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSecurable.Name = "tabSecurable";
            this.tabSecurable.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabSecurable.Size = new System.Drawing.Size(822, 408);
            this.tabSecurable.TabIndex = 3;
            this.tabSecurable.Text = "Securable";
            this.tabSecurable.UseVisualStyleBackColor = true;
            // 
            // dgvSecurable
            // 
            this.dgvSecurable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSecurable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableSecurable,
            this.colSelectSecurable,
            this.colUpdateSecurable,
            this.colInsertSecurable,
            this.colTabDelete,
            this.colTabRevoke});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSecurable.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSecurable.Location = new System.Drawing.Point(0, 0);
            this.dgvSecurable.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSecurable.Name = "dgvSecurable";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSecurable.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSecurable.RowHeadersVisible = false;
            this.dgvSecurable.RowHeadersWidth = 51;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvSecurable.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSecurable.RowTemplate.Height = 24;
            this.dgvSecurable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSecurable.Size = new System.Drawing.Size(821, 401);
            this.dgvSecurable.TabIndex = 2;
            this.dgvSecurable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecurable_CellContentClick_1);
            // 
            // colTableSecurable
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTableSecurable.DefaultCellStyle = dataGridViewCellStyle11;
            this.colTableSecurable.HeaderText = "Table";
            this.colTableSecurable.MinimumWidth = 6;
            this.colTableSecurable.Name = "colTableSecurable";
            this.colTableSecurable.ReadOnly = true;
            this.colTableSecurable.Width = 225;
            // 
            // colSelectSecurable
            // 
            this.colSelectSecurable.FalseValue = " ";
            this.colSelectSecurable.HeaderText = "Select";
            this.colSelectSecurable.MinimumWidth = 6;
            this.colSelectSecurable.Name = "colSelectSecurable";
            this.colSelectSecurable.ReadOnly = true;
            this.colSelectSecurable.TrueValue = "x";
            this.colSelectSecurable.Width = 125;
            // 
            // colUpdateSecurable
            // 
            this.colUpdateSecurable.FalseValue = " ";
            this.colUpdateSecurable.HeaderText = "Update";
            this.colUpdateSecurable.MinimumWidth = 6;
            this.colUpdateSecurable.Name = "colUpdateSecurable";
            this.colUpdateSecurable.ReadOnly = true;
            this.colUpdateSecurable.TrueValue = "x ";
            this.colUpdateSecurable.Width = 125;
            // 
            // colInsertSecurable
            // 
            this.colInsertSecurable.FalseValue = " ";
            this.colInsertSecurable.HeaderText = "Insert";
            this.colInsertSecurable.MinimumWidth = 6;
            this.colInsertSecurable.Name = "colInsertSecurable";
            this.colInsertSecurable.ReadOnly = true;
            this.colInsertSecurable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colInsertSecurable.TrueValue = "x";
            this.colInsertSecurable.Width = 125;
            // 
            // colTabDelete
            // 
            this.colTabDelete.HeaderText = "Delete";
            this.colTabDelete.MinimumWidth = 6;
            this.colTabDelete.Name = "colTabDelete";
            this.colTabDelete.TrueValue = "x";
            this.colTabDelete.Width = 125;
            // 
            // colTabRevoke
            // 
            this.colTabRevoke.HeaderText = "Revoke";
            this.colTabRevoke.MinimumWidth = 6;
            this.colTabRevoke.Name = "colTabRevoke";
            this.colTabRevoke.TrueValue = "x";
            this.colTabRevoke.Width = 125;
            // 
            // colPrivilege
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrivilege.DefaultCellStyle = dataGridViewCellStyle6;
            this.colPrivilege.HeaderText = "Privilege";
            this.colPrivilege.MinimumWidth = 6;
            this.colPrivilege.Name = "colPrivilege";
            this.colPrivilege.ReadOnly = true;
            this.colPrivilege.Width = 250;
            // 
            // colGrantPrevilege
            // 
            this.colGrantPrevilege.FalseValue = " ";
            this.colGrantPrevilege.HeaderText = "Grant";
            this.colGrantPrevilege.MinimumWidth = 6;
            this.colGrantPrevilege.Name = "colGrantPrevilege";
            this.colGrantPrevilege.ReadOnly = true;
            this.colGrantPrevilege.TrueValue = "x";
            this.colGrantPrevilege.Width = 125;
            // 
            // colWithAdminPrivilege
            // 
            this.colWithAdminPrivilege.FalseValue = " ";
            this.colWithAdminPrivilege.HeaderText = "With Admin";
            this.colWithAdminPrivilege.MinimumWidth = 6;
            this.colWithAdminPrivilege.Name = "colWithAdminPrivilege";
            this.colWithAdminPrivilege.ReadOnly = true;
            this.colWithAdminPrivilege.TrueValue = "x";
            this.colWithAdminPrivilege.Width = 125;
            // 
            // colRevokePrivilege
            // 
            this.colRevokePrivilege.FalseValue = " ";
            this.colRevokePrivilege.HeaderText = "Revoke";
            this.colRevokePrivilege.MinimumWidth = 6;
            this.colRevokePrivilege.Name = "colRevokePrivilege";
            this.colRevokePrivilege.ReadOnly = true;
            this.colRevokePrivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevokePrivilege.TrueValue = "x";
            this.colRevokePrivilege.Width = 125;
            // 
            // fEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabEditUser);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fEditRole";
            this.Text = "fEditRole";
            this.Load += new System.EventHandler(this.fEditRole_Load);
            this.tabEditUser.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
            this.tabSystemPrivilege.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemPrivilege)).EndInit();
            this.tabSecurable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabEditUser;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TabPage tabSystemPrivilege;
        private System.Windows.Forms.DataGridView dgvSystemPrivilege;
        private System.Windows.Forms.TabPage tabSecurable;
        private System.Windows.Forms.DataGridView dgvSecurable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdateSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsertSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTabDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTabRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantPrevilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdminPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevokePrivilege;
    }
}