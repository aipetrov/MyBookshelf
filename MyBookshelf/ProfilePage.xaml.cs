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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        Repository repository = new Repository();

        public ProfilePage(Repository _repository)
        {
            InitializeComponent();
            repository = _repository;
            user_name.Text = "Hello, " + repository.AuthorisedUser.Name+ "!";
            listbox_read.ItemsSource = repository.GetReadBooks();
        }

        private void edit_profile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditingProfilePage(repository));
        }

        private void listbox_read_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            NavigationService.Navigate(new InformationAboutBooksPage(listbox_read.SelectedItem as Book, repository));
        }
    }
}
