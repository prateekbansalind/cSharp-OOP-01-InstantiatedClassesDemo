using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonModel> employees = new List<PersonModel>();

            PersonModel employee = new PersonModel();
           
            string makeAnotherEntry;

            do
            {
                string firstName = UserMessages.GetAString("what is employee's first name: ");
                string lastName = UserMessages.GetAString("What is employee's last name: ");
                string email = UserMessages.GetAString("What is employee's email: ");
                string gender = UserMessages.GetAString("What is employee's gender: ");
                int age = UserMessages.GetAInteger("What is employee's age: ");

                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.Gender = gender;
                employee.Age = age;
                employee.Email = email;
                
                employees.Add(employee);
                

                makeAnotherEntry = UserMessages.GetAString("Do you want to make anothe entry (y/n): ");

            } while (makeAnotherEntry.ToLower() == "y");


            foreach (PersonModel emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}");
                Console.WriteLine($"{emp.LastName}");
                Console.WriteLine($"{emp.Gender}");
                Console.WriteLine($"{emp.Email}");
                Console.WriteLine($"{emp.Age}");
                
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}