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
	public partial class FrmBanks : Form
	{
		public FrmBanks()
		{
			InitializeComponent();
		}

		FinanialCrmDbEntities1 db = new FinanialCrmDbEntities1();
		private void FrmBanks_Load(object sender, EventArgs e)
		{

			//Banka Bilgileri
			var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBlance).FirstOrDefault();
			var vakıfBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBlance).FirstOrDefault();
			var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBlance).FirstOrDefault();

			lblIsBankasi.Text = isBankBalance.ToString() + "₺";
			lblVakıfBank.Text = vakıfBankBalance.ToString() + "₺";
			lblZiraatBankası.Text = ziraatBankBalance.ToString() + "₺";

			//Banka Hareketleri

			var bankProcess1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
			lblBankProcess1.Text = bankProcess1.Description + " " + bankProcess1.Amoun + " " + bankProcess1.ProcessDate;

			var bankProcess2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
			lblBankProcess2.Text = bankProcess2.Description + " " + bankProcess2.Amoun + " " + bankProcess2.ProcessDate;

			var bankProcess3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
			lblBankProcess3.Text = bankProcess3.Description + " " + bankProcess3.Amoun + " " + bankProcess3.ProcessDate;

			//var bankProcess4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
			//lblBankProcess4.Text = bankProcess4.Description + " " + bankProcess4.Amoun + " " + bankProcess4.ProcessDate;

			//var bankProcess5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
			//lblBankProcess5.Text = bankProcess5.Description + " " + bankProcess5.Amoun + " " + bankProcess5.ProcessDate;
		}

		private void btnBillForm_Click(object sender, EventArgs e)
		{
			FrmBilling frm = new FrmBilling();
			frm.Show();
			this.Hide();
		}
	}
}
