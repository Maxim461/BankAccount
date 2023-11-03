using System;
namespace BankAccount
{
	public class Account
	{
		private int NumberAccount;
		private string FIO;
		private double AmountAccount;

		public Account(int nom, string name, double sum)
		{
			this.NumberAccount = nom;
			this.FIO = name;
			this.AmountAccount = sum;
		}

		public void AccountInformation()
		{
			Console.WriteLine($"Номер счета: {NumberAccount}");
			Console.WriteLine($"Владелец счета: {FIO}");
            Console.WriteLine($"На вашем счету {AmountAccount:f2} рублей;");
        }

		public void ReplenishmentAccount()
		{
			Console.WriteLine("Введите сумма на которую вы хотите пополнить счет.");
			AmountAccount =+ double.Parse(Console.ReadLine());
        }

        public void WithdrawalAccount()
		{
            Console.WriteLine("Введите сумма которую вы хотите снять со счета.");
            AmountAccount =- double.Parse(Console.ReadLine());
        }

		public void RemoveAll()
		{
            Console.WriteLine($"Вы сняли: {AmountAccount}");
			AmountAccount = 0;
        }

        public void Transfer(Account Recipient, double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Сумма перевода должна быть положительной."); return;
            }
            if (AmountAccount < Amount)
            {
                Console.WriteLine("Недостаточно средств на счете для перевода."); return;
            }
            AmountAccount -= Amount;
            Recipient.AmountAccount += Amount;
            Console.WriteLine($"Перевод {Amount:f2} рублей выполнен успешно на счет {Recipient.NumberAccount} ({Recipient.FIO}).");
        }
    }
}

