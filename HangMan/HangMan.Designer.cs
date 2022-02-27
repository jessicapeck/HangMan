
namespace HangMan
{
    partial class HangMan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HangMan));
            this.frame = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.body = new System.Windows.Forms.PictureBox();
            this.left_arm = new System.Windows.Forms.PictureBox();
            this.left_leg = new System.Windows.Forms.PictureBox();
            this.right_arm = new System.Windows.Forms.PictureBox();
            this.right_leg = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.letter_gaps_label = new System.Windows.Forms.Label();
            this.letter_textbox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.guess_letter_message_label = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.guessed_letters_label = new System.Windows.Forms.Label();
            this.game_over = new System.Windows.Forms.Label();
            this.play_again_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_arm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_leg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_arm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_leg)).BeginInit();
            this.SuspendLayout();
            // 
            // frame
            // 
            this.frame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.frame.Image = ((System.Drawing.Image)(resources.GetObject("frame.Image")));
            this.frame.Location = new System.Drawing.Point(397, 304);
            this.frame.Name = "frame";
            this.frame.Size = new System.Drawing.Size(310, 304);
            this.frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frame.TabIndex = 0;
            this.frame.TabStop = false;
            // 
            // head
            // 
            this.head.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.head.Image = ((System.Drawing.Image)(resources.GetObject("head.Image")));
            this.head.Location = new System.Drawing.Point(554, 386);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(63, 50);
            this.head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            // 
            // body
            // 
            this.body.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.body.Image = ((System.Drawing.Image)(resources.GetObject("body.Image")));
            this.body.Location = new System.Drawing.Point(581, 434);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(10, 50);
            this.body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.body.TabIndex = 2;
            this.body.TabStop = false;
            // 
            // left_arm
            // 
            this.left_arm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.left_arm.Image = ((System.Drawing.Image)(resources.GetObject("left_arm.Image")));
            this.left_arm.Location = new System.Drawing.Point(566, 443);
            this.left_arm.Name = "left_arm";
            this.left_arm.Size = new System.Drawing.Size(18, 32);
            this.left_arm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_arm.TabIndex = 3;
            this.left_arm.TabStop = false;
            // 
            // left_leg
            // 
            this.left_leg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.left_leg.Image = ((System.Drawing.Image)(resources.GetObject("left_leg.Image")));
            this.left_leg.Location = new System.Drawing.Point(566, 478);
            this.left_leg.Name = "left_leg";
            this.left_leg.Size = new System.Drawing.Size(18, 32);
            this.left_leg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_leg.TabIndex = 4;
            this.left_leg.TabStop = false;
            // 
            // right_arm
            // 
            this.right_arm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.right_arm.Image = ((System.Drawing.Image)(resources.GetObject("right_arm.Image")));
            this.right_arm.Location = new System.Drawing.Point(587, 440);
            this.right_arm.Name = "right_arm";
            this.right_arm.Size = new System.Drawing.Size(17, 37);
            this.right_arm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_arm.TabIndex = 5;
            this.right_arm.TabStop = false;
            // 
            // right_leg
            // 
            this.right_leg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.right_leg.Image = ((System.Drawing.Image)(resources.GetObject("right_leg.Image")));
            this.right_leg.Location = new System.Drawing.Point(586, 480);
            this.right_leg.Name = "right_leg";
            this.right_leg.Size = new System.Drawing.Size(17, 28);
            this.right_leg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_leg.TabIndex = 6;
            this.right_leg.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Myanmar Text", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.welcome_label.Location = new System.Drawing.Point(86, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(560, 85);
            this.welcome_label.TabIndex = 7;
            this.welcome_label.Text = "Welcome to HangMan!";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // letter_gaps_label
            // 
            this.letter_gaps_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.letter_gaps_label.AutoSize = true;
            this.letter_gaps_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letter_gaps_label.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.letter_gaps_label.Location = new System.Drawing.Point(30, 116);
            this.letter_gaps_label.Name = "letter_gaps_label";
            this.letter_gaps_label.Size = new System.Drawing.Size(109, 46);
            this.letter_gaps_label.TabIndex = 8;
            this.letter_gaps_label.Text = "error";
            this.letter_gaps_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letter_textbox
            // 
            this.letter_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.letter_textbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.letter_textbox.Location = new System.Drawing.Point(251, 207);
            this.letter_textbox.Name = "letter_textbox";
            this.letter_textbox.Size = new System.Drawing.Size(100, 26);
            this.letter_textbox.TabIndex = 9;
            this.letter_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letter_textbox.Click += new System.EventHandler(this.letter_textbox_Click);
            // 
            // submit_button
            // 
            this.submit_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.submit_button.BackColor = System.Drawing.Color.CornflowerBlue;
            this.submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.Location = new System.Drawing.Point(357, 200);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(96, 41);
            this.submit_button.TabIndex = 10;
            this.submit_button.Text = "submit";
            this.submit_button.UseVisualStyleBackColor = false;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // guess_letter_message_label
            // 
            this.guess_letter_message_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guess_letter_message_label.AutoSize = true;
            this.guess_letter_message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_letter_message_label.Location = new System.Drawing.Point(32, 203);
            this.guess_letter_message_label.Name = "guess_letter_message_label";
            this.guess_letter_message_label.Size = new System.Drawing.Size(213, 32);
            this.guess_letter_message_label.TabIndex = 11;
            this.guess_letter_message_label.Text = "Guess a letter : ";
            // 
            // error_label
            // 
            this.error_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Crimson;
            this.error_label.Location = new System.Drawing.Point(33, 253);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(65, 29);
            this.error_label.TabIndex = 12;
            this.error_label.Text = "error";
            // 
            // guessed_letters_label
            // 
            this.guessed_letters_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guessed_letters_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guessed_letters_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessed_letters_label.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guessed_letters_label.Location = new System.Drawing.Point(38, 304);
            this.guessed_letters_label.MaximumSize = new System.Drawing.Size(500, 500);
            this.guessed_letters_label.MinimumSize = new System.Drawing.Size(250, 250);
            this.guessed_letters_label.Name = "guessed_letters_label";
            this.guessed_letters_label.Size = new System.Drawing.Size(313, 304);
            this.guessed_letters_label.TabIndex = 13;
            this.guessed_letters_label.Text = "Guessed letters : ";
            // 
            // game_over
            // 
            this.game_over.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.game_over.AutoSize = true;
            this.game_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over.ForeColor = System.Drawing.Color.Red;
            this.game_over.Location = new System.Drawing.Point(401, 264);
            this.game_over.Name = "game_over";
            this.game_over.Size = new System.Drawing.Size(306, 37);
            this.game_over.TabIndex = 14;
            this.game_over.Text = "Oh no! Game over.";
            // 
            // play_again_button
            // 
            this.play_again_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_again_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.play_again_button.Location = new System.Drawing.Point(493, 189);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(153, 59);
            this.play_again_button.TabIndex = 15;
            this.play_again_button.Text = "Play again";
            this.play_again_button.UseVisualStyleBackColor = true;
            this.play_again_button.Click += new System.EventHandler(this.play_again_button_Click);
            // 
            // HangMan
            // 
            this.AcceptButton = this.submit_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 630);
            this.Controls.Add(this.play_again_button);
            this.Controls.Add(this.game_over);
            this.Controls.Add(this.guessed_letters_label);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.guess_letter_message_label);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.letter_textbox);
            this.Controls.Add(this.letter_gaps_label);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.right_leg);
            this.Controls.Add(this.right_arm);
            this.Controls.Add(this.left_leg);
            this.Controls.Add(this.left_arm);
            this.Controls.Add(this.body);
            this.Controls.Add(this.head);
            this.Controls.Add(this.frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HangMan";
            this.Text = "HangMan";
            ((System.ComponentModel.ISupportInitialize)(this.frame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_arm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left_leg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_arm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_leg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox frame;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.PictureBox body;
        private System.Windows.Forms.PictureBox left_arm;
        private System.Windows.Forms.PictureBox left_leg;
        private System.Windows.Forms.PictureBox right_arm;
        private System.Windows.Forms.PictureBox right_leg;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label letter_gaps_label;
        private System.Windows.Forms.TextBox letter_textbox;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Label guess_letter_message_label;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label guessed_letters_label;
        private System.Windows.Forms.Label game_over;
        private System.Windows.Forms.Button play_again_button;
    }
}

