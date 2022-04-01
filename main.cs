// Created by: Marshall Demars
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double height;
        double width;
        double length;
        double area;

        // input
        Console.WriteLine("This program finds the volume of a pyramid");
        Console.WriteLine("");
        Console.WriteLine("the formula is: [(a + b) / 2] x h");
        Console.WriteLine("");
        Console.WriteLine("please enter the measurements (m)");
        Console.WriteLine("");

        Console.Write("Input the measurement for base a: ");
        baseA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for base b: ");
        baseB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the measurement for the height: ");
        height = Convert.ToDouble(Console.ReadLine());

        // process
        area = ((baseA + baseB) / 2) * height;

        // output
        Console.WriteLine("");
        Console.WriteLine("The area of the trapezoid is, " + area.ToString("0.00") + " m²");
        Console.WriteLine("\nDone.");
    }
}
