using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Design_Project
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            //check
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxWar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm  = new War();
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
        }

        private void textBoxWar_MouseEnter(object sender, EventArgs e)
        {
            textBoxWar.BackColor = Color.Navy;
        }

        private void textBoxWar_MouseLeave(object sender, EventArgs e)
        {
            textBoxWar.BackColor = Color.CornflowerBlue;
        }

        private void textBoxMemory_MouseEnter(object sender, EventArgs e)
        {
            textBoxMemory.BackColor = Color.Navy;
        }

        private void textBoxMemory_MouseLeave(object sender, EventArgs e)
        {
            textBoxMemory.BackColor = Color.CornflowerBlue;
        }
    }
}
