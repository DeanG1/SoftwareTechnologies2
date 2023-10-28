using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablePriceobserver
{
    class Restaurant: IRestaurant  // ConcreteRestaurant
    {
        private string _name;
        private Vegetable _vegetable;

        //Constructor
        public Restaurant(string name) 
        {
            this._name = name;
        }

        public void Update(Vegetable vegetable) 
        {
            Console.WriteLine("Notifies restaurant {0} that the price of " + "{1} is changed to {2} BGN", _name, vegetable.VegetableName, vegetable.price);


        }
        //Wzema  ili zadawa zelen4uka
        public Vegetable vegetable 
        {
            get { return _vegetable; }
            set { _vegetable = value; }
        }



    }
}
