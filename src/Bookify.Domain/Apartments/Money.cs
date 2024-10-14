namespace Bookify.Domain.Apartments
{
    public record Money(decimal Amount, Currency Currency) 
    {
        public static Money operator +(Money firts, Money second) 
        {
            if (firts.Currency != second.Currency) 
            {
                throw new InvalidOperationException("Currencies have to be equal");
            }

            return new Money(firts.Amount + second.Amount, firts.Currency);
        }

        public static Money Zero() => new(0,Currency.None);
    }
}
