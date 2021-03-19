using AbstractPatternHandson.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractPatternHandson
{
    public abstract class Factory
    {
        public abstract Headlight makeHeadlight();
        public abstract Tire makeTire();

    }
    

    }
