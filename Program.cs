Console.Write("Please enter your name : ");
string name = Console.ReadLine();

Console.Write("Please enter your age : ");
int age = Convert.ToInt32(Console.ReadLine());

int futureAge = age + 5;

Console.WriteLine($"Hello {name}, you will be {futureAge} in 5 years.");

//

Console.WriteLine("Please enter your age : ");
  int secondage = Convert.ToInt32(Console.ReadLine());

if (secondage < 0 || secondage > 110)
{
    Console.WriteLine("Invalid");
}
else
{
    if (secondage < 13)
    {
        Console.WriteLine("You are a child");
    }

    else if (secondage >= 13 && secondage <= 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else
    {
        Console.WriteLine("You are an adult");
    }
}

//

Console.WriteLine("Please enter an integer");
  int number = Convert.ToInt32(Console.ReadLine()); 

  if (number > 0)
{
    Console.WriteLine("This is a positive number");
}
  else if (number < 0)
{
    Console.WriteLine("This is a negative number");
}
  else
{ Console.WriteLine("This is zero");
}

//

Console.WriteLine("Enter year");
  int year = Convert.ToInt32(Console.ReadLine());

    if (year < 0)
{
    Console.WriteLine("Year cannot be negative");
}
    else
{
    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}

//


Console.WriteLine("Enter an integer: ");
int thirdnumber = Convert.ToInt32(Console.ReadLine());

if (thirdnumber % 2 == 0)
{
    Console.WriteLine($"{thirdnumber} is even");
}
  else
{
    Console.WriteLine($"{thirdnumber} is odd");
}
