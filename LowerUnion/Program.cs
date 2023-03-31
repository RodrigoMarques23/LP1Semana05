using System;

namespace LowerUnion
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)//verify array length
            {
                Console.WriteLine("sem qualquer argumento!");//print info
            }
            else//if array>0 
            {
                //convert all strings to lowercase
                for (int i = 0; i < args.Length; i++)
                {
                    args[i] = args[i].ToLower();
                }
                Array.Sort(args);//sort alphabetic
                //print all args with a underscore after each string
                for (int x = 0; x < args.Length; x++)
                {
                    Console.Write(args[x]);//print string
                    Console.Write("_");//print underscore after string
                }
            }
        }
    }
}
