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

namespace v3_languageSchool
{
    /// <summary>
    /// Логика взаимодействия для WinClient.xaml
    /// </summary>
    public partial class WinClient : Window
    {
        public WinClient()
        {
            InitializeComponent();



            // подгружаем таблицу сс базы данных, с которой в дальнейшем будем работать 
            using (LanguageEntities db = new LanguageEntities())
            {



                // подгружаем табличку о клиентах 
                db.cIient.Load();


                FilterBox.ItemsSource = db.cIient.Local.ToBindingList();

                var query = from u in db.cIient
                            select new { u.IDClient, u.SecondName, u.FirstName, u.MiddleName, u.Gender, u.Phone, u.DateOfBirth, u.Email, u.DateOfRegistration };

                DataTable.ItemsSource = query.ToList();
                TableCount.Text = query.Count().ToString();



            }



        }
        // кнопка перехода в главное меню 
        private void AheadPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        // кнопка выхода с приложения
        private void ExitSys_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        // Производим сортировку по определенным критериям
        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            
            
            using (LanguageEntities db = new LanguageEntities())
            {
                
                try
                {
                    //сортировка 
                    switch (SortBox.Text)
                    {
                        case "Фамилия":
                            DataTable.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("SecondName", System.ComponentModel.ListSortDirection.Ascending));
                            DataTable.Items.Refresh();
                            break;

                        case "Дата посещения":
                            DataTable.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("DateOfRegistration", System.ComponentModel.ListSortDirection.Ascending));
                            DataTable.Items.Refresh();
                            break;

                        case "По дате рождения":
                            DataTable.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("DateOfBirth", System.ComponentModel.ListSortDirection.Descending));
                            DataTable.Items.Refresh();
                            
                            break;
                    }
                }
                catch { }

            }




          

        }

        //фильтрация по Gender
        private void EditString_Click(object sender, RoutedEventArgs e)
        {
            cIient selectGender = (cIient)FilterBox.SelectedItem;

            using (LanguageEntities db = new LanguageEntities())
            {
                try
                {
                    switch (selectGender.Gender)
                    {
                        case "м":
                            var queryMale = from u in db.cIient
                                            where (u.Gender.ToString() == selectGender.Gender)
                                            select new { u.IDClient, u.SecondName, u.FirstName, u.MiddleName, u.Gender };
                            DataTable.ItemsSource = queryMale.ToList();
                            TableCount.Text = queryMale.Count().ToString();
                            break;

                        case "ж":
                            var queryFemale = from u in db.cIient
                                              where (u.Gender.ToString() == selectGender.Gender)
                                              select new { u.IDClient, u.SecondName, u.FirstName, u.MiddleName, u.Gender };
                            DataTable.ItemsSource = queryFemale.ToList();
                            TableCount.Text = queryFemale.Count().ToString();
                            break;
                    }
                }
                catch { }

            }
        }
        

        //Поиск данных с базы, обновление происходит  сразу же 
        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            using (LanguageEntities db = new LanguageEntities())
            {
                var search = from u in db.cIient
                             where ((u.FirstName.Contains(SearchBox.Text) || (u.SecondName.Contains(SearchBox.Text)) || (u.MiddleName.Contains(SearchBox.Text) ||
                             (u.Phone.Contains(SearchBox.Text)) || (u.Email.Contains(SearchBox.Text)))))
                             select new { u.IDClient, u.SecondName, u.FirstName, u.MiddleName, u.Gender, u.Phone, u.DateOfBirth, u.Email, u.DateOfRegistration };

                DataTable.ItemsSource = search.ToList();


                TableCount.Text = search.Count().ToString();
            }
        }

        private void ButtonReset(object sender, RoutedEventArgs e)
        {
            using (LanguageEntities db = new LanguageEntities())
            {
                var search = from u in db.cIient
                             where ((u.FirstName.Contains(SearchBox.Text) || (u.SecondName.Contains(SearchBox.Text)) || (u.MiddleName.Contains(SearchBox.Text) ||
                             (u.Phone.Contains(SearchBox.Text)) || (u.Email.Contains(SearchBox.Text)))))
                             select new { u.IDClient, u.SecondName, u.FirstName, u.MiddleName, u.Gender, u.Phone, u.DateOfBirth, u.Email, u.DateOfRegistration };

                DataTable.ItemsSource = search.ToList();
                TableCount.Text = search.Count().ToString();
            }
        }
    }
}
