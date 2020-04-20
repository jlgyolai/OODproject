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
    public partial class War : Form
    {
        public War()
        {
            InitializeComponent();
        }

        private void WarExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new MainMenu();
            newForm.FormClosed += (s, args) => this.Close();
            newForm.Show();
        }
    }
}
