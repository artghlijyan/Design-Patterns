namespace Decorator
{
    class Coffee : Bevarage
    {
        public Coffee()
        {
            description = "Coffee";
            price = 500;
        }

        public override int GetPrice()
        {
            return price;
        }
    }
}
