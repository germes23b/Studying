using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11Work
{
    struct Pryamaya
    {
        double k;
        double b;

        public Pryamaya(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0)
                return "Решений нет";
            else
                return string.Format("Решение : x={0}",-b / k);
        }
    }
}
