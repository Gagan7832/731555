using System;

namespace ConsoleApp1
{
    class Program
    {
        static int i=0;
        static void Main(string[] args)
        {
            MethodA();
           
            Console.WriteLine("now I am done!");

        }
        public static void MethodA()
        {
            while (Peanut())
            {
                Console.WriteLine("i is {0}", i);
                if(i>10)

                    {
                        return;

                    }
            }
        }
        public static bool Peanut()
        {
            i++;
            return true;
            Console.ReadLine();
        }
    }
}
