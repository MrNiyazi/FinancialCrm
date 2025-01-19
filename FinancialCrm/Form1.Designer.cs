namespace FinancialCrm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lblBillingTitle = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lblBillAmount = new System.Windows.Forms.Label();
			this.lblLastBankProcessAmount = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblTotalPrice = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button8 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.btnBillForm = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel2.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.panel5.Controls.Add(this.lblBillAmount);
			this.panel5.Controls.Add(this.lblBillingTitle);
			this.panel5.Location = new System.Drawing.Point(461, 16);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(222, 130);
			this.panel5.TabIndex = 13;
			// 
			// lblBillingTitle
			// 
			this.lblBillingTitle.AutoSize = true;
			this.lblBillingTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillingTitle.Location = new System.Drawing.Point(0, 0);
			this.lblBillingTitle.Name = "lblBillingTitle";
			this.lblBillingTitle.Size = new System.Drawing.Size(96, 24);
			this.lblBillingTitle.TabIndex = 11;
			this.lblBillingTitle.Text = "Fatura Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(0, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 49);
			this.label4.TabIndex = 10;
			this.label4.Text = "0000.00";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.lblLastBankProcessAmount);
			this.panel4.Location = new System.Drawing.Point(689, 16);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(223, 130);
			this.panel4.TabIndex = 12;
			// 
			// lblBillAmount
			// 
			this.lblBillAmount.AutoSize = true;
			this.lblBillAmount.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblBillAmount.Location = new System.Drawing.Point(0, 38);
			this.lblBillAmount.Name = "lblBillAmount";
			this.lblBillAmount.Size = new System.Drawing.Size(202, 53);
			this.lblBillAmount.TabIndex = 10;
			this.lblBillAmount.Text = "0000.00 tl";
			// 
			// lblLastBankProcessAmount
			// 
			this.lblLastBankProcessAmount.AutoSize = true;
			this.lblLastBankProcessAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblLastBankProcessAmount.Location = new System.Drawing.Point(0, 0);
			this.lblLastBankProcessAmount.Name = "lblLastBankProcessAmount";
			this.lblLastBankProcessAmount.Size = new System.Drawing.Size(157, 24);
			this.lblLastBankProcessAmount.TabIndex = 9;
			this.lblLastBankProcessAmount.Text = "Gelen Son Havale";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
			this.panel3.Controls.Add(this.lblTotalPrice);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(248, 16);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(207, 130);
			this.panel3.TabIndex = 11;
			// 
			// lblTotalPrice
			// 
			this.lblTotalPrice.AutoSize = true;
			this.lblTotalPrice.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalPrice.Location = new System.Drawing.Point(0, 38);
			this.lblTotalPrice.Name = "lblTotalPrice";
			this.lblTotalPrice.Size = new System.Drawing.Size(202, 53);
			this.lblTotalPrice.TabIndex = 6;
			this.lblTotalPrice.Text = "0000.00 tl";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(131, 24);
			this.label2.TabIndex = 5;
			this.label2.Text = "Toplam Bakiye";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.btnBillForm);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(2, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(240, 561);
			this.panel1.TabIndex = 10;
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(19, 492);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(203, 62);
			this.button8.TabIndex = 7;
			this.button8.Text = "Çıkış  Yap";
			this.button8.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button7.ForeColor = System.Drawing.Color.White;
			this.button7.Location = new System.Drawing.Point(19, 424);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(203, 62);
			this.button7.TabIndex = 6;
			this.button7.Text = "Ayarlar";
			this.button7.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button6.ForeColor = System.Drawing.Color.White;
			this.button6.Location = new System.Drawing.Point(18, 356);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(203, 62);
			this.button6.TabIndex = 5;
			this.button6.Text = "Dashboard";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button5.ForeColor = System.Drawing.Color.White;
			this.button5.Location = new System.Drawing.Point(18, 288);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(203, 62);
			this.button5.TabIndex = 4;
			this.button5.Text = "Banka Hareketleri";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// btnBillForm
			// 
			this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBillForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBillForm.ForeColor = System.Drawing.Color.White;
			this.btnBillForm.Location = new System.Drawing.Point(18, 220);
			this.btnBillForm.Name = "btnBillForm";
			this.btnBillForm.Size = new System.Drawing.Size(203, 62);
			this.btnBillForm.TabIndex = 2;
			this.btnBillForm.Text = "Giderler";
			this.btnBillForm.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(18, 84);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(203, 62);
			this.button4.TabIndex = 3;
			this.button4.Text = "Bankalar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(18, 152);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(203, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Faturalar";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(18, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(203, 62);
			this.button1.TabIndex = 1;
			this.button1.Text = "Kategoriler";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(257, 288);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(379, 257);
			this.chart1.TabIndex = 14;
			this.chart1.Text = "chart1";
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(657, 288);
			this.chart2.Name = "chart2";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.Legend = "Legend1";
			series2.Name = "Faturalar";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(379, 257);
			this.chart2.TabIndex = 15;
			this.chart2.Text = "chart2";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(257, 236);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(379, 46);
			this.panel2.TabIndex = 16;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel6.Controls.Add(this.label3);
			this.panel6.Location = new System.Drawing.Point(657, 236);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(379, 46);
			this.panel6.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(14, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(286, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Bankalar ve Hesaplarındaki para miktarı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(3, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(312, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Ödenen ve Ödenmesi Gereken  para miktarı";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 557);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.chart2);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "FrmDasboard";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblBillingTitle;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblBillAmount;
		private System.Windows.Forms.Label lblLastBankProcessAmount;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblTotalPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnBillForm;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label3;
	}
}

