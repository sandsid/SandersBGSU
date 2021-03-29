
namespace assingment3Sanders
{
    partial class Form2
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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.cboStartM = new System.Windows.Forms.ComboBox();
            this.cboStartH = new System.Windows.Forms.ComboBox();
            this.gpStop = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboStopM = new System.Windows.Forms.ComboBox();
            this.cboStopH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbStart.SuspendLayout();
            this.gpStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(18, 22);
            this.calendar.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.calendar.MinDate = new System.DateTime(2021, 3, 13, 0, 0, 0, 0);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            // 
            // gbStart
            // 
            this.gbStart.Controls.Add(this.label7);
            this.gbStart.Controls.Add(this.label4);
            this.gbStart.Controls.Add(this.lblHour);
            this.gbStart.Controls.Add(this.cboStartM);
            this.gbStart.Controls.Add(this.cboStartH);
            this.gbStart.Location = new System.Drawing.Point(269, 18);
            this.gbStart.Name = "gbStart";
            this.gbStart.Size = new System.Drawing.Size(200, 80);
            this.gbStart.TabIndex = 1;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Start Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minute";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(17, 31);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(37, 16);
            this.lblHour.TabIndex = 2;
            this.lblHour.Text = "Hour";
            // 
            // cboStartM
            // 
            this.cboStartM.FormattingEnabled = true;
            this.cboStartM.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cboStartM.Location = new System.Drawing.Point(115, 50);
            this.cboStartM.Name = "cboStartM";
            this.cboStartM.Size = new System.Drawing.Size(74, 24);
            this.cboStartM.TabIndex = 1;
            // 
            // cboStartH
            // 
            this.cboStartH.FormattingEnabled = true;
            this.cboStartH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboStartH.Location = new System.Drawing.Point(17, 50);
            this.cboStartH.Name = "cboStartH";
            this.cboStartH.Size = new System.Drawing.Size(74, 24);
            this.cboStartH.TabIndex = 0;
            // 
            // gpStop
            // 
            this.gpStop.Controls.Add(this.label8);
            this.gpStop.Controls.Add(this.label6);
            this.gpStop.Controls.Add(this.label5);
            this.gpStop.Controls.Add(this.cboStopM);
            this.gpStop.Controls.Add(this.cboStopH);
            this.gpStop.Location = new System.Drawing.Point(269, 104);
            this.gpStop.Name = "gpStop";
            this.gpStop.Size = new System.Drawing.Size(200, 80);
            this.gpStop.TabIndex = 2;
            this.gpStop.TabStop = false;
            this.gpStop.Text = "Stop Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Minute";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hour";
            // 
            // cboStopM
            // 
            this.cboStopM.FormattingEnabled = true;
            this.cboStopM.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cboStopM.Location = new System.Drawing.Point(115, 50);
            this.cboStopM.Name = "cboStopM";
            this.cboStopM.Size = new System.Drawing.Size(74, 24);
            this.cboStopM.TabIndex = 3;
            // 
            // cboStopH
            // 
            this.cboStopH.FormattingEnabled = true;
            this.cboStopH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cboStopH.Location = new System.Drawing.Point(17, 50);
            this.cboStopH.Name = "cboStopH";
            this.cboStopH.Size = new System.Drawing.Size(74, 24);
            this.cboStopH.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Event Description";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(18, 216);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(451, 22);
            this.txtEventTitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "&Event Description";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(18, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 254);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 29);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 295);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEventTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpStop);
            this.Controls.Add(this.gbStart);
            this.Controls.Add(this.calendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbStart.ResumeLayout(false);
            this.gbStart.PerformLayout();
            this.gpStop.ResumeLayout(false);
            this.gpStop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.ComboBox cboStartM;
        private System.Windows.Forms.ComboBox cboStartH;
        private System.Windows.Forms.GroupBox gpStop;
        private System.Windows.Forms.ComboBox cboStopM;
        private System.Windows.Forms.ComboBox cboStopH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}