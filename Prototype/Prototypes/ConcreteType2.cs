namespace Prototype_Pattern.Prototypes
{
    class ConcreteType2 : Prototype
    {
        public ConcreteType2(int id) : base(id) { }

        public override Prototype Clone()
        {
            return new ConcreteType2(id);
        }

        public override string ToString()
        {
            return $"{typeof(ConcreteType2).Name} {base.ToString()}";
        }
    }
}
