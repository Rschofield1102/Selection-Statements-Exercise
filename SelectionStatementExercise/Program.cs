namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {  //exercise 1

            Console.WriteLine("Welcome!");
            Console.WriteLine("Guess the correct number between 1 and 10!");

            var userResponse = Console.ReadLine();

            var guess = int.Parse(userResponse);

            var random = new Random();
            var number = 7;

            if (guess > number)
            {
                Console.WriteLine($"Im sorry, {userResponse} is too HIGH");

            }
            if (guess < number)
            {
                Console.WriteLine($"Im sorry, {userResponse} is too Low");
            }
            if (guess == number)
            {
                Console.WriteLine("good job");
            }
            Console.WriteLine();

            //exercise 2
            Console.WriteLine(" What is your favorite subject in school?");
            var subject = Console.ReadLine();
            switch (subject)
               {
                case "Math":
                    Console.WriteLine("Math is easy!");
                    break;
                case "Science":
                    Console.WriteLine("Science is one of my favorites too!");
                    break;
                case "P.E":
                    Console.WriteLine("P.E. is fun");
                    break;
                case "Language Arts":
                    Console.WriteLine("Ohhh");
                    break;
                case "Homeroom":
                    Console.WriteLine("HAAAA");
                    break;
                default:
                    Console.WriteLine($"Ahh {subject} is fun too!");
                    break;
                }
            
               

            


        




        }




    }




}




