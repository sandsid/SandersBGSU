
namespace calculatorBonus
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
            this.gbOperators = new System.Windows.Forms.GroupBox();
            this.lblLeft = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.lblRight = new System.Windows.Forms.Label();
            this.txtRight = new System.Windows.Forms.TextBox();
            this.lblExpression = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtEpression = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbMult = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbRemain = new System.Windows.Forms.RadioButton();
            this.lblEqual = new System.Windows.Forms.Label();
            this.gbOperators.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOperators
            // 
            this.gbOperators.Controls.Add(this.rbRemain);
            this.gbOperators.Controls.Add(this.rbDiv);
            this.gbOperators.Controls.Add(this.rbMult);
            this.gbOperators.Controls.Add(this.rbSub);
            this.gbOperators.Controls.Add(this.rbAdd);
            this.gbOperators.Location = new System.Drawing.Point(138, 11);
            this.gbOperators.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperators.Name = "gbOperators";
            this.gbOperators.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbOperators.Size = new System.Drawing.Size(145, 188);
            this.gbOperators.TabIndex = 0;
            this.gbOperators.TabStop = false;
            this.gbOperators.Text = "Operators";
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(10, 71);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(88, 16);
            this.lblLeft.TabIndex = 1;
            this.lblLeft.Text = "&Left Operand ";
            // 
            // txtLeft
            // 
            this.txtLeft.Location = new System.Drawing.Point(13, 91);
            this.txtLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(117, 22);
            this.txtLeft.TabIndex = 2;
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(291, 71);
            this.lblRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(95, 16);
            this.lblRight.TabIndex = 3;
            this.lblRight.Text = "Right Operand";
            // 
            // txtRight
            // 
            this.txtRight.Location = new System.Drawing.Point(287, 91);
            this.txtRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(117, 22);
            this.txtRight.TabIndex = 4;
            // 
            // lblExpression
            // 
            this.lblExpression.AutoSize = true;
            this.lblExpression.Location = new System.Drawing.Point(10, 216);
            this.lblExpression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(79, 16);
            this.lblExpression.TabIndex = 5;
            this.lblExpression.Text = "Exprerssion";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(243, 216);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(46, 16);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result";
            // 
            // txtEpression
            // 
            this.txtEpression.Location = new System.Drawing.Point(13, 236);
            this.txtEpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEpression.Name = "txtEpression";
            this.txtEpression.ReadOnly = true;
            this.txtEpression.Size = new System.Drawing.Size(158, 22);
            this.txtEpression.TabIndex = 7;
            this.txtEpression.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(246, 236);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(158, 22);
            this.txtResult.TabIndex = 8;
            this.txtResult.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 285);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(148, 32);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(223, 285);
            this.Quit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(148, 32);
            this.Quit.TabIndex = 10;
            this.Quit.Text = "&Quit";
            this.Quit.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(10, 347);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(65, 16);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(13, 367);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(391, 22);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.TabStop = false;
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.Location = new System.Drawing.Point(9, 36);
            this.rbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(87, 22);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.Text = "&+Addition";
            this.rbAdd.UseVisualStyleBackColor = true;
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSub.Location = new System.Drawing.Point(9, 65);
            this.rbSub.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(106, 22);
            this.rbSub.TabIndex = 1;
            this.rbSub.Text = "&-Subtraction";
            this.rbSub.UseVisualStyleBackColor = true;
            // 
            // rbMult
            // 
            this.rbMult.AutoSize = true;
            this.rbMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMult.Location = new System.Drawing.Point(9, 95);
            this.rbMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbMult.Name = "rbMult";
            this.rbMult.Size = new System.Drawing.Size(117, 22);
            this.rbMult.TabIndex = 2;
            this.rbMult.Text = "&*Multiplication";
            this.rbMult.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiv.Location = new System.Drawing.Point(9, 124);
            this.rbDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(82, 22);
            this.rbDiv.TabIndex = 3;
            this.rbDiv.Text = "&/Division";
            this.rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbRemain
            // 
            this.rbRemain.AutoSize = true;
            this.rbRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRemain.Location = new System.Drawing.Point(9, 154);
            this.rbRemain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbRemain.Name = "rbRemain";
            this.rbRemain.Size = new System.Drawing.Size(111, 22);
            this.rbRemain.TabIndex = 4;
            this.rbRemain.Text = "&%Remainder";
            this.rbRemain.UseVisualStyleBackColor = true;
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(198, 233);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(21, 24);
            this.lblEqual.TabIndex = 13;
            this.lblEqual.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 411);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtEpression);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.gbOperators);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOperators.ResumeLayout(false);
            this.gbOperators.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOperators;
        private System.Windows.Forms.RadioButton rbRemain;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMult;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.TextBox txtRight;
        private System.Windows.Forms.Label lblExpression;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtEpression;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblEqual;
    }
}

