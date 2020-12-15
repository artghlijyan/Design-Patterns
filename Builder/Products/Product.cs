using System;
using System.Collections;
using System.Collections.Generic;

namespace Builder.Products
{
    class Product : IEnumerable
    {
        List<ProductPart> _product;

        public Product()
        {
            _product = new List<ProductPart>();
        }
        
        public void Add(ProductPart part)
        {
            _product.Add(part);
        }

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
}
