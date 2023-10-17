namespace ToyotaAbstractFactory 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            ToyotaFactory myToyota = new JapanFactory();
            var prius = myToyota.CreateModel();
            prius.Print();

            Console.WriteLine();
                
            myToyota = new EuropeFactory();  
            var corolla = myToyota.CreateModel();  
            corolla.Print();

            Console.ReadKey();
        } 
    }
}