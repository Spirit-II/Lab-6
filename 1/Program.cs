using Lab_6_5;

internal class Program
{
    static void Main()
    {
        /// Тестирование базового класса
        Book book1 = new Book(200, 1500, 4);
        Book book2 = new Book(book1);

        Console.WriteLine("Book 1:");
        Console.WriteLine(book1.ToString());
        Console.WriteLine("Max Field: " + book1.MaxField());

        Console.WriteLine("\nBook 2 (Copy):");
        Console.WriteLine(book2.ToString());
        Console.WriteLine("Max Field: " + book2.MaxField());

        /// Тестирование дочернего класса
        eBook ebook1 = new eBook(150, 1200, 5, true);
        eBook ebook2 = new eBook(ebook1);

        Console.WriteLine("\neBook 1:");
        Console.WriteLine(ebook1.ToString());
        Console.WriteLine("Max Field: " + ebook1.MaxField());
        Console.WriteLine("Total Price with Discount: " + ebook1.GetTotalPrice(200));
        Console.WriteLine("Has High Rating: " + ebook1.HasHighRating(3));

        Console.WriteLine("\neBook 2 (Copy):");
        Console.WriteLine(ebook2.ToString());
        Console.WriteLine("Max Field: " + ebook2.MaxField());
        Console.WriteLine("Total Price with Discount: " + ebook2.GetTotalPrice(200));
        Console.WriteLine("Has High Rating: " + ebook2.HasHighRating(3));
    }
}