
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Book("Micah's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(98.2);

            book.ShowStatistics();



        }
    }
}
