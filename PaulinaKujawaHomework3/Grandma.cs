using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaHomework3
{
    public partial class Grandma : Form
    {
        public Grandma()
        {
            InitializeComponent();
            pictureBoxFail.Visible = false;
        }
        // Grandma is asking user if he's eaten yet
        // if answered "yes" and clicked "Answer" - the window closes and messageBox shows
        // if answered anything else - picture of failure becomes visible, messageBox shows and whole application closes
        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            if (textBoxAnswer.Text == "yes" || textBoxAnswer.Text == "Yes" || textBoxAnswer.Text == "YES")
            {
                MessageBox.Show("Oh. Get back to work then, you lazy ass");
                this.Close();

            }
            else
            {
                pictureBoxFail.Visible = true;
                MessageBox.Show("You failed. Although, you've been beaten by Boss - not a shame.");
                Application.Exit();
            }
        }
    }
}
