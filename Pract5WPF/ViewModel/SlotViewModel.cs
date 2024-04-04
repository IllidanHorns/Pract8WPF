using Accessibility;
using Microsoft.Win32.SafeHandles;
using Pract5WPF.Model;
using Pract5WPF.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Media3D;
using System.Xml.Serialization;

namespace Pract5WPF.ViewModel
{
    public class SlotViewModel : BindingHelper
    {
        private string login;

        private double balancee;
        public double Balancee
        {
            get
            {
                return balancee;
            }
            set
            {
                balancee = value;
                OnPropertyChanged();
            }
        }

        private int rate;
        public int Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
                OnPropertyChanged();
            }
        }

        private string value1;
        public string Value1
        {
            get
            {
                return value1;
            }
            set
            {
                value1 = value;
                OnPropertyChanged();
            }
        }

        private string value2;
        public string Value2
        {
            get
            {
                return value2;
            }
            set
            {
                value2 = value;
                OnPropertyChanged();
            }
        }

        private string value3;
        public string Value3
        {
            get
            {
                return value3;
            }
            set
            {
                value3 = value;
                OnPropertyChanged();
            }
        }

        private double win;
        public double Win
        {
            get
            {
                return win;
            }
            set
            {
                win = value;
                OnPropertyChanged();
            }
        }


        Rate rate_slot1 = new Rate();

        RandomValues random_values = new RandomValues();

        public BindableCommand Spin { get; set; }
        public BindableCommand Plus_rate_b { get; set; }
        public BindableCommand Minus_rate_b { get; set; }


        public SlotViewModel(string login)
        {
            Spin = new BindableCommand(_ => spin());
            Plus_rate_b = new BindableCommand(_ => plus_rate());
            Minus_rate_b = new BindableCommand(_ => minus_rate());
            this.login = login;
            Balancee = Check.Balance_action.get_balance(login);
            Rate = rate_slot1.get_rate();
            Value1 = random_values.return_3_value()[0];
            Value2 = random_values.return_3_value()[1];
            Value3 = random_values.return_3_value()[2];
        }

        public void minus_rate()
        {
            rate_slot1.minus_rate();
            Rate = rate_slot1.get_rate();
        }

        public void plus_rate()
        {
            rate_slot1.plus_rate();
            Rate = rate_slot1.get_rate();
        }

        public void spin()
        {
            if (Balancee >= Rate)
            {
                Check.Balance_action.balance_value(login, rate, "minus");
                Balancee = Check.Balance_action.get_balance(login);
                Random rnd = new Random();
                List<string> values_of_squres = new List<string>();
                values_of_squres = random_values.return_3_value();
                Win = random_values.get_win(rate);
                Value1 = values_of_squres[0];
                Value2 = values_of_squres[1];
                Value3 = values_of_squres[2];
                if (Win > 0)
                {
                    Check.Balance_action.balance_value(login, Win, "plus");
                }
                Balancee = Check.Balance_action.get_balance(login);
            }
        }
    }
}
