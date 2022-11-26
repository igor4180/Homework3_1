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

namespace Trenager2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string textForTask = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            speed.Text = "0";
            fails.Text = "0";
        }

        private void difficult_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelDifficult.Text = ((int)difficult.Value).ToString();
            taskText.Text = TextGenerator.GetTextByDiffLvl((int)difficult.Value);
        }

    }
}
