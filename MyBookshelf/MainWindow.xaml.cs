using MyBookshelfData;
using Newtonsoft.Json;
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

namespace MyBookshelf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Context context = new Context();
            //var books = context.Books.Include("Readers").ToList();

            //foreach (var book in books)
            //{
            //    var jsonBook = JsonConvert.SerializeObject(book);
            //    MessageBox.Show(jsonBook);
            //}
        }
    }
}
