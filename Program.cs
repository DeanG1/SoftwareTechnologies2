using VegetablePriceobserver;

namespace VegetablePriceObserver 
{
    class Program 
    {
        static void Main(string[] args) 
        
        {
            Cucumber cucumber = new Cucumber("Cucumber", 02.10);
            cucumber.Attach(new Restaurant("Odeon"));
            cucumber.Attach(new Restaurant("Nicole"));
            cucumber.Attach(new Restaurant("Victoria"));

            Cabbage cabbage = new Cabbage("Cabbage", 01.05);
            cabbage.Attach(new Restaurant("Odeon"));
            cabbage.Attach(new Restaurant("Nicole"));
            cabbage.Attach(new Restaurant("Victoria"));

            Tomato tomato = new Tomato("Tomato", 01.95);
            tomato.Attach(new Restaurant("Odeon"));
            tomato.Attach(new Restaurant("Nicole"));
            tomato.Attach(new Restaurant("Victoria"));

            cucumber.price = 02.25;
            cucumber.price = 02.15;
            cucumber.price = 02.20;

            cabbage.price = 01.10;
            cabbage.price = 01.15;
            cabbage.price = 01.10;

            cucumber.price = 02.10;
            cucumber.price = 02.25;
            cucumber.price = 02.20;

            Console.ReadKey();
        }
    }
}
