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
    public partial class MainWindow : Form
    {
        Additional.Additional AdditionalWindow = new Additional.Additional();
        Myweek WindowMyWeek = new Myweek();
        Grandma WindowGrandma = new Grandma();
        To_Watch.ToWatch WindowWatch = new To_Watch.ToWatch();
        Calories.Calories WindowCalories = new Calories.Calories();
        Friend.Friend WindowFriend = new Friend.Friend();
        int t = 0; // will be used by timerGrandma
        int timebreak = 0; // will be used by timerBreak
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonGoMyWeek_Click(object sender, EventArgs e)
        {
            WindowMyWeek.Show();
        }
        // when a minute passes, Grandma is calling you and a special window shows
        private void timerGrandma_Tick(object sender, EventArgs e)
        {
            t++;
            if (t == 60)
            {
                WindowGrandma.Show();
            }
        }

        private void buttonToWatch_Click(object sender, EventArgs e)
        {
            WindowWatch.Show();
        }

        private void buttonAddiAct_Click(object sender, EventArgs e)
        {
            AdditionalWindow.Show();
        }

        private void buttonWithCalories_Click(object sender, EventArgs e)
        {
            WindowCalories.Show();
        }

        private void buttonGoToFriend_Click(object sender, EventArgs e)
        {
            WindowFriend.Show();
        }
        // this timer will start after clicking on button buttonBreak (to make a 5-minute break from work). When it reaches 5 minutes - messageBox shows to inform you that your break finished
        private void timerBreak_Tick(object sender, EventArgs e)
        {
            timebreak++;
            if (timebreak == 300)
            {
                MessageBox.Show("Get back to work. Your break is over!");
            }
        }

        private void buttonBreak_Click(object sender, EventArgs e)
        {
            timerBreak.Start();

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
