using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game ");
            const int startPosition = 0;
            Random die = new Random();
            int dieNum = die.Next(1, 7);
            Console.WriteLine("Die Number is {0} ", dieNum);
        }
    }
}
