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
            int numberOfPlayer = 2;
            int playerNumber = 1;
            int positionOfPlayer1 = 0;
            int positionOfPlayer2 = 0;
            int winningPosition = 100;
            int dieNum = 0;
            int option = 0;
            int Moves = 0;
            int totalNumberOfMoves = 0;

            Random random = new Random();

            while (positionOfPlayer1 < winningPosition && positionOfPlayer2<winningPosition)
            {
                Moves++;
                switch (playerNumber)
                {
                    case 1:
                        dieNum = random.Next(1, 7);
                        Console.WriteLine("Die number is {0}", dieNum);
                        option = random.Next(0, 3);
                        Console.WriteLine("Option is {0}", option);

                        switch (option)
                        {
                            case NO_PLAY:
                                break;
                            case LADDER:
                                if (positionOfPlayer1 + dieNum <= winningPosition)
                                    positionOfPlayer1 += dieNum;
                                break;
                            case SNAKE:
                                positionOfPlayer1 -= dieNum;
                                if (positionOfPlayer1 < startPosition)
                                    positionOfPlayer1 = 0;
                                break;

                        }
                        if (positionOfPlayer1 != winningPosition)
                            playerNumber = 2;
                        Console.WriteLine("The position of player 1 after die roll number {0} is {1}", Moves, positionOfPlayer1);
                        break;

                    case 2:
                        dieNum = random.Next(1, 7);
                        Console.WriteLine("Die number is {0}", dieNum);
                        option = random.Next(0, 3);
                        Console.WriteLine("Option is {0}", option);

                        switch (option)
                        {
                            case NO_PLAY:
                                break;
                            case LADDER:
                                if (positionOfPlayer2 + dieNum <= winningPosition)
                                    positionOfPlayer2 += dieNum;
                                break;
                            case SNAKE:
                                positionOfPlayer2 -= dieNum;
                                if (positionOfPlayer2 < winningPosition)
                                    positionOfPlayer2 = 0;
                                break;

                        }
                        if (positionOfPlayer2 != winningPosition)
                            playerNumber = 1;
                        Console.WriteLine("The position of player 2 after die roll number {0} is {1}", Moves, positionOfPlayer2);
                        break;
                }
            
            }
        Console.WriteLine("The winner is is player number {0} and total number of MOves is {1}", playerNumber, Moves);
        }
    }
}
 