namespace Abstract_Factory.AbstractProducts.Impl
{
    class ProductA2 : AbstractProductA
    {
        public override string Description { get; set; } = "ProductA2";
        public override string ToString()
        {
            return this.Description;
        }
    }
}
