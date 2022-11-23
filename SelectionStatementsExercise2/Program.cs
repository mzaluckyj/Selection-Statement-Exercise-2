using System.Linq.Expressions;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");

            string subject = Console.ReadLine();

            switch (subject)    
            {
                case "Math":
                    Console.WriteLine("I hated Calculus 2 in college");
                    break;

                case "English":
                    Console.WriteLine("Worst subject ever!");
                    break;

                case "Gym":
                    Console.WriteLine("You miss 100% of the shots you don't take. -Wayne Gretzky -Michael Scott");
                    break;

                case "History":
                    Console.WriteLine("History is written by the vicotrs -Chruchill");
                    break;

                case "Muggle Studies":
                    Console.WriteLine("Safer than defense against the dark arts!");
                    break;

                default: Console.WriteLine("Really? Why?");
                    break;
                    
            }
           
        }
    }
}