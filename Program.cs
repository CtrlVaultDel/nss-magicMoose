using System;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            string Question = "blank";
            Random rand = new Random();

            while (Question != "")
            {
                // Prompt user for a question
                Console.WriteLine("Ask me a question!");
                Question = Console.ReadLine();

                // Check if the user entered an empty question
                // Exit the application if so and send a goodbye
                // message to the user.
                if (Question == "")
                {
                    Console.WriteLine("See you later!");
                    break;
                }

                // Choose a random response
                int Response = rand.Next(0, 20);

                // Possible responses to user's question
                switch (Response)
                {
                    case 0:
                        Console.WriteLine("Ah I see it, yes.");
                        break;
                    case 1:
                        Console.WriteLine("Ask again later.");
                        break;
                    case 2:
                        Console.WriteLine("Better not tell you now.");
                        break;
                    case 3:
                        Console.WriteLine("Cannot predict now.");
                        break;
                    case 4:
                        Console.WriteLine("Concentrate and ask again.");
                        break;
                    case 5:
                        Console.WriteLine("Don't count on it.");
                        break;
                    case 6:
                        Console.WriteLine("It is certain.");
                        break;
                    case 7:
                        Console.WriteLine("It is decidedly so.");
                        break;
                    case 8:
                        Console.WriteLine("Most likely.");
                        break;
                    case 9:
                        Console.WriteLine("My reply is no.");
                        break;
                    case 10:
                        Console.WriteLine("My sources say no.");
                        break;
                    case 11:
                        Console.WriteLine("Outlook not so good.");
                        break;
                    case 12:
                        Console.WriteLine("Outlook good.");
                        break;
                    case 13:
                        Console.WriteLine("Reply hazy, try again.");
                        break;
                    case 14:
                        Console.WriteLine("Signs point to yes.");
                        break;
                    case 15:
                        Console.WriteLine("Very doubtful.");
                        break;
                    case 16:
                        Console.WriteLine("Without a doubt.");
                        break;
                    case 17:
                        Console.WriteLine("Yes.");
                        break;
                    case 18:
                        Console.WriteLine("Yes-definitely");
                        break;
                    case 19:
                        Console.WriteLine("You may rely on it.");
                        break;
                }

                // Spacing after the response
                Console.WriteLine();
            }
        }
    }
}
