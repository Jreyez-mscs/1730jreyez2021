
namespace jreyez1c1
{
    partial class FrmFoodTruck
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotdogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHotdogTotal = new System.Windows.Forms.TextBox();
            this.txtBurgerTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBurgers = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtPretaxTotal = new System.Windows.Forms.TextBox();
            this.txtPretaxTotalL = new System.Windows.Forms.Label();
            this.txtTaxL = new System.Windows.Forms.Label();
            this.txtTotalL = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ExitClick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(119, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hot dogs:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHotdogs
            // 
            this.txtHotdogs.Location = new System.Drawing.Point(178, 47);
            this.txtHotdogs.Name = "txtHotdogs";
            this.txtHotdogs.Size = new System.Drawing.Size(65, 20);
            this.txtHotdogs.TabIndex = 1;
            this.txtHotdogs.Text = "0";
            this.txtHotdogs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHotdogs.TextChanged += new System.EventHandler(this.txtHotdogs_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x $4.00 =";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHotdogTotal
            // 
            this.txtHotdogTotal.Location = new System.Drawing.Point(306, 47);
            this.txtHotdogTotal.Name = "txtHotdogTotal";
            this.txtHotdogTotal.ReadOnly = true;
            this.txtHotdogTotal.Size = new System.Drawing.Size(100, 20);
            this.txtHotdogTotal.TabIndex = 3;
            this.txtHotdogTotal.TabStop = false;
            this.txtHotdogTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHotdogTotal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtBurgerTotal
            // 
            this.txtBurgerTotal.Location = new System.Drawing.Point(306, 73);
            this.txtBurgerTotal.Name = "txtBurgerTotal";
            this.txtBurgerTotal.ReadOnly = true;
            this.txtBurgerTotal.Size = new System.Drawing.Size(100, 20);
            this.txtBurgerTotal.TabIndex = 7;
            this.txtBurgerTotal.TabStop = false;
            this.txtBurgerTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "x $5.00 =";
            // 
            // txtBurgers
            // 
            this.txtBurgers.Location = new System.Drawing.Point(178, 73);
            this.txtBurgers.Name = "txtBurgers";
            this.txtBurgers.Size = new System.Drawing.Size(65, 20);
            this.txtBurgers.TabIndex = 5;
            this.txtBurgers.Text = "0";
            this.txtBurgers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBurgers.TextChanged += new System.EventHandler(this.txtBurgers_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(119, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Burgers:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(168, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(306, 151);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(306, 125);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 10;
            this.txtTax.TabStop = false;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPretaxTotal
            // 
            this.txtPretaxTotal.Location = new System.Drawing.Point(306, 99);
            this.txtPretaxTotal.Name = "txtPretaxTotal";
            this.txtPretaxTotal.ReadOnly = true;
            this.txtPretaxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPretaxTotal.TabIndex = 11;
            this.txtPretaxTotal.TabStop = false;
            this.txtPretaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPretaxTotal.TextChanged += new System.EventHandler(this.txtPretaxTotal_TextChanged);
            // 
            // txtPretaxTotalL
            // 
            this.txtPretaxTotalL.AutoSize = true;
            this.txtPretaxTotalL.Location = new System.Drawing.Point(237, 102);
            this.txtPretaxTotalL.Name = "txtPretaxTotalL";
            this.txtPretaxTotalL.Size = new System.Drawing.Size(63, 13);
            this.txtPretaxTotalL.TabIndex = 12;
            this.txtPretaxTotalL.Text = "Pretax total:";
            // 
            // txtTaxL
            // 
            this.txtTaxL.AutoSize = true;
            this.txtTaxL.Location = new System.Drawing.Point(272, 128);
            this.txtTaxL.Name = "txtTaxL";
            this.txtTaxL.Size = new System.Drawing.Size(28, 13);
            this.txtTaxL.TabIndex = 13;
            this.txtTaxL.Text = "Tax:";
            // 
            // txtTotalL
            // 
            this.txtTotalL.AutoSize = true;
            this.txtTotalL.Location = new System.Drawing.Point(266, 154);
            this.txtTotalL.Name = "txtTotalL";
            this.txtTotalL.Size = new System.Drawing.Size(34, 13);
            this.txtTotalL.TabIndex = 14;
            this.txtTotalL.Text = "Total:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(249, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ExitClick
            // 
            this.ExitClick.Location = new System.Drawing.Point(330, 192);
            this.ExitClick.Name = "ExitClick";
            this.ExitClick.Size = new System.Drawing.Size(75, 23);
            this.ExitClick.TabIndex = 16;
            this.ExitClick.Text = "&Exit";
            this.ExitClick.UseVisualStyleBackColor = true;
            this.ExitClick.Click += new System.EventHandler(this.ExitClick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(199, 283);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 91);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmFoodTruck
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitClick);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotalL);
            this.Controls.Add(this.txtTaxL);
            this.Controls.Add(this.txtPretaxTotalL);
            this.Controls.Add(this.txtPretaxTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBurgerTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBurgers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHotdogTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHotdogs);
            this.Controls.Add(this.label1);
            this.Name = "FrmFoodTruck";
            this.Text = "jreyez1c1: foodTruck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotdogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHotdogTotal;
        private System.Windows.Forms.TextBox txtBurgerTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBurgers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtPretaxTotal;
        private System.Windows.Forms.Label txtPretaxTotalL;
        private System.Windows.Forms.Label txtTaxL;
        private System.Windows.Forms.Label txtTotalL;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button ExitClick;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

