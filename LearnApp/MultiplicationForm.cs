using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class MultiplicationForm : Form
    {
        private Random random = new Random();
        private int number1;
        private int number2;

        public MultiplicationForm()
        {
            InitializeComponent();
        }

        private void MultiplicationForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int answer;
            if (int.TryParse(txtAnswer.Text, out answer) && answer == number1 * number2)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Try again!");
            }

            GenerateNewQuestion();
            txtAnswer.Clear();
        }

        private void GenerateNewQuestion()
        {
            number1 = random.Next(1, 13); // Generates a number between 1 and 12
            number2 = random.Next(1, 13); // Generates a number between 1 and 12
            lblQuestion.Text = $"What is {number1} x {number2}?";
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}