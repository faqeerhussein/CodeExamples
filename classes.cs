
using System;

namespace ClassDemo
{
    // This class demonstrates various ways to declare a class,
    // different property and field implementations, and object creation methods.
    public class Person
    {
        // Private fields
        // usually their names start with _ (underscore)
        private string _firstName;
        private string _lastName;
        private int _age;

        // Auto-implemented property
        public string Email { get; set; }

        // Property with a backing field
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        // Read-only property
        public string FullName
        {
            get { return $"{_firstName} {_lastName}"; }
        }

        // Property with private setter
        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }

        // Static members ( a static property)
        public static int Population { get; private set; }

        // Default constructor
        public Person()
        {
            _firstName = "Unknown";
            _lastName = "Unknown";
            Age = 0;
            Population++;
        }

        // Parameterized constructor
        public Person(string firstName, string lastName, int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
            Population++;
        }

        // Method to demonstrate changing private field through public method
        public void UpdateName(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Method to print Person's detail
        public string DisplayInfo()
        {
            return $"{FullName}, Age: {Age}, Email: {Email}, Phone: {PhoneNumber}";
        }

        // Static method
        public static void ShowPopulation()
        {
            Console.WriteLine($"Current population: {Population} people created.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Object creation Using default constructor
            Person person1 = new();
            Console.WriteLine("Person 1:\n" + person1.DisplayInfo());

            // Object creation Using parameterized constructor
            Person person2 = new("Faqeer", "Hussain", 41);
            person2.Email = "faqeerhussain79@gmail.com";
            person2.PhoneNumber = "03320684191";
            Console.WriteLine("Person 2:\n" + person2.DisplayInfo());

            // Object creation Using object initializer syntax
            Person person3 = new()
            {
                Email = "abc@example.com",
                PhoneNumber = "0300000000000"
            };
            person3.UpdateName("Alice", "Brown");
            Console.WriteLine("Person 3:\n" + person3.DisplayInfo());
            
            // Accessing static method
            Person.ShowPopulation();
        }
    }
}
