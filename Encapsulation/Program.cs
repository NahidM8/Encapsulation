using System;
using Encapsulation.Models;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User(Console.ReadLine(), Console.ReadLine());

            Console.WriteLine(user.Password);
        }
    }
}
