namespace Decorator
{
    abstract class Bevarage
    {
        public string description;
        public int price;

        public override string ToString()
        {
            return $"{description}; Price: {price}";
        }

        public abstract int GetPrice();
    }
}
