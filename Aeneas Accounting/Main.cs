using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aeneas_Accounting
{
    public partial class Main : Form
    {
        List<Transaction> allTrans = new List<Transaction>();
        List<Expense> allExp = new List<Expense>();
        decimal budget = 0;
        decimal remainder = 0;
        decimal totalTran = 0;
        decimal remCash = 0;

        public Main()
        {
            InitializeComponent();
            allTrans = FileData.LoadTrans();
            if (allTrans != null)
                UpdateDisplay();
            else allTrans = new List<Transaction>();
            allExp = FileData.LoadExp();
            if (allExp != null)
                UpdateExDisplay();
            else allExp = new List<Expense>();
            if (allExp == null)
                totalExLbl.Text = "NA";
            UpdateBudget();
            if (budget == 0)
                budLbl.Text = "NA";
            if (remainder == 0)
                remLbl.Text = "NA";
            InitializeDisplayView();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry(allTrans);
            entry.ShowDialog();
            Transaction transaction = entry.transaction;
            if (transaction != null)
            {
                allTrans.Add(transaction);
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            displayView.Items.Clear();
            allTrans = allTrans.OrderByDescending(x => x.DateTime).ToList();
            foreach (Transaction t in allTrans)
            {
                ListViewItem item = new ListViewItem(new[] {t.ID.ToString(), t.Type, t.DateTime.ToShortDateString(), t.Business, "¥" + t.Value.ToString("N0"), t.Party, t.Misc});
                item.Tag = t.ID;
                displayView.Items.Add(item);
            }
            totalTran = 0;
            foreach (Transaction t in allTrans)
            {
                if (t.DateTime.Month == DateTime.Now.Month)
                {
                    totalTran += t.Value;
                }
            }
            totalTranLbl.Text = totalTran.ToString("N0");
        }

        private void UpdateExDisplay()
        {
            expenseView.Items.Clear();
            allExp = allExp.OrderByDescending(x => x.DateTime).ToList();
            foreach (Expense e in allExp)
            {
                string date;
                if (e.Freq != "Once")
                    date = e.DateTime.Day.ToString();
                else date = e.DateTime.ToShortDateString();
                ListViewItem item = new ListViewItem(new[] { e.ID.ToString(), e.Freq, e.Type, date, e.Business, "¥" + e.Value.ToString("N0"), e.Party, e.Misc });
                item.Tag = e.ID;
                expenseView.Items.Add(item);
            }
            
        }

        private void UpdateBudget()
        {
            decimal totalExp = 0;
            foreach (Expense e in allExp)
            {
                decimal toAdd = 0;
                if (e.Freq == "Monthly")
                    toAdd = e.Value;
                else if (e.Freq == "Bimonthly")
                    toAdd = e.Value / 2;
                else if (e.Freq == "Trimonthly")
                    toAdd = e.Value / 3;
                else if (e.Freq == "Semi-Annually")
                    toAdd = e.Value / 6;
                else if (e.Freq == "Annually")
                    toAdd = e.Value / 12;
                else if (e.Freq == "Once" && e.DateTime.Month == DateTime.Now.Month)
                    toAdd = e.Value;
                totalExp += toAdd;
            }
            totalExLbl.Text = "¥" + totalExp.ToString("N0");
            budLbl.Text = "¥" + budget.ToString("N0");
            remLbl.Text = "¥" + (budget - totalExp).ToString("N0");
        }

        private void InitializeDisplayView()
        {
            displayView.View = View.Details;
            expenseView.View = View.Details;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            FileData.SaveData(allTrans, allExp);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (displayView.SelectedItems.Count > 0)
            {
                int id = (int)displayView.SelectedItems[0].Tag;
                Entry entry = new Entry(allTrans, id);
                Transaction transaction = entry.transaction;
                entry.ShowDialog();
                UpdateDisplay();
            }
            else
            {
                MessageBox.Show("No Item Selected");
            }
        }

        private void displayView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void exNewBtn_Click(object sender, EventArgs e)
        {
            ExEntry exEntry = new ExEntry(allExp);
            exEntry.ShowDialog();
            Expense expense = exEntry.expense;
            if (expense != null)
            {
                allExp.Add(expense);
                UpdateExDisplay();
                UpdateBudget();
            }
        }

        private void exEditBtn_Click(object sender, EventArgs e)
        {
            if (expenseView.SelectedItems.Count > 0)
            {
                int id = (int)expenseView.SelectedItems[0].Tag;
                ExEntry exEntry = new ExEntry(allExp, id);
                Transaction transaction = exEntry.expense;
                exEntry.ShowDialog();
                UpdateExDisplay();
                UpdateBudget();
            }
            else
            {
                MessageBox.Show("No Item Selected");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (displayView.SelectedItems.Count > 0)
            {
                int id = (int)displayView.SelectedItems[0].Tag;
                foreach (Transaction t in allTrans)
                {
                    if (t.ID == id)
                    {
                        allTrans.Remove(t);
                        break;
                    }
                }
            }
            UpdateDisplay();
        }

        private void exDelBtn_Click(object sender, EventArgs e)
        {
            if (expenseView.SelectedItems.Count > 0)
            {
                int id = (int)expenseView.SelectedItems[0].Tag;
                foreach (Expense ex in allExp)
                {
                    if (ex.ID == id)
                    {
                        allExp.Remove(ex);
                        break;
                    }
                }
            }
            UpdateExDisplay();
        }

        private void budBtn_Click(object sender, EventArgs e)
        {
            SetBudget setBudget = new SetBudget();
            setBudget.ShowDialog();
            budget = setBudget.budget;
            UpdateBudget();
        }
    }
}
