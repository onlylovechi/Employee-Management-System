namespace PHANQUYENADMIN
{
    partial class fEditUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEditUser = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabRole = new System.Windows.Forms.TabPage();
            this.dgvtabRole = new System.Windows.Forms.DataGridView();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrant = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdmin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSystemPrivilege = new System.Windows.Forms.TabPage();
            this.dgvTabSystemPrivilege = new System.Windows.Forms.DataGridView();
            this.colPrivilege = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGrantPrevilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colWithAdminPrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colRevokePrivilege = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabSecurable = new System.Windows.Forms.TabPage();
            this.dgvTabSecurable = new System.Windows.Forms.DataGridView();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.colTableSecurable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSelectSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUpdateSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colInsertSecurable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTabRevoke = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabEditUser.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.tabRole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabRole)).BeginInit();
            this.tabSystemPrivilege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSystemPrivilege)).BeginInit();
            this.tabSecurable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSecurable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditUser
            // 
            this.tabEditUser.Controls.Add(this.tabUser);
            this.tabEditUser.Controls.Add(this.tabRole);
            this.tabEditUser.Controls.Add(this.tabSystemPrivilege);
            this.tabEditUser.Controls.Add(this.tabSecurable);
            this.tabEditUser.Location = new System.Drawing.Point(40, 32);
            this.tabEditUser.Name = "tabEditUser";
            this.tabEditUser.SelectedIndex = 0;
            this.tabEditUser.Size = new System.Drawing.Size(738, 353);
            this.tabEditUser.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.txtConfirmPassword);
            this.tabUser.Controls.Add(this.txtPassword);
            this.tabUser.Controls.Add(this.label4);
            this.tabUser.Controls.Add(this.label3);
            this.tabUser.Controls.Add(this.label2);
            this.tabUser.Controls.Add(this.label1);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(730, 324);
            this.tabUser.TabIndex = 0;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            this.tabUser.Click += new System.EventHandler(this.tabUser_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(171, 151);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(188, 22);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(188, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "N\\A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // tabRole
            // 
            this.tabRole.Controls.Add(this.dgvtabRole);
            this.tabRole.Location = new System.Drawing.Point(4, 25);
            this.tabRole.Name = "tabRole";
            this.tabRole.Padding = new System.Windows.Forms.Padding(3);
            this.tabRole.Size = new System.Drawing.Size(730, 324);
            this.tabRole.TabIndex = 1;
            this.tabRole.Text = "Role";
            this.tabRole.UseVisualStyleBackColor = true;
            // 
            // dgvtabRole
            // 
            this.dgvtabRole.AllowUserToAddRows = false;
            this.dgvtabRole.AllowUserToDeleteRows = false;
            this.dgvtabRole.AllowUserToResizeColumns = false;
            this.dgvtabRole.AllowUserToResizeRows = false;
            this.dgvtabRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtabRole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtabRole.ColumnHeadersHeight = 29;
            this.dgvtabRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvtabRole.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRole,
            this.colGrant,
            this.colWithAdmin,
            this.colRevoke});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtabRole.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtabRole.Location = new System.Drawing.Point(0, 0);
            this.dgvtabRole.MultiSelect = false;
            this.dgvtabRole.Name = "dgvtabRole";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtabRole.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtabRole.RowHeadersVisible = false;
            this.dgvtabRole.RowHeadersWidth = 51;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.dgvtabRole.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtabRole.RowTemplate.Height = 24;
            this.dgvtabRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtabRole.Size = new System.Drawing.Size(730, 321);
            this.dgvtabRole.TabIndex = 0;
            this.dgvtabRole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtabRole_CellContentClick);
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
            this.tabSystemPrivilege.Controls.Add(this.dgvTabSystemPrivilege);
            this.tabSystemPrivilege.Location = new System.Drawing.Point(4, 25);
            this.tabSystemPrivilege.Name = "tabSystemPrivilege";
            this.tabSystemPrivilege.Padding = new System.Windows.Forms.Padding(3);
            this.tabSystemPrivilege.Size = new System.Drawing.Size(730, 324);
            this.tabSystemPrivilege.TabIndex = 2;
            this.tabSystemPrivilege.Text = "System Privilege";
            this.tabSystemPrivilege.UseVisualStyleBackColor = true;
            // 
            // dgvTabSystemPrivilege
            // 
            this.dgvTabSystemPrivilege.AllowUserToAddRows = false;
            this.dgvTabSystemPrivilege.AllowUserToDeleteRows = false;
            this.dgvTabSystemPrivilege.AllowUserToResizeColumns = false;
            this.dgvTabSystemPrivilege.AllowUserToResizeRows = false;
            this.dgvTabSystemPrivilege.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabSystemPrivilege.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTabSystemPrivilege.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabSystemPrivilege.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPrivilege,
            this.colGrantPrevilege,
            this.colWithAdminPrivilege,
            this.colRevokePrivilege});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabSystemPrivilege.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTabSystemPrivilege.Location = new System.Drawing.Point(0, 2);
            this.dgvTabSystemPrivilege.Name = "dgvTabSystemPrivilege";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabSystemPrivilege.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTabSystemPrivilege.RowHeadersVisible = false;
            this.dgvTabSystemPrivilege.RowHeadersWidth = 51;
            this.dgvTabSystemPrivilege.RowTemplate.Height = 24;
            this.dgvTabSystemPrivilege.Size = new System.Drawing.Size(730, 321);
            this.dgvTabSystemPrivilege.TabIndex = 1;
            this.dgvTabSystemPrivilege.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabSystemPrivilege_CellContentClick);
            // 
            // colPrivilege
            // 
            this.colPrivilege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colPrivilege.DefaultCellStyle = dataGridViewCellStyle7;
            this.colPrivilege.HeaderText = "Privilege";
            this.colPrivilege.MinimumWidth = 6;
            this.colPrivilege.Name = "colPrivilege";
            this.colPrivilege.ReadOnly = true;
            this.colPrivilege.Width = 350;
            // 
            // colGrantPrevilege
            // 
            this.colGrantPrevilege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGrantPrevilege.HeaderText = "Grant";
            this.colGrantPrevilege.MinimumWidth = 6;
            this.colGrantPrevilege.Name = "colGrantPrevilege";
            this.colGrantPrevilege.ReadOnly = true;
            this.colGrantPrevilege.TrueValue = "x";
            this.colGrantPrevilege.Width = 125;
            // 
            // colWithAdminPrivilege
            // 
            this.colWithAdminPrivilege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colWithAdminPrivilege.HeaderText = "With Admin";
            this.colWithAdminPrivilege.MinimumWidth = 6;
            this.colWithAdminPrivilege.Name = "colWithAdminPrivilege";
            this.colWithAdminPrivilege.ReadOnly = true;
            this.colWithAdminPrivilege.TrueValue = "x";
            this.colWithAdminPrivilege.Width = 125;
            // 
            // colRevokePrivilege
            // 
            this.colRevokePrivilege.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRevokePrivilege.HeaderText = "Revoke";
            this.colRevokePrivilege.MinimumWidth = 6;
            this.colRevokePrivilege.Name = "colRevokePrivilege";
            this.colRevokePrivilege.ReadOnly = true;
            this.colRevokePrivilege.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRevokePrivilege.TrueValue = "x";
            this.colRevokePrivilege.Width = 125;
            // 
            // tabSecurable
            // 
            this.tabSecurable.Controls.Add(this.dgvTabSecurable);
            this.tabSecurable.Location = new System.Drawing.Point(4, 25);
            this.tabSecurable.Name = "tabSecurable";
            this.tabSecurable.Padding = new System.Windows.Forms.Padding(3);
            this.tabSecurable.Size = new System.Drawing.Size(730, 324);
            this.tabSecurable.TabIndex = 3;
            this.tabSecurable.Text = "Securable";
            this.tabSecurable.UseVisualStyleBackColor = true;
            // 
            // dgvTabSecurable
            // 
            this.dgvTabSecurable.AllowUserToAddRows = false;
            this.dgvTabSecurable.AllowUserToDeleteRows = false;
            this.dgvTabSecurable.AllowUserToResizeColumns = false;
            this.dgvTabSecurable.AllowUserToResizeRows = false;
            this.dgvTabSecurable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabSecurable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTabSecurable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabSecurable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTableSecurable,
            this.colSelectSecurable,
            this.colUpdateSecurable,
            this.colInsertSecurable,
            this.colDelete,
            this.colTabRevoke});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabSecurable.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTabSecurable.Location = new System.Drawing.Point(0, 0);
            this.dgvTabSecurable.Name = "dgvTabSecurable";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabSecurable.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTabSecurable.RowHeadersVisible = false;
            this.dgvTabSecurable.RowHeadersWidth = 51;
            this.dgvTabSecurable.RowTemplate.Height = 24;
            this.dgvTabSecurable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabSecurable.Size = new System.Drawing.Size(730, 321);
            this.dgvTabSecurable.TabIndex = 2;
            this.dgvTabSecurable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTabSecurable_CellContentClick);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(532, 391);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(91, 33);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(668, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.colUpdateSecurable.TrueValue = "x";
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
            // colDelete
            // 
            this.colDelete.FalseValue = " ";
            this.colDelete.HeaderText = "Delete";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colDelete.TrueValue = "x";
            this.colDelete.Width = 125;
            // 
            // colTabRevoke
            // 
            this.colTabRevoke.FalseValue = " ";
            this.colTabRevoke.HeaderText = "Revoke";
            this.colTabRevoke.MinimumWidth = 6;
            this.colTabRevoke.Name = "colTabRevoke";
            this.colTabRevoke.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTabRevoke.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTabRevoke.TrueValue = "x";
            this.colTabRevoke.Width = 125;
            // 
            // fEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabEditUser);
            this.Name = "fEditUser";
            this.Text = "fEditUser";
            this.Load += new System.EventHandler(this.fEditUser_Load);
            this.tabEditUser.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.tabRole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtabRole)).EndInit();
            this.tabSystemPrivilege.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSystemPrivilege)).EndInit();
            this.tabSecurable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabSecurable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEditUser;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabRole;
        private System.Windows.Forms.TabPage tabSystemPrivilege;
        private System.Windows.Forms.TabPage tabSecurable;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvtabRole;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvTabSystemPrivilege;
        private System.Windows.Forms.DataGridView dgvTabSecurable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrantPrevilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdminPrivilege;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevokePrivilege;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGrant;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colWithAdmin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRevoke;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTableSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelectSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUpdateSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInsertSecurable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colDelete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTabRevoke;
    }
}