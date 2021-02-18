namespace w5_inclass1
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
            this.picCats = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).BeginInit();
            this.SuspendLayout();
            // 
            // picCats
            // 
            this.picCats.Image = global::w5_inclass1.Properties.Resources.kitty2;
            this.picCats.Location = new System.Drawing.Point(50, 76);
            this.picCats.Name = "picCats";
            this.picCats.Size = new System.Drawing.Size(308, 191);
            this.picCats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCats.TabIndex = 0;
            this.picCats.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(167, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 296);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picCats);
            this.Name = "Form1";
            this.Text = "Picture Gallery";
            ((System.ComponentModel.ISupportInitialize)(this.picCats)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCats;
        private System.Windows.Forms.Button btnNext;
    }
}

