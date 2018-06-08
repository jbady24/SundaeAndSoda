using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredsIceCreamShop
{
    public class NameMissing : ApplicationException
    {
        private static string msg = "Name is required";

        public NameMissing() : base(msg)
        {

        }
    }
}
