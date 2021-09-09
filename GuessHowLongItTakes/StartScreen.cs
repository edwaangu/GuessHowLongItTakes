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
    public partial class StartScreen : UserControl
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.playerNumbers[0] = Convert.ToInt32(player1Choice.Text);
                if((Form1.playerNumbers[0] < 1 || Form1.playerNumbers[0] > 100) && player1Choice.Text != "")
                {
                    errorLabel.Text = "Only 1-100!";
                    return;
                }
                if(player1Choice.Text == "")
                {
                    errorLabel.Text = "There must be a player 1";
                    return;
                }

                if(player2Choice.Text != "")
                {
                    Form1.playerNumbers[1] = Convert.ToInt32(player2Choice.Text);
                    if (Form1.playerNumbers[1] < 1 || Form1.playerNumbers[1] > 100)
                    {
                        errorLabel.Text = "Only 1-100!";
                        return;
                    }
                    if(Form1.playerNumbers[1] == Form1.playerNumbers[0])
                    {
                        errorLabel.Text = "You must have different guesses!";
                        return;
                    }
                }
                if (player3Choice.Text != "")
                {
                    Form1.playerNumbers[2] = Convert.ToInt32(player3Choice.Text);
                    if (Form1.playerNumbers[2] < 1 || Form1.playerNumbers[2] > 100)
                    {
                        errorLabel.Text = "Only 1-100!";
                        return;
                    }
                    if (Form1.playerNumbers[2] == Form1.playerNumbers[1] || Form1.playerNumbers[2] == Form1.playerNumbers[0])
                    {
                        errorLabel.Text = "You must have different guesses!";
                        return;
                    }
                }
                if (player4Choice.Text != "")
                {
                    Form1.playerNumbers[3] = Convert.ToInt32(player4Choice.Text);
                    if (Form1.playerNumbers[3] < 1 || Form1.playerNumbers[3] > 100)
                    {
                        errorLabel.Text = "Only 1-100!";
                        return;
                    }
                    if (Form1.playerNumbers[3] == Form1.playerNumbers[2] || Form1.playerNumbers[3] == Form1.playerNumbers[1] || Form1.playerNumbers[3] == Form1.playerNumbers[0])
                    {
                        errorLabel.Text = "You must have different guesses!";
                        return;
                    }
                }


                Form f = this.FindForm();
                f.Controls.Remove(this);

                LoadingScreen loadingScreen = new LoadingScreen();
                f.Controls.Add(loadingScreen);
            }
            catch
            {
                errorLabel.Text = "One of these choices are invalid!";
            }
        }
    }
}
