namespace C_Sharp_Advanced
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2.6
            var dictionary = new GenericDictionary<string, string>();
            dictionary.Add("Temp", "Temp");

            var number = new Nullable<int>(5);
            Console.WriteLine(number);

            //2.7
            var processor = new PhotoProcessor();
            var filters = new PhotoFilter();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);

            //2.8
            Console.WriteLine(Square(5));
            //args => expression
            //number => number * number

            //These both accomplish the same thing
            Func<int, int> square = Square;
            Func<int, int> squareLambda = number => number * number;
            // () => ...
            // x => ...
            // (x, y, z) => ...

            const int factor = 5;
            Func<int, int> multiplier = n => n * factor;
            var result = multiplier(10);

            var books = new BookRepository().GetBooks();
            //Predicate is delegate that points to method that gets book and returns a boolean value specifying if given condition was satisfied

            //These two things achieve the same
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            //book goes to book.price less than 10
            var cheapBooksLamba = books.Find(b => b.Price < 10);
        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }

        static int Square(int number)
        {
            return number * number;
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("redeye");
        }
    }
}