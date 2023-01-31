namespace Newton_Deliverable3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            string series = "";

            while (true)
            {
                try
                {
                    Console.Write("Enter an integer number between 1 and 100: ");
                    input = int.Parse(Console.ReadLine());

                    if (input >= 1 && input <= 100)
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Please use a integer number between 1 and 100");
                    Console.ReadKey(true);
                }
            }
            while (true)
            {
                Console.Write("Specify the series type: Even or Odd ");
                series = Console.ReadLine();

                if (series == "Even" || series == "Odd")
                {
                    break;
                }
            }


            if (series == "Odd")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are:\n");
                for (int i = 1; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            if (series == "Even")
            {
                Console.Write("You have selected " + series + " series. The numbers between 0 and " + input + " are:\n");
                for (int i = 2; i <= input; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
