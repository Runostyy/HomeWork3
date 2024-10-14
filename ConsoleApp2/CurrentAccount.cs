using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CurrentAccount : BankAccount
{
    public CurrentAccount(string accountNumber) : base(accountNumber) { }

    public override void Popovnyty_Rakhunok(double amount)
    {
        balance += amount;
        Console.WriteLine($"На рахунок {AccountNumber} поповнено на {amount}.");
    }

    public override void Znaty_z_Rakhunku(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"З рахунку {AccountNumber} знято {amount}.");
        }
        else
        {
            Console.WriteLine("Недостатньо коштів для зняття.");
        }
    }
}
