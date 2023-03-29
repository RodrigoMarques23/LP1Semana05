using System;

namespace RandomDice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarate random
            Random random = new Random();
            
            Console.WriteLine("Inserir numero de dados!");//Ask input
            int n = Int32.Parse(Console.ReadLine());//Convert input

            //Random between 0 and 6
            int rnd1 = random.Next(0, 6);
            int rnd2 = random.Next(0, 6);
            int rnd3 = random.Next(0, 6);

            //Values addition and print
            Console.WriteLine($"Soma= {rnd1 + rnd2 + rnd3}");


        }
    }
}
