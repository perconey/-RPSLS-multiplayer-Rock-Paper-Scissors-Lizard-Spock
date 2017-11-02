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
namespace RPSLS.Logic
{
    class Scoresystem
    {
        private static int _player1Points;
        private static int _player2Points;

                
        public int Player2Points { get => _player2Points; set => _player2Points = value; }
        public int Player1Points { get => _player1Points; set => _player1Points = value; }

        public Scoresystem()
        {
            Player1Points = 0;
            Player2Points = 0;    
        }

        public void GivePoint(int playerNumber)
        {
            if(playerNumber == 1)
            {
                Player1Points++;
            }
            if(playerNumber == 2)
            {
                Player2Points++;
            }
        }
        public void Reset()
        {
            Player1Points = 0;
            Player2Points = 0;
        }

    }
}
