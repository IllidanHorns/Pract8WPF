using Pract5WPF.Model;
using Pract5WPF.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Pract5WPF.ViewModel
{
    class Slot2ViewModel : BindingHelper
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

        private int number_user;
        public int Number_user
        {
            get
            {
                return number_user;
            }
            set
            {
                number_user = value;
                OnPropertyChanged();
            }
        }

        private int number_random;
        public int Number_random
        {
            get
            {
                return number_random;
            }
            set
            {
                number_random = value;
                OnPropertyChanged();
            }
        }

        Rate rate_slot2 = new Rate();
        RandomValues random_user = new RandomValues();

        public BindableCommand Result { get; set; }
        public BindableCommand Plus_rate_b { get; set; }
        public BindableCommand Minus_rate_b { get; set; }

        public Slot2ViewModel(string login)
        {
            Rate = rate_slot2.get_rate();
            Balancee = Check.Balance_action.get_balance(login);
            Result = new BindableCommand(_ => result());
            Plus_rate_b = new BindableCommand(_ => plus_rate());
            Minus_rate_b = new BindableCommand(_ => minus_rate());
            this.login = login;
        }

        public void minus_rate()
        {
            rate_slot2.minus_rate();
            Rate = rate_slot2.get_rate();
        }

        public void plus_rate()
        {
            rate_slot2.plus_rate();
            Rate = rate_slot2.get_rate();
        }

        public void result()
        {
            if (Balancee >= Rate)
            {
                if (Number_user < 11 && Number_user > 0)
                {
                    Check.Balance_action.balance_value(login, rate, "minus");
                    Balancee = Check.Balance_action.get_balance(login);
                    Number_random = random_user.return_random_number();
                    if (Number_random == Number_user)
                    {
                        Win = Rate * 10;
                        Check.Balance_action.balance_value(login, Win, "plus");
                    }
                    Balancee = Check.Balance_action.get_balance(login);
                }
                else
                {
                    MessageBox.Show("Число должно быть от 1 до 10!");
                }
            }
        }
    }
}
