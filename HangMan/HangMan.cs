﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class HangMan : Form
    {

        List<string> words = new List<string>() { "butterfly", "cat", "octopus" };
        List<string> all_letters = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
        List<string> all_guessed_letters = new List<string>() { };

        string current_word;
        string letter_gaps;
        int lives_remaining = 6;


        public HangMan()
        {
            InitializeComponent();

            initial_UI_setup();

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

            // enabled set up
            letter_textbox.Enabled = true;
            submit_button.Enabled = true;
            

        }

        private void generate_random_word()
        {
            int num_words = words.Count;

            Random random = new Random();
            int num = random.Next(0, num_words);

            current_word = words[num];

            letter_gaps = string.Concat(Enumerable.Repeat("_ ", current_word.Length));

            letter_gaps_label.Text = "Here is the word : " + letter_gaps;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string guess = letter_textbox.Text;
            guess = guess.ToLower();


            if (guess.Length != 1) {
                error_label.Text = "Please only enter one character.";
                error_label.Visible = true;
            }
            else if (!(all_letters.Contains(guess))){
                error_label.Text = "Please make sure that you are entering a letter.";
                error_label.Visible = true;
            }
            else if (all_guessed_letters.Contains(guess)) {
                error_label.Text = "You have already guessed that letter.";
                error_label.Visible = true;
            }
            else {
                error_label.Visible = false;
                all_guessed_letters.Add(guess);

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

            letter_gaps_label.Text = "Here is the word : " + letter_gaps;

            if (word_complete)
            {
                letter_textbox.Enabled = false;
                submit_button.Enabled = false;

                letter_gaps_label.ForeColor = Color.Green;
                letter_gaps_label.Text = "Here is the word : " + current_word;

            }

        }

        private void update_lives_remaining(string guess)
        {
            if (!(current_word.Contains(guess)))
            {
                lives_remaining -= 1;
                update_hangman_pic();
            }

            if (lives_remaining == 0)
            {
                letter_textbox.Enabled = false;
                submit_button.Enabled = false;
                game_over.Visible = true;

                letter_gaps_label.ForeColor = Color.Red;
                letter_gaps_label.Text = "Here is the word : " + current_word;

            }
        }

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

        private void letter_textbox_Click(object sender, EventArgs e)
        {
            letter_textbox.Text = "";
        }
    }
}