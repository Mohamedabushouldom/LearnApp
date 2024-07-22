using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathGame;
using HebrewGame;

namespace MainPageSelict
{
    public partial class MainP : Form
    {
        public MainP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm formB = new MainForm();
            formB.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hebrew formC = new Hebrew();
            formC.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnglish_Click(object sender, EventArgs e)
        {

        }

        private void labelLibrary_Click(object sender, EventArgs e)
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
