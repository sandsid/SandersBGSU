namespace bonuslab4
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
            this.txtBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.lstBoxPhone = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxPhoneNum
            // 
            this.txtBoxPhoneNum.Location = new System.Drawing.Point(36, 42);
            this.txtBoxPhoneNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPhoneNum.Name = "txtBoxPhoneNum";
            this.txtBoxPhoneNum.ReadOnly = true;
            this.txtBoxPhoneNum.Size = new System.Drawing.Size(506, 38);
            this.txtBoxPhoneNum.TabIndex = 0;
            // 
            // lstBoxPhone
            // 
            this.lstBoxPhone.FormattingEnabled = true;
            this.lstBoxPhone.ItemHeight = 31;
            this.lstBoxPhone.Location = new System.Drawing.Point(36, 117);
            this.lstBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxPhone.Name = "lstBoxPhone";
            this.lstBoxPhone.Size = new System.Drawing.Size(506, 252);
            this.lstBoxPhone.TabIndex = 1;
            this.lstBoxPhone.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(36, 417);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(189, 58);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(309, 417);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(233, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 518);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstBoxPhone);
            this.Controls.Add(this.txtBoxPhoneNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Phone List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPhoneNum;
        private System.Windows.Forms.ListBox lstBoxPhone;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
    }
}

