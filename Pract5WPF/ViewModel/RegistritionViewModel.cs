using Pract5WPF.Model;
using Pract5WPF.View;
using Pract5WPF.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using JSON_CustomLibrary;
using BindLib;

namespace Pract5WPF.ViewModel
{
    public class RegistritionViewModel : BindingHelper, Check
    {
        #region "Свойства"
        private string login = "";
        public string Login
        {
            get { return login; }
            set
            {
                login = value;
                OnPropertyChanged();
            }
        }

        private string password = "";
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }

        private double balance = 0;
        public double Balance 
        {
            get { return balance; }
            set
            {
                balance = value;
                OnPropertyChanged();
            }
        }
        #endregion


        public BindableCommand RegistrationToCasic { get; set; }

        public RegistritionViewModel()
        {
            RegistrationToCasic = new BindableCommand(_ => registration_user());
        }

        private void registration_user()
        {
            if (Check.check_null(login, password, balance) == true)
            {
                if (Check.check_volue(login, password, balance) == true)
                {
                    if (Check.check_uniqueness(login) == true)
                    {
                        UserClass user = new UserClass(login, password, balance);
                        Json_save.Serialization(user);
                        MessageBox.Show("Пользователь успешно зарегестрирован!");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь с таким именем уже сущействует!");
                    }
                }
                else
                {
                    MessageBox.Show("Количество символов в полях логина и пароля не должно превышать 20 символов. Баланс на старте не может быть больше 9999999.");
                } 
            }
            else
            {
                MessageBox.Show("Значения полей не могут быть пустыми!");
            }
        }

    }
}
