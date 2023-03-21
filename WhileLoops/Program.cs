//while loop

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; // bpp; -true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
  
    Console.WriteLine("Make a quess. Enter a number 1-3");
    int usernumber = Int32.Parse(Console.ReadLine());

    if (usernumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, You won!");
        loopActive = false;// voi break;
    }
    else
    {
        Console.WriteLine("Oops. Try again");
    }
}

Console.WriteLine("Have a nice day");

