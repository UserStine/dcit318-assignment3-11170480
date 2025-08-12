using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class FinanceApp
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void Run()
        {
            // i. Create a savings account
            var account = new SavingsAccount("ACC123", 1000m);

            // ii. Create transactions
            var t1 = new Transaction(1, DateTime.Now, 200m, "Groceries");
            var t2 = new Transaction(2, DateTime.Now, 150m, "Utilities");
            var t3 = new Transaction(3, DateTime.Now, 50m, "Entertainment");

            // iii. Process transactions
            ITransactionProcessor p1 = new MobileMoneyProcessor();
            ITransactionProcessor p2 = new BankTransferProcessor();
            ITransactionProcessor p3 = new CryptoWalletProcessor();

            p1.Process(t1);
            p2.Process(t2);
            p3.Process(t3);

            // iv. Apply transactions to account
            account.ApplyTransaction(t1);
            account.ApplyTransaction(t2);
            account.ApplyTransaction(t3);

            // v. Store transactions
            _transactions.AddRange(new[] { t1, t2, t3 });
        }
    }

}
