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

namespace Submission_of_Applications_Toshmatov
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            frame.Navigate(new Pages.Education());
        }

        public enum PageType
        {
            Education,
            Statement,
            Status,
   
        }

        public void OpenPages(PageType page)
        {
            switch (page)
            {
                case PageType.Education:
                    frame.Navigate(new Pages.Education());
                    break;
                case PageType.Statement:
                    frame.Navigate(new Pages.Statement());
                    break;
                case PageType.Status:
                    frame.Navigate(new Pages.Status());
                    break;
            }
        }
    }
}
