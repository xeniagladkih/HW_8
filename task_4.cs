using System;

public class Book : IPrice, IDiscount
{
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount is {discount}");
    }
    public void SetPrice(double price)
    {
        Console.WriteLine($"Price is {price}$");
    }
}

public class Overdress : IColor, ISize, IPrice, IDiscount
{
    public void SetSize(byte size)
    {
        Console.WriteLine($"Size - {size}");
    }
    public void SetColor(byte color)
    {
        Console.WriteLine($"Color - {color}");
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount - {discount}");
    }
    public void SetPrice(double price)
    {
        Console.WriteLine($"Price - {price}$");
    }
}
interface IPromocode
{
    void ApplyPromocode(string promocode);
}
interface IDiscount
{
    void ApplyDiscount(string discount);
}
interface IColor
{
    void SetColor(byte color);
}
interface ISize
{
    void SetSize(byte size);
}
interface IPrice
{
    void SetPrice(double price);
}
class Program
{
    static void Main(String[] args)
    {
        Book book = new Book();
        Console.WriteLine("The book \"Clean code\"");
        book.ApplyDiscount("50%");
        book.SetPrice(350);
        Overdress jacket = new Overdress();
        Console.WriteLine();
        Console.WriteLine("Prada Jacket");
        jacket.SetColor(16);
        jacket.SetSize(36);
        jacket.ApplyDiscount("10%");
        jacket.SetPrice(2500);
    }
}
