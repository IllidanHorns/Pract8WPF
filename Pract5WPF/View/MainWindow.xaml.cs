using Pract5WPF.View;
using Pract5WPF.ViewModel;
using Pract5WPF.ViewModel.Helpers;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pract5WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged, Check
    {
        private string loginn = "";
        public string Login
        {
            get { return loginn; }
            set
            {
                loginn = value;
                OnPropertyChanged();
            }
        }

        private string passwordd = "";
        public string Password
        {
            get { return passwordd; }
            set
            {
                passwordd = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            Registration restration_window = new Registration();

            restration_window.Show();
            this.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            if (Check.check_user(loginn, passwordd) == true)
            {
                GameChange change_game_window = new GameChange(loginn);
                change_game_window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные были введены неверно!");
            }
        }
    }
}