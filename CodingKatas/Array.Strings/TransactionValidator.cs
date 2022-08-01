using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Loader;

namespace CodingKatas.Array.Strings
{
   
    public class TransactionValidator
    { 
        public class Transaction
    {
        public string Name { get; set; }
        public int Time { get; set; }
        public int Amount { get; set; }
        public string City { get; set; }

        public bool IsValid { get; set; }
        private const int MaxAmountAllowed = 1000;
        private const int MaxTimeTolerance = 60;

        public Transaction(string transaction)
        {
            var items = transaction.Split(',');
            if (items.Length < 3)
                return;
            this.Name = items[0];
            this.Time =  int.Parse(items[1]);
            this.Amount = int.Parse(items[2]);
            this.City = items[3];
            this.IsValid = this.Amount < MaxAmountAllowed;
        }

        public bool ValidateTime(Transaction tran)
        {
          return Math.Abs(this.Time - tran.Time) <= MaxTimeTolerance;
        }

        public override string ToString()
        {
            return $"{this.Name},{this.Time},{this.Amount},{this.City}" ;
        }
    }
  
        public IList<string> InvalidTransactions(string[] transactions)
        {
            var dict = new Dictionary<string, List<Transaction>>();
            var invalids = new List<string>();
            foreach (var t in transactions)
            {
                var tran = new Transaction(t);
                if (!tran.IsValid)
                {
                    invalids.Add(tran.ToString());
                }

                if (dict.TryGetValue(tran.Name, out var listT))
                {
                    foreach (var storedTran in listT)
                    {
                        if (tran.City != storedTran.City)
                        {
                            if (storedTran.ValidateTime(tran) && storedTran.IsValid)
                            {
                                storedTran.IsValid = false;
                                invalids.Add(storedTran.ToString());
                            }
                            if (tran.ValidateTime(storedTran) && tran.IsValid)
                            {
                                tran.IsValid = false;
                                invalids.Add(tran.ToString());
                            } 
                        }
                    }

                    listT.Add(tran);
                }
                else
                {
                    dict.Add(tran.Name, new List<Transaction>(new Transaction[] { tran }));
                }
            }
            return invalids;
        }
    }
}