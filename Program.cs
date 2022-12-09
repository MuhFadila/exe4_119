using System;

namespace exe4_119
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fadil = -1;
            int[] s = new int[39];
            Console.WriteLine("Enter the size of the stack");
            int MAX = Convert.ToInt16(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Your Choice :");
                int ch = Convert.ToInt16(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        if (Fadil > MAX - 1) Console.WriteLine("...Stack Overflow...");
                        else
                        {
                            Console.WriteLine("Enter the Item :");
                            int n = int.Parse(Console.ReadLine());
                            s[++Fadil] = n;
                        }
                        break;
                    case 2:
                        if (Fadil == -1) Console.WriteLine("...Stack Underflow...");
                        else
                        {
                            Console.WriteLine("Popped item :" + s[Fadil--]);
                        }
                        break;
                }
            }
        }
    }
}
