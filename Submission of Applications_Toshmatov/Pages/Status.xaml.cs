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
using Microsoft.Win32;
namespace Submission_of_Applications_Toshmatov.Pages
{
    public partial class Status : Page
    {
        public Status()
        {
            InitializeComponent();
        }

        private void RbHaveMilitary_Checked(object sender, RoutedEventArgs e)
        {
            // Показываем блок загрузки файлов при выборе "имею"
            fileUploadPanel.Visibility = Visibility.Visible;
        }

        private void RbNoMilitary_Checked(object sender, RoutedEventArgs e)
        {
            // Скрываем блок загрузки файлов при выборе "не имею"
            fileUploadPanel.Visibility = Visibility.Collapsed;
        }

        private void BtnSelectMilitaryFiles_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                Multiselect = true,
                Title = "Выберите сканы документов"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                // Обработка выбранных файлов
                MessageBox.Show($"Выбрано файлов: {openFileDialog.FileNames.Length}", "Файлы выбраны");
                // Здесь можно добавить логику для отображения выбранных файлов
            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            // Проверка: если выбрано "имею", но файлы не загружены
            if (rbHaveMilitary.IsChecked == true && fileUploadPanel.Visibility == Visibility.Visible)
            {
                // Можно добавить проверку, что файлы действительно выбраны
                MessageBox.Show("Пожалуйста, прикрепите сканы документов", "Внимание");
                return;
            }

            // Переход на следующую страницу или сохранение данных
            MessageBox.Show("Данные статуса сохранены", "Успешно");
            // NavigationService?.Navigate(new NextPage());
        }
    }
}
