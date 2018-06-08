using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class NoFood : ApplicationException
    {
        private static string msg = "No food selected!";

        public NoFood() : base(msg)
        {

        }
    }
}
