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

namespace battleshipw3
{
    /// <summary>
    /// Interaction logic for welcomePage.xaml
    /// </summary>
    public partial class welcomePage : Window
    {
        MainWindow mainWindow;
        public welcomePage()
        {
            InitializeComponent();
            mainWindow = new MainWindow();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ShowDialog();
        }
    }
}
