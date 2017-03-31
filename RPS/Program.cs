using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool started = true;
            while (started)
            {
                string p1 = "player 1";
                string p2 = "player 2";

                Console.WriteLine("Please select from the menu");
                Console.WriteLine("'name' to enter players names");
                Console.WriteLine("'play' to enter game");
                Console.WriteLine("'exit' to exit game");
               


                string input = Console.ReadLine();

                switch (input)
                {
                    case "play":

                        bool game = true;
                        while (game)
                        {
                            Console.WriteLine(p1 + "Please select 'rock', 'scissor' or 'paper'");
                            string gameInputp1 = Console.ReadLine();
                            Console.WriteLine(p2 + "Please select 'rock', 'scissor' or 'paper'");
                            string gameInputp2 = Console.ReadLine();

                            switch (gameInputp1)
                            {
                                case "rock":
                                    switch (gameInputp2)
                                    {
                                        case "rock":
                                            Console.WriteLine("Draw!");
                                            break;

                                        case "scissors":
                                            Console.WriteLine(p1 + "Wins!");
                                            break;

                                        case "paper":
                                            Console.WriteLine(p2 + "Wins!");
                                            break;

                                        default:
                                            break;
                                    }
                                    break;

                                case "scissors":
                                    switch (gameInputp2)
                                    {
                                        case "rock":
                                            Console.WriteLine(p2 + "Wins!");
                                            break;

                                        case "scissors":
                                            Console.WriteLine("Draw!");
                                            break;

                                        case "paper":
                                            Console.WriteLine(p1 + "Wins!");
                                            break;

                                        default:
                                            break;
                                    }
                                    break;

                                case "paper":
                                    switch (gameInputp2)
                                    {
                                        case "rock":
                                            Console.WriteLine(p1 + "Wins!");
                                            break;

                                        case "scissors":
                                            Console.WriteLine(p2 + "Wins!");
                                            break;

                                        case "paper":
                                            Console.WriteLine("Draw!");
                                            break;

                                        default:
                                            break;
                                    }
                                    break;

                                default:
                                    break;
                            }

                            game = false;

                        }

                        break;
                    case "name":
                        Console.WriteLine("Player 1 name: ");
                        p1 = Console.ReadLine();
                        Console.WriteLine("Player 2 name: ");
                        p2 = Console.ReadLine();

                        break;
                    case "exit":
                        started = false;
                        break;
                }
            }
        }

       
    }
}