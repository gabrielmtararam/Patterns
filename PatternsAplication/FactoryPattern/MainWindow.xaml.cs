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

namespace FactoryPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IEletronic eletronic = EletronicFactory.LoadEletronic();
            Console.WriteLine($"eletronic toString {eletronic.CustomToString()}");
        }

        private void OnCreateNewEletronic(object sender, RoutedEventArgs e)
        {
            IEletronic eletronic = EletronicFactory.LoadEletronic();
            //Console.WriteLine($"eletronic toString {eletronic.CustomToString()}");
            MyListBox.Items.Add(eletronic.CustomToString());
        }
    }
}
