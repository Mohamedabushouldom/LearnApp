using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HebrewGame
{
    public partial class Hebrew : Form
    {
        public Hebrew()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string[] words = new[] { "Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape", "Honeydew", "Ivy", "Jackfruit" };
        static int index = 0;
        static int score = 0;
        Random random = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            index = 0;
            score = 0;
            label_result.Text = "Result";
            label_result.BackColor = Color.Peru;
            label_score.Text = "00";
            displaywors();
            button1_next.Enabled = true;
            button2_start.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkword();
            if (index < words.Length - 1)
            {
                index++;
                displaywors();
            }
        }

        public void displaywors()
        {
            int pos1 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);

            string word = words[index];
            word = word.Remove(pos1, 1).Insert(pos1, "_ ");
            word = word.Remove(pos2, 1).Insert(pos2, "_ ");
            word = word.Remove(pos3, 1).Insert(pos3, "_ ");

            label_word.Text = word;
        }

        public void checkword()
        {
            if (textBox1_Guess.Text.Equals(words[index], StringComparison.OrdinalIgnoreCase))
            {
                label_result.Text = "Correct";
                label_result.BackColor = Color.Green;
                score++;
            }
            else
            {
                label_result.Text = "Wrong";
                label_result.BackColor = Color.Red;
            }
            textBox1_Guess.Text = "";
            label_score.Text = $"{score} / {words.Length}";

            if (index == words.Length - 1)
            {
                button2_start.Enabled = true;
                button1_next.Enabled = false;
            }
        }

        private void label_word_Click(object sender, EventArgs e)
        {

        }

        private void button1_next_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button2_start_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void label_result_Click(object sender, EventArgs e)
        {

        }

        private void label_score_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Guess_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}