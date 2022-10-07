using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadChoresMain
{
   public class ChoreItem
    {
        public string ChoreName { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public Boolean Approved { get; set; }
        public int Id { get; set; }

        public ChoreItem(string name, double amount)
        {
            ChoreName = name;
            Amount = amount;
            Approved = false;
        }

        public ChoreItem(int ID, string name, double amount, DateTime date, Boolean approve)
        {
            Id = ID;
            ChoreName = name;
            Amount = amount;
            Date = date;
            Approved = approve;
        }

        public override string ToString()
        {
            String str = string.Format("Chore: {0} - ${1} - {2} - Approved: {3}", ChoreName, Amount, Date, Approved);
            return str;
        }
    }
}
