using Builder.Builders;

namespace Builder.Directors
{
    class Director
    {
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
