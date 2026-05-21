using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Simulator
{
    public partial class Form1 : Form
    {
        private BankAccount account;
        private const decimal MaxTransactionAmount = 1000000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            account = null;
            accountInfoTextBox.Text = "請先建立帳戶";
            InitializeControls();
        }

        private void InitializeControls()
        {
            // 初始化控制項
            depositAmountTextBox.Clear();
            withdrawAmountTextBox.Clear();
            LockOperationControls();
        }

        private void LockOperationControls()
        {
            // 鎖定存提操作（未建立帳戶時）
            depositGroupBox.Enabled = false;
            withdrawGroupBox.Enabled = false;
        }

        private void UnlockOperationControls()
        {
            // 解鎖存提操作（建立帳戶後）
            depositGroupBox.Enabled = true;
            withdrawGroupBox.Enabled = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                string accountNumber = accountNumberTextBox.Text.Trim();
                string ownerName = ownerNameTextBox.Text.Trim();
                string balanceText = initialBalanceTextBox.Text.Trim();

                // 驗證帳號
                if (string.IsNullOrEmpty(accountNumber))
                {
                    MessageBox.Show("請輸入帳號", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accountNumberTextBox.Focus();
                    return;
                }

                if (accountNumber.Length < 6)
                {
                    MessageBox.Show("帳號至少需要6個字元", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    accountNumberTextBox.Focus();
                    return;
                }

                // 驗證姓名
                if (string.IsNullOrEmpty(ownerName))
                {
                    MessageBox.Show("請輸入姓名", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ownerNameTextBox.Focus();
                    return;
                }

                // 驗證初始金額
                if (string.IsNullOrEmpty(balanceText))
                {
                    MessageBox.Show("請輸入開戶金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    initialBalanceTextBox.Focus();
                    return;
                }

                decimal initialBalance;
                if (!decimal.TryParse(balanceText, out initialBalance))
                {
                    MessageBox.Show("開戶金額請輸入有效數字", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    initialBalanceTextBox.Focus();
                    return;
                }

                if (initialBalance < 0)
                {
                    MessageBox.Show("開戶金額不能為負數", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    initialBalanceTextBox.Focus();
                    return;
                }

                if (initialBalance > MaxTransactionAmount)
                {
                    MessageBox.Show(string.Format("開戶金額不能超過${0:F2}", MaxTransactionAmount), 
                        "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    initialBalanceTextBox.Focus();
                    return;
                }

                account = new BankAccount(accountNumber, ownerName, initialBalance);
                UpdateDisplay();
                UnlockOperationControls();
                
                MessageBox.Show("帳戶建立成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // 清空建立帳戶的輸入欄
                accountNumberTextBox.Clear();
                ownerNameTextBox.Clear();
                initialBalanceTextBox.Clear();
                createButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("請先建立帳戶", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string amountText = depositAmountTextBox.Text.Trim();

                if (string.IsNullOrEmpty(amountText))
                {
                    MessageBox.Show("請輸入存入金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    depositAmountTextBox.Focus();
                    return;
                }

                decimal amount;
                if (!decimal.TryParse(amountText, out amount))
                {
                    MessageBox.Show("請輸入有效的金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    depositAmountTextBox.Focus();
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("存入金額必須大於0", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    depositAmountTextBox.Focus();
                    return;
                }

                if (amount > MaxTransactionAmount)
                {
                    MessageBox.Show(string.Format("單筆存入金額不能超過${0:F2}", MaxTransactionAmount), 
                        "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (account.Deposit(amount))
                {
                    depositAmountTextBox.Clear();
                    UpdateDisplay();
                    MessageBox.Show(string.Format("存入${0:F2}成功\n新餘額：${1:F2}", amount, account.Balance), 
                        "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (account == null)
            {
                MessageBox.Show("請先建立帳戶", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string amountText = withdrawAmountTextBox.Text.Trim();

                if (string.IsNullOrEmpty(amountText))
                {
                    MessageBox.Show("請輸入提取金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    withdrawAmountTextBox.Focus();
                    return;
                }

                decimal amount;
                if (!decimal.TryParse(amountText, out amount))
                {
                    MessageBox.Show("請輸入有效的金額", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    withdrawAmountTextBox.Focus();
                    return;
                }

                if (amount <= 0)
                {
                    MessageBox.Show("提取金額必須大於0", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    withdrawAmountTextBox.Focus();
                    return;
                }

                if (amount > MaxTransactionAmount)
                {
                    MessageBox.Show(string.Format("單筆提取金額不能超過${0:F2}", MaxTransactionAmount), 
                        "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (amount > account.Balance)
                {
                    MessageBox.Show(string.Format("餘額不足！\n目前餘額：${0:F2}", account.Balance), 
                        "提取失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (account.Withdraw(amount))
                {
                    withdrawAmountTextBox.Clear();
                    UpdateDisplay();
                    MessageBox.Show(string.Format("提取${0:F2}成功\n新餘額：${1:F2}", amount, account.Balance), 
                        "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("系統錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要關閉程式嗎？", "確認", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void UpdateDisplay()
        {
            if (account != null)
            {
                accountInfoTextBox.Text = account.GetAccountInfo();
            }
        }
    }
}