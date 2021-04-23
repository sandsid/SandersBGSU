
namespace Lab6
{
    partial class FieldExceptionForm
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblFied = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtField = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(21, 29);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 16);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // lblFied
            // 
            this.lblFied.AutoSize = true;
            this.lblFied.Location = new System.Drawing.Point(21, 78);
            this.lblFied.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFied.Name = "lblFied";
            this.lblFied.Size = new System.Drawing.Size(38, 16);
            this.lblFied.TabIndex = 1;
            this.lblFied.Text = "Field";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(21, 131);
            this.lblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(43, 16);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(97, 29);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(287, 22);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TabStop = false;
            // 
            // txtField
            // 
            this.txtField.Enabled = false;
            this.txtField.Location = new System.Drawing.Point(97, 72);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(287, 22);
            this.txtField.TabIndex = 4;
            this.txtField.TabStop = false;
            // 
            // txtValue
            // 
            this.txtValue.Enabled = false;
            this.txtValue.Location = new System.Drawing.Point(97, 125);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(287, 22);
            this.txtValue.TabIndex = 5;
            this.txtValue.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(176, 165);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(116, 31);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FieldExceptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 215);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblFied);
            this.Controls.Add(this.lblMessage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FieldExceptionForm";
            this.Text = "FieldExceptionForm";
            this.Load += new System.EventHandler(this.FieldExceptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblFied;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnOk;
    }
}