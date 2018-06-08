using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class TooManyFlavors : ApplicationException
    {
        private static string msg = "Only 1 mixin allowed";

        public TooManyFlavors() : base(msg)
        {

        }
    }
}
