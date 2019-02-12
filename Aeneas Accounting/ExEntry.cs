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
    public partial class ExEntry : Form
    {
        public Expense expense;
        public int id;
        public bool edit;

        public ExEntry()
        {
            InitializeComponent();
        }

        public ExEntry(List<Expense> allExp)
        {
            InitializeComponent();
            edit = false;
            id = 0;
            id = GetID(allExp);
        }

        public ExEntry(List<Expense> allExp, int editID)
        {
            InitializeComponent();
            edit = true;
            foreach (Expense e in allExp)
            {
                if (e.ID == editID)
                {
                    expense = e;
                    break;
                }
            }
            EditUIUpdate(expense);
        }

        private int GetID(List<Expense> allExp)
        {
            if (allExp != null)
            {
                if (allExp.Count > 0)
                {
                    foreach (Expense e in allExp)
                    {
                        if (e.ID >= id)
                            id = e.ID + 1;
                    }
                }
                foreach (Expense e in allExp)
                {
                    string type = e.Type;
                    bool exists = false;
                    foreach (string s in typeBox.Items)
                    {
                        if (s == type)
                            exists = true;
                    }
                    if (!exists)
                        typeBox.Items.Add(type);
                    exists = false;
                }
                foreach (Expense e in allExp)
                {
                    string business = e.Business;
                    bool exists = false;
                    foreach (string s in businessBox.Items)
                    {
                        if (s == business)
                            exists = true;
                    }
                    if (!exists)
                        businessBox.Items.Add(business);
                    exists = false;
                }
                return id;
            }
            else return 0;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (edit == false)
                CreateExpense();
            if (edit == true)
                EditExpense();
        }

        private void CreateExpense()
        {
            expense = new Expense(-1, "", -1, "", "", "", DateTime.Now, "");
            expense.ID = id;
            if (String.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Enter Expense Type");
                return;
            }
            expense.Type = typeBox.Text;
            decimal value;
            if (!decimal.TryParse(valueBox.Text, out value))
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            expense.Value = value;
            expense.Business = businessBox.Text;
            expense.Party = partyBox.Text;
            DateTime dt;
            if (!DateTime.TryParse(dateBox.Text, out dt))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            expense.DateTime = dt;
            expense.Misc = notesBox.Text;
            if (String.IsNullOrWhiteSpace(freqBox.Text))
            {
                MessageBox.Show("Select Expense Frequency");
                return;
            }
            expense.Freq = freqBox.Text;
            this.Close();
        }

        private void EditUIUpdate(Expense e)
        {
            typeBox.Text = e.Type;
            valueBox.Text = e.Value.ToString("N0");
            businessBox.Text = e.Business;
            partyBox.Text = e.Party;
            notesBox.Text = e.Misc;
            dateBox.Text = e.DateTime.ToShortDateString();
            freqBox.Text = e.Freq;
        }

        private void EditExpense()
        {
            if (String.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Enter Expense Type");
                return;
            }
            expense.Type = typeBox.Text;
            decimal value;
            if (!decimal.TryParse(valueBox.Text, out value))
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            expense.Value = value;
            expense.Business = businessBox.Text;
            expense.Party = partyBox.Text;
            DateTime dt;
            if (!DateTime.TryParse(dateBox.Text, out dt))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            expense.DateTime = dt;
            expense.Misc = notesBox.Text;
            if (String.IsNullOrWhiteSpace(freqBox.Text))
            {
                MessageBox.Show("Select Expense Frequency");
                return;
            }
            expense.Freq = freqBox.Text;
            this.Close();
        }

        private void businessBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
