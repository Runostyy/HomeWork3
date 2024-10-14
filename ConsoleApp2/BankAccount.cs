using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class BankAccount : IAccountManagement
{
    protected double balance; // Залишок на рахунку
    public string AccountNumber { get; private set; }

    public BankAccount(string accountNumber)
    {
        AccountNumber = accountNumber;
        balance = 0.0; // Початковий залишок
    }

    // Реалізація методів інтерфейсу
    public void Novyi_Rakhunok()
    {
        Console.WriteLine($"Новий рахунок {AccountNumber} створено.");
    }

    public void Vydalyty_Rakhunok()
    {
        Console.WriteLine($"Рахунок {AccountNumber} видалено.");
    }

    // Абстрактні методи для поповнення та зняття коштів
    public abstract void Popovnyty_Rakhunok(double amount);
    public abstract void Znaty_z_Rakhunku(double amount);
}
