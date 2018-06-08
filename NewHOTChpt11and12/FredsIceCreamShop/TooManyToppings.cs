using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class TooManyToppings : ApplicationException
    {
        private static string msg = "Only 2 toppings allowed";

        public TooManyToppings() : base(msg)
        {

        }
    }
}
