using System;
using System.Collections;
using System.Collections.Generic;

namespace Builder.Products
{
    abstract class AbstractProduct : IEnumerable
    {
        protected List<ProductPart> _product;

        public AbstractProduct()
        {
            _product = new List<ProductPart>();
        }

        public abstract void Add(ProductPart part);

        public void Show()
        {
            foreach (var item in this)
            {
                System.Console.WriteLine(item);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _product.GetEnumerator();
        }
    }

    class Product : AbstractProduct
    {
        public Product() : base() { }

        public override void Add(ProductPart part)
        {
            _product.Add(part);
        }
    }
}
