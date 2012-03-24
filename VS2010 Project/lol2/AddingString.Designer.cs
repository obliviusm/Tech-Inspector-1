namespace lol2
{
    partial class AddingString
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
            this.parameterTextBox = new System.Windows.Forms.TextBox();
            this.addParameterButton = new System.Windows.Forms.Button();
            this.cancelOperationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parameterTextBox
            // 
            this.parameterTextBox.Location = new System.Drawing.Point(4, 9);
            this.parameterTextBox.Name = "parameterTextBox";
            this.parameterTextBox.Size = new System.Drawing.Size(244, 20);
            this.parameterTextBox.TabIndex = 0;
            // 
            // addParameterButton
            // 
            this.addParameterButton.Location = new System.Drawing.Point(254, 6);
            this.addParameterButton.Name = "addParameterButton";
            this.addParameterButton.Size = new System.Drawing.Size(75, 23);
            this.addParameterButton.TabIndex = 1;
            this.addParameterButton.Text = "Додати";
            this.addParameterButton.UseVisualStyleBackColor = true;
            this.addParameterButton.Click += new System.EventHandler(this.addParameterButton_Click);
            // 
            // cancelOperationButton
            // 
            this.cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelOperationButton.Location = new System.Drawing.Point(335, 6);
            this.cancelOperationButton.Name = "cancelOperationButton";
            this.cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelOperationButton.TabIndex = 2;
            this.cancelOperationButton.Text = "Відміна";
            this.cancelOperationButton.UseVisualStyleBackColor = true;
            this.cancelOperationButton.Click += new System.EventHandler(this.cancelOperationButton_Click);
            // 
            // AddingString
            // 
            this.AcceptButton = this.addParameterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.CancelButton = this.cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(422, 36);
            this.Controls.Add(this.cancelOperationButton);
            this.Controls.Add(this.addParameterButton);
            this.Controls.Add(this.parameterTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddingString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox parameterTextBox;
        private System.Windows.Forms.Button addParameterButton;
        private System.Windows.Forms.Button cancelOperationButton;
    }
}