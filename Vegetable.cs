using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetablePriceobserver
{
    abstract class Vegetable
    {
        private string _vegetableName;
        private double _price;
        private List<IRestaurant> _restaurants = new List<IRestaurant>();   

        //Constructor

        public Vegetable(string vegetableName, double price) 
        {
            this._vegetableName = vegetableName;
            this._price = price;
        }
        public void Attach(IRestaurant restaurant) 
        {
            _restaurants.Add(restaurant);   
        }
        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify() 
        {
            foreach (IRestaurant restaurant in _restaurants) 
            {
                restaurant.Update(this);
            }
            Console.WriteLine("");
        }
        public double price 
        {
            get { return _price; }
            set 
            {
                if (_price != value) 
                {
                    _price = value;
                    Notify();   
                }
            }

        }
        public string VegetableName
        {
            get { return _vegetableName; }
        }
    }
}
