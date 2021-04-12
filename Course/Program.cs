using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "alex", Email = "alex@gmail.com" };


            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b); // comparação de referencia de memoria
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
