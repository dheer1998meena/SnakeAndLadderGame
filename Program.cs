using System;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Game");
            const int startPosition = 0;
            const int NO_PLAY = 1;
            const int LADDER = 2;
            const int SNAKE = 3;
            int currentPostion = startPosition;

            Random die = new Random();
            int dieNum = die.Next(1, 7);
            Console.WriteLine("Die Number is {0}", dieNum);
            Random opt = new Random();
            int option = opt.Next(1, 4);
            Console.WriteLine("Option is {0}", option);

            switch (option)
            {
                case NO_PLAY:
                    break;
                case LADDER:
                    currentPostion += dieNum;
                    break;
                case SNAKE:
                    currentPostion -= dieNum;
                    break;
                default:
                    break;
            }
            Console.WriteLine("Current Position is {0}", currentPostion);
        }
    }
    
}
