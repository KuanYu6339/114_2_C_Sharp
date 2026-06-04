using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulator
{
    class BankAccount
    {
        private string accountNumber;
        private string ownerName;
        private decimal balance;
        private List<string> transactionHistory;

        // 建構函式
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.ownerName = ownerName;
            this.balance = initialBalance;
            this.transactionHistory = new List<string>();
            
            // 紀錄開戶交易
            transactionHistory.Add(string.Format("[{0}] 開戶：+${1:F2}，餘額：${2:F2}", 
                DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), initialBalance, balance));
        }

        // 屬性
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string OwnerName
        {
            get { return ownerName; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public List<string> TransactionHistory
        {
            get { return transactionHistory; }
        }

        // 存錢方法
        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                transactionHistory.Add(string.Format("[{0] 存入：+${1:F2}，餘額：${2:F2}", 
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), amount, balance));
                return true;
            }
            return false;
        }

        // 提錢方法
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                transactionHistory.Add(string.Format("[{0}] 提取：-${1:F2}，餘額：${2:F2}", 
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), amount, balance));
                return true;
            }
            return false;
        }

        // 取得帳戶資訊
        public string GetAccountInfo()
        {
            return string.Format("帳號：{0}\r\n姓名：{1}\r\n餘額：${2:F2}", 
                accountNumber, ownerName, balance);
        }

        // 取得交易歷史
        public string GetTransactionHistory()
        {
            if (transactionHistory.Count == 0)
                return "尚無交易紀錄";

            StringBuilder sb = new StringBuilder();
            for (int i = transactionHistory.Count - 1; i >= 0; i--)
            {
                sb.AppendLine(transactionHistory[i]);
            }
            return sb.ToString();
        }
    }
}
