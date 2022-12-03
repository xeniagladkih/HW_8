//У даному прикладі порушено The Liskov Substitution Principle.
//Функції, які використовують посилання на базові
//класи, повинні мати можливість використовувати
//об'єкти похідних класів, не знаючи про це.
//Це можна виправити наступним чином:

using System;
class Program
{
    static void Main(string[] args)
    {
        Shape rect = new Rectangle { Width = 5, Height = 10 };
        Console.WriteLine(rect.GetArea());
        Console.ReadKey();
    }
}

public abstract class Shape
{
    public abstract int GetArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int GetArea()
    {
        return Width * Height;
    }
}


public class Square : Shape
{
    public int Length { get; set; }
    public override int GetArea()
    {
        return Length * Length;
    }
}
