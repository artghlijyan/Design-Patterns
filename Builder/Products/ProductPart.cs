namespace Builder.Products
{
    abstract class ProductPart
    {
         public abstract string Part { get; set; }
    }

    class ProductPart1 : ProductPart
    {
        public override string Part { get; set; } = "This is";

        public override string ToString()
        {
            return Part;
        }
    }

    class ProductPart2 : ProductPart
    {
        public override string Part { get; set; } = "Final Product";

        public override string ToString()
        {
            return Part;
        }
    }
}
