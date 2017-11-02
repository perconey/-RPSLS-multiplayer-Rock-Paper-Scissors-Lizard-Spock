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
        private String _player1Choice;
        private String _player2Choice;
        private bool _firstPlayerWon;
        private bool _roundDrawn;
        private bool _roundIsOver;

        public String Player1Choice
        {
            get => _player1Choice;
            set
            {
                _player1Choice = value;
                WhoWon();
            }
        }

        public String Player2Choice
        {
            get => _player2Choice;
            set
            {
                _player2Choice = value;
                WhoWon();
            }
        }

        public bool FirstPlayerWon
        {
            get => _firstPlayerWon;
            set
            {
                _firstPlayerWon = value;
            }
        }

        public bool RoundDrawn { get => _roundDrawn; set => _roundDrawn = value; }
        public bool RoundIsOver { get => _roundIsOver; set => _roundIsOver = value; }

        public Round()
        {
            Player1Choice = "nothing";
            Player2Choice = "nothing";
            RoundDrawn = false;
        }

        /*
        R  1     || R  0
        P  2     || P  9
        Sc 3     || Sc i
        L  e     || L  j
        Sp c     || Sp m   
        PLAYER 1 || PLAYER 2
        */

        /* Comparing table
         *  IF 1 - Rock
         *  Wins to: Scissors, Lizard
         *  Loses to: Paper, Spock
         *  
         *  IF 1 - Paper
         *  Wins to: Rock, Spock
         *  Loses to: Scissors, Lizard
         *  
         *  IF 1 - Scissors
         *  Wins to: Paper, Lizard
         *  Loses to: Spock, Rock
         *  
         *  IF 1 - Lizard
         *  Wins to: Paper, Spock
         *  Loses to: Rock, Scissors
         *  
         *  IF 1 - Spock
         *  Wins to: Scissors, Rock
         *  Loses to: Lizard, Paper
         */

        public void WhoWon()
        {
            if (Player2Choice != "nothing" && Player1Choice != "nothing")
            {

                switch (Player1Choice)
                {
                    case "Rock":
                        if (Player2Choice == "Rock")
                        {
                            FirstPlayerWon = false;
                            RoundDrawn = true;
                        }
                        if (Player2Choice == "Paper")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Scissors")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Lizard")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Spock")
                            FirstPlayerWon = false;
                        break;

                    case "Paper":
                        if (Player2Choice == "Rock")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Paper")
                        {
                            FirstPlayerWon = false;
                            RoundDrawn = true;
                        }
                        if (Player2Choice == "Scissors")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Lizard")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Spock")
                            FirstPlayerWon = true;
                        break;

                    case "Scissors":
                        if (Player2Choice == "Rock")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Paper")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Scissors")
                        {
                            FirstPlayerWon = false;
                            RoundDrawn = true;
                        }
                        if (Player2Choice == "Lizard")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Spock")
                            FirstPlayerWon = false;
                        break;

                    case "Lizard":
                        if (Player2Choice == "Rock")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Paper")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Scissors")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Lizard")
                        {
                            FirstPlayerWon = false;
                            RoundDrawn = true;
                        }
                        if (Player2Choice == "Spock")
                            FirstPlayerWon = true;
                        break;

                    case "Spock":
                        if (Player2Choice == "Rock")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Paper")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Scissors")
                            FirstPlayerWon = true;
                        if (Player2Choice == "Lizard")
                            FirstPlayerWon = false;
                        if (Player2Choice == "Spock")
                        {
                            FirstPlayerWon = false;
                            RoundDrawn = true;
                        }
                        break;
                }
                RoundIsOver = true;

            }

        }
        public void CheckKeyPresses(KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                Player1Choice = "Rock";
            }
            if (e.Key == Key.D2)
            {
                Player1Choice = "Paper";
            }
            if (e.Key == Key.D3)
            {
                Player1Choice = "Scissors";
            }
            if (e.Key == Key.E)
            {
                Player1Choice = "Lizard";
            }
            if (e.Key == Key.C)
            {
                Player1Choice = "Spock";
            }

            ////////////////////////////////////////////////
            if (e.Key == Key.D0)
            {
                Player2Choice = "Rock";
            }
            if (e.Key == Key.D9)
            {
                Player2Choice = "Paper";
            }
            if (e.Key == Key.I)
            {
                Player2Choice = "Scissors";
            }
            if (e.Key == Key.J)
            {
                Player2Choice = "Lizard";
            }
            if (e.Key == Key.M)
            {
                Player2Choice = "Spock";
            }
        }

        public void Reset()
        {
            Player1Choice = "nothing";
            Player2Choice = "nothing";
            FirstPlayerWon = false;
            RoundDrawn = false;
            RoundIsOver = false;
        }
        

    }
}
