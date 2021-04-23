
namespace Bonus_Delegate
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
            this.btnLambda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLambda
            // 
            this.btnLambda.Location = new System.Drawing.Point(91, 76);
            this.btnLambda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLambda.Name = "btnLambda";
            this.btnLambda.Size = new System.Drawing.Size(172, 46);
            this.btnLambda.TabIndex = 0;
            this.btnLambda.Text = "Lambdas";
            this.btnLambda.UseVisualStyleBackColor = true;
            this.btnLambda.Click += new System.EventHandler(this.btnLambda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 215);
            this.Controls.Add(this.btnLambda);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Lambda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLambda;
    }
}

