using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		FinanialCrmDbEntities1 db = new FinanialCrmDbEntities1 ();
		int count = 0;
		private void Form1_Load(object sender, EventArgs e)
		{
			var totalBalance = db.Banks.Sum(x => x.BankBlance);
			lblTotalPrice.Text = totalBalance.ToString() + "₺";

			var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amoun).FirstOrDefault();
			label4.Text = lastBankProcessAmount.ToString();

			//Chart 1 Kodları
			var bankData = db.Banks.Select(x => new
			{
				x.BankTitle,
				x.BankBlance
			}).ToList();
			chart1.Series.Clear();
			var series = chart1.Series.Add("Series1");
			foreach(var item in bankData)
			{
				series.Points.AddXY(item.BankTitle, item.BankBlance);
			}

			//Chart 2 Kodları
			var billData = db.Bills.Select(x => new
			{
				x.BillTitle,
				x.BillAmount
			}).ToList();
			chart2.Series.Clear();
			var series2 = chart2.Series.Add("Faturalar");
			foreach (var item in billData)
			{
				series2.Points.AddXY(item.BillTitle, item.BillAmount);
			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			count++;
			if (count % 4 == 1)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillingTitle.Text = "Elektrik Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
			}
			if (count % 4 == 2)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillingTitle.Text = "Doğalgaz Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
			}
			if (count % 4 == 3)
			{
				var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
				lblBillingTitle.Text = "Su Faturası";
				lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
			}
			//if (count % 4 == 0)
			//{
			//	var elektrikFaturasi = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
			//	lblBillingTitle.Text = "Elektrik Faturası";
			//	lblBillAmount.Text = elektrikFaturasi.ToString() + "₺";
			//}

		}
	}
}
