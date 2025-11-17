using FactorySample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.Models
{
    // ConcreteCreator1 overskriver factory metoden for at ændre i 
    // resulterende produkt's type.
    class ConcreteCreator1 : Creator
    {
        //Bemærk at metodens signatur stadig bruger den abstrakte produkttype, 
        // selvom det konkrete produkt faktisk returneres fra metoden.
        // På denne måde kan skaberen forblive uafhængig af konkrete produktklasser.
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
