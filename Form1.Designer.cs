namespace SAC_1_Task_1
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
            this.lblTextbookAge = new System.Windows.Forms.Label();
            this.lblCollectionWorth = new System.Windows.Forms.Label();
            this.lblWorth = new System.Windows.Forms.Label();
            this.lblPurchasedPrice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnEndQuote = new System.Windows.Forms.Button();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.numTextbookPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextbookPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextbookAge
            // 
            this.lblTextbookAge.AutoSize = true;
            this.lblTextbookAge.Location = new System.Drawing.Point(99, 63);
            this.lblTextbookAge.Name = "lblTextbookAge";
            this.lblTextbookAge.Size = new System.Drawing.Size(151, 16);
            this.lblTextbookAge.TabIndex = 0;
            this.lblTextbookAge.Text = "How old is the textbook?";
            // 
            // lblCollectionWorth
            // 
            this.lblCollectionWorth.AutoSize = true;
            this.lblCollectionWorth.Location = new System.Drawing.Point(408, 238);
            this.lblCollectionWorth.Name = "lblCollectionWorth";
            this.lblCollectionWorth.Size = new System.Drawing.Size(44, 16);
            this.lblCollectionWorth.TabIndex = 1;
            this.lblCollectionWorth.Text = "label2";
            // 
            // lblWorth
            // 
            this.lblWorth.AutoSize = true;
            this.lblWorth.Location = new System.Drawing.Point(408, 103);
            this.lblWorth.Name = "lblWorth";
            this.lblWorth.Size = new System.Drawing.Size(44, 16);
            this.lblWorth.TabIndex = 2;
            this.lblWorth.Text = "label3";
            // 
            // lblPurchasedPrice
            // 
            this.lblPurchasedPrice.AutoSize = true;
            this.lblPurchasedPrice.Location = new System.Drawing.Point(99, 206);
            this.lblPurchasedPrice.Name = "lblPurchasedPrice";
            this.lblPurchasedPrice.Size = new System.Drawing.Size(176, 16);
            this.lblPurchasedPrice.TabIndex = 3;
            this.lblPurchasedPrice.Text = "How much did you pay for it?";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(102, 329);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnEndQuote
            // 
            this.btnEndQuote.Location = new System.Drawing.Point(411, 329);
            this.btnEndQuote.Name = "btnEndQuote";
            this.btnEndQuote.Size = new System.Drawing.Size(96, 23);
            this.btnEndQuote.TabIndex = 5;
            this.btnEndQuote.Text = "End Quote";
            this.btnEndQuote.UseVisualStyleBackColor = true;
            this.btnEndQuote.Click += new System.EventHandler(this.btnEndQuote_Click);
            // 
            // numAge
            // 
            this.numAge.DecimalPlaces = 2;
            this.numAge.Location = new System.Drawing.Point(102, 103);
            this.numAge.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 22);
            this.numAge.TabIndex = 6;
            // 
            // numTextbookPrice
            // 
            this.numTextbookPrice.DecimalPlaces = 2;
            this.numTextbookPrice.Location = new System.Drawing.Point(102, 238);
            this.numTextbookPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTextbookPrice.Name = "numTextbookPrice";
            this.numTextbookPrice.Size = new System.Drawing.Size(120, 22);
            this.numTextbookPrice.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numTextbookPrice);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.btnEndQuote);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPurchasedPrice);
            this.Controls.Add(this.lblWorth);
            this.Controls.Add(this.lblCollectionWorth);
            this.Controls.Add(this.lblTextbookAge);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTextbookPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextbookAge;
        private System.Windows.Forms.Label lblCollectionWorth;
        private System.Windows.Forms.Label lblWorth;
        private System.Windows.Forms.Label lblPurchasedPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnEndQuote;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numTextbookPrice;
    }
}

