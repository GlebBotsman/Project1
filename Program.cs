using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var userName = Console.ReadLine();
            Console.WriteLine("You name is" + userName);

            Console.WriteLine("[" + DateTime.Now + "] " + "Hello, " + userName + "!");
        }
        
         
        }
    }

