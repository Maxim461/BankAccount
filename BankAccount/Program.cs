using BankAccount;

class Program
{
    static void Main()
    {
        EmptyClass petrol = new EmptyClass(0, "", 0);

        Console.WriteLine("Инструкция");
        Console.WriteLine("1 - Открыть счет;");
        Console.WriteLine("2 - Показать информацию о счете;");
        Console.WriteLine("3 - Положить на счет;");
        Console.WriteLine("4 - Снять со счета;");
        Console.WriteLine("5 - Взять всю сумму;");
        Console.WriteLine("6 - Перенести сумму с одного счета на другой.");

        while (true)
        {
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

            switch (KeyInfo.Key)
            {
                case ConsoleKey.D1:
                    petrol.OpenAnAccount();
                break;

                case ConsoleKey.D2:
                    petrol.ShowAccountInformation();
                break;

                case ConsoleKey.D3:
                    petrol.PutItOnTheAccount();
                break;

                case ConsoleKey.D4:
                    petrol.WithdrawFromTheAccount();
                break;

                case ConsoleKey.D5:
                    petrol.TakeTheWholeAmount();
                break;

                case ConsoleKey.D6:
                    petrol.TransferTheAmountFromOneAccountToAnother();
                break;
            }
        }
    }
}