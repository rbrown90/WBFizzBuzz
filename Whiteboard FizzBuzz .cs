using System;
using System.Collections.Generic;
using Linq;

namespace Fizzbuzz
{
    class name 
    {   
        static void Main(string[] args )
        {

            Console.WriteLine("What number do you wish to enter?");

            Console.ReadLine();

            public string Fizzbuzz(int number)
            {
                var answer = "";

                    if (number % 3 == 0 )
                    {
                        answer = "fizz";
                    }
                    if (number % 5 == 0)
                    {
                        answer += "buzz";
                    }
                    
                    return answer;
            }    
        }
    }
}