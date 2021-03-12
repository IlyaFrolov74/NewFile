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

namespace v3_languageSchool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        //Закрытие окна
        private void ButtonExit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Переход к клиентам
        private void ButtonClient(object sender, RoutedEventArgs e)
        {
            WinClient winClient = new WinClient();
            winClient.Show();
            Close();
        }

        //Переход к добавленю данных
        private void AddDataBase(object sender, RoutedEventArgs e)
        {
            WinAddDataBase addDataBase = new WinAddDataBase();
            addDataBase.Show();
            Close();
        }

        private void ButtonDelete(object sender, RoutedEventArgs e)
        {
            WinDelete winDelete = new WinDelete();
            winDelete.Show();
            Close();


        }
    }
}
