using System;
using System.Collections.Generic;

namespace Exercise1Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> nameList = new List<String> {"Jhon", "Mary", "Sue", "Greg", "Yolanda", "Jose", "Bill" };

            foreach (String i in nameList)
            {
                Console.WriteLine("Hello "+i);
            }

            Console.WriteLine();

            List<PersonModel> personList = new List<PersonModel> { 
                new PersonModel("Tim","Corey"), 
                new PersonModel("Bill", "McCoy"),
                new PersonModel("Mary","Jones"),
                new PersonModel("Sue","Smith")
            };

            foreach (PersonModel i in personList)
            {
                Console.WriteLine("Hello " + i.FirstName + " " + i.LastName);
            }
        }
    }
}
