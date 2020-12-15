using Builder.Builders;
using Builder.Directors;
using Builder.Products;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteBulder builder = new ConcreteBulder();
            Director director = new Director();

            director.Construct(builder);

            Product finalProduct = builder.GetResult();

            finalProduct.Show();
        }
    }
}
