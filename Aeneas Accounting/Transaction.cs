using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeneas_Accounting
{
    [Serializable]
    public class Transaction
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public decimal Value { get; set; }
        public string Business { get; set; }
        public string Party { get; set; }
        public string Misc { get; set; }
        public DateTime DateTime { get; set; }

        public Transaction(int id, string type, decimal value, string business, string party, string misc, DateTime dateTime)
        {
            ID = id;
            Type = type;
            Value = value;
            Business = business;
            Party = party;
            Misc = misc;
            DateTime = dateTime;
        }
    }

    [Serializable]
    public class Expense : Transaction
    {
        public string Freq { get; set; }

        public Expense(int id, string type, decimal value, string business, string party, string misc, DateTime dateTime, string freq) : base (id, type, value, business, party, misc, dateTime)
        {
            Freq = freq;
        }
    }
}
