using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Point = new MyClass();
            
                 
        }
        public class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("insert number 1");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                y = Convert.ToInt32(Console.ReadLine());
                z = x + y;
                Console.WriteLine("Ответ:");
                Console.WriteLine(z);
            }
            public int x;
            public int y;
            public int z;
           
                }
            
        }
        
    }

