using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessHowLongItTakes
{
    public partial class LoadingScreen : UserControl
    {
        Random randGen = new Random();
        int computerGuess = 0;

        public LoadingScreen()
        {
            InitializeComponent();
        }
        
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            timerTick.Enabled = true;
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            computerGuess = randGen.Next(1, 101);
            while (Form1.computerGuesses.Contains(computerGuess))
            {
                computerGuess = randGen.Next(1, 101);
            }
            Form1.computerGuesses.Add(computerGuess);
            loadLabel.Text = $"{computerGuess}";

            for(int i = 0;i < Form1.playerNumbers.Count();i++)
            {
                if(computerGuess == Form1.playerNumbers[i])
                {
                    Form1.winner = i;

                    timerTick.Enabled = false;

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    ResultsScreen resultsScreen = new ResultsScreen();
                    f.Controls.Add(resultsScreen);
                }
            }
            this.Refresh();
        }
    }
}
