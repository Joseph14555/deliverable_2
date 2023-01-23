Console.WriteLine("Hello, World!");
while (true)
    try
    {
        Console.Write("What Grade do you expect in ISM 4300: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 1 && num < 60)
        {
            Console.WriteLine("\nYour letter grade is F");
        }
        else if (num >= 60 && num < 70)
        {
            Console.WriteLine("\n Your letter grade is D");
        }
        else if (num >= 70 && num < 80)
        {
            Console.WriteLine("\n Your letter grade is C");
        }
        else if (num >= 80 && num < 90)
        {
            Console.WriteLine("\n Your letter grade is B");
        }
        else if (num >= 90 && num < 100)
        {
            Console.WriteLine("\n Your letter grade is A");
        }
        else
        {
            Console.WriteLine("\nYour Marks are not valid");
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("Not a valid number. Please try again.");
        {
            Console.WriteLine("");
        }
    }

           
