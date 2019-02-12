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
    public partial class Entry : Form
    {
        public Transaction transaction;
        public int id;
        public bool edit;

        public Entry()
        {
            InitializeComponent();
        }

        public Entry(List<Transaction> allTrans)
        {
            InitializeComponent();
            edit = false;
            id = 0;
            id = GetID(allTrans);
        }

        public Entry(List<Transaction> allTrans, int editID)
        {
            InitializeComponent();
            edit = true;
            foreach (Transaction t in allTrans)
            {
                if (t.ID == editID)
                {
                    transaction = t;
                    break;
                }
            }
            EditUIUpdate(transaction);
        }

        private int GetID(List<Transaction> allTrans)
        {
            if (allTrans != null)
            {
                if (allTrans.Count > 0)
                {
                    foreach (Transaction t in allTrans)
                    {
                        if (t.ID >= id)
                            id = t.ID + 1;
                    }
                }
                foreach (Transaction t in allTrans)
                {
                    string type = t.Type;
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
                foreach (Transaction t in allTrans)
                {
                    string business = t.Business;
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
                CreateTransaction();
            if (edit == true)
                EditTransaction();
        }

        private void CreateTransaction()
        {
            transaction = new Transaction(-1, "", -1, "", "", "", DateTime.Now);
            transaction.ID = id;
            if (String.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Enter Transaction Type");
                return;
            }
            transaction.Type = typeBox.Text;
            decimal value;
            if (!decimal.TryParse(valueBox.Text, out value))
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            transaction.Value = value;
            transaction.Business = businessBox.Text;
            transaction.Party = partyBox.Text;
            DateTime dt;
            if (!DateTime.TryParse(dateBox.Text, out dt))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            transaction.DateTime = dt;
            transaction.Misc = notesBox.Text;
            this.Close();
        }

        private void EditUIUpdate(Transaction t)
        {
            typeBox.Text = t.Type;
            valueBox.Text = t.Value.ToString("N0");
            businessBox.Text = t.Business;
            partyBox.Text = t.Party;
            notesBox.Text = t.Misc;
            dateBox.Text = t.DateTime.ToShortDateString();
        }

        private void EditTransaction()
        {
            if (String.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Enter Transaction Type");
                return;
            }
            transaction.Type = typeBox.Text;
            decimal value;
            if (!decimal.TryParse(valueBox.Text, out value))
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            transaction.Value = value;
            transaction.Business = businessBox.Text;
            transaction.Party = partyBox.Text;
            DateTime dt;
            if (!DateTime.TryParse(dateBox.Text, out dt))
            {
                MessageBox.Show("Invalid Date");
                return;
            }
            transaction.DateTime = dt;
            transaction.Misc = notesBox.Text;
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
