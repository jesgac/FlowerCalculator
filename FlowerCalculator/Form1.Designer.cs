namespace FlowerCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.marketPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Flower_Qty = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sellPrice = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.discountNumeric = new System.Windows.Forms.NumericUpDown();
            this.copyClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Flower_Qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Price";
            // 
            // marketPrice
            // 
            this.marketPrice.Location = new System.Drawing.Point(94, 22);
            this.marketPrice.Name = "marketPrice";
            this.marketPrice.Size = new System.Drawing.Size(100, 20);
            this.marketPrice.TabIndex = 1;
            this.marketPrice.Text = "$0";
            this.marketPrice.Enter += new System.EventHandler(this.marketPrice_Enter);
            this.marketPrice.Leave += new System.EventHandler(this.marketPrice_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // Flower_Qty
            // 
            this.Flower_Qty.Location = new System.Drawing.Point(94, 48);
            this.Flower_Qty.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Flower_Qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Flower_Qty.Name = "Flower_Qty";
            this.Flower_Qty.Size = new System.Drawing.Size(100, 20);
            this.Flower_Qty.TabIndex = 3;
            this.Flower_Qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Flower_Qty.ValueChanged += new System.EventHandler(this.Flower_Qty_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Selling Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount (%)";
            // 
            // sellPrice
            // 
            this.sellPrice.Location = new System.Drawing.Point(94, 99);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.ReadOnly = true;
            this.sellPrice.Size = new System.Drawing.Size(100, 20);
            this.sellPrice.TabIndex = 7;
            this.sellPrice.Text = "$0";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(109, 125);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(85, 37);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // discountNumeric
            // 
            this.discountNumeric.Location = new System.Drawing.Point(94, 74);
            this.discountNumeric.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.discountNumeric.Name = "discountNumeric";
            this.discountNumeric.Size = new System.Drawing.Size(100, 20);
            this.discountNumeric.TabIndex = 9;
            this.discountNumeric.ValueChanged += new System.EventHandler(this.discountNumeric_ValueChanged);
            // 
            // copyClipboard
            // 
            this.copyClipboard.Location = new System.Drawing.Point(18, 125);
            this.copyClipboard.Name = "copyClipboard";
            this.copyClipboard.Size = new System.Drawing.Size(85, 37);
            this.copyClipboard.TabIndex = 10;
            this.copyClipboard.Text = "Copy to Clipboard";
            this.copyClipboard.UseVisualStyleBackColor = true;
            this.copyClipboard.Click += new System.EventHandler(this.copyClipboard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 174);
            this.Controls.Add(this.copyClipboard);
            this.Controls.Add(this.discountNumeric);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Flower_Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.marketPrice);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gabe\'s Flower Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.Flower_Qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox marketPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Flower_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sellPrice;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.NumericUpDown discountNumeric;
        private System.Windows.Forms.Button copyClipboard;
    }
}

