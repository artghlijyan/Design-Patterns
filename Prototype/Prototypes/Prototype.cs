namespace Prototype_Pattern.Prototypes
{
    abstract class Prototype // or : ICloneable
    {
        public int id;

        protected Prototype(int id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();

        public override string ToString()
        {
            return $"id: {id}";
        }
    }
}
