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
    class Machine
    {
        
        static private double ATMdailyAmount = 0;
        static public DateTime lastUseDate = DateTime.Now, currentUseDate = DateTime.Now;

        static public int verifyLogIn(string PIN)
        {
            if (PIN.Length < 4 && PIN.Length < 6)
            {
                return -1;
            }

            int cID = -1;
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT * FROM blankenship_customer WHERE PIN=@num";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                

                cmd.Parameters.AddWithValue("@num", PIN);
                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    cID = Int32.Parse(myReader["customerID"].ToString());
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return cID;
        }

        static public bool verifyLogOut()
        {
            string message = "Are you sure you wish to log out?";
            string title = "Log Off";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public void updateDaily()
        {
            if (lastUseDate.Date.CompareTo(currentUseDate.Date) == -1)
            {
                ATMdailyAmount = 0;
            }
            lastUseDate = currentUseDate;
        }
        static public bool checkDaily(double amount)
        {
            if (ATMdailyAmount + amount > 100000)
            {
                return false;
            }
            else
            {
                ATMdailyAmount += amount;
                return true;
            }
        }
    }
}
