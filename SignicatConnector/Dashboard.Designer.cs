namespace SignicatConnector
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.clientSecretTextBox = new System.Windows.Forms.TextBox();
            this.clientIdTextBox = new System.Windows.Forms.TextBox();
            this.clientSecretLabel = new System.Windows.Forms.Label();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitButton);
            this.groupBox1.Controls.Add(this.clientSecretTextBox);
            this.groupBox1.Controls.Add(this.clientIdTextBox);
            this.groupBox1.Controls.Add(this.clientSecretLabel);
            this.groupBox1.Controls.Add(this.clientIdLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(31, 158);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clientSecretTextBox
            // 
            this.clientSecretTextBox.Location = new System.Drawing.Point(31, 124);
            this.clientSecretTextBox.Name = "clientSecretTextBox";
            this.clientSecretTextBox.PasswordChar = '*';
            this.clientSecretTextBox.Size = new System.Drawing.Size(561, 27);
            this.clientSecretTextBox.TabIndex = 3;
            // 
            // clientIdTextBox
            // 
            this.clientIdTextBox.Location = new System.Drawing.Point(31, 63);
            this.clientIdTextBox.Name = "clientIdTextBox";
            this.clientIdTextBox.Size = new System.Drawing.Size(561, 27);
            this.clientIdTextBox.TabIndex = 2;
            // 
            // clientSecretLabel
            // 
            this.clientSecretLabel.AutoSize = true;
            this.clientSecretLabel.Location = new System.Drawing.Point(31, 99);
            this.clientSecretLabel.Name = "clientSecretLabel";
            this.clientSecretLabel.Size = new System.Drawing.Size(92, 20);
            this.clientSecretLabel.TabIndex = 1;
            this.clientSecretLabel.Text = "Client Secret";
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(31, 39);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(66, 20);
            this.clientIdLabel.TabIndex = 0;
            this.clientIdLabel.Text = "Client ID";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(43, 217);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(279, 20);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = "Something went wrong! Please try again!";
            this.errorLabel.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 264);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label clientSecretLabel;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.TextBox clientIdTextBox;
        private System.Windows.Forms.TextBox clientSecretTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label errorLabel;
    }
}

