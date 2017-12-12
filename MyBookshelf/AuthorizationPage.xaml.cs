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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        Repository repository = new Repository();

        public AuthorizationPage()
        {
            InitializeComponent();
            Context context = new Context();
            context.Books.ToList();
        }

        private void btn_signin_Click(object sender, RoutedEventArgs e)
        {
            if (repository.SignedIn(text_login.Text, password_box.Password))
            {
                MyBookshelfWindow myBookshelfWindow = new MyBookshelfWindow();
                myBookshelfWindow.Show();
            }
            else
            {
                MessageBox.Show("User with such login and password doesn't exist.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
