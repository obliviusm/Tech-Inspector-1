namespace lol2
{
    partial class LoginForm
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.inButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tech_inspectorDataSet = new lol2.tech_inspectorDataSet();
            this.usersTableAdapter = new lol2.tech_inspectorDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userNameLabel.Location = new System.Drawing.Point(31, 38);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(57, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Логін :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.passwordLabel.Location = new System.Drawing.Point(31, 112);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Пароль :";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.Silver;
            this.userNameTextBox.Location = new System.Drawing.Point(35, 76);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.Tag = "noPas";
            this.userNameTextBox.Text = "Введіть...";
            this.userNameTextBox.Click += new System.EventHandler(this.userNameTextBox_Click);
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Silver;
            this.passwordTextBox.Location = new System.Drawing.Point(35, 145);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.Tag = "noPas";
            this.passwordTextBox.Text = "Введіть";
            this.passwordTextBox.Click += new System.EventHandler(this.passwordTextBox_Click);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // inButton
            // 
            this.inButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.inButton.Location = new System.Drawing.Point(12, 206);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(114, 33);
            this.inButton.TabIndex = 4;
            this.inButton.Text = "Вхід";
            this.inButton.UseVisualStyleBackColor = true;
            this.inButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outButton
            // 
            this.outButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.outButton.Location = new System.Drawing.Point(132, 206);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(114, 33);
            this.outButton.TabIndex = 5;
            this.outButton.Text = "Вихід";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.tech_inspectorDataSet;
            // 
            // tech_inspectorDataSet
            // 
            this.tech_inspectorDataSet.DataSetName = "tech_inspectorDataSet";
            this.tech_inspectorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.inButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 261);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.inButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизація";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tech_inspectorDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button inButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private tech_inspectorDataSet tech_inspectorDataSet;
        private tech_inspectorDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}