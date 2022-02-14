using CircleObjects;

Console.WriteLine("Welcome to the Circle Tester");

Circle circle = new Circle();

Console.WriteLine("Enter radius: ");
double r;

while(!int.TryParse(circle.Radius, out r))
{
    Console.WriteLine("Invalid Input");
}

circle.Radius = r;

Console.WriteLine($"The circumference of the circle is {circle.Circumference}");

Console.WriteLine($"The area of the circle is {circle.Area}");

Console.WriteLine("Continue? (y/n)");
  