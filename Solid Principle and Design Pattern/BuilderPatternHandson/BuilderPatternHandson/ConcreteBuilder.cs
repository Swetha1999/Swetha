using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternHandson
{
    public class AdultBuilder : Builder
    {
        private Product _product = new Product();
 public override void Sweet()

 {

 _product.Add("---Adult---\n 2 sweets");

 }
 public override void Savory()

 {
_product.Add("\n 2 savory");

}

 public override Product GetResult()

 {

    return _product;

     }
    }
}
