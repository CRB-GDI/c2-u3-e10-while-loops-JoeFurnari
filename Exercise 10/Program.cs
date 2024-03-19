namespace Exercise_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;

            while ( choice != 4)
            {

            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine("");

            Console.WriteLine("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Creating Game...");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading Game...");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Loading options...");
                }
                else if (choice > 4 || choice < 1)
                {
                    Console.WriteLine("Please type in 1,2,3, or 4");
                }
            }
        }
    }
}