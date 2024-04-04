using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pract5WPF.Model
{
    public class Rate
    {
        private int[] rates = [50, 100, 300, 500, 1000];

        private int rate_position = 0;


        public int get_rate()
        {
            return rates[rate_position];
        }

        public void plus_rate()
        {
            if (rate_position < rates.Count()-1)
            {
                rate_position++;
            }
        }

        public void minus_rate()
        {
            if (rate_position > 0)
            {
                rate_position--;
            }
        }
    }
}
