namespace Soechi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUom = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtDiscAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtQtyKecil = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Desc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UOM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Discount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "DiscountAmt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Qty Kecil";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // txtUom
            // 
            this.txtUom.Location = new System.Drawing.Point(91, 34);
            this.txtUom.Name = "txtUom";
            this.txtUom.Size = new System.Drawing.Size(100, 20);
            this.txtUom.TabIndex = 12;
            this.txtUom.TextChanged += new System.EventHandler(this.txtUom_TextChanged);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(92, 57);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 13;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(92, 81);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 14;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(92, 103);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscount.TabIndex = 15;
            // 
            // txtDiscAmount
            // 
            this.txtDiscAmount.Enabled = false;
            this.txtDiscAmount.Location = new System.Drawing.Point(92, 125);
            this.txtDiscAmount.Name = "txtDiscAmount";
            this.txtDiscAmount.Size = new System.Drawing.Size(100, 20);
            this.txtDiscAmount.TabIndex = 16;
            this.txtDiscAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(92, 147);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(250, 31);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 18;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtQtyKecil
            // 
            this.txtQtyKecil.Enabled = false;
            this.txtQtyKecil.Location = new System.Drawing.Point(252, 58);
            this.txtQtyKecil.Name = "txtQtyKecil";
            this.txtQtyKecil.Size = new System.Drawing.Size(100, 20);
            this.txtQtyKecil.TabIndex = 19;
            this.txtQtyKecil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Table Satuan/UOM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Satuan,
            this.Rate});
            this.dataGridView1.Location = new System.Drawing.Point(370, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(143, 129);
            this.dataGridView1.TabIndex = 22;
            // 
            // Satuan
            // 
            this.Satuan.HeaderText = "Satuan";
            this.Satuan.Name = "Satuan";
            this.Satuan.Width = 70;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 70;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(197, 178);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 209);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtQtyKecil);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDiscAmount);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtUom;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtDiscAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtQtyKecil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.Label lblError;
    }
}

