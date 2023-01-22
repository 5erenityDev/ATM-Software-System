
namespace ATMSoftwareSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonLogOff = new System.Windows.Forms.Button();
            this.buttonCheckBalance = new System.Windows.Forms.Button();
            this.buttonTransferMoney = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelSelectAccount = new System.Windows.Forms.Panel();
            this.btnAccConfirm = new System.Windows.Forms.Button();
            this.btnAccCancel = new System.Windows.Forms.Button();
            this.lBoxAccounts = new System.Windows.Forms.ListBox();
            this.lblSelectAccount = new System.Windows.Forms.Label();
            this.panelTransaction = new System.Windows.Forms.Panel();
            this.btnTransCancel = new System.Windows.Forms.Button();
            this.btnTransContinue = new System.Windows.Forms.Button();
            this.tBoxTransAmount = new System.Windows.Forms.TextBox();
            this.lblTransEnterAmount = new System.Windows.Forms.Label();
            this.lblTransCurBal = new System.Windows.Forms.Label();
            this.lblTransAccountName = new System.Windows.Forms.Label();
            this.panelInsertCard = new System.Windows.Forms.Panel();
            this.tBoxLoginEnterPIN = new System.Windows.Forms.TextBox();
            this.btnLoginExit = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblLoginInsertCard = new System.Windows.Forms.Label();
            this.lblLoginZZZBank = new System.Windows.Forms.Label();
            this.panelMainMenu.SuspendLayout();
            this.panelSelectAccount.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.panelInsertCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Controls.Add(this.buttonLogOff);
            this.panelMainMenu.Controls.Add(this.buttonCheckBalance);
            this.panelMainMenu.Controls.Add(this.buttonTransferMoney);
            this.panelMainMenu.Controls.Add(this.buttonDeposit);
            this.panelMainMenu.Controls.Add(this.btnWithdraw);
            this.panelMainMenu.Controls.Add(this.lblWelcome);
            this.panelMainMenu.Location = new System.Drawing.Point(12, 12);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(544, 426);
            this.panelMainMenu.TabIndex = 0;
            // 
            // buttonLogOff
            // 
            this.buttonLogOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.buttonLogOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.buttonLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOff.Font = new System.Drawing.Font("Lato", 20F);
            this.buttonLogOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.buttonLogOff.Location = new System.Drawing.Point(23, 331);
            this.buttonLogOff.Name = "buttonLogOff";
            this.buttonLogOff.Size = new System.Drawing.Size(499, 81);
            this.buttonLogOff.TabIndex = 6;
            this.buttonLogOff.Text = "Log Off";
            this.buttonLogOff.UseVisualStyleBackColor = false;
            this.buttonLogOff.Click += new System.EventHandler(this.btnLogOff_Click);
            // 
            // buttonCheckBalance
            // 
            this.buttonCheckBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.buttonCheckBalance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.buttonCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckBalance.Font = new System.Drawing.Font("Lato", 20F);
            this.buttonCheckBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.buttonCheckBalance.Location = new System.Drawing.Point(23, 213);
            this.buttonCheckBalance.Name = "buttonCheckBalance";
            this.buttonCheckBalance.Size = new System.Drawing.Size(230, 94);
            this.buttonCheckBalance.TabIndex = 5;
            this.buttonCheckBalance.Text = "Check Balance";
            this.buttonCheckBalance.UseVisualStyleBackColor = false;
            this.buttonCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // buttonTransferMoney
            // 
            this.buttonTransferMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.buttonTransferMoney.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.buttonTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransferMoney.Font = new System.Drawing.Font("Lato", 20F);
            this.buttonTransferMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.buttonTransferMoney.Location = new System.Drawing.Point(292, 213);
            this.buttonTransferMoney.Name = "buttonTransferMoney";
            this.buttonTransferMoney.Size = new System.Drawing.Size(230, 94);
            this.buttonTransferMoney.TabIndex = 4;
            this.buttonTransferMoney.Text = "Transfer Money";
            this.buttonTransferMoney.UseVisualStyleBackColor = false;
            this.buttonTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.buttonDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.buttonDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeposit.Font = new System.Drawing.Font("Lato", 20F);
            this.buttonDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.buttonDeposit.Location = new System.Drawing.Point(292, 96);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(230, 94);
            this.buttonDeposit.TabIndex = 2;
            this.buttonDeposit.Text = "Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = false;
            this.buttonDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnWithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Lato", 20F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnWithdraw.Location = new System.Drawing.Point(21, 96);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(232, 94);
            this.btnWithdraw.TabIndex = 1;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Lato", 25F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.lblWelcome.Location = new System.Drawing.Point(56, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(431, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to ZZZ Bank ATM";
            // 
            // panelSelectAccount
            // 
            this.panelSelectAccount.Controls.Add(this.btnAccConfirm);
            this.panelSelectAccount.Controls.Add(this.btnAccCancel);
            this.panelSelectAccount.Controls.Add(this.lBoxAccounts);
            this.panelSelectAccount.Controls.Add(this.lblSelectAccount);
            this.panelSelectAccount.Location = new System.Drawing.Point(12, 12);
            this.panelSelectAccount.Name = "panelSelectAccount";
            this.panelSelectAccount.Size = new System.Drawing.Size(544, 426);
            this.panelSelectAccount.TabIndex = 3;
            // 
            // btnAccConfirm
            // 
            this.btnAccConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnAccConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnAccConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccConfirm.Font = new System.Drawing.Font("Lato", 20F);
            this.btnAccConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnAccConfirm.Location = new System.Drawing.Point(408, 361);
            this.btnAccConfirm.Name = "btnAccConfirm";
            this.btnAccConfirm.Size = new System.Drawing.Size(126, 51);
            this.btnAccConfirm.TabIndex = 3;
            this.btnAccConfirm.Text = "Confirm";
            this.btnAccConfirm.UseVisualStyleBackColor = false;
            this.btnAccConfirm.Click += new System.EventHandler(this.btnAccConfirm_Click);
            // 
            // btnAccCancel
            // 
            this.btnAccCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnAccCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnAccCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnAccCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnAccCancel.Location = new System.Drawing.Point(11, 361);
            this.btnAccCancel.Name = "btnAccCancel";
            this.btnAccCancel.Size = new System.Drawing.Size(126, 51);
            this.btnAccCancel.TabIndex = 2;
            this.btnAccCancel.Text = "Cancel";
            this.btnAccCancel.UseVisualStyleBackColor = false;
            this.btnAccCancel.Click += new System.EventHandler(this.btnAccCancel_Click);
            // 
            // lBoxAccounts
            // 
            this.lBoxAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.lBoxAccounts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lBoxAccounts.Font = new System.Drawing.Font("Lato", 30F);
            this.lBoxAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.lBoxAccounts.FormattingEnabled = true;
            this.lBoxAccounts.ItemHeight = 48;
            this.lBoxAccounts.Location = new System.Drawing.Point(10, 55);
            this.lBoxAccounts.Name = "lBoxAccounts";
            this.lBoxAccounts.Size = new System.Drawing.Size(524, 290);
            this.lBoxAccounts.TabIndex = 1;
            // 
            // lblSelectAccount
            // 
            this.lblSelectAccount.AutoSize = true;
            this.lblSelectAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSelectAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.lblSelectAccount.Location = new System.Drawing.Point(2, 12);
            this.lblSelectAccount.Name = "lblSelectAccount";
            this.lblSelectAccount.Size = new System.Drawing.Size(230, 31);
            this.lblSelectAccount.TabIndex = 0;
            this.lblSelectAccount.Text = "Select an account";
            // 
            // panelTransaction
            // 
            this.panelTransaction.Controls.Add(this.btnTransCancel);
            this.panelTransaction.Controls.Add(this.btnTransContinue);
            this.panelTransaction.Controls.Add(this.tBoxTransAmount);
            this.panelTransaction.Controls.Add(this.lblTransEnterAmount);
            this.panelTransaction.Controls.Add(this.lblTransCurBal);
            this.panelTransaction.Controls.Add(this.lblTransAccountName);
            this.panelTransaction.Location = new System.Drawing.Point(12, 12);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new System.Drawing.Size(544, 426);
            this.panelTransaction.TabIndex = 3;
            // 
            // btnTransCancel
            // 
            this.btnTransCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnTransCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnTransCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransCancel.Font = new System.Drawing.Font("Lato", 25F);
            this.btnTransCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnTransCancel.Location = new System.Drawing.Point(13, 307);
            this.btnTransCancel.Name = "btnTransCancel";
            this.btnTransCancel.Size = new System.Drawing.Size(240, 99);
            this.btnTransCancel.TabIndex = 5;
            this.btnTransCancel.Text = "Cancel";
            this.btnTransCancel.UseVisualStyleBackColor = false;
            this.btnTransCancel.Click += new System.EventHandler(this.btnTransCancel_Click);
            // 
            // btnTransContinue
            // 
            this.btnTransContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnTransContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnTransContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransContinue.Font = new System.Drawing.Font("Lato", 25F);
            this.btnTransContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnTransContinue.Location = new System.Drawing.Point(287, 307);
            this.btnTransContinue.Name = "btnTransContinue";
            this.btnTransContinue.Size = new System.Drawing.Size(240, 99);
            this.btnTransContinue.TabIndex = 4;
            this.btnTransContinue.Text = "Confirm";
            this.btnTransContinue.UseVisualStyleBackColor = false;
            this.btnTransContinue.Click += new System.EventHandler(this.btnTransCon_Click);
            // 
            // tBoxTransAmount
            // 
            this.tBoxTransAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.tBoxTransAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxTransAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.tBoxTransAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.tBoxTransAmount.Location = new System.Drawing.Point(14, 218);
            this.tBoxTransAmount.Name = "tBoxTransAmount";
            this.tBoxTransAmount.Size = new System.Drawing.Size(464, 53);
            this.tBoxTransAmount.TabIndex = 3;
            this.tBoxTransAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBoxTransAmount_KeyPress);
            // 
            // lblTransEnterAmount
            // 
            this.lblTransEnterAmount.AutoSize = true;
            this.lblTransEnterAmount.Font = new System.Drawing.Font("Lato", 20F);
            this.lblTransEnterAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.lblTransEnterAmount.Location = new System.Drawing.Point(7, 179);
            this.lblTransEnterAmount.Name = "lblTransEnterAmount";
            this.lblTransEnterAmount.Size = new System.Drawing.Size(470, 33);
            this.lblTransEnterAmount.TabIndex = 2;
            this.lblTransEnterAmount.Text = "Please Enter the Amount to Withdraw:";
            // 
            // lblTransCurBal
            // 
            this.lblTransCurBal.AutoSize = true;
            this.lblTransCurBal.Font = new System.Drawing.Font("Lato", 25F);
            this.lblTransCurBal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.lblTransCurBal.Location = new System.Drawing.Point(8, 88);
            this.lblTransCurBal.Name = "lblTransCurBal";
            this.lblTransCurBal.Size = new System.Drawing.Size(279, 41);
            this.lblTransCurBal.TabIndex = 1;
            this.lblTransCurBal.Text = "Current Balance: ";
            this.lblTransCurBal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTransAccountName
            // 
            this.lblTransAccountName.AutoSize = true;
            this.lblTransAccountName.Font = new System.Drawing.Font("Lato", 25F);
            this.lblTransAccountName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.lblTransAccountName.Location = new System.Drawing.Point(9, 15);
            this.lblTransAccountName.Name = "lblTransAccountName";
            this.lblTransAccountName.Size = new System.Drawing.Size(248, 41);
            this.lblTransAccountName.TabIndex = 0;
            this.lblTransAccountName.Text = "Account Name:";
            this.lblTransAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelInsertCard
            // 
            this.panelInsertCard.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelInsertCard.Controls.Add(this.tBoxLoginEnterPIN);
            this.panelInsertCard.Controls.Add(this.btnLoginExit);
            this.panelInsertCard.Controls.Add(this.btnLogIn);
            this.panelInsertCard.Controls.Add(this.lblLoginInsertCard);
            this.panelInsertCard.Controls.Add(this.lblLoginZZZBank);
            this.panelInsertCard.Location = new System.Drawing.Point(15, 12);
            this.panelInsertCard.Name = "panelInsertCard";
            this.panelInsertCard.Size = new System.Drawing.Size(541, 426);
            this.panelInsertCard.TabIndex = 4;
            // 
            // tBoxLoginEnterPIN
            // 
            this.tBoxLoginEnterPIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.tBoxLoginEnterPIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxLoginEnterPIN.Font = new System.Drawing.Font("Lato", 30F);
            this.tBoxLoginEnterPIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.tBoxLoginEnterPIN.Location = new System.Drawing.Point(206, 257);
            this.tBoxLoginEnterPIN.MaxLength = 6;
            this.tBoxLoginEnterPIN.Name = "tBoxLoginEnterPIN";
            this.tBoxLoginEnterPIN.Size = new System.Drawing.Size(144, 55);
            this.tBoxLoginEnterPIN.TabIndex = 8;
            // 
            // btnLoginExit
            // 
            this.btnLoginExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnLoginExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnLoginExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginExit.Font = new System.Drawing.Font("Lato", 20F);
            this.btnLoginExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnLoginExit.Location = new System.Drawing.Point(445, 367);
            this.btnLoginExit.Name = "btnLoginExit";
            this.btnLoginExit.Size = new System.Drawing.Size(87, 45);
            this.btnLoginExit.TabIndex = 3;
            this.btnLoginExit.Text = "EXIT";
            this.btnLoginExit.UseVisualStyleBackColor = false;
            this.btnLoginExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(18)))));
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(215)))), ((int)(((byte)(192)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Lato", 20F);
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            this.btnLogIn.Location = new System.Drawing.Point(207, 331);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(144, 81);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblLoginInsertCard
            // 
            this.lblLoginInsertCard.AutoSize = true;
            this.lblLoginInsertCard.Font = new System.Drawing.Font("Lato", 25F);
            this.lblLoginInsertCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(190)))));
            this.lblLoginInsertCard.Location = new System.Drawing.Point(46, 165);
            this.lblLoginInsertCard.Name = "lblLoginInsertCard";
            this.lblLoginInsertCard.Size = new System.Drawing.Size(469, 82);
            this.lblLoginInsertCard.TabIndex = 1;
            this.lblLoginInsertCard.Text = "Please Insert Card and \r\nEnter Your 4-6 Digit PIN Code";
            this.lblLoginInsertCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoginZZZBank
            // 
            this.lblLoginZZZBank.AutoSize = true;
            this.lblLoginZZZBank.Font = new System.Drawing.Font("Lato", 50F);
            this.lblLoginZZZBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(218)))), ((int)(((byte)(224)))));
            this.lblLoginZZZBank.Location = new System.Drawing.Point(167, 13);
            this.lblLoginZZZBank.Name = "lblLoginZZZBank";
            this.lblLoginZZZBank.Size = new System.Drawing.Size(220, 160);
            this.lblLoginZZZBank.TabIndex = 0;
            this.lblLoginZZZBank.Text = "ZZZ\r\nBANK";
            this.lblLoginZZZBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(7)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.panelInsertCard);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelSelectAccount);
            this.Controls.Add(this.panelTransaction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormATM";
            this.panelMainMenu.ResumeLayout(false);
            this.panelMainMenu.PerformLayout();
            this.panelSelectAccount.ResumeLayout(false);
            this.panelSelectAccount.PerformLayout();
            this.panelTransaction.ResumeLayout(false);
            this.panelTransaction.PerformLayout();
            this.panelInsertCard.ResumeLayout(false);
            this.panelInsertCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Panel panelSelectAccount;
        private System.Windows.Forms.ListBox lBoxAccounts;
        private System.Windows.Forms.Label lblSelectAccount;
        private System.Windows.Forms.Panel panelTransaction;
        private System.Windows.Forms.TextBox tBoxTransAmount;
        private System.Windows.Forms.Label lblTransEnterAmount;
        private System.Windows.Forms.Button buttonLogOff;
        private System.Windows.Forms.Button buttonCheckBalance;
        private System.Windows.Forms.Button buttonTransferMoney;
        private System.Windows.Forms.Button btnTransCancel;
        private System.Windows.Forms.Button btnTransContinue;
        private System.Windows.Forms.Button btnAccCancel;
        private System.Windows.Forms.Label lblTransCurBal;
        private System.Windows.Forms.Panel panelInsertCard;
        private System.Windows.Forms.Label lblLoginInsertCard;
        private System.Windows.Forms.Label lblLoginZZZBank;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnLoginExit;
        private System.Windows.Forms.Label lblTransAccountName;
        private System.Windows.Forms.TextBox tBoxLoginEnterPIN;
        private System.Windows.Forms.Button btnAccConfirm;
    }
}

