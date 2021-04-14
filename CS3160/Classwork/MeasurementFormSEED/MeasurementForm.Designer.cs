namespace MeasurementFormSEED
{
    partial class MeasurementForm
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.cboMeasure = new System.Windows.Forms.ComboBox();
            this.rdoFeet = new System.Windows.Forms.RadioButton();
            this.rdoFeetSquare = new System.Windows.Forms.RadioButton();
            this.rdoPounds = new System.Windows.Forms.RadioButton();
            this.errorProject = new System.Windows.Forms.ErrorProvider(this.components);
            this.unit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProject)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Project";
            // 
            // unit
            // 
            this.unit.Controls.Add(this.rdoPounds);
            this.unit.Controls.Add(this.rdoFeetSquare);
            this.unit.Controls.Add(this.rdoFeet);
            this.unit.Location = new System.Drawing.Point(253, 24);
            this.unit.Margin = new System.Windows.Forms.Padding(4);
            this.unit.Name = "unit";
            this.unit.Padding = new System.Windows.Forms.Padding(4);
            this.unit.Size = new System.Drawing.Size(192, 135);
            this.unit.TabIndex = 16;
            this.unit.TabStop = false;
            this.unit.Text = "Unit";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Measure";
            // 
            // txtProject
            // 
            this.txtProject.Location = new System.Drawing.Point(91, 68);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(140, 22);
            this.txtProject.TabIndex = 18;
            // 
            // cboMeasure
            // 
            this.cboMeasure.FormattingEnabled = true;
            this.cboMeasure.Items.AddRange(new object[] {
            "Length",
            "Width",
            "Height",
            "Weight",
            "Volume"});
            this.cboMeasure.Location = new System.Drawing.Point(91, 129);
            this.cboMeasure.Name = "cboMeasure";
            this.cboMeasure.Size = new System.Drawing.Size(140, 24);
            this.cboMeasure.TabIndex = 19;
            // 
            // rdoFeet
            // 
            this.rdoFeet.AutoSize = true;
            this.rdoFeet.Location = new System.Drawing.Point(26, 31);
            this.rdoFeet.Name = "rdoFeet";
            this.rdoFeet.Size = new System.Drawing.Size(53, 20);
            this.rdoFeet.TabIndex = 0;
            this.rdoFeet.TabStop = true;
            this.rdoFeet.Text = "Feet";
            this.rdoFeet.UseVisualStyleBackColor = true;
            // 
            // rdoFeetSquare
            // 
            this.rdoFeetSquare.AutoSize = true;
            this.rdoFeetSquare.Location = new System.Drawing.Point(26, 69);
            this.rdoFeetSquare.Name = "rdoFeetSquare";
            this.rdoFeetSquare.Size = new System.Drawing.Size(100, 20);
            this.rdoFeetSquare.TabIndex = 1;
            this.rdoFeetSquare.TabStop = true;
            this.rdoFeetSquare.Text = "Feet Square";
            this.rdoFeetSquare.UseVisualStyleBackColor = true;
            // 
            // rdoPounds
            // 
            this.rdoPounds.AutoSize = true;
            this.rdoPounds.Location = new System.Drawing.Point(26, 105);
            this.rdoPounds.Name = "rdoPounds";
            this.rdoPounds.Size = new System.Drawing.Size(72, 20);
            this.rdoPounds.TabIndex = 2;
            this.rdoPounds.TabStop = true;
            this.rdoPounds.Text = "Pounds";
            this.rdoPounds.UseVisualStyleBackColor = true;
            // 
            // errorProject
            // 
            this.errorProject.ContainerControl = this;
            // 
            // MeasurementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 201);
            this.Controls.Add(this.cboMeasure);
            this.Controls.Add(this.txtProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeasurementForm";
            this.Text = "Measurement Details";
            this.unit.ResumeLayout(false);
            this.unit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.ComboBox cboMeasure;
        private System.Windows.Forms.RadioButton rdoPounds;
        private System.Windows.Forms.RadioButton rdoFeetSquare;
        private System.Windows.Forms.RadioButton rdoFeet;
        private System.Windows.Forms.ErrorProvider errorProject;
    }
}