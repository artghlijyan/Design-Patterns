namespace Abstract_Factory.AbstractProducts.Impl
{
    class ProductB1 : AbstractProductB
    {
        public override string Description { get; set; } = "ProductB1";

        public override string ToString()
        {
            return this.Description;
        }
    }
}
