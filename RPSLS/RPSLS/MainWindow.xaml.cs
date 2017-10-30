using RPSLS.Logic;
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

namespace RPSLS
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Round round = new Round();

        internal static Round Round { get => round; set => round = value; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void instructionsButton_Click(object sender, RoutedEventArgs e)
        {
            var instructions = new Instructions();
            instructions.Show();
            instructions.Activate();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            Round.CheckKeyPresses(e);
        }
    }
}
