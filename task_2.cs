//У даному прикладі також порушено The Single Responsibility Principle.
//Це можна виправити наступним чином:

class Email
{
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
}
class EmailSendTo
{
    public void SendTo(Email email)
    {
        // ... sending...
        Console.WriteLine(email.To);
    }
}

class EmailSendFrom
{
    public void SendFrom(Email email)
    {
        // ... sending...
        Console.WriteLine(email.From);
    }
}

class EmailSendTheme
{
    public void SendTheme(Email email)
    {
        // ... sending...
        Console.WriteLine(email.Theme);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Email e1 = new Email() { From = "Nata", To = "Ludmula", Theme = "You are wonderful!" };
        Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
        Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
        Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
        Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
        Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

        EmailSendTo to = new EmailSendTo();
        EmailSendFrom from = new EmailSendFrom();
        EmailSendTheme theme = new EmailSendTheme();
        to.SendTo(e1);
        from.SendFrom(e1);
        theme.SendTheme(e1);
        Console.ReadKey();
    }
}
