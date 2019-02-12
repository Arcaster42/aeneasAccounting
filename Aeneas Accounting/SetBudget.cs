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
    public partial class SetBudget : Form
    {
        public decimal budget;

        public SetBudget()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(budBox.Text, out budget))
            {
                MessageBox.Show("Invalid Amount");
                return;
            }
            this.Close();
        }
    }
}
