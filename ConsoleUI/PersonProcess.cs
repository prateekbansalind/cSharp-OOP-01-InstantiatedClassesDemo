using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonProcess
    {
        public void ValidForPromotion(PersonModel employee)
        {
            if (employee.Age <= 29)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} is not qualified for overseas management position.");
                employee.IsValidAge = false;
            }

            else
            {
                Console.WriteLine($"Congratulation, {employee.FirstName} {employee.LastName}. You are qualified for overseas management position.");
                employee.IsValidAge = true;
            }
        }
    }
}
