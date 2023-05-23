namespace TicTacToe
{
    public partial class fTicTacToe : Form
    {
        private bool xPlaying;
        private static int MAX_TURN = 9;
        private static int timesPlayed;
        public fTicTacToe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            xPlaying = true;
            timesPlayed = 0;
        }
        private void onFieldClicked(object sender, EventArgs e)
        {
            Button clickedButtonField = sender as Button;
            clickedButtonField.Text = this.xPlaying ? "X" : "O";
            clickedButtonField.Enabled = false;
            this.xPlaying = !this.xPlaying;
            timesPlayed++;
            string winCondition = string.Concat(clickedButtonField.Text, clickedButtonField.Text, clickedButtonField.Text); //XXX || OOO
            if (
                //Tres lineas Verticales
                string.Concat(b2x1.Text, b1x1.Text, b3x1.Text) == winCondition ||
                string.Concat(b2x2.Text, b1x2.Text, b3x2.Text) == winCondition ||
                string.Concat(b2x3.Text, b1x3.Text, b3x3.Text) == winCondition ||


                //Tres lineas Horizontales
                string.Concat(b1x2.Text, b1x1.Text, b1x3.Text) == winCondition ||
                string.Concat(b2x2.Text, b2x1.Text, b2x3.Text) == winCondition ||
                string.Concat(b3x2.Text, b3x1.Text, b3x3.Text) == winCondition ||

                //Lineas diagonales
                string.Concat(b1x1.Text, b2x2.Text, b3x3.Text) == winCondition ||
                string.Concat(b1x3.Text, b2x2.Text, b3x1.Text) == winCondition
                )
            {
                MessageBox.Show($"Player {clickedButtonField.Text} wins the game!!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bReset_Click(new object(), EventArgs.Empty);
            }
            else if (timesPlayed == MAX_TURN)
            {
                MessageBox.Show($"The game ended as tied!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bReset_Click(new object(), EventArgs.Empty);
            }


        }

        private void bReset_Click(object sender, EventArgs e)
        {
            foreach (Button button in pGame.Controls)
            {
                button.Enabled = true;
                button.Text = "";
            }
            this.xPlaying = true;
            timesPlayed = 0;
        }
    }
}