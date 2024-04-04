using Pract5WPF.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pract5WPF.ViewModel.Helpers
{
    internal interface Check : JsonSave
    {
        public static bool check_user(string login, string password)
        {
            List<UserClass> user_list = Deserialization<UserClass>();
            foreach (UserClass i in user_list)
            {
                if (i.Name == login && i.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool check_uniqueness(string login)
        {
            List<UserClass> user_list = Deserialization<UserClass>();
            foreach (UserClass i in user_list)
            {
                if (i.Name == login)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool check_null(string login, string password, double balance = 1)
        {
            if (login != null && password != null && balance != 0 && login != "" && password != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool check_volue(string login, string password, double balance)
        {
            if (login.Count() < 21 && password.Count() < 21 && balance < 1000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public class Balance_action
        {
            static List<UserClass> user_list = Deserialization<UserClass>();
            public static double get_balance(string login)
            {
                foreach (UserClass i in user_list)
                {
                    if (i.Name == login)
                    {
                        return i.Balance;
                    }
                }
                return 0;
            }

            public static void balance_value(string login, double value, string action)
            {
                for (int i =0; i < user_list.Count(); i++)
                {
                    if (user_list[i].Name == login)
                    {
                        if (action == "minus")
                        {
                               user_list[i].Balance -= value;
                               JsonSave.Serialization(user_list);
                        }
                        else if (action == "plus")
                        {
                            user_list[i].Balance += value;
                            JsonSave.Serialization(user_list);
                        }
                    }
                }
            }
        }
    }
}
