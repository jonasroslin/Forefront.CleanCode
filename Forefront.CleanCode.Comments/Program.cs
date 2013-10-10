using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forefront.CleanCode.Comments
{
    class Program
    {


        static void Main(string[] args)
        {
            int x = 0;
            int numberOfGames = 0;
            while (true)
            {

                numberOfGames++;
                
                //Create random number
                var random = new Random();
                var magicNumber = random.Next(1, 10);

                //Start the game
                var inputNumber = new int();
                var y = 0;
                while (inputNumber != magicNumber)
                {
                    Console.Write("Enter a number: ");
                    //Get user input and convert to int
                    var readLine = Console.ReadLine();
                    
                  inputNumber = Convert.ToInt16(readLine);

                    //Check if the number is wrong and print to screen
                  if (inputNumber != magicNumber)
                  {
                      Console.WriteLine("Wrong number");
                  }

                    //Check if the number is to high and print to screen
                    if (inputNumber > magicNumber)
                        Console.WriteLine("To high");

                        //Check if the number is to low and print to screen
                        if (inputNumber < magicNumber)
                            Console.WriteLine("To low");

                    //Add number of times 
                    y++;
                }

                //Add global times
                x = x + y;
                //Print correct result
                Console.WriteLine("Correct after {0} times", y);





                Console.WriteLine("Correct number {0}", magicNumber);
                Console.WriteLine("Avg: {0}", x / numberOfGames );

                Console.WriteLine("One more time? Y/N");
                var line = Console.ReadLine();
                if (line.ToLower() == "y")
                    continue;
                if(line.ToLower() == "n")
                    break;   
            }
        }
    }
}
