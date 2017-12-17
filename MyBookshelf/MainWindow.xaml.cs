using MyBookshelfData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

            Context context = new Context();
            //var books = context.UserBooks.Include("User_Id").Include("Book_Id").ToList();

            //FileStream fs = new FileStream(@"C:\Users\Влада\Desktop\MyBookshelf-master (1)\userbooks.json", FileMode.Create);
            //using (StreamWriter sw = new StreamWriter(fs))
            //{
            //    foreach (var book in books)
            //    {
            //        var jsonBook = JsonConvert.SerializeObject(book);
            //        sw.WriteLine(jsonBook);
            //    }
            //}
            context.UserBooks.Add(new ReadBook { User = new User { Id = 100, Login = "1", Birth = DateTime.Now, Name = "1", Password = "1" }, Book = new Book{ Author = "1", Genre = "1", Description = "1", ImagePath = "1", Title = "1" } });
            context.SaveChanges();
            context.Dispose();
        }
    }
}
