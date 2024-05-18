using Pract5WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pract5WPF.View
{
    /// <summary>
    /// Логика взаимодействия для Slot2.xaml
    /// </summary>
    public partial class Slot2 : Window
    {
        string Login;
        public Slot2(string login)
        {
            Login = login;
            DataContext = new Slot2ViewModel(Login);
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            GameChange game_change_window = new GameChange(Login);
            game_change_window.Show();
            this.Close();
        }   
    }
}
