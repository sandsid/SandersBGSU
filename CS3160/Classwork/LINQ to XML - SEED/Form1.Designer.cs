namespace LINQ_to_XML
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
            this.btnRawXML = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnHomePhone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmtHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRawXML
            // 
            this.btnRawXML.Location = new System.Drawing.Point(25, 152);
            this.btnRawXML.Name = "btnRawXML";
            this.btnRawXML.Size = new System.Drawing.Size(120, 23);
            this.btnRawXML.TabIndex = 0;
            this.btnRawXML.Text = "Raw XML";
            this.btnRawXML.UseVisualStyleBackColor = true;
            this.btnRawXML.Click += new System.EventHandler(this.btnRawXML_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(25, 25);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(621, 108);
            this.lstDisplay.TabIndex = 1;
            // 
            // btnHomePhone
            // 
            this.btnHomePhone.Location = new System.Drawing.Point(168, 152);
            this.btnHomePhone.Name = "btnHomePhone";
            this.btnHomePhone.Size = new System.Drawing.Size(120, 23);
            this.btnHomePhone.TabIndex = 2;
            this.btnHomePhone.Text = "Female Names";
            this.btnHomePhone.UseVisualStyleBackColor = true;
            this.btnHomePhone.Click += new System.EventHandler(this.btnFemales_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "City Alta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cmtHome
            // 
            this.cmtHome.Location = new System.Drawing.Point(455, 152);
            this.cmtHome.Name = "cmtHome";
            this.cmtHome.Size = new System.Drawing.Size(150, 23);
            this.cmtHome.TabIndex = 4;
            this.cmtHome.Text = "Home Phone Numbers";
            this.cmtHome.UseVisualStyleBackColor = true;
            this.cmtHome.Click += new System.EventHandler(this.cmtHome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 202);
            this.Controls.Add(this.cmtHome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHomePhone);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.btnRawXML);
            this.Name = "Form1";
            this.Text = "LINQ to XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRawXML;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnHomePhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmtHome;
    }
}

