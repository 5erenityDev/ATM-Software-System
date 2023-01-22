using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ATMSoftwareSystem
{
    class Account
    {
        private int accountID;
        private string name;
        private double balance;
        private double dailyTransLimit;


        public Account(int accID, string n, double bal, double dayTrans)
        {
            accountID = accID;
            name = n;
            balance = bal;
            dailyTransLimit = dayTrans;
        }

        public void processWithdraw(double amount)
        {
            if (this.balance >= amount)
            {
                string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

                try
                {
                    conn.Open();
                    string sql = "UPDATE blankenship_account SET balance = @bal, dailyTransAmount = @dailyTrans WHERE accountID = @accID";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    Machine.updateDaily();
                    if (Machine.checkDaily(amount))
                    {
                        cmd.Parameters.AddWithValue("@bal", this.balance - amount);
                        cmd.Parameters.AddWithValue("@dailyTrans", this.dailyTransLimit + amount);
                        cmd.Parameters.AddWithValue("@accID", this.accountID);
                        cmd.ExecuteNonQuery();

                        this.balance -= amount;
                        this.dailyTransLimit += amount;
                        MessageBox.Show("Cash has been dispensed. Please collect it.", "ZZZ Bank");
                    }
                    else
                    {
                        MessageBox.Show("This ATM is out of money for possible withdraws. Please use a different ATM or return to this one tommorow.", "ZZZ Bank");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("You do not have enough money for this transaction. Please lower the amount or deposit more funds.", "ZZZ Bank");
            }
        }

        public void processDeposit(double amount)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "UPDATE blankenship_account SET balance = @bal, dailyTransAmount = @dailyTrans WHERE accountID = @accID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@bal", this.balance + amount);
                cmd.Parameters.AddWithValue("@dailyTrans", this.dailyTransLimit + amount);
                cmd.Parameters.AddWithValue("@accID", this.accountID);
                cmd.ExecuteNonQuery();

                this.balance += amount;
                this.dailyTransLimit += amount;
                MessageBox.Show("Cash has been deposited and will be processed by the bank. Thank you.", "ZZZ Bank");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        public void processTransfer(double amount, Account otherAcc)
        {
            if (this.balance >= amount)
            {
                string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

                try
                {
                    conn.Open();
                    string sql = "UPDATE blankenship_account SET balance = @bal, dailyTransAmount = @dailyTrans WHERE accountID = @accID";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                    cmd.Parameters.AddWithValue("@bal", this.balance - amount);
                    cmd.Parameters.AddWithValue("@dailyTrans", this.dailyTransLimit + amount);
                    cmd.Parameters.AddWithValue("@accID", this.accountID);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    this.balance -= amount;
                    this.dailyTransLimit += amount;

                    conn.Open();
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@bal", otherAcc.Balance + amount);
                    cmd.Parameters.AddWithValue("@dailyTrans", otherAcc.DailyTransLimit + amount);
                    cmd.Parameters.AddWithValue("@accID", otherAcc.AccountID);
                    cmd.ExecuteNonQuery();

                    otherAcc.Balance += amount;
                    otherAcc.DailyTransLimit += amount;
                    MessageBox.Show("Cash has been transfered from one acccount to the other. Thank you.", "ZZZ Bank");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("You do not have enough money for this transaction. Please lower the amount or deposit more funds.", "ZZZ Bank");
            }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double DailyTransLimit
        {
            get { return dailyTransLimit; }
            set { dailyTransLimit = value; }
        }

        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }
    }
}
