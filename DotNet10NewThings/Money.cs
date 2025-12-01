using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet10NewThings;

public struct Money(string currency,decimal amount)
{
    public string Currency { get; private set; } = currency;
    public decimal Amount { get;  private set; } = amount;
    public void operator +=(Money b)
    {
        if (this.Currency != b.Currency)
            throw new InvalidOperationException("Cannot add amounts with different currencies.");

        this.Amount += b.Amount;
    }
    public static Money operator +(Money a, Money b)
    {
        if (a.Currency != b.Currency)
            throw new InvalidOperationException("Cannot add amounts with different currencies.");

        return new Money(a.Currency, a.Amount + b.Amount);
    }
    public override string ToString() => $"{Amount} {Currency}";
}
