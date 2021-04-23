namespace PhoneApp
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(41, 40);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(260, 22);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TabStop = false;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 16;
            this.lstNames.Location = new System.Drawing.Point(41, 86);
            this.lstNames.Margin = new System.Windows.Forms.Padding(4);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(260, 244);
            this.lstNames.TabIndex = 1;
            this.lstNames.SelectedIndexChanged += new System.EventHandler(this.lstNames_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mergeMenuItem,
            this.saveAsMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // mergeMenuItem
            // 
            this.mergeMenuItem.Name = "mergeMenuItem";
            this.mergeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mergeMenuItem.Text = "Merge";
            this.mergeMenuItem.Click += new System.EventHandler(this.mergeMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Enabled = false;
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsMenuItem.Text = "Save As..";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMenuItem,
            this.modifyMenuItem,
            this.removeMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editMenuItem.Text = "Edit";
            // 
            // insertMenuItem
            // 
            this.insertMenuItem.Name = "insertMenuItem";
            this.insertMenuItem.Size = new System.Drawing.Size(180, 22);
            this.insertMenuItem.Text = "Insert";
            this.insertMenuItem.Click += new System.EventHandler(this.insertMenuItem_Click);
            // 
            // modifyMenuItem
            // 
            this.modifyMenuItem.Enabled = false;
            this.modifyMenuItem.Name = "modifyMenuItem";
            this.modifyMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modifyMenuItem.Text = "Modify";
            this.modifyMenuItem.Click += new System.EventHandler(this.modifyMenuItem_Click);
            // 
            // removeMenuItem
            // 
            this.removeMenuItem.Enabled = false;
            this.removeMenuItem.Name = "removeMenuItem";
            this.removeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeMenuItem.Text = "Remove";
            this.removeMenuItem.Click += new System.EventHandler(this.removeMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 353);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Phone List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeMenuItem;
    }
}

