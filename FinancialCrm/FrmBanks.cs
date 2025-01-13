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
			var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBlance).FirstOrDefault();
			var vakıfBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBlance).FirstOrDefault();
			var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBlance).FirstOrDefault();

			lblIsBankasi.Text = isBankBalance.ToString() + "₺";
			lblVakıfBank.Text = vakıfBankBalance.ToString() + "₺";
			lblZiraatBankası.Text = ziraatBankBalance.ToString() + "₺";
		}
	}
}
