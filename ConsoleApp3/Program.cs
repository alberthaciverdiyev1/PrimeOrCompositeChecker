class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Number");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number is not null)
        {
            if (number == 1)
            {
                Console.WriteLine($"{number} Sade.");
            }
            else if (number <= 0)
            {
                Console.WriteLine($"Sade ve Murekkeb eded anlayisi ancaq natural ededeler ucun kecerlidir");
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine($"{number} Murekkeb.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{number} Sade.");
                        break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("I am eRRoR.");

        }
    }

}
