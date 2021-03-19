﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPatternHandson
{
   public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)

        {

            _parts.Add(part);

        }
        public void Show()

        {

            Console.WriteLine("\n---------Sweet shop -------");

            foreach (string part in _parts)

                Console.WriteLine(part);
        }
    }
}
