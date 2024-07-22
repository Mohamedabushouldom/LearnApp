using System;
using System.Windows.Forms;

namespace MathGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



        }

        private void BtnGameA_Click(object sender, EventArgs e)
        {
            var form = new WriteNumbersInOrderForm();
            form.ShowDialog();
        }

        private void BtnGameB_Click(object sender, EventArgs e)
        {
            var form = new CompleteSequencesForm();
            form.ShowDialog();
        }

        private void BtnGameC_Click(object sender, EventArgs e)
        {
            var form = new AdditionForm();
            form.ShowDialog();
        }

        private void BtnGameD_Click(object sender, EventArgs e)
        {
            var form = new SubtractionForm();
            form.ShowDialog();
        }

        private void BtnGameE_Click(object sender, EventArgs e)
        {
            var form = new MultiplicationForm();
            form.ShowDialog();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.Color.FromArgb(78, 180, 180); // Lighter yellow background color on hover
            button.FlatAppearance.BorderSize = 0; // Slight border on hover
            button.FlatAppearance.BorderColor = System.Drawing.Color.Black; // Border color on hover
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = System.Drawing.Color.FromArgb(0, 180, 180); // Original yellow background color
            button.FlatAppearance.BorderSize = 0; // Remove border
        }
    }
}