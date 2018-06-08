using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class Sundae
    {
        public const double BASE_PRICE = 4.50;
        public const double TOPPING_PRICE = .50;

        private SundaeTopping[] _toppings;

        private int _toppingCount;
        private double _price;

        public Sundae()
        {
            _price = BASE_PRICE;
            _toppingCount = 0;
            _toppings = new SundaeTopping[2];
        }

        public int ToppingCount
        {
            get { return _toppingCount; }
        }
        public double Price
        {
            get { return _price; }
        }

        public void AddTopping(SundaeTopping t)
        {
            if (_toppingCount >= 2)
            {
                throw new TooManyToppings();
            }
            _toppings[ToppingCount] = t;
            ++_toppingCount;
            _price += TOPPING_PRICE;
        }

        public override string ToString()
        {
            string toppings = "";

            for (int i = 0; i < _toppingCount; i++)
            {
                toppings += string.Format("{0} ", _toppings[i]);
            }

            if (toppings == "")
            {
                toppings = "NONE";
            }
            return String.Format("Sundae - {0} - {1:C}", toppings, _price);
        }
    }
}
