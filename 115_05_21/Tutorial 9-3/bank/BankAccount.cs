namespace Account_Simulator
{
    /// <summary>
    /// 銀行帳戶類別：負責管理帳戶的餘額與交易操作。
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// 帳戶餘額（私有欄位）。
        /// </summary>
        private decimal balance;

        /// <summary>
        /// 帳戶持有人姓名（私有欄位）。
        /// </summary>
        private string name;

        /// <summary>
        /// 帳戶編號（私有欄位）。
        /// </summary>
        private string accountNumber;

        /// <summary>
        /// 建構子：初始化帳戶並設定初始餘額。
        /// </summary>
        /// <param name="initialBalance">初始餘額金額</param>
        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

        /// <summary>
        /// 建構子：初始化帳戶、設定帳號及初始餘額。
        /// </summary>
        /// <param name="accountNumber">帳號</param>
        /// <param name="initialBalance">初始餘額金額</param>
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            balance = initialBalance;
        }

        /// <summary>
        /// 建構子：初始化帳戶、設定帳號、姓名及初始餘額。
        /// </summary>
        /// <param name="accountNumber">帳號</param>
        /// <param name="name">帳戶持有人姓名</param>
        /// <param name="initialBalance">初始餘額金額</param>
        public BankAccount(string accountNumber, string name, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            balance = initialBalance;
        }

        /// <summary>
        /// 取得帳戶餘額。
        /// </summary>
        public decimal Balance
        {
            get { return balance; }
        }

        /// <summary>
        /// 取得或設定帳戶持有人姓名。
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 取得或設定帳戶編號。
        /// </summary>
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        /// <summary>
        /// 存入金額至帳戶。
        /// </summary>
        /// <param name="amount">存入的金額</param>
        /// <returns>操作成功返回 true，否則返回 false</returns>
        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                return false;
            }
            balance += amount;
            return true;
        }

        /// <summary>
        /// 從帳戶提取金額。
        /// </summary>
        /// <param name="amount">提取的金額</param>
        /// <returns>操作成功返回 true，否則返回 false</returns>
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
            {
                return false;
            }
            balance -= amount;
            return true;
        }

        /// <summary>
        /// 取得帳戶資訊字串。
        /// </summary>
        /// <returns>帳戶資訊</returns>
        public override string ToString()
        {
            return $"帳號: {accountNumber}, 姓名: {name}, 餘額: {balance:C}";
        }
    }
}