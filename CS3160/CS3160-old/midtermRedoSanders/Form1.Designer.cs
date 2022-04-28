namespace midtermRedoSanders
{
    partial class Form1
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
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAvgSal = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAvgSalary = new System.Windows.Forms.TextBox();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 31;
            this.lstEmployee.Location = new System.Drawing.Point(49, 59);
            this.lstEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(296, 438);
            this.lstEmployee.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(391, 60);
            this.lblSalary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(99, 31);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(401, 162);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(89, 31);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblAvgSal
            // 
            this.lblAvgSal.AutoSize = true;
            this.lblAvgSal.Location = new System.Drawing.Point(401, 288);
            this.lblAvgSal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvgSal.Name = "lblAvgSal";
            this.lblAvgSal.Size = new System.Drawing.Size(146, 31);
            this.lblAvgSal.TabIndex = 3;
            this.lblAvgSal.Text = "AvgSalary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(509, 57);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(314, 38);
            this.txtSalary.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(509, 159);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(314, 38);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAvgSalary
            // 
            this.txtAvgSalary.Location = new System.Drawing.Point(555, 285);
            this.txtAvgSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAvgSalary.Name = "txtAvgSalary";
            this.txtAvgSalary.Size = new System.Drawing.Size(271, 38);
            this.txtAvgSalary.TabIndex = 6;
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(386, 439);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(211, 56);
            this.btnAddEmp.TabIndex = 7;
            this.btnAddEmp.Text = "&Add Employee";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(641, 439);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 56);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 540);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.txtAvgSalary);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblAvgSal);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lstEmployee);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Employee App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEmployee;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAvgSal;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAvgSalary;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnExit;
    }
}

