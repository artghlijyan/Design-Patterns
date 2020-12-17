namespace Decorator
{
    abstract class CoffeeDecorator : Bevarage
    {
        protected Bevarage bevarage;

        public CoffeeDecorator(Bevarage bevarage)
        {
            this.bevarage = bevarage;
        }
    }
}
