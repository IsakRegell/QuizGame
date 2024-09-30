namespace QuizGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            bool programIsRunning = true;

            Console.WriteLine("Welcome to the Quiz");
            Console.WriteLine("- - - - - - - - - - - ");


            Q1();
            while (programIsRunning)
            {
                String A1 = Console.ReadLine().ToUpper();

                switch (A1)
                {
                    case "A":
                        Console.WriteLine("Rätt svar");
                        score++;
                        programIsRunning = false;
                        break;

                    case "B":
                        Console.WriteLine("Fel svar, rätt svar var A");
                        programIsRunning = false;
                        break;

                    case "C":
                        Console.WriteLine("Fel svar, rätt svar var A");
                        programIsRunning = false;
                        break;

                    case "D":
                        Console.WriteLine("Fel svar, rätt svar var A");
                        programIsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltligt svar, försök igen!");
                        break;
                }
            }
            
            Q2();

            while (!programIsRunning)
            {
                String A2 = Console.ReadLine().ToUpper();
                switch (A2)
                {
                    case "A":
                        Console.WriteLine("Fel svar");
                        programIsRunning = true;
                        break;

                    case "B":
                        Console.WriteLine("Fel svar");
                        programIsRunning = true;
                        break;

                    case "C":
                        Console.WriteLine("Rätt svar");
                        programIsRunning = true;
                        score++;
                        break;
                    case "D":
                        Console.WriteLine("Fel svar");
                        programIsRunning = true;
                        break;
                    default:
                        Console.WriteLine("Oglitigt svar, försök igen");
                        break;
                }
            }
            

            Q3();
            while (programIsRunning)
            {
                String A3 = Console.ReadLine().ToUpper();
                switch (A3)
                {
                    case "A":
                        Console.WriteLine("Fel svar");
                        programIsRunning = false;
                        break;

                    case "B":
                        Console.WriteLine("Rätt svar");
                        programIsRunning = false;
                        score++;
                        break;

                    case "C":
                        Console.WriteLine("Fel svar");
                        programIsRunning = false;
                        break;

                    case "D":
                        Console.WriteLine("Fel svar");
                        programIsRunning = false;
                        break;

                    default:
                        Console.WriteLine("Ogiltígt svar, försök igen");
                        break;

                }
            }
            

            Console.WriteLine($"Du fick {score} av 3 rätt");





        }



        static void Q1()
         {
            Console.WriteLine("Vad är den maximala tillåtna storleken på ett golfhål enligt reglerna?");
            Console.WriteLine("A : 108 mm"); //rätt svar
            Console.WriteLine("B : 110 mm");
            Console.WriteLine("C : 102 mm");
            Console.WriteLine("D : 104 mm");
            Console.Write("Ditt svar : ");
           
        }

        static void Q2()
        {
            Console.WriteLine("Vilken golfspelare har rekordet för flest antal major-segrar?");
            Console.WriteLine("A : Phil Mickelson");
            Console.WriteLine("B : Arnold Palmer");
            Console.WriteLine("C : Jack Nickaus"); // rätt svar
            Console.WriteLine("D : Tiger Woods");
            Console.Write("Ditt svar : ");

            
        }

        static void Q3()
        {
            Console.WriteLine("Vad är den maximala vikten på en golfboll enligt reglerna?");
            Console.WriteLine("A : 46,5 gram");
            Console.WriteLine("B : 45,93 gram"); //rätt svar
            Console.WriteLine("C : 45,0 gram");
            Console.WriteLine("D : 47,5 gram");
            Console.Write("Ditt svar : ");
            
        }

     
       

    }


}
