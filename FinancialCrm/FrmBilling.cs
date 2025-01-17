using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
	public partial class FrmBilling : Form
	{
		public FrmBilling()
		{
			InitializeComponent();
		}
		FinanialCrmDbEntities1 db = new FinanialCrmDbEntities1(); 
		private void FrmBilling_Load(object sender, EventArgs e)
		{
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnBillList_Click(object sender, EventArgs e)
		{
			string title = txtBillTitle.Text;
			decimal amount = decimal.Parse(txtBillAmount.Text);
			string period = txtBillPeriod.Text;

			Bills bills = new Bills();
			bills.BillTitle = title;
			bills.BillAmount = amount;
			bills.BillPeriod = period;
			db.Bills.Add(bills);
			MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			var values = db.Bills.ToList();
			dataGridView1.DataSource = values;
		}
	}
}
