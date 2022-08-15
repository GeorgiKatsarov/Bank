using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    public class bankAcount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;
                foreach (var item in transactions)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }
        private static int acountNumber = 0;
        private List<Transaction> transactions = new List<Transaction>();
        
        public bankAcount(string name, decimal initalBalance)
        {
            this.Owner = name;
            makeDeposit(initalBalance, DateTime.Now, "initial balance");
            this.Number = acountNumber.ToString();
            acountNumber++;
        }
        
        public void makeDeposit(decimal amaunt, DateTime date, string note)
        {
            if (amaunt <=0 )
            {
                throw new ArgumentOutOfRangeException(nameof(amaunt), "Amount of deposit must be positif");
            }
            var deposit = new Transaction(amaunt, date, note);
            transactions.Add(deposit);
        }
        
        public void makeWithdraw(decimal amaunt, DateTime date, string note)
        {
            if (amaunt <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amaunt), "Amount of withdraw must be positif");
            }
            if (Balance - amaunt < 0)
            {
                throw new InvalidOperationException("Not suficiant funds for this withdraw"); 
            }
            var withdraw = new Transaction(-amaunt, date, note);
            transactions.Add(withdraw);



        }
        public string getAcountHistory()
        {
            var history = new StringBuilder();
             history.AppendLine("Date\t\tNote\t\tAmount\n");
            foreach (var item in transactions)
            {
              
                history.AppendLine($"{item.Date.ToShortDateString()}\t{item.Notes}\t{item.Amount}\n");
            }
            return history.ToString();
        }
        
    }
}
