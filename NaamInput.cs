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

namespace speler_naam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int clickedtimes;

        private string name = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {
            name = MainTextBox.Text;


            NameLabel.Content = $"Hallo, {name.ToString()} welkom bij de Albert Heijn game";
        }
    }
}
