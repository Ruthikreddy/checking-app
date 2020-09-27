using System;

namespace LearningProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int EmpPresent = 1;
            Random randomnum = new Random();
            int EmpCheck = randomnum.Next(0, 2);
            if (EmpCheck == EmpPresent)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("employee is absent");
            }
            if (EmpCheck){
                Console.WriteLine("check for merge");
            }
        }
    }
}
