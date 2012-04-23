namespace lol2
{
    partial class AddUser
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.userNameInfoLabel = new System.Windows.Forms.Label();
            this.passwordInfoLabel = new System.Windows.Forms.Label();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.roleLabel = new System.Windows.Forms.Label();
            this.rolesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.rolesTableAdapter();
            this.addUserButton = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.usersTableAdapter();
            this.verifyPasswordLabel = new System.Windows.Forms.Label();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(27, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(37, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Логін:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(134, 24);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(15, 16);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(15, 47);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(99, 13);
            this.repeatPasswordLabel.TabIndex = 3;
            this.repeatPasswordLabel.Text = "Повторіть пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(122, 13);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(163, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(122, 42);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(163, 20);
            this.repeatPasswordTextBox.TabIndex = 5;
            this.repeatPasswordTextBox.Leave += new System.EventHandler(this.repeatPasswordTextBox_Leave);
            // 
            // userNameInfoLabel
            // 
            this.userNameInfoLabel.AutoSize = true;
            this.userNameInfoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.userNameInfoLabel.Location = new System.Drawing.Point(316, 27);
            this.userNameInfoLabel.Name = "userNameInfoLabel";
            this.userNameInfoLabel.Size = new System.Drawing.Size(175, 39);
            this.userNameInfoLabel.TabIndex = 6;
            this.userNameInfoLabel.Text = "Логін повинен містити латинські \r\nчи українські букви та мати \r\nдовжину від 3 до " +
                "32 символів";
            // 
            // passwordInfoLabel
            // 
            this.passwordInfoLabel.AutoSize = true;
            this.passwordInfoLabel.ForeColor = System.Drawing.Color.Maroon;
            this.passwordInfoLabel.Location = new System.Drawing.Point(316, 112);
            this.passwordInfoLabel.Name = "passwordInfoLabel";
            this.passwordInfoLabel.Size = new System.Drawing.Size(164, 39);
            this.passwordInfoLabel.TabIndex = 7;
            this.passwordInfoLabel.Text = "Бажано, щоб пароль мав \r\nдовжину понад 6 символів \r\nта містив як букви, так і циф" +
                "ри";
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.DataSource = this.rolesBindingSource;
            this.rolesComboBox.DisplayMember = "role_name";
            this.rolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(134, 59);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(163, 21);
            this.rolesComboBox.TabIndex = 9;
            this.rolesComboBox.ValueMember = "role_id";
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(27, 62);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(42, 13);
            this.roleLabel.TabIndex = 8;
            this.roleLabel.Text = "Права:";
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(134, 203);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(163, 25);
            this.addUserButton.TabIndex = 10;
            this.addUserButton.Text = "Додати профіль";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // verifyPasswordLabel
            // 
            this.verifyPasswordLabel.AutoSize = true;
            this.verifyPasswordLabel.ForeColor = System.Drawing.Color.Green;
            this.verifyPasswordLabel.Location = new System.Drawing.Point(126, 72);
            this.verifyPasswordLabel.Name = "verifyPasswordLabel";
            this.verifyPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.verifyPasswordLabel.TabIndex = 11;
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.passwordLabel);
            this.passwordGroupBox.Controls.Add(this.verifyPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.repeatPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGroupBox.Controls.Add(this.repeatPasswordTextBox);
            this.passwordGroupBox.Location = new System.Drawing.Point(12, 96);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(298, 92);
            this.passwordGroupBox.TabIndex = 12;
            this.passwordGroupBox.TabStop = false;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 247);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.userNameInfoLabel);
            this.Controls.Add(this.passwordInfoLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додати профіль";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label userNameInfoLabel;
        private System.Windows.Forms.Label passwordInfoLabel;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Label roleLabel;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private tech_inspectorDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private tech_inspectorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label verifyPasswordLabel;
        private System.Windows.Forms.GroupBox passwordGroupBox;
    }
}