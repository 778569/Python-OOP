using System.Drawing;
using Test_APP;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        RectangleR rectangleR = new RectangleR(10,20);
        //rectangleR.FindArea();
        rectangleR.printDetails();

        Console.ReadLine();

    }
}