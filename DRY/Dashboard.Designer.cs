namespace DRY
{
    partial class Dashboard
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.employeeIdText = new System.Windows.Forms.TextBox();
            this.generateEmployeeIDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(61, 63);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(61, 109);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Location = new System.Drawing.Point(61, 266);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIDLabel.TabIndex = 2;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(176, 56);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(393, 20);
            this.firstNameText.TabIndex = 3;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(176, 102);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(395, 20);
            this.lastNameText.TabIndex = 4;
            // 
            // employeeIdText
            // 
            this.employeeIdText.Location = new System.Drawing.Point(176, 259);
            this.employeeIdText.Name = "employeeIdText";
            this.employeeIdText.Size = new System.Drawing.Size(419, 20);
            this.employeeIdText.TabIndex = 5;
            // 
            // generateEmployeeIDButton
            // 
            this.generateEmployeeIDButton.Location = new System.Drawing.Point(220, 156);
            this.generateEmployeeIDButton.Name = "generateEmployeeIDButton";
            this.generateEmployeeIDButton.Size = new System.Drawing.Size(300, 64);
            this.generateEmployeeIDButton.TabIndex = 6;
            this.generateEmployeeIDButton.Text = "Generate Employee ID";
            this.generateEmployeeIDButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(767, 553);
            this.Controls.Add(this.generateEmployeeIDButton);
            this.Controls.Add(this.employeeIdText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.TextBox employeeIdText;
        private System.Windows.Forms.Button generateEmployeeIDButton;
    }
}

