using RPSLS.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private static Round _round = new Round();
        private static Scoresystem _score = new Scoresystem();

        internal static Round Round { get => _round; set => _round = value; }
        internal static Scoresystem Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }

        enum Players : int
        {
            First = 1,Second = 2
        };
        public MainWindow()
        {
            InitializeComponent();

            player1Points.SetBinding(ContentProperty, new Binding("player1Points"));
            player2Points.SetBinding(ContentProperty, new Binding("player2Points"));

            Binding b = new Binding("player1Points");
            b.Mode = BindingMode.OneWay;
            b.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            Binding b1 = new Binding("player2Points");
            b.Mode = BindingMode.OneWay;
            b.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;

            player1Points.SetBinding(Label.ContentProperty, b);
            player2Points.SetBinding(Label.ContentProperty, b1);

            DataContext = this;
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
            if(Round.RoundIsOver)
            {
                switch(Round.FirstPlayerWon)
                {
                    case true:
                        player1Side.Source = new BitmapImage(new Uri("Resources/winner.png", UriKind.Relative));
                        Score.GivePoint((int)Players.First);
                        break;
                    case false:
                        if(Round.RoundDrawn)
                        {
                            draw.Source = new BitmapImage(new Uri("Resources/winner.png", UriKind.Relative));
                            Score.GivePoint((int)Players.Second);
                            break;
                        }
                        player2Side.Source = new BitmapImage(new Uri("Resources/winner.png", UriKind.Relative));
                        break;
                }

            }
            MessageBox.Show($"First player score {Score.Player1Points}\n" +
                $"Second player score {Score.Player2Points}");

        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            System.Threading.Interlocked.CompareExchange(ref PropertyChanged, null, null)?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}
