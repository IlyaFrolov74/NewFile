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
    /// Логика взаимодействия для WinAddDataBase.xaml
    /// </summary>
    public partial class WinAddDataBase : Window
    {
        public WinAddDataBase()
        {
            InitializeComponent();
        }


        //Элементы для работы с данными о дате
        private void DateAdd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePicker = new DatePicker();
            datePicker.SelectedDate = new DateTime(2020, 3, 23);
            datePicker.DisplayDateStart = new DateTime(2009, 1, 1);
            datePicker.DisplayDateEnd = new DateTime(2020, 12, 31);
            datePicker.SelectedDateFormat = DatePickerFormat.Long;
            datePicker.FirstDayOfWeek = DayOfWeek.Monday;
        }


        // Кнопка по добавлению данных
        private void AddingDataButton(object sender, RoutedEventArgs e)
        {
            // Если все ячейки пустые, то просим пользователя добавить в них данные
            if (SecondName.Text == "" ||
             NameAdd.Text == "" ||
             MiddleNameAdd.Text == "" ||
             GenderAdd.Text == "" ||
             PhoneAdd.Text == "" ||
             EmailAdd.Text == "" ||
              DateAdd.Text == "")

            {
                MessageBox.Show("пожалуйста заполните каждое поле");
            }


            // Если ячейки не пустые то производим сохранение введенных данных
            else
            {
                LanguageEntities db = new LanguageEntities();
                db.cIient.Load();


                // Обозначим рандом, в дальнейшем сгенерированное число здесь будет  использовано как ID
                Random rnd = new Random();
                int RandomID = rnd.Next();

                // Первоначальное ID, которое в дальнейшем заменим на случайное число 
                int newIDAdd = 102;

                var ID_NEW = db.cIient.Where(u => u.IDClient == newIDAdd).FirstOrDefault();

                //Если ячейки не пустые
                if (SecondName.Text != "" ||
              NameAdd.Text != "" ||
              MiddleNameAdd.Text != "" ||
              GenderAdd.Text != "" ||
              PhoneAdd.Text != "" ||
              EmailAdd.Text != "" ||
               DateAdd.Text != "")

                {
                    // сохраняем полученные данные
                    string newSecondName = SecondName.Text;
                    string newNameAdd = NameAdd.Text;
                    string newMiddleNameAdd = MiddleNameAdd.Text;
                    string newGenderAdd = GenderAdd.Text;
                    string newPhoneAdd = PhoneAdd.Text;
                    string newEmailAdd = EmailAdd.Text;
                    DateTime newDate = Convert.ToDateTime(DateAdd.Text);

                    // передаем полученные данные в базу данных
                    ID_NEW = new cIient();
                    ID_NEW.SecondName = newSecondName;
                    ID_NEW.FirstName = newNameAdd;
                    ID_NEW.MiddleName = newMiddleNameAdd;
                    ID_NEW.Gender = newGenderAdd;
                    ID_NEW.Phone = newPhoneAdd;
                    ID_NEW.Email = newEmailAdd;
                    ID_NEW.IDClient = RandomID;
                    ID_NEW.DateOfBirth = newDate;
                    db.cIient.Add(ID_NEW);

                    //Производим сохранение данных
                    db.SaveChanges();

                    //выводим сообщение, что все прошло успешно
                    MessageBox.Show("Данные успешно добавлены");


                }


            }

        }

        //Чтоб пользователь вводил только цифры
        private void PhoneAdd_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        // переход в главное меню 
        private void MainWin(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void SecondName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SecondName.Clear();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void NameAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NameAdd.Clear();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void MiddleNameAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MiddleNameAdd.Clear();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void PhoneAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PhoneAdd.Clear();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void EmailAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EmailAdd.Clear();
        }

        //Производим очищение  первоначальных данных при нажатии 2 раза ЛКМ 
        private void GenderAdd_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            GenderAdd.Clear();
        }
    }
}
