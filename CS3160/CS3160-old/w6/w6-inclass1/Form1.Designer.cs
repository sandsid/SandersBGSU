namespace w6_inclass1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.txtEstimate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drop Off Date";
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.Location = new System.Drawing.Point(110, 158);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(406, 31);
            this.dtpCalendar.TabIndex = 1;
            this.dtpCalendar.ValueChanged += new System.EventHandler(this.dtpCalendar_ValueChanged);
            // 
            // lblEstimate
            // 
            this.lblEstimate.AutoSize = true;
            this.lblEstimate.Location = new System.Drawing.Point(110, 268);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(242, 25);
            this.lblEstimate.TabIndex = 2;
            this.lblEstimate.Text = "Estimated Delivery Date";
            // 
            // txtEstimate
            // 
            this.txtEstimate.Enabled = false;
            this.txtEstimate.Location = new System.Drawing.Point(110, 334);
            this.txtEstimate.Name = "txtEstimate";
            this.txtEstimate.Size = new System.Drawing.Size(406, 31);
            this.txtEstimate.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 480);
            this.Controls.Add(this.txtEstimate);
            this.Controls.Add(this.lblEstimate);
            this.Controls.Add(this.dtpCalendar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.TextBox txtEstimate;
    }
}

