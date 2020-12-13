namespace Abstract_Factory.AbstractProducts.Impl
{
    class ProductB2 : AbstractProductB
    {
        public override string Description { get; set; } = "ProductB2";

        public override string ToString()
        {
            return this.Description;
        }
    }
}
