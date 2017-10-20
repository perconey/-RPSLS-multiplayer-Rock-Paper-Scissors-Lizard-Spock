using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RPSLS.Logic
{
    class Round
    {
        private char _choice1;
        private char _choice2;

        public char Choice1
        {
            get => _choice1;
            set
            {
                _choice1 = value;
                if(_choice2 != ' ')
                {
                    MessageBox.Show("Both chosen");

                }
            }
        }
        public char Choice2
        {
            get => _choice2;
            set
            {
                _choice2 = value;
                if (_choice2 != ' ')
                {
                    MessageBox.Show("Both chosen");
                }
            }
        }

        public Round()
        {
            Choice1 = ' ';
            Choice2 = ' ';
        }

        /*
        R  1     || R  0
        P  2     || P  9
        Sc 3     || Sc i
        L  e     || L  j
        Sp c     || Sp m   
        PLAYER 1 || PLAYER 2
        */
        public void CheckKeyPresses(KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                Choice1 = '1';
            }
            if (e.Key == Key.D2)
            {
                Choice1 = '2';
            }
            if (e.Key == Key.D3)
            {
                Choice1 = '3';
            }
            if (e.Key == Key.E)
            {
                Choice1 = 'e';
            }
            if (e.Key == Key.C)
            {
                Choice1 = 'c';
            }
            ////////////////////////////////////////////////
            if (e.Key == Key.D0)
            {
                Choice2 = '0';
            }
            if (e.Key == Key.D9)
            {
                Choice2 = '9';
            }
            if (e.Key == Key.I)
            {
                Choice2 = 'i';
            }
            if (e.Key == Key.J)
            {
                Choice2 = 'j';
            }
            if (e.Key == Key.M)
            {
                Choice2 = 'm';
            }
        }


    }
}
