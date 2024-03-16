using System;

class Book
{
    public Title Title { get; }
    public Author Author { get; set; }
    public Content Content { get; set; }

    public Book(string title)
    {
        this.Title = new Title(title);
    }

    public void Show()
    {
        Title.Show();
        Author.Show();
        Content.Show();
    }
}

class Title
{
    private string title;

    public Title(string title)
    {
        this.title = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Назва: " + title);
        Console.ResetColor();
    }
}

class Author
{
    public string Name { get; set; }

    public Author(string name)
    {
        Name = name;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Автор: " + Name);
        Console.ResetColor();
    }
}

class Content
{
    public string Info { get; set; }

    public Content(string info)
    {
        Info = info;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Зміст: " + Info);
        Console.ResetColor();
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("Історія України");
        book.Author = new Author("Іван Франко");
        book.Content = new Content("Ця книга розповідає про історію України...");

        book.Show();
    }
}
