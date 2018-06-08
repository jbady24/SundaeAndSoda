using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class Order
    {
        private string _name;
        private Sundae _sundae;
        private Soda _soda;

        public Order(string name, bool sundae, bool soda)
        {

            if (String.IsNullOrWhiteSpace(name))
            {
                throw new NameMissing();
            }

            if (sundae == false && soda == false)
            {
                throw new NoFood();
            }

            _name = name;

            if (sundae)
            {
                _sundae = new Sundae();
            }

            if (soda)
            {
                _soda = new Soda();
            }
            
        }

        public string Name
        {
            get { return _name; }
        }
        public Sundae Sundae
        {
            get { return _sundae; }
        }
        public Soda Soda
        {
            get { return _soda; }
        }

        public double Price
        {
            get
            {
                double total = 0;

                if (_sundae != null)
                {
                    total += _sundae.Price;
                }
                if (_soda != null)
                {
                    total += _soda.Price;
                }
                return total;
            }
        }

        public override string ToString()
        {
            string order = _name + "\r\n-------------------\r\n";

            if (_sundae != null)
            {
                order += _sundae.ToString() + "\r\n";
            }
            if (_soda != null)
            {
                order += _soda.ToString() + "\r\n";
            }
            return order;
        }
    }
}
