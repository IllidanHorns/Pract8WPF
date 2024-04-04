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
    /// Логика взаимодействия для Slot.xaml
    /// </summary>
    public partial class Slot : Window
    {
        string Login;

        public Slot(string login)
        {
            InitializeComponent();
            Login = login;
            DataContext = new SlotViewModel(login);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            GameChange slot1 = new GameChange(Login);
            slot1.Show();
            this.Close();
        }
    }
}
