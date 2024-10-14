using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DepositAccount : BankAccount
{
    private double interestRate; // Відсоткова ставка

    public DepositAccount(string accountNumber, double interestRate) : base(accountNumber)
    {
        this.interestRate = interestRate;
    }

    public override void Popovnyty_Rakhunok(double amount)
    {
        balance += amount;
        Console.WriteLine($"На рахунок {AccountNumber} поповнено на {amount}.");
    }

    public override void Znaty_z_Rakhunku(double amount)
    {
        Console.WriteLine("Зняття коштів з депозитного рахунку недоступне до закінчення терміну дії депозиту.");
    }

    // Метод для нарахування відсотків
    public void NahradzhennyaVidсotkiv()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine($"Нараховані відсотки на рахунок {AccountNumber}: {interest}.");
    }
}
