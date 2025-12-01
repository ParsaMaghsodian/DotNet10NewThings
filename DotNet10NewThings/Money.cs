using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet10NewThings;

public struct Money(string currency, decimal amount)
{
    delegate void ApplyDiscount(ref decimal money);
    public string Currency { get; private set; } = currency;
    public decimal Amount { get; private set; } = amount;
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
    // Reusable method to apply any discount
    private Money ApplyDiscountMethod(ApplyDiscount discount)
    {
        decimal tempAmount = Amount;  // copy current amount
        discount(ref tempAmount);     // apply discount delegate
        return new Money(Currency, tempAmount);
    }

    // Example: 10% discount
    public Money Apply10PercentDiscount()
    {
        ApplyDiscount discount = (ref price) =>
        {
            price *= 0.9m; // reduce by 10%
        };

        return ApplyDiscountMethod(discount);
    }
    public override string ToString() => $"{Amount} {Currency}";
}
