namespace lab2
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
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.radWater = new System.Windows.Forms.RadioButton();
            this.radSoftDrink = new System.Windows.Forms.RadioButton();
            this.radFries = new System.Windows.Forms.RadioButton();
            this.radSandwich = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cboQuantity = new System.Windows.Forms.ComboBox();
            this.staticTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.grpItem.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.radWater);
            this.grpItem.Controls.Add(this.radSoftDrink);
            this.grpItem.Controls.Add(this.radFries);
            this.grpItem.Controls.Add(this.radSandwich);
            this.grpItem.Location = new System.Drawing.Point(13, 13);
            this.grpItem.Margin = new System.Windows.Forms.Padding(4);
            this.grpItem.Name = "grpItem";
            this.grpItem.Padding = new System.Windows.Forms.Padding(4);
            this.grpItem.Size = new System.Drawing.Size(139, 153);
            this.grpItem.TabIndex = 0;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Item";
            // 
            // radWater
            // 
            this.radWater.AutoSize = true;
            this.radWater.Location = new System.Drawing.Point(9, 113);
            this.radWater.Margin = new System.Windows.Forms.Padding(4);
            this.radWater.Name = "radWater";
            this.radWater.Size = new System.Drawing.Size(117, 35);
            this.radWater.TabIndex = 4;
            this.radWater.Text = "Water";
            this.radWater.UseVisualStyleBackColor = true;
            this.radWater.CheckedChanged += new System.EventHandler(this.radWater_CheckedChanged);
            // 
            // radSoftDrink
            // 
            this.radSoftDrink.AutoSize = true;
            this.radSoftDrink.Location = new System.Drawing.Point(9, 84);
            this.radSoftDrink.Margin = new System.Windows.Forms.Padding(4);
            this.radSoftDrink.Name = "radSoftDrink";
            this.radSoftDrink.Size = new System.Drawing.Size(165, 35);
            this.radSoftDrink.TabIndex = 3;
            this.radSoftDrink.Text = "Soft Drink";
            this.radSoftDrink.UseVisualStyleBackColor = true;
            this.radSoftDrink.CheckedChanged += new System.EventHandler(this.radSoftDrink_CheckedChanged);
            // 
            // radFries
            // 
            this.radFries.AutoSize = true;
            this.radFries.Location = new System.Drawing.Point(9, 54);
            this.radFries.Margin = new System.Windows.Forms.Padding(4);
            this.radFries.Name = "radFries";
            this.radFries.Size = new System.Drawing.Size(106, 35);
            this.radFries.TabIndex = 2;
            this.radFries.Text = "Fries";
            this.radFries.UseVisualStyleBackColor = true;
            this.radFries.CheckedChanged += new System.EventHandler(this.radFries_CheckedChanged);
            // 
            // radSandwich
            // 
            this.radSandwich.AutoSize = true;
            this.radSandwich.Location = new System.Drawing.Point(9, 25);
            this.radSandwich.Margin = new System.Windows.Forms.Padding(4);
            this.radSandwich.Name = "radSandwich";
            this.radSandwich.Size = new System.Drawing.Size(163, 35);
            this.radSandwich.TabIndex = 1;
            this.radSandwich.Text = "Sandwich";
            this.radSandwich.UseVisualStyleBackColor = true;
            this.radSandwich.CheckedChanged += new System.EventHandler(this.radSandwich_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(189, 13);
            this.grpSize.Margin = new System.Windows.Forms.Padding(4);
            this.grpSize.Name = "grpSize";
            this.grpSize.Padding = new System.Windows.Forms.Padding(4);
            this.grpSize.Size = new System.Drawing.Size(129, 134);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(9, 84);
            this.radLarge.Margin = new System.Windows.Forms.Padding(4);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(114, 35);
            this.radLarge.TabIndex = 2;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(9, 54);
            this.radMedium.Margin = new System.Windows.Forms.Padding(4);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(140, 35);
            this.radMedium.TabIndex = 1;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            this.radMedium.CheckedChanged += new System.EventHandler(this.radMedium_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(9, 25);
            this.radSmall.Margin = new System.Windows.Forms.Padding(4);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(112, 35);
            this.radSmall.TabIndex = 0;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(357, 13);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(116, 31);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // cboQuantity
            // 
            this.cboQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuantity.FormattingEnabled = true;
            this.cboQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboQuantity.Location = new System.Drawing.Point(360, 36);
            this.cboQuantity.Name = "cboQuantity";
            this.cboQuantity.Size = new System.Drawing.Size(66, 39);
            this.cboQuantity.TabIndex = 4;
            // 
            // staticTotal
            // 
            this.staticTotal.AutoSize = true;
            this.staticTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staticTotal.Location = new System.Drawing.Point(389, 102);
            this.staticTotal.Name = "staticTotal";
            this.staticTotal.Size = new System.Drawing.Size(80, 31);
            this.staticTotal.TabIndex = 5;
            this.staticTotal.Text = "Total";
            this.staticTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(382, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 31);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 30;
            this.lstOrder.Location = new System.Drawing.Point(14, 191);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(420, 124);
            this.lstOrder.TabIndex = 7;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 343);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(358, 343);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 392);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.staticTotal);
            this.Controls.Add(this.cboQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rick\'s Sandwich Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.RadioButton radWater;
        private System.Windows.Forms.RadioButton radSoftDrink;
        private System.Windows.Forms.RadioButton radFries;
        private System.Windows.Forms.RadioButton radSandwich;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cboQuantity;
        private System.Windows.Forms.Label staticTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
    }
}

