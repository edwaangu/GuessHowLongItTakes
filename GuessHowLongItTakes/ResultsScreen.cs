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
    public partial class ResultsScreen : UserControl
    {
        public ResultsScreen()
        {
            InitializeComponent();
        }

        private void ResultsScreen_Load(object sender, EventArgs e)
        {
            playerWinsLabel.Text = $"Player {Form1.winner + 1} Wins!";
            infoLabel.Text = $"Their guess '{Form1.playerNumbers[Form1.winner]}' took '{Form1.computerGuesses.Count}' tries.";
        }
    }
}
