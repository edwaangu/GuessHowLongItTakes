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
    public partial class Form1 : Form
    {
        public static List<int> computerGuesses = new List<int>();
        public static int[] playerNumbers = {-1, -1, -1, -1};
        public static int winner = -1; //0, 1, 2, 3. P1, P2, P3, P4;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartScreen startScreen = new StartScreen();
            this.Controls.Add(startScreen);
        }
    }
}
