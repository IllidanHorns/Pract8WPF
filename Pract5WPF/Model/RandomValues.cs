using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Pract5WPF.Model
{
    class RandomValues 
    {
        string[] values = ["🥃", "🤠", "🐎", "💰", "⛏️"];

        Random rnd = new Random();

        string[] values_of_win = ["", "", ""]; 

        public List<string> return_3_value() 
        {
            string value1 = values[rnd.Next(0, values.Length)];
            string value2 = values[rnd.Next(0, values.Length)];
            string value3 = values[rnd.Next(0, values.Length)];
            List<string> values_3 = new List<string>();
            values_3.Add(value1);
            values_3.Add(value2);
            values_3.Add(value3);
            values_of_win[0] = value1;
            values_of_win[1] = value2;
            values_of_win[2] = value3;
            return values_3;
        }

        public double get_win(double stavka)
        {
            if (values_of_win[0] == "🥃" && values_of_win[1] == "🥃" && values_of_win[2] == "🥃")
            {
                return stavka * 1.5;
            }
            else if (values_of_win[0] == "\U0001f920" && values_of_win[1] == "\U0001f920" && values_of_win[2] == "\U0001f920")
            {
                return stavka * 3;
            }
            else if (values_of_win[0] == "🐎" && values_of_win[1] == "🐎" && values_of_win[2] == "🐎")
            {
                return stavka * 8;
            }

            else if (values_of_win[0] == "💰" && values_of_win[1] == "💰" && values_of_win[2] == "💰")
            {
                return stavka * 100;
            }
            else if (values_of_win[0] == "⛏️" && values_of_win[1] == "⛏️" && values_of_win[2] == "⛏️")
            {
                return stavka * 20;
            }
            else
            {
                return 0;
            }
        }

        public string[] return_main_values()
        {
            return values;
        }

        public int return_random_number()
        {
            return rnd.Next(1, 11);
        }
    }
}