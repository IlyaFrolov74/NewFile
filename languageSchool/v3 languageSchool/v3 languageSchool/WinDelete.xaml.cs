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
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace v3_languageSchool
{
    /// <summary>
    /// Логика взаимодействия для WinDelete.xaml
    /// </summary>
    public partial class WinDelete : Window
    {
        public WinDelete()
        {
            InitializeComponent();
        }

        private void DelButtonClick(object sender, RoutedEventArgs e)
        {
            if( PhoneDel.Text == "" )

            {
                MessageBox.Show("Заполните пожалуйста все поля!");
            }

            else
            {
                string PhoneNew = Convert.ToString(PhoneDel.Text);

                LanguageEntities db = new LanguageEntities();

                db.cIient.Load();

                var delPhone = db.cIient.Where(u => u.Phone == PhoneNew).FirstOrDefault();

                if (delPhone == null)
                {
                    MessageBox.Show("Данные с таким номером не существуют.");
                }
                else
                {
                    db.cIient.Remove(delPhone);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены");
                }

            }


        }

     

        private void PhoneDel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PhoneDel.Clear();
        }

        private void PhoneDel_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        

        private void MainWin_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
