using FactorySample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorySample.Models
{
    // The Creator class erklærer en factory metoden som skal returnere 
    // et objekt af typen Product class. Creator's underklasser sørger normalt for 
    // implementationen af metoden.
    abstract class Creator
    {
        // Bemærk at the Creator normalt sørger for default implementation af
        // factory metoden.
        public abstract IProduct FactoryMethod();

        // På trods af Creator's navn, så er Creator's primære ansvar ikke at 
        // creating products. Normalt indeholder den en kerneforretningslogik,
        // der er afhængig af produktobjekter, returneret af fabriksmetoden.
        // Underklasser kan indirekte ændre denne forretningslogik
        // ved at tilsidesætte fabriksmetoden og returnere en anden type
        // produkt fra den.
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }
    }
}
