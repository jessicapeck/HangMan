using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HangMan
{
    public partial class HangMan : Form
    {

        // initialise variables
        List<string> words = new List<string>() { };
        List<string> all_letters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> all_guessed_letters;
        string current_word;
        string letter_gaps;
        int lives_remaining;


        public HangMan()
        {
            InitializeComponent();

            // run the start sequence to set up game
            start_sequence();

        }

        private void start_sequence()
        {
            // read all words from file into words list
            StreamReader sr = new StreamReader("C:\\Users\\jess\\OneDrive\\Documents\\Sixth Form\\Computer Science\\Paper2_Programming\\Hangman C#\\words_filtered.txt");
            string line = sr.ReadLine();

            while (line != null)
            {
                words.Add(line.TrimEnd(','));
                line = sr.ReadLine();
            }

            // assign starting value of 6 to lives_remaining variable
            lives_remaining = 6;

            // empty the all_guessed_letters list at the start of the game
            all_guessed_letters = new List<string>() { };

            // set up the UI
            initial_UI_setup();

            // generate the random word for this game
            generate_random_word();
        }

        private void initial_UI_setup()
        {
            // visibility setup
            welcome_label.Visible = true;
            letter_gaps_label.Visible = true;
            guess_letter_message_label.Visible = true;
            error_label.Visible = false;
            letter_textbox.Visible = true;
            submit_button.Visible = true;
            game_over.Visible = false;

            frame.Visible = true;
            head.Visible = false;
            body.Visible = false;
            left_arm.Visible = false;
            left_leg.Visible = false;
            right_arm.Visible = false;
            right_leg.Visible = false;

            // text setup
            letter_textbox.Text = "";
            guessed_letters_label.Text = "Guessed letters : ";

            // enabled set up
            letter_textbox.Enabled = true;
            submit_button.Enabled = true;
            play_again_button.Enabled = false;

            // colour setup
            letter_gaps_label.ForeColor = Color.Black;

        }

        private void generate_random_word()
        {
            // generate random number to be used as words list index
            int num_words = words.Count;

            Random random = new Random();
            int num = random.Next(0, num_words);

            // assign the current word to be guessed
            current_word = words[num];

            // create the letter gaps
            letter_gaps = string.Concat(Enumerable.Repeat("_ ", current_word.Length));

            // show the letter gaps
            letter_gaps_label.Text = "Here is the word : " + letter_gaps;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
           // take in user's guess input, covert to lower case
            string guess = letter_textbox.Text;
            guess = guess.ToLower();


            // length check
            if (guess.Length != 1) {
                error_label.Text = "Please only enter one character.";
                error_label.Visible = true;
            }
            // dictionary check (see if it is a letter)
            else if (!(all_letters.Contains(guess))){
                error_label.Text = "Please make sure that you are entering a letter.";
                error_label.Visible = true;
            }
            // check if user has already guessed that letter
            else if (all_guessed_letters.Contains(guess)) {
                error_label.Text = "You have already guessed that letter.";
                error_label.Visible = true;
            }
            // if the guess is valid...
            else {
                error_label.Visible = false;
                // add the guess to their list of guessed letters
                all_guessed_letters.Add(guess);

                // show user's guess in the guessed letters box
                if (all_guessed_letters.Count == 1)
                {
                    guessed_letters_label.Text = guessed_letters_label.Text + guess;
                }
                else
                {
                    guessed_letters_label.Text = guessed_letters_label.Text + ", " + guess;

                }

                update_letter_gaps();
                update_lives_remaining(guess);
            }

            letter_textbox.Text = "";

        }

        
        private void update_letter_gaps()
        {
            bool word_complete = true;

            string new_letter_gaps = "";

            // fill in letter gaps with correctly guessed letters
            for (var i = 0; i < current_word.Length; i++)
            {
                if (all_guessed_letters.Contains(current_word[i].ToString()))
                {
                    new_letter_gaps += current_word[i] + " ";
                }
                else
                {
                    word_complete = false;
                    new_letter_gaps += "_ ";
                }
            }

            letter_gaps = new_letter_gaps;

            // show updated letter gaps
            letter_gaps_label.Text = "Here is the word : " + letter_gaps;

            // check if the word is complete
            if (word_complete)
            {
                letter_textbox.Enabled = false;
                submit_button.Enabled = false;

                letter_gaps_label.ForeColor = Color.Green;
                letter_gaps_label.Text = "Here is the word : " + current_word;
                play_again_button.Enabled = true;

            }

        }

        private void update_lives_remaining(string guess)
        {
            // if the user's letter guess is not in the word...
            // ...decrement lives remaining by 1 and update the hangman picture
            if (!(current_word.Contains(guess)))
            {
                lives_remaining -= 1;
                update_hangman_pic();
            }

            // if user has no lives remaining, end game
            if (lives_remaining == 0)
            {
                letter_textbox.Enabled = false;
                submit_button.Enabled = false;
                game_over.Visible = true;

                letter_gaps_label.ForeColor = Color.Red;
                letter_gaps_label.Text = "Here is the word : " + current_word;
                play_again_button.Enabled = true;

            }
        }

        // instructions on how to update hangman picture based on lives remaining
        private void update_hangman_pic()
        {
            if (lives_remaining == 5)
            {
                head.Visible = true;
            }
            else if (lives_remaining == 4)
            {
                body.Visible = true;
            }
            else if (lives_remaining == 3)
            {
                left_arm.Visible = true;
            }
            else if (lives_remaining == 2)
            {
                right_arm.Visible = true;
            }
            else if (lives_remaining == 1)
            {
                left_leg.Visible = true;
            }
            else if (lives_remaining == 0)
            {
                right_leg.Visible = true;
            }
        }

        // on letter_textbox click, make its contents empty
        private void letter_textbox_Click(object sender, EventArgs e)
        {
            letter_textbox.Text = "";
        }

        // on play_again_button click, initiate the start sequence again
        private void play_again_button_Click(object sender, EventArgs e)
        {
            start_sequence();
        }
    }
}
