//function task:
Console.WriteLine("Enter your name");
string userName = Console.ReadLine();
greet(userName);

Console.WriteLine("Enter length");
double length = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter width");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter height");
double height = Convert.ToDouble(Console.ReadLine());

double volume = calculateVolume(length, width, height);
Console.WriteLine($"The volume of the box is {volume}");


static void greet(string name)
{
    Console.WriteLine($"Hello {name}");
}

static double calculateVolume(double length, double width, double height)
{
    return length * width * height;
}

