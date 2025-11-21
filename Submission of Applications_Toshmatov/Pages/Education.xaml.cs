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
    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void BtnSelectFiles_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|PDF files (*.pdf)|*.pdf|All files (*.*)|*.*",
                Multiselect = true
            };

            if (openFileDialog.ShowDialog() == true)
            {

                MessageBox.Show($"Выбрано файлов: {openFileDialog.FileNames.Length}", "Файлы выбраны");
            }
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {

            if (!rb9Class.IsChecked.Value && !rb11Class.IsChecked.Value && !rbSPO.IsChecked.Value && !rbVPO.IsChecked.Value)
            {
                MessageBox.Show("Выберите базу образования", "Ошибка");
                return;
            }

            if (!rbAttestat.IsChecked.Value && !rbDiplom.IsChecked.Value)
            {
                MessageBox.Show("Выберите тип документа", "Ошибка");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDocumentNumber.Text))
            {
                MessageBox.Show("Введите серию и номер документа", "Ошибка");
                return;
            }

            // Переход на следующую страницу
            NavigationService?.Navigate(new Statement());
        }
    }
}
