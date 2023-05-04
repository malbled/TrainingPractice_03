using System;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProvider formProvider = new FormProvider();
            formProvider.Show();
        }

        private void топливоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuel formFuel = new FormFuel();
            formFuel.Show();
        }

        private void учётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBalance formBalance = new FormBalance();
            formBalance.Show();
        }
    }
}
