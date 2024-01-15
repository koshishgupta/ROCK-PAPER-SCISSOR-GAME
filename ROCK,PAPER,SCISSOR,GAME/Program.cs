namespace ROCK_PAPER_SCISSOR_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerscore = 0, enemyscore = 0;
            Console.WriteLine("WELCOME TO ROCK PAPER SCISSORS GAME:");
           Random random = new Random();

            while (enemyscore != 3 || enemyscore != 3)
            {
                Console.WriteLine(" PLAYER SCORE =" + playerscore + " ENEMY SCORE = " + enemyscore);
            
                    Console.WriteLine("PRESS R FOR ROCK:");
                    Console.WriteLine("PRESS P FOR PAPER:");
                    Console.WriteLine("PRESS S FOR SCISSOR:");
                    string playerchoice=Console.ReadLine();
                    int enemychoice= random.Next(0,3);
                    if (enemychoice == 0)
                    {
                        Console.WriteLine("ENEMY CHOOSE ROCK:");
                        switch(playerchoice)
                        {
                            case "r": Console.WriteLine("MATCH TIE");
                            break;
                        case "p": Console.WriteLine("PLAYER WIN THIS ROUND");
                            playerscore++;
                            break;
                            case "s": Console.WriteLine("ENEMY WIN THIS ROUND");
                            enemyscore++;
                            break;

                                
                                

                              
                        }
                    }
                    else if(enemychoice == 1)
                    
                    {
                        Console.WriteLine("ENEMY CHOOSE PAPER");
                   switch(playerchoice)
                    {
                       
                        case "r":
                            Console.WriteLine("ENEMY WIN THIS ROUND");
                            enemyscore++;
                            break;
                        case "p":
                            Console.WriteLine("MATCH TIE");
                                
                            break;
                        case "s":
                            Console.WriteLine("PLAYER WIN THIS ROUND");
                            playerscore++;
                            break;
                    }


                    }
                    else
                    {
                        Console.WriteLine("ENEMY CHOICE SCISSOR");
                    switch (playerchoice)
                    {
                     
                        case "r":
                            Console.WriteLine("PLAYER WIN THIS ROUND");
                            playerscore++;
                            break;
                        case "p":
                            Console.WriteLine("ENEMY WIN THIS ROUND");
                            enemyscore++;
                            break;
                        case "s":
                            Console.WriteLine("MATCH TIE");
                            break;
                    }
                    }









                }
            }
        }
    }

