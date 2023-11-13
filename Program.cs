namespace HotDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();    
            tea.MakeDrink();

            Console.WriteLine();

            Coffee coffee = new Coffee();
            coffee.MakeDrink();


        }
    }
}