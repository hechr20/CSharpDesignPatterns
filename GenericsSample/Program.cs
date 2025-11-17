// create an instance with data type string 
using GenericsSample.Models;

Student<string> studentName = new Student<string>("Avicii");
studentName.DisplayData();

// create an instance with data type int
Student<int> studentId = new Student<int>(23);
studentId.DisplayData();
