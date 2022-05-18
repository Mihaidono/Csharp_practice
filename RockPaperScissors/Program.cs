using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playCondition = true;
            Random random= new Random();
            int winCount=0;
            int loseCount = 0;
            int drawCount = 0;
            int rounds = 1;
            String player;
            String computer;

            while (playCondition)
            {
                
                player = "";
                computer = "";
                int auxWinCount = winCount;
                while (player!="ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter rock,paper or scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("ROUND "+rounds+":\nPlayer: "+player+"\tComputer: "+computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            drawCount++;
                            Console.WriteLine("===DRAW===");
                        }
                        else if (computer == "SCISSORS")
                        {
                            winCount++;
                            Console.WriteLine("===YOU WIN===");
                        }
                        else 
                        {
                            loseCount++;
                            Console.WriteLine("===YOU LOSE==="); 
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            drawCount++;
                            Console.WriteLine("===DRAW===");
                        }
                        else if (computer == "ROCK")
                        {
                            winCount++;
                            Console.WriteLine("===YOU WIN===");
                        }
                        else
                        {
                            loseCount++;
                            Console.WriteLine("===YOU LOSE===");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            drawCount++;
                            Console.WriteLine("===DRAW===");
                        }
                        else if (computer == "PAPER")
                        {
                            winCount++;
                            Console.WriteLine("===YOU WIN===");
                        }
                        else
                        {
                            loseCount++;
                            Console.WriteLine("===YOU LOSE===");
                        }
                        break;
                }
                rounds++;

                Console.WriteLine("Play again?(Y/N): ");
                String answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playCondition = true;
                } else
                {
                    playCondition = false;
                }
            }
            Console.WriteLine("===/STATS\\===\nIn this session you:\nWon "+winCount+" games\nLost "+
                loseCount+" games\nDrawed "+drawCount+" games.\nGood session chief!");
        }
    }
}
