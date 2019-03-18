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

namespace polymorphismExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddingHelper ah = new AddingHelper();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExample1_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content =  ah.Add(1, 2).ToString();
        }

        private void btnExample2_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = ah.Add(1, 2, 3).ToString();
        }

        private void btnExample3_Click(object sender, RoutedEventArgs e)
        {
            int[] mynumbers = { 1, 2, 3, 4, 5, 6 };
            lblOutput.Content = ah.Add(mynumbers).ToString();
        }
    }
}
