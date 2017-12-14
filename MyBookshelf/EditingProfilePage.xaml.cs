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
    /// Логика взаимодействия для EditingProfilePage.xaml
    /// </summary>
    public partial class EditingProfilePage : Page
    {
        Repository repository = new Repository();
        public EditingProfilePage(Repository _repository)
        {
            InitializeComponent();
            repository = _repository;
            text_name.Text = repository.AuthorisedUser.Name;
            birth_date.SelectedDate = repository.AuthorisedUser.Birth;
        }

        private void save_profile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                repository.EditProfile(text_name.Text, password_box.Password, birth_date.SelectedDate.Value);
                NavigationService.Navigate(new ProfilePage(repository));
            }
            catch
            {
                MessageBox.Show("Fill in all gaps. If you want to change password, enter a new password, oherwise - an old one.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }
    }
}
