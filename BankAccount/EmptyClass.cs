using System;
using System.Security.Principal;

namespace BankAccount
{
	public class EmptyClass
    {
        private int AccountNumber;
        private string FullName;
        private double AmountOnAccount;

        public EmptyClass(int AccountNumber, string FullName, double AmountOnAccount)
		{
            this.AccountNumber = AccountNumber;
            this.FullName = FullName;
            this.AmountOnAccount = AmountOnAccount;
        }
	
        public void OpenAnAccount()
        {   Random random = new Random();
            AccountNumber = random.Next(999999999);

            Console.WriteLine("Введите свое ФИО");
            FullName = Console.ReadLine();

            AmountOnAccount = 0;

            Console.WriteLine("Счет открыт");
        }

        public void ShowAccountInformation()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}");
            Console.WriteLine($"ФИО владельца счета: {FullName}");
            Console.WriteLine($"Сумма на счету: {AmountOnAccount}");
        }

        public void PutItOnTheAccount()
        {
            Console.WriteLine("Введите сумму для пополнения счета:");
            double VarUser = Double.Parse(Console.ReadLine());
            AmountOnAccount = AmountOnAccount + VarUser;
            Console.WriteLine($"Вы пополни счет на: {VarUser}");
        }

        public void WithdrawFromTheAccount()
        {
            Console.WriteLine("Введите сумму которую хотите снять со счета:");
            double VarUser = Double.Parse(Console.ReadLine());
            AmountOnAccount = AmountOnAccount - VarUser;
            Console.WriteLine($"Вы сняли со счета: {VarUser}");
        }

        public void TakeTheWholeAmount()
        {
            Console.WriteLine($"Вы сняли все свои средства({AmountOnAccount})");
            AmountOnAccount = 0;
        }

        public void TransferTheAmountFromOneAccountToAnother()
        {
            
        }
    }
}