using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null)
            {
                Console.WriteLine("sem qualquer argumento!");
            }
            else
            {
                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = args[i].ToLower();
                }
            }
        }
    }
}
