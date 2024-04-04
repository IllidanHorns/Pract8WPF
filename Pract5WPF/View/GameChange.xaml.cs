using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для GameChange.xaml
    /// </summary>
    public partial class GameChange : Window
    {
        public string Login { get; set; }

        public GameChange(string login)
        {
            InitializeComponent();
            DataContext = this;
            Login = login;
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main_window = new MainWindow();  
            main_window.Show();
            this.Close();
        }

        private void first_game_button_Click(object sender, RoutedEventArgs e)
        {
            Slot slot_1 = new Slot(Login);
            slot_1.Show();
            this.Close();
        }

        private void second_game_button_Click(object sender, RoutedEventArgs e)
        {
            Slot2 slot_2 = new Slot2(Login);
            slot_2.Show();
            this.Close();
        }
    }
}
