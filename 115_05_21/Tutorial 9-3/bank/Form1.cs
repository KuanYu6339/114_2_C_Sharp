using Account_Simulator;

namespace bank
{
    public partial class Form1 : Form
    {
        private BankAccount? currentAccount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "銀行帳戶管理系統";
            this.Width = 700;
            this.Height = 450;
            InitializeControls();
        }

        private void InitializeControls()
        {
            // 主標題
            Label titleLabel = new Label();
            titleLabel.Text = "建立帳戶";
            titleLabel.Font = new Font("新細明體", 14, FontStyle.Bold);
            titleLabel.Location = new Point(50, 30);
            titleLabel.Size = new Size(200, 30);
            this.Controls.Add(titleLabel);

            // 帳號
            Label accountLabel = new Label();
            accountLabel.Text = "帳號：";
            accountLabel.Location = new Point(50, 80);
            accountLabel.Size = new Size(80, 25);
            this.Controls.Add(accountLabel);

            TextBox accountTextBox = new TextBox();
            accountTextBox.Name = "accountTextBox";
            accountTextBox.Location = new Point(130, 80);
            accountTextBox.Size = new Size(200, 25);
            this.Controls.Add(accountTextBox);

            // 姓名
            Label nameLabel = new Label();
            nameLabel.Text = "姓名：";
            nameLabel.Location = new Point(50, 120);
            nameLabel.Size = new Size(80, 25);
            this.Controls.Add(nameLabel);

            TextBox nameTextBox = new TextBox();
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Location = new Point(130, 120);
            nameTextBox.Size = new Size(200, 25);
            this.Controls.Add(nameTextBox);

            // 開戶金額
            Label initialAmountLabel = new Label();
            initialAmountLabel.Text = "開戶金額：";
            initialAmountLabel.Location = new Point(50, 160);
            initialAmountLabel.Size = new Size(80, 25);
            this.Controls.Add(initialAmountLabel);

            TextBox initialAmountTextBox = new TextBox();
            initialAmountTextBox.Name = "initialAmountTextBox";
            initialAmountTextBox.Location = new Point(130, 160);
            initialAmountTextBox.Size = new Size(200, 25);
            this.Controls.Add(initialAmountTextBox);

            // 建立帳戶按鈕
            Button createAccountBtn = new Button();
            createAccountBtn.Text = "建立帳戶";
            createAccountBtn.Location = new Point(450, 100);
            createAccountBtn.Size = new Size(100, 80);
            createAccountBtn.Font = new Font("新細明體", 11, FontStyle.Bold);
            createAccountBtn.Click += CreateAccountBtn_Click;
            this.Controls.Add(createAccountBtn);

            // 存入金額標籤
            Label depositLabel = new Label();
            depositLabel.Text = "存入";
            depositLabel.Location = new Point(50, 220);
            depositLabel.Size = new Size(80, 25);
            this.Controls.Add(depositLabel);

            Label depositAmountLabel = new Label();
            depositAmountLabel.Text = "金額：";
            depositAmountLabel.Location = new Point(50, 250);
            depositAmountLabel.Size = new Size(50, 25);
            this.Controls.Add(depositAmountLabel);

            TextBox depositAmountTextBox = new TextBox();
            depositAmountTextBox.Name = "depositAmountTextBox";
            depositAmountTextBox.Location = new Point(100, 250);
            depositAmountTextBox.Size = new Size(120, 25);
            this.Controls.Add(depositAmountTextBox);

            // 提取金額標籤
            Label withdrawLabel = new Label();
            withdrawLabel.Text = "提取";
            withdrawLabel.Location = new Point(280, 220);
            withdrawLabel.Size = new Size(80, 25);
            this.Controls.Add(withdrawLabel);

            Label withdrawAmountLabel = new Label();
            withdrawAmountLabel.Text = "金額：";
            withdrawAmountLabel.Location = new Point(280, 250);
            withdrawAmountLabel.Size = new Size(50, 25);
            this.Controls.Add(withdrawAmountLabel);

            TextBox withdrawAmountTextBox = new TextBox();
            withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            withdrawAmountTextBox.Location = new Point(330, 250);
            withdrawAmountTextBox.Size = new Size(120, 25);
            this.Controls.Add(withdrawAmountTextBox);

            // 存入按鈕
            Button depositBtn = new Button();
            depositBtn.Text = "存入";
            depositBtn.Location = new Point(100, 290);
            depositBtn.Size = new Size(80, 30);
            depositBtn.Click += DepositBtn_Click;
            this.Controls.Add(depositBtn);

            // 提取按鈕
            Button withdrawBtn = new Button();
            withdrawBtn.Text = "提取";
            withdrawBtn.Location = new Point(330, 290);
            withdrawBtn.Size = new Size(80, 30);
            withdrawBtn.Click += WithdrawBtn_Click;
            this.Controls.Add(withdrawBtn);

            // 餘額顯示
            Label balanceLabel = new Label();
            balanceLabel.Text = "餘額：";
            balanceLabel.Location = new Point(480, 220);
            balanceLabel.Size = new Size(50, 25);
            this.Controls.Add(balanceLabel);

            TextBox balanceTextBox = new TextBox();
            balanceTextBox.Name = "balanceTextBox";
            balanceTextBox.Location = new Point(480, 250);
            balanceTextBox.Size = new Size(120, 25);
            balanceTextBox.ReadOnly = true;
            this.Controls.Add(balanceTextBox);

            // 離開按鈕
            Button exitBtn = new Button();
            exitBtn.Text = "離開";
            exitBtn.Location = new Point(520, 290);
            exitBtn.Size = new Size(80, 30);
            exitBtn.Click += ExitBtn_Click;
            this.Controls.Add(exitBtn);
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox accountTextBox = (TextBox)this.Controls["accountTextBox"];
                TextBox nameTextBox = (TextBox)this.Controls["nameTextBox"];
                TextBox initialAmountTextBox = (TextBox)this.Controls["initialAmountTextBox"];

                if (string.IsNullOrWhiteSpace(accountTextBox.Text))
                {
                    MessageBox.Show("請輸入帳號！", "錯誤");
                    return;
                }

                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                {
                    MessageBox.Show("請輸入姓名！", "錯誤");
                    return;
                }

                if (!decimal.TryParse(initialAmountTextBox.Text, out decimal amount))
                {
                    MessageBox.Show("請輸入有效的金額！", "錯誤");
                    return;
                }

                if (amount < 0)
                {
                    MessageBox.Show("金額不能為負數！", "錯誤");
                    return;
                }

                // 建立帳戶
                currentAccount = new BankAccount(accountTextBox.Text, nameTextBox.Text, amount);

                // 更新餘額顯示
                TextBox balanceTextBox = (TextBox)this.Controls["balanceTextBox"];
                balanceTextBox.Text = currentAccount.Balance.ToString("F2");

                // 清空輸入欄位
                accountTextBox.Clear();
                nameTextBox.Clear();
                initialAmountTextBox.Clear();

                MessageBox.Show($"帳戶建立成功！\n帳號：{currentAccount.AccountNumber}\n姓名：{currentAccount.Name}\n餘額：{currentAccount.Balance:F2}", "提示");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤：{ex.Message}", "錯誤");
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentAccount == null)
                {
                    MessageBox.Show("請先建立帳戶！", "錯誤");
                    return;
                }

                TextBox depositAmountTextBox = (TextBox)this.Controls["depositAmountTextBox"];

                if (string.IsNullOrWhiteSpace(depositAmountTextBox.Text))
                {
                    MessageBox.Show("請輸入存入金額！", "錯誤");
                    return;
                }

                if (!decimal.TryParse(depositAmountTextBox.Text, out decimal amount))
                {
                    MessageBox.Show("請輸入有效的金額！", "錯誤");
                    return;
                }

                if (currentAccount.Deposit(amount))
                {
                    TextBox balanceTextBox = (TextBox)this.Controls["balanceTextBox"];
                    balanceTextBox.Text = currentAccount.Balance.ToString("F2");
                    depositAmountTextBox.Clear();
                    MessageBox.Show($"存入成功！\n存入金額：{amount:F2}\n目前餘額：{currentAccount.Balance:F2}", "提示");
                }
                else
                {
                    MessageBox.Show("存入金額必須大於 0！", "錯誤");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤：{ex.Message}", "錯誤");
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentAccount == null)
                {
                    MessageBox.Show("請先建立帳戶！", "錯誤");
                    return;
                }

                TextBox withdrawAmountTextBox = (TextBox)this.Controls["withdrawAmountTextBox"];

                if (string.IsNullOrWhiteSpace(withdrawAmountTextBox.Text))
                {
                    MessageBox.Show("請輸入提取金額！", "錯誤");
                    return;
                }

                if (!decimal.TryParse(withdrawAmountTextBox.Text, out decimal amount))
                {
                    MessageBox.Show("請輸入有效的金額！", "錯誤");
                    return;
                }

                if (currentAccount.Withdraw(amount))
                {
                    TextBox balanceTextBox = (TextBox)this.Controls["balanceTextBox"];
                    balanceTextBox.Text = currentAccount.Balance.ToString("F2");
                    withdrawAmountTextBox.Clear();
                    MessageBox.Show($"提取成功！\n提取金額：{amount:F2}\n目前餘額：{currentAccount.Balance:F2}", "提示");
                }
                else
                {
                    MessageBox.Show($"提取失敗！\n提取金額必須大於 0 且不超過餘額 {currentAccount.Balance:F2}", "錯誤");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"錯誤：{ex.Message}", "錯誤");
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
