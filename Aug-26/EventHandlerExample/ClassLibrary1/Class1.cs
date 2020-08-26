using ClassLibrary1;
using System;

namespace Company
{
    //Publisher class
    public class Product
    {
        //private field
        private double _price;

        //auto-impl event
        public event EventHandler PriceChanged;

        //public property
        public double Price
        {
            set
            {
                this._price = value;
                PriceChanged(this, new MyEventArgs() { UpdatedPrice = this._price } ); //raise the event
            }
            get
            {
                return _price;
            }
        }
    }
}

