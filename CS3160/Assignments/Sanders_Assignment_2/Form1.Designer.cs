
namespace purchased
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
            this.gbItem = new System.Windows.Forms.GroupBox();
            this.rbtnWater = new System.Windows.Forms.RadioButton();
            this.rbtnSoftDrink = new System.Windows.Forms.RadioButton();
            this.rbtnFries = new System.Windows.Forms.RadioButton();
            this.rbtnBurger = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbtnLarge = new System.Windows.Forms.RadioButton();
            this.rbtnMedium = new System.Windows.Forms.RadioButton();
            this.rbtnSmall = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbQuantity = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStatisTotal = new System.Windows.Forms.Label();
            this.pbBurger = new System.Windows.Forms.PictureBox();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbItem.SuspendLayout();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // gbItem
            // 
            this.gbItem.Controls.Add(this.rbtnWater);
            this.gbItem.Controls.Add(this.rbtnSoftDrink);
            this.gbItem.Controls.Add(this.rbtnFries);
            this.gbItem.Controls.Add(this.rbtnBurger);
            this.gbItem.Location = new System.Drawing.Point(21, 27);
            this.gbItem.Margin = new System.Windows.Forms.Padding(4);
            this.gbItem.Name = "gbItem";
            this.gbItem.Padding = new System.Windows.Forms.Padding(4);
            this.gbItem.Size = new System.Drawing.Size(185, 145);
            this.gbItem.TabIndex = 0;
            this.gbItem.TabStop = false;
            this.gbItem.Text = "Item";
            // 
            // rbtnWater
            // 
            this.rbtnWater.AutoSize = true;
            this.rbtnWater.Location = new System.Drawing.Point(8, 108);
            this.rbtnWater.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnWater.Name = "rbtnWater";
            this.rbtnWater.Size = new System.Drawing.Size(62, 20);
            this.rbtnWater.TabIndex = 3;
            this.rbtnWater.Text = "Water";
            this.rbtnWater.UseVisualStyleBackColor = true;
            this.rbtnWater.CheckedChanged += new System.EventHandler(this.rbtnWater_CheckedChanged);
            // 
            // rbtnSoftDrink
            // 
            this.rbtnSoftDrink.AutoSize = true;
            this.rbtnSoftDrink.Location = new System.Drawing.Point(8, 80);
            this.rbtnSoftDrink.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSoftDrink.Name = "rbtnSoftDrink";
            this.rbtnSoftDrink.Size = new System.Drawing.Size(83, 20);
            this.rbtnSoftDrink.TabIndex = 2;
            this.rbtnSoftDrink.Text = "Soft Drink";
            this.rbtnSoftDrink.UseVisualStyleBackColor = true;
            this.rbtnSoftDrink.CheckedChanged += new System.EventHandler(this.rbtnSoftDrink_CheckedChanged);
            // 
            // rbtnFries
            // 
            this.rbtnFries.AutoSize = true;
            this.rbtnFries.Location = new System.Drawing.Point(8, 52);
            this.rbtnFries.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFries.Name = "rbtnFries";
            this.rbtnFries.Size = new System.Drawing.Size(56, 20);
            this.rbtnFries.TabIndex = 1;
            this.rbtnFries.Text = "Fries";
            this.rbtnFries.UseVisualStyleBackColor = true;
            this.rbtnFries.CheckedChanged += new System.EventHandler(this.rbtnFries_CheckedChanged);
            // 
            // rbtnBurger
            // 
            this.rbtnBurger.AutoSize = true;
            this.rbtnBurger.Location = new System.Drawing.Point(8, 23);
            this.rbtnBurger.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnBurger.Name = "rbtnBurger";
            this.rbtnBurger.Size = new System.Drawing.Size(66, 20);
            this.rbtnBurger.TabIndex = 0;
            this.rbtnBurger.Text = "Burger";
            this.rbtnBurger.UseVisualStyleBackColor = true;
            this.rbtnBurger.CheckedChanged += new System.EventHandler(this.rbtnBurger_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbtnLarge);
            this.gbSize.Controls.Add(this.rbtnMedium);
            this.gbSize.Controls.Add(this.rbtnSmall);
            this.gbSize.Location = new System.Drawing.Point(229, 27);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4);
            this.gbSize.Size = new System.Drawing.Size(171, 108);
            this.gbSize.TabIndex = 1;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rbtnLarge
            // 
            this.rbtnLarge.AutoSize = true;
            this.rbtnLarge.Location = new System.Drawing.Point(8, 80);
            this.rbtnLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnLarge.Name = "rbtnLarge";
            this.rbtnLarge.Size = new System.Drawing.Size(61, 20);
            this.rbtnLarge.TabIndex = 6;
            this.rbtnLarge.Text = "Large";
            this.rbtnLarge.UseVisualStyleBackColor = true;
            this.rbtnLarge.CheckedChanged += new System.EventHandler(this.rbtnLarge_CheckedChanged);
            // 
            // rbtnMedium
            // 
            this.rbtnMedium.AutoSize = true;
            this.rbtnMedium.Location = new System.Drawing.Point(8, 52);
            this.rbtnMedium.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnMedium.Name = "rbtnMedium";
            this.rbtnMedium.Size = new System.Drawing.Size(74, 20);
            this.rbtnMedium.TabIndex = 5;
            this.rbtnMedium.Text = "Medium";
            this.rbtnMedium.UseVisualStyleBackColor = true;
            this.rbtnMedium.CheckedChanged += new System.EventHandler(this.rbtnMedium_CheckedChanged);
            // 
            // rbtnSmall
            // 
            this.rbtnSmall.AutoSize = true;
            this.rbtnSmall.Location = new System.Drawing.Point(8, 23);
            this.rbtnSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSmall.Name = "rbtnSmall";
            this.rbtnSmall.Size = new System.Drawing.Size(60, 20);
            this.rbtnSmall.TabIndex = 4;
            this.rbtnSmall.Text = "Small";
            this.rbtnSmall.UseVisualStyleBackColor = true;
            this.rbtnSmall.CheckedChanged += new System.EventHandler(this.rbtnSmall_CheckedChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(424, 27);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 16);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // cbQuantity
            // 
            this.cbQuantity.FormattingEnabled = true;
            this.cbQuantity.Items.AddRange(new object[] {
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
            this.cbQuantity.Location = new System.Drawing.Point(428, 50);
            this.cbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuantity.Name = "cbQuantity";
            this.cbQuantity.Size = new System.Drawing.Size(56, 24);
            this.cbQuantity.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(428, 100);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 27);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStatisTotal
            // 
            this.lblStatisTotal.AutoSize = true;
            this.lblStatisTotal.Location = new System.Drawing.Point(375, 156);
            this.lblStatisTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatisTotal.Name = "lblStatisTotal";
            this.lblStatisTotal.Size = new System.Drawing.Size(79, 16);
            this.lblStatisTotal.TabIndex = 5;
            this.lblStatisTotal.Text = "Order Total:";
            // 
            // pbBurger
            // 
            this.pbBurger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBurger.Image = global::Sanders_Assignment_2.Properties.Resources.burger;
            this.pbBurger.Location = new System.Drawing.Point(13, 156);
            this.pbBurger.Margin = new System.Windows.Forms.Padding(4);
            this.pbBurger.Name = "pbBurger";
            this.pbBurger.Size = new System.Drawing.Size(239, 199);
            this.pbBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBurger.TabIndex = 6;
            this.pbBurger.TabStop = false;
            // 
            // lstOrder
            // 
            this.lstOrder.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.ItemHeight = 16;
            this.lstOrder.Location = new System.Drawing.Point(260, 191);
            this.lstOrder.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(275, 164);
            this.lstOrder.TabIndex = 7;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 376);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(435, 376);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 28);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(481, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(53, 16);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "lblTotal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 421);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.pbBurger);
            this.Controls.Add(this.lblStatisTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.gbItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Five Guys Burger Joint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbItem.ResumeLayout(false);
            this.gbItem.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.RadioButton rbtnWater;
        private System.Windows.Forms.RadioButton rbtnSoftDrink;
        private System.Windows.Forms.RadioButton rbtnFries;
        private System.Windows.Forms.RadioButton rbtnBurger;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbtnLarge;
        private System.Windows.Forms.RadioButton rbtnMedium;
        private System.Windows.Forms.RadioButton rbtnSmall;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblStatisTotal;
        private System.Windows.Forms.PictureBox pbBurger;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblTotal;
    }
}

