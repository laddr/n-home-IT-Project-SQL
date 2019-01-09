namespace nHomeIT.Tests.EmployeeSystem.WinForms
{
    partial class DashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Access Level";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(169, 85);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(136, 20);
            this.lblEmployeeID.TabIndex = 4;
            this.lblEmployeeID.Text = "{ EMPLOYEE ID }";
            this.lblEmployeeID.Click += new System.EventHandler(this.lblEmployeeID_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(169, 126);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(117, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "{ FULL NAME }";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(169, 167);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(149, 20);
            this.lblDateOfBirth.TabIndex = 6;
            this.lblDateOfBirth.Text = "{ DATE OF BIRTH }";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Location = new System.Drawing.Point(169, 208);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(148, 20);
            this.lblAccessLevel.TabIndex = 7;
            this.lblAccessLevel.Text = "{ ACCESS LEVEL }";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(396, 374);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(18, 57, 18, 19);
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblAccessLevel;
       


    }
}
