using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithym.Shared
{
    public static class Tools
    {
        public static int Log2n(int n)
        {
            return (n > 1) ? 1 + Log2n(n / 2) : 0;
        }

    }
}
