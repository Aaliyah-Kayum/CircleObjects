//public Circle (double radius)
//public double CalculateCircumference()
//public string CalculateFormattedCircumference()
//public double CalculateArea()
//public string CalculateFormattedArea()  
//private string FormatNumber(double x)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleObjects
{
    internal class Circle
    {
        public double radius { get; set; }

        public double CalculateCircumference()
        {
        return 2 * mathPI * radius
            }
    public double CalculateArea()
        {
            return mathPI * radius * 2
        }
string choice = Console.ReadLine(); 
        if(choice == "y")
{
    continue;
}
else if (choice == "n")
{
    break;
}
else
{
    Console.WriteLine($"Goodbye. You created {circle} Circle object(s)");
}