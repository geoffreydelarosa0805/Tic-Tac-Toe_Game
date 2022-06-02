namespace Tic_Tac_Toe_Game
{
    public partial class Form1 : Form
    {
        bool turn = true; //true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("It is a game in which two players seek in alternate turns to complete a row, a column, or a diagonal with either three O's or three X's drawn in the spaces of a grid of nine squares.", "Tic Tac Toe Game");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void continueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            continueToolStripMenuItem.Select();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "O";
            else
                b.Text = "X";

            turn = !turn;
            b.Enabled = false;
            turn_count++;

            checkforWinner();
        }

        private void checkforWinner()
        {
            bool there_is_a_winner = false;

            //horizontal checks
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled))
                there_is_a_winner = true;

            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled))
                there_is_a_winner = true;

            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled))
                there_is_a_winner = true;


            //vertical checks
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled))
                there_is_a_winner = true;

            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled))
                there_is_a_winner = true;

            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled))
                there_is_a_winner = true;


            //diagonal checks
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled))
                there_is_a_winner = true;

            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled))
                there_is_a_winner = true;


            if (there_is_a_winner)
            {
                disabledButtons();

                string winner = "";
                if (turn)
                    winner = "Player X";
                else
                    winner = "Player O";

                MessageBox.Show(winner + " Wins", "Congratulations!");
            } //end if
            else
            {
                if (turn_count == 9)
                    MessageBox.Show(" It's A Draw! Try Another Round.", "WOW! What A Match!");
            }
        }//end checkForWinner

        private void disabledButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                } //end foreach
            }
            catch 
            {
            
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_count = 0;

            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                } //end foreach
            }//end try
            catch 
            { 
            
            }
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "O";
                else b.Text = "X";
            }//end if
            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                 b.Text = "";
            }//end if
        }
    }
}