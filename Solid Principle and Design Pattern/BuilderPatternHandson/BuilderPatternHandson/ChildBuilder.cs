using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternHandson
{
    public class ChildBuilder : Builder
    {
        private Product _product = new Product();
        public override void Sweet()

        {

            _product.Add("---Child--- \n2 sweets");

        }
        public override void Savory()

        {
            _product.Add("\n1 savory");

        }

        public override Product GetResult()

        {

            return _product;

        }
    }
}
