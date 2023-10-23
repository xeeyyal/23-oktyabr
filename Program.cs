using ConsoleApp1.Exceptions;
using ConsoleApp1.Models;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK - 1 (1-ci usul qisa sintaksis)

            //SortedDictionary<int, string> programmingLanguages = new SortedDictionary<int, string>();

            //programmingLanguages.Add(1989, "Python");
            //programmingLanguages.Add(1972, "C");
            //programmingLanguages.Add(1983, "C++");
            //programmingLanguages.Add(2000, "C#");
            //programmingLanguages.Add(1995, "JavaScript");

            //Console.WriteLine("Programming Languages:");
            //foreach (var language in programmingLanguages)
            //{
            //    Console.WriteLine($"{language.Value} - {language.Key}");
            //}

            //TASK-1 (2-ci usul)
            //Dictionary<string, DateTime> programmingLanguages = new Dictionary<string, DateTime>();

            //programmingLanguages["Java"] = new DateTime(1995, 5, 23);
            //programmingLanguages["C"] = new DateTime(1972, 1, 1);
            //programmingLanguages["C++"] = new DateTime(1983, 1, 1);
            //programmingLanguages["C#"] = new DateTime(2000, 1, 1);
            //programmingLanguages["Python"] = new DateTime(1989, 2, 20);

            //var sortedLanguages = programmingLanguages.OrderBy(language => language.Value);

            //Console.WriteLine("Programming Languages:");
            //foreach (var language in sortedLanguages)
            //{
            //    Console.WriteLine($"{language.Key} ({language.Value.Year})");
            //}

            //TASK-3

            //    List<Library> libraries = new List<Library>();
            //    List<Category> categories = new List<Category>();
            //    List<Book> books = new List<Book>();


            //    while (true)
            //    {
            //        Console.WriteLine("Ana Menyu ");
            //        Console.WriteLine("[1] Yeni kitabxana yarat");
            //        Console.WriteLine("[2] Yeni kateqoriya yarat");
            //        Console.WriteLine("[3] Yeni kitab yarat");
            //        Console.WriteLine("[4] Kitabxanaya daxil ol");
            //        Console.WriteLine("[0] Proqramdan chix");

            //        string input = Console.ReadLine();
            //        switch (input)
            //        {
            //            case "1":
            //                Console.Write("Kitabxana adını daxil edin: ");
            //                string libraryName = Console.ReadLine();
            //                Library library = new Library(libraryName);
            //                libraries.Add(library);
            //                Console.WriteLine($"{libraryName} adlı kitabxana yaradıldı.");
            //                break;

            //            case "2":
            //                Console.Write("Kateqoriyanın adını daxil edin: ");
            //                string categoryName = Console.ReadLine();
            //                Category category = new Category(categoryName);
            //                categories.Add(category);
            //                Console.WriteLine($"{categoryName} adlı kateqoriya yaradıldı.");
            //                break;

            //            case "3":
            //                Console.Write("Kitabın adını daxil edin: ");
            //                string bookName = Console.ReadLine();
            //                Console.Write("Yazarını daxil edin: ");
            //                string author = Console.ReadLine();

            //                Console.WriteLine("Kateqoriyalar:");
            //                for (int i = 0; i < categories.Count; i++)
            //                {
            //                    Console.WriteLine($"{i + 1}. {categories[i].Name}");
            //                }

            //                int categoryIndex;
            //                do
            //                {
            //                    Console.Write("Kateqoriyanın nömrəsini seçin: ");
            //                } while (!int.TryParse(Console.ReadLine(), out categoryIndex) || categoryIndex < 1 || categoryIndex > categories.Count);

            //                throw new CategoryNotFoundException();

            //                Category selectedCategory = categories[categoryIndex - 1];
            //                Book book = new Book(bookName, author, selectedCategory);
            //                books.Add(book);
            //                Console.WriteLine($"Kitab \"{bookName}\" yaradıldı.");
            //                break;

            //            case "4":
            //                Console.WriteLine("Kitabxanalar:");
            //                for (int i = 0; i < libraries.Count; i++)
            //                {
            //                    Console.WriteLine($"{i + 1}. {libraries[i].Name}");
            //                }

            //                int libraryIndex;
            //                do
            //                {
            //                    Console.Write("Kitabxananın nömrəsini seçin: ");
            //                } while (!int.TryParse(Console.ReadLine(), out libraryIndex) || libraryIndex < 1 || libraryIndex > libraries.Count);

            //                throw new LibraryNotFoundException();

            //                Library selectedLibrary = libraries[libraryIndex - 1];
            //                LibraryMenu(selectedLibrary, books);
            //                break;
            //            case "0":
            //                Environment.Exit(0);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}
            //static void LibraryMenu(Library library, List<Book> _books)
            //{
            //    Console.WriteLine($"{library.Name}:  Kitabxanasinin menyusu");
            //    Console.WriteLine("1. Kitab əlavə et");
            //    Console.WriteLine("3. Kitabxanadan çıx");

            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            BookList(_books);
            //            AddBookToLibrary(library, _books);
            //            break;
            //        case "2":
            //            Console.WriteLine($"Kitabxana: {library.Name}");
            //            foreach (var book in _books)
            //            {
            //                Console.WriteLine($"Kitab adı: {book.Name}, Müəllif: {book.Author}, Kateqoriya: {book.Category.Name}");
            //            }
            //            break;
            //        default:
            //            break;
            //    }
            //}
            //static void BookList(List<Book> books)
            //{
            //    Console.WriteLine("Kitablar:");
            //    for (int i = 0; i < books.Count; i++)
            //    {
            //        Console.WriteLine($"{i + 1}. {books[i].Name} - {books[i].Author}");
            //    }
            //}
            //static void AddBookToLibrary(Library library, List<Book> books)
            //{
            //    int bookIndex;
            //    do
            //    {
            //        Console.Write("Əlavə etmək istədiyiniz kitabın nömrəsini seçin: ");
            //    } while (!int.TryParse(Console.ReadLine(), out bookIndex) || bookIndex < 1 || bookIndex > books.Count);

            //    //TryParse-dan false gelirse:
            //    throw new WrongInputException();

            //    Book selectedBook = books[bookIndex - 1];
            //    library.AddBook(selectedBook);
            //}
        }
    }
}