bool backTop = true;
while (backTop)
{
    Console.WriteLine("How many people are we making PB&J sandwhiches for?");
    int x = int.Parse(Console.ReadLine());

    double bread = x * 2;
    double peanut = x * 2;
    double jelly = x * 4;

    Console.WriteLine("");
    Console.WriteLine("You need:");
    Console.WriteLine("");

    Console.WriteLine(bread + " slices of bread");
    Console.WriteLine(peanut + " tablespoons of peanut butter");
    Console.WriteLine(jelly + " teaspoons of jelly");

    Console.WriteLine("");
    Console.WriteLine("which is...");
    Console.WriteLine("");
    

    double loavesOfBread = Math.Ceiling(bread / 28);
    double jarsOfPeanutButter = Math.Ceiling(peanut / 32);
    double jarsOfJelly = Math.Ceiling(jelly / 48);


    Console.WriteLine(loavesOfBread + " loaves of bread");
    Console.WriteLine(jarsOfPeanutButter + " jars of peanut butter");
    Console.WriteLine(jarsOfJelly + " jars of jelly");
    Console.WriteLine("");

   
    while (backTop)
    {
        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        string input = Console.ReadLine();
        if (input == "yes")
            break;
        else if (input == "y")
            break;
        else
            Console.WriteLine("Goodbye");
        return;
    }
}

