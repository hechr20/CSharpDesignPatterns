using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsSample.Models
{
    // define a generics class named Student
    public class Student<T>
    {
        // define a variable of type T 
        public T data;

        // define a constructor of the Student class 
        public Student(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: " + this.data);
        }

        // define a generics method that displays the passed data  
        public void DisplayData()
        {
            Console.WriteLine("The data passed is: " + data);
        }
    }
}
