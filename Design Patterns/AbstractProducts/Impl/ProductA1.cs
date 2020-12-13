namespace Abstract_Factory.AbstractProducts.Impl
{
    class ProductA1 : AbstractProductA
    {
        public override string Description { get; set; } = "ProductA1";

        public override string ToString()
        {
            return this.Description;
        }
    }
}
