namespace BooksAdapter
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Library unknown = new Library("Unknown");
            unknown.Display();

            //Adapter books
            Library book1 = new Book("1");
            book1.Display();

            Library book2 = new Book("2");
            book2.Display();


            Library book3 = new Book("3");
            book3.Display();

            Console.ReadKey();

        }
    }


}
