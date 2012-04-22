namespace lol2
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.userTable = new System.Windows.Forms.DataGridView();
            this.userlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.filterGroupBox = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.user_listTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.user_listTableAdapter();
            this.rolesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.rolesTableAdapter();
            this.editUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.filterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // userTable
            // 
            this.userTable.AllowUserToAddRows = false;
            this.userTable.AllowUserToDeleteRows = false;
            this.userTable.AllowUserToOrderColumns = true;
            this.userTable.AutoGenerateColumns = false;
            this.userTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.roleid,
            this.username,
            this.rolename});
            this.userTable.DataSource = this.userlistBindingSource;
            this.userTable.Location = new System.Drawing.Point(38, 118);
            this.userTable.Name = "userTable";
            this.userTable.ReadOnly = true;
            this.userTable.Size = new System.Drawing.Size(543, 300);
            this.userTable.TabIndex = 0;
            // 
            // userlistBindingSource
            // 
            this.userlistBindingSource.DataMember = "user_list";
            this.userlistBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filterGroupBox
            // 
            this.filterGroupBox.Controls.Add(this.refreshButton);
            this.filterGroupBox.Controls.Add(this.rolesComboBox);
            this.filterGroupBox.Controls.Add(this.roleLabel);
            this.filterGroupBox.Controls.Add(this.userNameTextBox);
            this.filterGroupBox.Controls.Add(this.userNameLabel);
            this.filterGroupBox.Location = new System.Drawing.Point(38, 27);
            this.filterGroupBox.Name = "filterGroupBox";
            this.filterGroupBox.Size = new System.Drawing.Size(543, 72);
            this.filterGroupBox.TabIndex = 1;
            this.filterGroupBox.TabStop = false;
            this.filterGroupBox.Text = "Фільтри";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(323, 16);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(164, 50);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Обновити";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.DataSource = this.rolesBindingSource;
            this.rolesComboBox.DisplayMember = "role_name";
            this.rolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(98, 45);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(159, 21);
            this.rolesComboBox.TabIndex = 3;
            this.rolesComboBox.ValueMember = "role_id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(46, 48);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(42, 13);
            this.roleLabel.TabIndex = 2;
            this.roleLabel.Text = "Права:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(98, 16);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(46, 23);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(37, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Логін:";
            // 
            // user_listTableAdapter
            // 
            this.user_listTableAdapter.ClearBeforeFill = true;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // editUserButton
            // 
            this.editUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editUserButton.Location = new System.Drawing.Point(72, 442);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(143, 33);
            this.editUserButton.TabIndex = 8;
            this.editUserButton.Text = "Редагувати профіль";
            this.editUserButton.UseVisualStyleBackColor = true;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteUserButton.Location = new System.Drawing.Point(426, 442);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(143, 33);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Видалити профіль";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addUserButton.Location = new System.Drawing.Point(250, 442);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(143, 33);
            this.addUserButton.TabIndex = 6;
            this.addUserButton.Text = "Додати профіль";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userid
            // 
            this.userid.DataPropertyName = "user_id";
            this.userid.HeaderText = "user_id";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            this.userid.Visible = false;
            // 
            // roleid
            // 
            this.roleid.DataPropertyName = "role_id";
            this.roleid.HeaderText = "role_id";
            this.roleid.Name = "roleid";
            this.roleid.ReadOnly = true;
            this.roleid.Visible = false;
            // 
            // username
            // 
            this.username.DataPropertyName = "user_name";
            this.username.HeaderText = "Логін";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // rolename
            // 
            this.rolename.DataPropertyName = "role_name";
            this.rolename.HeaderText = "Права";
            this.rolename.Name = "rolename";
            this.rolename.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 578);
            this.Controls.Add(this.editUserButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.filterGroupBox);
            this.Controls.Add(this.userTable);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.filterGroupBox.ResumeLayout(false);
            this.filterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView userTable;
        private System.Windows.Forms.GroupBox filterGroupBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Button refreshButton;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource userlistBindingSource;
        private tech_inspectorDataSetTableAdapters.user_listTableAdapter user_listTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private tech_inspectorDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolename;
    }
}