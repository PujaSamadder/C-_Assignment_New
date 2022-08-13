using System;


namespace Assignment7_3
{
    public delegate void BalanceDelegate(object source, EventArgs e);




    public class Account
    {
        #region Fields
        public event BalanceDelegate AccountEvent;
        long accountNumber;
        string customerName;
        double balance;
        #endregion

        #region Properties
        public long AccountNumber 
        { 
            get 
            { 
                return accountNumber; 
            } 
            set 
            { 
                this.accountNumber = value; 
            } 
        }
        public string CustomerName 
        { 
            get 
            { 
                return customerName; 
            } 
            set 
            { 
                this.customerName = value; 
            } 
        }
        public double Balance 
        { 
            get 
            { 
                return balance; 
            } 
            set 
            { 
                this.balance = value; 
            } 
        }
        #endregion

        #region Constructor
        public Account(long accountNumber, string customerName, double balance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.balance = balance;
        }
        #endregion



        #region Withdraw
        public bool Withdraw(double amount)
        {

            if (amount < 0 || this.balance < amount)
            {
                Console.WriteLine("Balance Zero/Insufficient");
                AccountEvent(this, EventArgs.Empty);
                return false;
            }
            this.balance -= amount;
            AccountEvent(this, EventArgs.Empty);
            return true;
        }
        #endregion

        #region Deposit
        public double Deposit(double amount)
        {
            AccountEvent(this, EventArgs.Empty);
            Console.WriteLine("{0} Deposit successful", amount);
            balance += amount;
            Console.WriteLine();
            return balance;
        }
        #endregion

        #region Display Balance
        public void displayBalance()
        {
            Console.WriteLine("Balance: " + this.balance);
            Console.WriteLine();
        }
        #endregion

        #region Display Account
        public void displayAccount()
        {
            Console.WriteLine("Account of: {0} ", this.customerName);
            Console.WriteLine("Account Number: {0}", this.accountNumber);
            Console.WriteLine("Balance: {0}", this.balance);
            Console.WriteLine();
            Console.WriteLine();
        }
        #endregion

        #region Subscribe Events
        public void LinkEvent()
        {
            AccountEvent += this.UnderBalance;
            AccountEvent += this.ZeroBalance;
        }
        #endregion

        #region Under Balance Event
        
        public virtual void UnderBalance(object source, EventArgs e)
        {

            if (balance < 500)
            {
                Console.WriteLine("Account Under Balance");
            }
            Console.WriteLine();

        }
        #endregion

        #region Zero Balance Event
        
        public virtual void ZeroBalance(object source, EventArgs e)
        {

            if (balance == 0)
            {
                Console.WriteLine("Account Balance is Zero");
            }

        }
        #endregion

        #region Main
        public static void Main(string[] args)
        {
            Account accountA = new Account(124964289654, "Ritabrata Biswas", 9000);
            accountA.LinkEvent();

            accountA.Withdraw(2000);
            accountA.Deposit(500);

            accountA.Withdraw(300);

            accountA.displayAccount();

            Console.Read();
        }
        #endregion
    }
}
