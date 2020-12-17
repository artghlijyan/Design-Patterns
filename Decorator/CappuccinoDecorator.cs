namespace Decorator
{
    class CappuccinoDecorator : CoffeeDecorator
    {
        public CappuccinoDecorator(Bevarage bevarage) : base(bevarage)
        {
            description = bevarage.description + " with Milk";
            price = bevarage.GetPrice() + 300;
        }

        public override int GetPrice()
        {
            return price;
        }
    }
}
