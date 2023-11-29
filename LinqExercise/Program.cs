using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            var SumOfNumbers = numbers.Sum();
            Console.WriteLine($"{SumOfNumbers}");
            Console.WriteLine("--------------");


            //TODO: Print the Average of numbers
            var AverageOfNumbers = numbers.Average();
            Console.WriteLine($"{AverageOfNumbers}");
            Console.WriteLine("--------------");

            //TODO: Order numbers in ascending order and print to the console
            var AscendingNumbers = numbers.OrderBy(x => x);

            foreach(int i in AscendingNumbers)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("--------------");

            //TODO: Order numbers in descending order and print to the console
            var DescendingNumbers = numbers.OrderByDescending(x => x);

            foreach (int i in DescendingNumbers)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("--------------");

            //TODO: Print to the console only the numbers greater than 6
            var NumbersOverSix = numbers.Where(x => x > 6);

            foreach (int i in NumbersOverSix)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("--------------");

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            var AscendingFourNumbers = numbers.OrderBy(x => x).Take(4); 

            foreach (int i in AscendingFourNumbers)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("--------------");

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            numbers[4] = 27;
            var DescendingNumbers2 = numbers.OrderByDescending(x => x);

            foreach (int i in DescendingNumbers2)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("--------------");

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var PickyNames = employees.Where(guy => guy.FirstName.ToLower().StartsWith('c') || guy.FirstName.ToLower().StartsWith('s'))
                            .OrderBy(guy => guy.FirstName);

            Console.WriteLine("----");
            foreach (var i in PickyNames)
            {
                Console.WriteLine(i.FullName);
            }
            Console.WriteLine("--------------");

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            var over26 = employees.Where(guy => guy.Age > 26).OrderByDescending(guy => guy.Age).ThenBy(guy => guy.FirstName);

            foreach (var i in over26)
            {
                Console.WriteLine($"Name{i.FullName}, Age: {i.Age}");
            }
            Console.WriteLine("--------------");

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            var MoreEmployee = employees.Where(guy => guy.YearsOfExperience <= 10 && guy.Age > 35);

            Console.WriteLine($"Total Years of Experience:{MoreEmployee.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine("--------------");

            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine($"Average Years:{MoreEmployee.Average(x => x.YearsOfExperience)}");
            Console.WriteLine("--------------");

            //TODO: Add an employee to the end of the list without using employees.Add()
            employees = employees.Append(new Employee("Kevin", "Malone", 39, 8)).ToList();

       
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
