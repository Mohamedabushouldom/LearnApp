using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class CompleteSequencesForm : Form
    {
        private Random random = new Random();
        private int start, step, missing1, missing2;

        public CompleteSequencesForm()
        {
            InitializeComponent();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CompleteSequencesForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int number1, number2;
            bool isNumber1Valid = int.TryParse(txtNumber1.Text, out number1);
            bool isNumber2Valid = int.TryParse(txtNumber2.Text, out number2);

            if (isNumber1Valid && isNumber2Valid && number1 == missing1 && number2 == missing2)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Try again!");
            }

            GenerateNewQuestion();
            txtNumber1.Clear();
            txtNumber2.Clear();
        }

        private void GenerateNewQuestion()
        {
            start = random.Next(1, 10);
            step = random.Next(2, 5);
            missing1 = start + step * 2;
            missing2 = start + step * 3;
            lblInstruction.Text = $"Complete the sequence: {start}, {start + step}, _, _, {start + step * 4}";
        }
    }
}