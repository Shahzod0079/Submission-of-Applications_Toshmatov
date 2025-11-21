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
            fileUploadPanel.Visibility = Visibility.Visible;
        }

        private void RbNoMilitary_Checked(object sender, RoutedEventArgs e)
        {
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
                MessageBox.Show($"Выбрано файлов: {openFileDialog.FileNames.Length}", "Файлы выбраны");
            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if (rbHaveMilitary.IsChecked == true && fileUploadPanel.Visibility == Visibility.Visible)
            {
                MessageBox.Show("Пожалуйста, прикрепите сканы документов", "Внимание");
                return;
            }

            MessageBox.Show("Данные статуса сохранены", "Успешно");

            NavigationService?.Navigate(new Speciality());
        }
    }
}
