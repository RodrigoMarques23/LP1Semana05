using System;
using System.IO;

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

                using (StringWriter writer = new StringWriter())
                {
                    for (int i = 0; i < args.Length; i++)
                    {
                        Console.Write(args[i]);

                        if (i + 1 < args.Length)
                            Console.Write("_");
                    }
                }


                /*string mergedArgs = string.Join("_", args);//merge all strings
                Console.WriteLine(mergedArgs);//print new string
                StringWriter.*/
            }
        }
    }
}
