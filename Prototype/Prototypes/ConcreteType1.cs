namespace Prototype_Pattern.Prototypes
{
    class ConcreteType1 : Prototype
    {
        public ConcreteType1(int id) : base(id) { }
        
        public override Prototype Clone()
        {
            return new ConcreteType1(id);
        }

        public override string ToString()
        {
            return $"{typeof(ConcreteType1).Name} {base.ToString()}";
        }
    }
}
