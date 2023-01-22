using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSoftwareSystem
{
    public partial class Form1 : Form
    {
        Customer thisCustomer;
        Account otherAcc;
        string curTrans;
        int curAccountIndex, secondAccountIndex;
        bool firstAccSelect;
        string[] TRANSACTIONS = { "NONE", "WITHDRAW", "DEPOSIT", "CHECK BALANCE", "TRANSFER"};

        public Form1()
        {
            InitializeComponent();

            // Set initial panel visibility
            panelInsertCard.Visible = true;
            panelMainMenu.Visible = false;
            panelSelectAccount.Visible = false;
            panelTransaction.Visible = false;

            // Set textbox properties
            tBoxLoginEnterPIN.MaxLength = 6;        // Limit PIN code to 6 numbers
            tBoxTransAmount.MaxLength = 7;          // Limit withdraw amount to
                                                    // 7 characters (EX: 3000.00)
        }



        ///////////////////////////
        ////////INSERT CARD////////
        ///////////////////////////
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            int cID = Machine.verifyLogIn(tBoxLoginEnterPIN.Text);
            if (cID != -1)
            {
                thisCustomer = Customer.retrieveInformation(cID);
                panelInsertCard.Visible = false;
                panelMainMenu.Visible = true;
                tBoxLoginEnterPIN.Text = "";
            }
            else
            {
                string box_msg = "Invalid Log In Attempt. Please Try Again.";
                string box_title = "ZZZ Bank";
                MessageBox.Show(box_msg, box_title);
            }
        }

        private void tBoxEnterPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 


        ///////////////////////////
        /////////MAIN MENU/////////
        ///////////////////////////
        ///WITHDRAW///
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            // Set transaction screen
            lblTransEnterAmount.Text = "Please Enter the Amount to Withdraw:";
            tBoxTransAmount.Visible = true;
            btnTransContinue.Visible = true;
            btnTransCancel.Text = "Cancel";
            curTrans = TRANSACTIONS[1];

            // Set account screen
            lblSelectAccount.Text = "Select an Account to WITHDRAW from";

            // Clear previous accounts
            lBoxAccounts.Items.Clear();
            // Add new accounts
            foreach (Account a in thisCustomer.AccountList)
                lBoxAccounts.Items.Add(a.Name);

            // Set panel visibility
            panelMainMenu.Visible = false;
            panelSelectAccount.Visible = true;
            


        }
        ///BUTTON: DEPOSIT///
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            // Set transaction screen
            lblTransEnterAmount.Text = "Please Enter the Amount to Deposit:";
            tBoxTransAmount.Visible = true;
            btnTransContinue.Visible = true;
            btnTransCancel.Text = "Cancel";
            curTrans = TRANSACTIONS[2];

            // Set account screen
            lblSelectAccount.Text = "Select an Account to DEPOSIT into";

            // Clear previous accounts
            lBoxAccounts.Items.Clear();
            // Add new accounts
            foreach (Account a in thisCustomer.AccountList)
                lBoxAccounts.Items.Add(a.Name);

            // Set panel visibility
            panelMainMenu.Visible = false;
            panelSelectAccount.Visible = true;
        }
        ///BUTTON: CHECK BALANCE///
        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            // Set transaction screen
            lblTransCurBal.Text = "";
            lblTransAccountName.Text = "";
            lblTransEnterAmount.Text = "";
            tBoxTransAmount.Visible = false;
            btnTransContinue.Visible = false;
            btnTransCancel.Text = "Done";
            curTrans = TRANSACTIONS[3];

            // Set account screen
            lblSelectAccount.Text = "Select an Account to CHECK BALANCE";

            // Clear previous accounts
            lBoxAccounts.Items.Clear();
            // Add new accounts
            foreach (Account a in thisCustomer.AccountList)
                lBoxAccounts.Items.Add(a.Name);

            //set panel visibility
            panelMainMenu.Visible = false;
            panelSelectAccount.Visible = true;
        }
        ///BUTTON: TRANSFER MONEY///
        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            // Set transaction screen
            lblTransEnterAmount.Text = "Please Enter the Amount to Transfer:";
            tBoxTransAmount.Visible = true;
            btnTransContinue.Visible = true;
            btnTransCancel.Text = "Cancel";
            curTrans = TRANSACTIONS[4];
            firstAccSelect = false;

            // Set account screen
            lblSelectAccount.Text = "Select an Account to TRANSFER FROM";

            // Clear previous accounts
            lBoxAccounts.Items.Clear();
            // Add new accounts
            foreach (Account a in thisCustomer.AccountList)
                lBoxAccounts.Items.Add(a.Name);

            // Set panel visibility
            panelMainMenu.Visible = false;
            panelSelectAccount.Visible = true;
        }
        ///BUTTON: LOG OFF///
        private void btnLogOff_Click(object sender, EventArgs e)
        {
            curTrans = TRANSACTIONS[0];
            if (Machine.verifyLogOut())
            {
                thisCustomer = null;
                panelInsertCard.Visible = true;
                panelMainMenu.Visible = false;
            }
        }



        ///////////////////////////
        //////SELECT ACCOUNT///////
        ///////////////////////////
        private void btnAccConfirm_Click(object sender, EventArgs e)
        {
            if (lBoxAccounts.SelectedIndex >= 0)
            {
                string curAccountName = lBoxAccounts.SelectedItem.ToString();
                if (curTrans.Equals("TRANSFER") && !firstAccSelect)
                {
                    curAccountIndex = -1;
                    foreach (Account a in thisCustomer.AccountList)
                    {
                        curAccountIndex++;
                        if (curAccountName == a.Name)
                        {
                            // Set Labels
                            
                            if (a.Balance % 1 == 0)
                                lblTransAccountName.Text = a.Name + " Balance: " + a.Balance + ".00";
                            else
                                lblTransAccountName.Text = a.Name + " Balance: " + a.Balance;
                            break;
                        }
                    }

                    int i = -1;
                    // Clear previous accounts
                    lBoxAccounts.Items.Clear();

                    // Add new accounts
                    foreach (Account a in thisCustomer.AccountList)
                    {
                        i++;
                        if (i != curAccountIndex)
                            lBoxAccounts.Items.Add(a.Name);
                    }
                        

                    lblSelectAccount.Text = "Select an account to TRANSFER INTO";
                    firstAccSelect = true;
                }
                else if (curTrans.Equals("TRANSFER"))
                {
                    secondAccountIndex = -1;
                    foreach (Account a in thisCustomer.AccountList)
                    {
                        secondAccountIndex++;
                        if (curAccountName == a.Name)
                        {
                            // Set Labels
                            if (a.Balance % 1 == 0)
                                lblTransCurBal.Text = a.Name + " Balance: " + a.Balance + ".00";
                            else
                                lblTransCurBal.Text = a.Name + " Balance: " + a.Balance;
                            break;
                        }
                    }
                    firstAccSelect = false;

                    // Set panel visibility
                    panelSelectAccount.Visible = false;
                    panelTransaction.Visible = true;

                    // Set text
                    lblSelectAccount.Text = "Select an account";
                    tBoxTransAmount.Text = "";
                }
                else
                {
                    curAccountIndex = -1;
                    foreach (Account a in thisCustomer.AccountList)
                    {
                        curAccountIndex++;
                        if (curAccountName == a.Name)
                        {
                            // Set Labels
                            lblTransAccountName.Text = "Account Name: " + a.Name;
                            if (a.Balance % 1 == 0)
                                lblTransCurBal.Text = "Balance: " + a.Balance + ".00";
                            else
                                lblTransCurBal.Text = "Balance: " + a.Balance;
                            break;
                        }
                    }

                    // Set panel visibility
                    panelSelectAccount.Visible = false;
                    panelTransaction.Visible = true;

                    // Set withdraw amount
                    tBoxTransAmount.Text = "";
                }
            }
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            //set panel visibility
            panelMainMenu.Visible = true;
            panelSelectAccount.Visible = false;
            lblSelectAccount.Text = "Select an account";
            firstAccSelect = false;
        }


        ///////////////////////////
        ///////TRANSACTIONS////////
        ///////////////////////////
        private void tBoxTransAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Initialize variables
            string senderText = (sender as TextBox).Text;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;

            // Only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // But also allow only one decimal point
            if (e.KeyChar == '.'
                && senderText.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // And make sure that only two numbers can be put after decimal point
            if (!char.IsControl(e.KeyChar) && senderText.IndexOf('.') < cursorPosition 
                && splitByDecimal.Length > 1 && splitByDecimal[1].Length == 2)
            {
                e.Handled = true;
            }
        }
        private void btnTransCon_Click(object sender, EventArgs e)
        {
            if (tBoxTransAmount.TextLength > 0 && tBoxTransAmount.Text != ".")
            {
                if (Double.Parse(tBoxTransAmount.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Please enter an amount above 0 dollars.", "ZZZ Bank");
                }
                else if (Double.Parse(tBoxTransAmount.Text.ToString()) <= 3000 - thisCustomer.AccountList[curAccountIndex].DailyTransLimit)
                {
                    switch (curTrans)
                    {
                        case "NONE":
                            break;
                        case "WITHDRAW":
                            thisCustomer.AccountList[curAccountIndex].processWithdraw(Double.Parse(tBoxTransAmount.Text.ToString()));
                            lblTransEnterAmount.Visible = false;
                            tBoxTransAmount.Visible = false;
                            if (thisCustomer.AccountList[curAccountIndex].Balance % 1 == 0)
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance + ".00";
                            else
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance;
                            break;
                        case "DEPOSIT":
                            thisCustomer.AccountList[curAccountIndex].processDeposit(Double.Parse(tBoxTransAmount.Text.ToString()));
                            lblTransEnterAmount.Visible = false;
                            tBoxTransAmount.Visible = false;
                            if (thisCustomer.AccountList[curAccountIndex].Balance % 1 == 0)
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance + ".00";
                            else
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance;
                            break;
                        case "CHECK BALANCE":
                            break;
                        case "TRANSFER":
                            thisCustomer.AccountList[curAccountIndex].processTransfer(Double.Parse(tBoxTransAmount.Text.ToString()), thisCustomer.AccountList[secondAccountIndex]);
                            lblTransEnterAmount.Visible = false;
                            tBoxTransAmount.Visible = false;
                            if (thisCustomer.AccountList[curAccountIndex].Balance % 1 == 0)
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance + ".00";
                            else
                                lblTransCurBal.Text = "Balance: " + thisCustomer.AccountList[curAccountIndex].Balance;
                            break;
                    }
                    //set panel visibility
                    lblTransEnterAmount.Visible = true;
                    tBoxTransAmount.Visible = true;
                    panelMainMenu.Visible = true;
                    panelTransaction.Visible = false;
                }
                else if (Double.Parse(tBoxTransAmount.Text.ToString()) >= 3000 - thisCustomer.AccountList[curAccountIndex].DailyTransLimit)
                {
                    MessageBox.Show("This transaction exceeds the ATM's daily transaction limit of $3000. Please enter a lower amount or wait until the next day.", "ZZZ Bank");
                }
            }
            else
            {
                MessageBox.Show("Please enter a value for the transaction.", "ZZZ Bank");
            }
        }

        private void btnTransCancel_Click(object sender, EventArgs e)
        {
            //set panel visibility
            panelSelectAccount.Visible = true;
            panelTransaction.Visible = false;
        }
    }
}
