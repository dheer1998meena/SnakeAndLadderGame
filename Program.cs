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
            int currentPosition = startPosition;
            int winningPosition = 100;
            int Moves = 0;

            Random random = new Random();

            while (currentPosition < winningPosition)
            {
                int dieNum = random.Next(1, 7);
                Console.WriteLine("Die Number is {0}", dieNum);
                int option = random.Next(1, 4);
                Console.WriteLine("Option is {0}", option);
                switch (option)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        if (currentPosition + dieNum <= winningPosition)
                            currentPosition += dieNum;
                        break;
                    case SNAKE:
                        currentPosition -= dieNum;
                        if (currentPosition < startPosition)
                            currentPosition = startPosition;
                        break;
                    default:
                        break;
                }
                Moves++;
                Console.WriteLine("Current Position is {0}", currentPosition);
                Console.WriteLine("Number Of MOves Used {0}", Moves);
            } 
        }
    }
    
    
}
