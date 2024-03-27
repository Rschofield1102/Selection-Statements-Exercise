namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Welcome to guess the number!");
            Console.WriteLine("Guess the correct number!");

            var userResponse = Console.ReadLine();

            var guess = int.Parse(userResponse);

            var random = new Random();
            var number = 7;
            

            
            

                if (guess > number)
                {
                    Console.WriteLine("too HIGH");
                
                }
                else if (guess < number)
                {
                    Console.WriteLine("too Low");
                }
                else
                {
                    Console.WriteLine("good job");
                }


            
        }
    }    }