
using System;

namespace InheritanceDemo
{
    // this is our Base/Parent class
    public class Person
    {
        // Base/Parent class properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Base/Parent class method
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Implementing Inheritance for Student Class
    public class Student : Person
    {
        // Derived/Child class Property
        public string RollNumber { get; set; }

        // Derived/Child class method
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Student Roll Number: {RollNumber}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an object of the derived/child class
            // through Object-initializer technique
            // accessing properties declared in both
            // Parent and Child classes
            Student Asfar = new()
            {
                Name = "Asfar Hussain",
                Age = 12,
                RollNumber = "IT-2013"
            };

            // Accessing base/parent class method
            Asfar.DisplayPersonInfo();

            // Accessing derived/child class method
            Asfar.DisplayStudentInfo();
        }
    }
}
