using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 3;
            do
            {
                Console.Write("What is my favorite food? ");
                string answer = Console.ReadLine();

                if (answer.Equals("Hotdog")){
                    Console.WriteLine(answer + " is correct! \nCongratulations!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    lives--;
                    Console.WriteLine("Lives left: " + lives);
                    Console.WriteLine();
                    if(lives == 0)
                    {
                        Console.WriteLine("Game Over");
                    }
                }
            } while (lives > 0);
        }
    }
}