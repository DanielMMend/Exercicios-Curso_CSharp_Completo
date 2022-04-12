namespace S5_Exercicio_Encapsulamento_1.Entities
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance = Balance + amount;
        }
        public void Withdraw(double amount)
        {
            Balance = Balance - amount - 5.0;
        }

        public override string ToString()
        {
            return $"Conta {Number}, Titular: {Holder}, Saldo: ${Balance:F2}";
        }
    }
}
