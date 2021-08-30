using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            bool keepGoing = true;
            bool repeatHello = true;
            bool repeatSup = true;
            bool repeatHelloThere = true;
            
            Console.WriteLine("What would you like to say to the chat bot?");

            //loop
            while (keepGoing)//conditionals
            {
                string question = Console.ReadLine().ToLower();

                if (question == "hello" )
                {
                    if (repeatHello)
                    {
                        Console.WriteLine("Hi good to see you.");
                        repeatHello = false;
                    }
                    else
                    { 
                        Console.WriteLine("I'm sorry, but you have already said that.");
                    }
                } 
                else if (question == "sup")
                {
                    if (repeatSup)
                    {
                        Console.WriteLine("I am good");
                        repeatSup = false;
                    } 
                    else
                    {
                        Console.WriteLine("I'm sorry, but you have already said that.");
                    }
                }
                else if (question == "hello there")
                {
                    if (repeatHelloThere)
                    {
                        Console.WriteLine("General Kenobi");
                        repeatHelloThere = false;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, but you have already said that.");
                    }
                }
                else if (question == "bye")
                {
                    Console.WriteLine("Good Bye!");
                    break;
                } else
                {
                    Console.WriteLine("Sorry, I do not understand you..could you rephrase? ");
                }
                Console.WriteLine("Please say something else:");
                
                

            } 

        }
    }
}
    

