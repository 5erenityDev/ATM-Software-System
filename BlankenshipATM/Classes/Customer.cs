using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftwareSystem
{
    class Customer
    {
        private int customerID;
        private string name;
        private DateTime lastAccessDate;
        private DateTime currentAccessDate;
        private List<Account> accountList;

        Customer(int cID, string n, DateTime lad, List<Account> accList)
        {
            customerID = cID;
            name = n;
            lastAccessDate = lad;
            currentAccessDate = DateTime.Now;
            accountList = accList;
        }

        public void analyzeAccessDate()
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            if (lastAccessDate.Date.CompareTo(currentAccessDate.Date) == -1)
            {
                try
                {
                    foreach(Account acc in this.accountList)
                    {
                        conn.Open();
                        string sql = "UPDATE blankenship_account SET dailyTransAmount = @dailyTrans WHERE accountID = @accID";
                        MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@dailyTrans", 0);
                        cmd.Parameters.AddWithValue("@accID", acc.AccountID);
                        cmd.ExecuteNonQuery();

                        acc.DailyTransLimit = 0;
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                
            }
            try
            {
                conn.Open();
                string sql = "UPDATE blankenship_customer SET lastAccessDate = @lastAcc WHERE customerID = @cID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@lastAcc", this.currentAccessDate.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@cID", this.customerID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }
        public static Customer retrieveInformation(int cID)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            Customer thisCustomer = null;

            try
            {
                conn.Open();
                string name = "";
                DateTime lad = DateTime.Now;
                List<Account> newAccountList = new List<Account>();

                string sql = "SELECT * FROM blankenship_customer WHERE customerID=@cID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                

                cmd.Parameters.AddWithValue("@cID", cID);         //accID was localID

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    name = myReader["name"].ToString();
                    lad = Convert.ToDateTime(myReader["lastAccessDate"].ToString());
                }

                conn.Close();
                conn.Open();
                sql = "SELECT * FROM blankenship_account WHERE customerID=@cID";
                cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@cID", cID);         //accID was localID

                myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    int accID = Int32.Parse(myReader["accountID"].ToString());
                    string accountName = myReader["accountName"].ToString();
                    double bal = Double.Parse(myReader["balance"].ToString());
                    double dayTrans = Double.Parse(myReader["dailyTransAmount"].ToString());

                    newAccountList.Add(new Account(accID, accountName, bal, dayTrans));
                }

                thisCustomer = new Customer(cID, name, lad, newAccountList);
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            thisCustomer.analyzeAccessDate();
            return thisCustomer;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Account> AccountList
        {
            get { return accountList; }
            set { accountList = value; }
        }
    }
}
