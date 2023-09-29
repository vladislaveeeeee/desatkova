using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
                string des = "";
                int temp = 128;
                int num;
                bool started = false;

                do
                {
                    Console.Write("Enter num = ");
                    num = int.Parse(Console.ReadLine());
                } while (num > 255 || num < 0);

                while (temp >= 1)
                {
                    if (num >= temp)
                    {
                        des += "1";
                        num -= temp;
                        started = true;
                    }
                    else if (started)
                    {
                        des += "0";
                    }
                    temp /= 2;
                }

                Console.WriteLine(des);
        }
    }
    
}