﻿namespace lol2
{
    partial class EditUser
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
            this.verifyPasswordLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.rolesComboBox = new System.Windows.Forms.ComboBox();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.roleLabel = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.verifyOldPassLabel = new System.Windows.Forms.Label();
            this.oldPassLabel = new System.Windows.Forms.Label();
            this.oldPassTextBox = new System.Windows.Forms.TextBox();
            this.rolesTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.rolesTableAdapter();
            this.usersTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.passwordGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // verifyPasswordLabel
            // 
            this.verifyPasswordLabel.AutoSize = true;
            this.verifyPasswordLabel.ForeColor = System.Drawing.Color.Green;
            this.verifyPasswordLabel.Location = new System.Drawing.Point(145, 138);
            this.verifyPasswordLabel.Name = "verifyPasswordLabel";
            this.verifyPasswordLabel.Size = new System.Drawing.Size(0, 13);
            this.verifyPasswordLabel.TabIndex = 23;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(99, 269);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(149, 37);
            this.addUserButton.TabIndex = 22;
            this.addUserButton.Text = "Зберегти зміни";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // rolesComboBox
            // 
            this.rolesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "role_id", true));
            this.rolesComboBox.DataSource = this.rolesBindingSource;
            this.rolesComboBox.DisplayMember = "role_name";
            this.rolesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rolesComboBox.FormattingEnabled = true;
            this.rolesComboBox.Location = new System.Drawing.Point(153, 230);
            this.rolesComboBox.Name = "rolesComboBox";
            this.rolesComboBox.Size = new System.Drawing.Size(163, 21);
            this.rolesComboBox.TabIndex = 21;
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
            this.roleLabel.Location = new System.Drawing.Point(17, 230);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(42, 13);
            this.roleLabel.TabIndex = 20;
            this.roleLabel.Text = "Права:";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(141, 108);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.PasswordChar = '*';
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(163, 20);
            this.repeatPasswordTextBox.TabIndex = 17;
            this.repeatPasswordTextBox.Leave += new System.EventHandler(this.repeatPasswordTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(141, 71);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(163, 20);
            this.passwordTextBox.TabIndex = 16;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(5, 111);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(132, 13);
            this.repeatPasswordLabel.TabIndex = 15;
            this.repeatPasswordLabel.Text = "Повторіть новий пароль:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(5, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(81, 13);
            this.passwordLabel.TabIndex = 14;
            this.passwordLabel.Text = "Новий пароль:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_name", true));
            this.userNameTextBox.Location = new System.Drawing.Point(153, 23);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.userNameTextBox.TabIndex = 13;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(17, 26);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(37, 13);
            this.userNameLabel.TabIndex = 12;
            this.userNameLabel.Text = "Логін:";
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.verifyOldPassLabel);
            this.passwordGroupBox.Controls.Add(this.oldPassLabel);
            this.passwordGroupBox.Controls.Add(this.oldPassTextBox);
            this.passwordGroupBox.Controls.Add(this.passwordLabel);
            this.passwordGroupBox.Controls.Add(this.verifyPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.repeatPasswordLabel);
            this.passwordGroupBox.Controls.Add(this.passwordTextBox);
            this.passwordGroupBox.Controls.Add(this.repeatPasswordTextBox);
            this.passwordGroupBox.Location = new System.Drawing.Point(12, 49);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(333, 167);
            this.passwordGroupBox.TabIndex = 24;
            this.passwordGroupBox.TabStop = false;
            this.passwordGroupBox.Text = "Змінити пароль";
            // 
            // verifyOldPassLabel
            // 
            this.verifyOldPassLabel.AutoSize = true;
            this.verifyOldPassLabel.ForeColor = System.Drawing.Color.Green;
            this.verifyOldPassLabel.Location = new System.Drawing.Point(145, 49);
            this.verifyOldPassLabel.Name = "verifyOldPassLabel";
            this.verifyOldPassLabel.Size = new System.Drawing.Size(0, 13);
            this.verifyOldPassLabel.TabIndex = 26;
            // 
            // oldPassLabel
            // 
            this.oldPassLabel.AutoSize = true;
            this.oldPassLabel.Location = new System.Drawing.Point(5, 25);
            this.oldPassLabel.Name = "oldPassLabel";
            this.oldPassLabel.Size = new System.Drawing.Size(85, 13);
            this.oldPassLabel.TabIndex = 24;
            this.oldPassLabel.Text = "Старий пароль:";
            // 
            // oldPassTextBox
            // 
            this.oldPassTextBox.Location = new System.Drawing.Point(141, 22);
            this.oldPassTextBox.Name = "oldPassTextBox";
            this.oldPassTextBox.PasswordChar = '*';
            this.oldPassTextBox.Size = new System.Drawing.Size(163, 20);
            this.oldPassTextBox.TabIndex = 25;
            this.oldPassTextBox.Leave += new System.EventHandler(this.oldPassTextBox_Leave);
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 328);
            this.Controls.Add(this.passwordGroupBox);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.rolesComboBox);
            this.Controls.Add(this.roleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редагувати профіль";
            this.Load += new System.EventHandler(this.EditUsercs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verifyPasswordLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.ComboBox rolesComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.Label oldPassLabel;
        private System.Windows.Forms.TextBox oldPassTextBox;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private tech_inspectorDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private tech_inspectorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label verifyOldPassLabel;
    }
}