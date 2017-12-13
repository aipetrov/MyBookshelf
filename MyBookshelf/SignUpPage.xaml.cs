using MyBookshelfData;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyBookshelf
{
    /// <summary>
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        Repository repository = new Repository();

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                repository.SignUp(text_login.Text, password_box.Password, text_name.Text, text_birth.SelectedDate.Value);
                MessageBox.Show("You are successfully registered.", "Success", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                NavigationService.Navigate(new AuthorizationPage());
            }
            catch
            {
                MessageBox.Show("Entered data is incorrect.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
