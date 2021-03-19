using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternHandson
{
    public class Director
  {

// Builder uses a complex series of steps

 public void Construct(Builder builder)

 {
     builder.Sweet();

     builder.Savory();
 
     }

   }
}
