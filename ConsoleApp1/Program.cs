using System;

namespace ConsoleApp1
{
    class Program
    {
      
        static int GetRandom()
        {
         
            Random rnd = new Random(246);

            //Получить случайное число 
            int value = rnd.Next();

          
            return value;
        }

        static void Main(string[] args)
        {
    
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
            Console.WriteLine(GetRandom());
        }
    }
}
