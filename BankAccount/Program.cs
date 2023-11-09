using BankAccount;
using static System.Collections.Specialized.BitVector32;

class Program
{
    static void Main()
    {
        Account AccountOne = new Account(593481, "Зуев Александор Максимович", 0);
        Account AccountTwo = new Account(315317, "Кириллова Виктория Викторовна", 0);

        Account AccountSelection = null;

        while (true)
        {
            if (AccountSelection == null)
            {
                Console.WriteLine("Выберите банк (1 или 2)");
                int ChoosingCarIfElse = int.Parse(Console.ReadLine());
                if (ChoosingCarIfElse == 0)
                {
                    break;
                }
                else if (ChoosingCarIfElse == 1)
                {
                    AccountSelection = AccountOne;
                }
                else if (ChoosingCarIfElse == 2)
                {
                    AccountSelection = AccountTwo;
                }
                else
                {
                    Console.WriteLine("Вы не правильно выбрали банк.\nВведите 1 или 2.");
                }
            }

            Console.WriteLine("1 - Показать информацию о счете;");
            Console.WriteLine("2 - Положить на счет;");
            Console.WriteLine("3 - Снять со счета;");
            Console.WriteLine("4 - Взять всю сумму;");
            Console.WriteLine("5 - Перенести сумму с одного счета на другой;");
            Console.WriteLine("6 - Сменить банк;");

            int Button = int.Parse(Console.ReadLine());
            switch (Button)
            {
                case 1:
                    AccountSelection.AccountInformation();
                break;

                case 2:
                    AccountSelection.ReplenishmentAccount();
                break;

                case 3:
                    AccountSelection.WithdrawalAccount();
                break;

                case 4:
                    AccountSelection.RemoveAll();
                break;

                case 5:
                    Console.WriteLine("Введите номер счета, на который хотите перевести средства:");
                    int RecipientAccountNumber = int.Parse(Console.ReadLine());
                    Account RecipientAccount;
                    if (RecipientAccountNumber == 1)
                    {
                        RecipientAccount = AccountOne;
                    }
                    else if (RecipientAccountNumber == 2)
                    {
                        RecipientAccount = AccountTwo;
                    }
                    else
                    {
                        Console.WriteLine("Неверный номер счета.");
                        break;
                    }
                    Console.WriteLine("Введите сумму для перевода:");
                    double TransferAmount = double.Parse(Console.ReadLine());
                    AccountSelection.Transfer(RecipientAccount, TransferAmount);
                    break;

                case 6:
                    AccountSelection = null;
                    break;
            }
        }
    }
}