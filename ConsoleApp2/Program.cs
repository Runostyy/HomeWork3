using System;

class Program
{
    static void Main(string[] args)
    {
        // Створення поточного рахунку
        CurrentAccount currentAccount = new CurrentAccount("UA123456789");
        currentAccount.Novyi_Rakhunok();
        currentAccount.Popovnyty_Rakhunok(1000);
        currentAccount.Znaty_z_Rakhunku(500);
        currentAccount.Vydalyty_Rakhunok();

        // Створення депозитного рахунку
        DepositAccount depositAccount = new DepositAccount("UA987654321", 5);
        depositAccount.Novyi_Rakhunok();
        depositAccount.Popovnyty_Rakhunok(2000);
        depositAccount.NahradzhennyaVidсotkiv();
        depositAccount.Znaty_z_Rakhunku(300); // Цей метод не повинен працювати
        depositAccount.Vydalyty_Rakhunok();
    }
}
