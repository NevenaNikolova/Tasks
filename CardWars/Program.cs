using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars
{
    class Program
    {
        static void Main(string[] args)
        {
            //ne e dovarshena

            int n = int.Parse(Console.ReadLine());
            int handPlayer1 = 0;
            int scorePlayer1 = 0;
            int handPlayer2 = 0;
            int scorePlayer2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    string card = Console.ReadLine();
                    if (card == "Z")
                    {
                        scorePlayer1 *= 2;
                    }
                    else if (card == "Y")
                    {
                        scorePlayer1 -= 200;
                    }
                    else if (card == "X")
                    {

                    }
                    
                    int cardPoints = SwitchToPoints(card);
                    handPlayer1 += cardPoints;
                }

                for (int k = 0; k < 3; k++)
                {
                    string card = Console.ReadLine();
                    if (card == "Z")
                    {
                        scorePlayer2 *= 2;
                    }
                    else if (card == "Y")
                    {
                        scorePlayer2 -= 200;
                    }
                    else if (card == "X")
                    {

                    }            
                        int cardPoints = SwitchToPoints(card);
                        handPlayer2 += cardPoints;                   
                }
                if (handPlayer1 > handPlayer2)
                {
                    scorePlayer1 += handPlayer1;
                }
                else if (handPlayer2 > handPlayer1)
                {
                    scorePlayer2 += handPlayer2;
                }
            }
        }

        static int SwitchToPoints(string card)
        {
            int points = 0;
            switch (card)
            {
                case "2": points = 10; break;
                case "3": points = 9; break;
                case "4": points = 8; break;
                case "5": points = 7; break;
                case "6": points = 6; break;
                case "7": points = 5; break;
                case "8": points = 4; break;
                case "9": points = 3; break;
                case "10": points = 2; break;
                case "A": points = 1; break;
                case "J": points = 11; break;
                case "Q": points = 12; break;
                case "K": points = 13; break;                
                default:
                    break;
            }
            return points;

        }
    }
}
