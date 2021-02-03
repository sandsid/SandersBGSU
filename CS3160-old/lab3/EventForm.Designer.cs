namespace lab3
{
    partial class EventForm
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
            this.mthCal = new System.Windows.Forms.MonthCalendar();
            this.lblStart = new System.Windows.Forms.Label();
            this.cmbSHour = new System.Windows.Forms.ComboBox();
            this.lblcolon1 = new System.Windows.Forms.Label();
            this.cmbSMinute = new System.Windows.Forms.ComboBox();
            this.cmbSAMPM = new System.Windows.Forms.ComboBox();
            this.lblStop = new System.Windows.Forms.Label();
            this.cmbEHour = new System.Windows.Forms.ComboBox();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.cmbEMinute = new System.Windows.Forms.ComboBox();
            this.cmbEAMPM = new System.Windows.Forms.ComboBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mthCal
            // 
            this.mthCal.Location = new System.Drawing.Point(33, 52);
            this.mthCal.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mthCal.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.mthCal.MinDate = new System.DateTime(2020, 3, 17, 0, 0, 0, 0);
            this.mthCal.Name = "mthCal";
            this.mthCal.TabIndex = 0;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(604, 79);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(139, 31);
            this.lblStart.TabIndex = 1;
            this.lblStart.Text = "Start Time";
            // 
            // cmbSHour
            // 
            this.cmbSHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSHour.FormattingEnabled = true;
            this.cmbSHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbSHour.Location = new System.Drawing.Point(609, 144);
            this.cmbSHour.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSHour.Name = "cmbSHour";
            this.cmbSHour.Size = new System.Drawing.Size(160, 39);
            this.cmbSHour.TabIndex = 2;
            // 
            // lblcolon1
            // 
            this.lblcolon1.AutoSize = true;
            this.lblcolon1.Location = new System.Drawing.Point(779, 148);
            this.lblcolon1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcolon1.Name = "lblcolon1";
            this.lblcolon1.Size = new System.Drawing.Size(22, 31);
            this.lblcolon1.TabIndex = 3;
            this.lblcolon1.Text = ":";
            // 
            // cmbSMinute
            // 
            this.cmbSMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSMinute.FormattingEnabled = true;
            this.cmbSMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cmbSMinute.Location = new System.Drawing.Point(811, 144);
            this.cmbSMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSMinute.Name = "cmbSMinute";
            this.cmbSMinute.Size = new System.Drawing.Size(160, 39);
            this.cmbSMinute.TabIndex = 4;
            // 
            // cmbSAMPM
            // 
            this.cmbSAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSAMPM.FormattingEnabled = true;
            this.cmbSAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbSAMPM.Location = new System.Drawing.Point(1007, 144);
            this.cmbSAMPM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSAMPM.Name = "cmbSAMPM";
            this.cmbSAMPM.Size = new System.Drawing.Size(85, 39);
            this.cmbSAMPM.TabIndex = 5;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(603, 249);
            this.lblStop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(137, 31);
            this.lblStop.TabIndex = 6;
            this.lblStop.Text = "Stop Time";
            // 
            // cmbEHour
            // 
            this.cmbEHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEHour.FormattingEnabled = true;
            this.cmbEHour.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbEHour.Location = new System.Drawing.Point(609, 314);
            this.cmbEHour.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEHour.Name = "cmbEHour";
            this.cmbEHour.Size = new System.Drawing.Size(160, 39);
            this.cmbEHour.TabIndex = 7;
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(779, 317);
            this.lblColon2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(22, 31);
            this.lblColon2.TabIndex = 8;
            this.lblColon2.Text = ":";
            // 
            // cmbEMinute
            // 
            this.cmbEMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEMinute.FormattingEnabled = true;
            this.cmbEMinute.Items.AddRange(new object[] {
            "00",
            "15",
            "20",
            "45"});
            this.cmbEMinute.Location = new System.Drawing.Point(811, 314);
            this.cmbEMinute.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEMinute.Name = "cmbEMinute";
            this.cmbEMinute.Size = new System.Drawing.Size(160, 39);
            this.cmbEMinute.TabIndex = 9;
            // 
            // cmbEAMPM
            // 
            this.cmbEAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEAMPM.FormattingEnabled = true;
            this.cmbEAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cmbEAMPM.Location = new System.Drawing.Point(1007, 314);
            this.cmbEAMPM.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEAMPM.Name = "cmbEAMPM";
            this.cmbEAMPM.Size = new System.Drawing.Size(85, 39);
            this.cmbEAMPM.TabIndex = 10;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(27, 469);
            this.lblDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(228, 31);
            this.lblDescrip.TabIndex = 11;
            this.lblDescrip.Text = "Event Description";
            // 
            // txtEvent
            // 
            this.txtEvent.Location = new System.Drawing.Point(33, 516);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(4);
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(1059, 38);
            this.txtEvent.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(39, 585);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 58);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(913, 585);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 58);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // EventForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1125, 707);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.cmbEAMPM);
            this.Controls.Add(this.cmbEMinute);
            this.Controls.Add(this.lblColon2);
            this.Controls.Add(this.cmbEHour);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.cmbSAMPM);
            this.Controls.Add(this.cmbSMinute);
            this.Controls.Add(this.lblcolon1);
            this.Controls.Add(this.cmbSHour);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.mthCal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventForm";
            this.Text = "New Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mthCal;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.ComboBox cmbSHour;
        private System.Windows.Forms.Label lblcolon1;
        private System.Windows.Forms.ComboBox cmbSMinute;
        private System.Windows.Forms.ComboBox cmbSAMPM;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.ComboBox cmbEHour;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.ComboBox cmbEMinute;
        private System.Windows.Forms.ComboBox cmbEAMPM;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}