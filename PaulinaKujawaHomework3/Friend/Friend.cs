using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaHomework3.Friend
{
    public partial class Friend : Form
    {
        SqlConnection connection;
        int nadvices; //for normies advices
        int dadvices; //for dank advices
        int hadvices; // for honest advices
        int fadvices; // for friend advices
        string type;  //type of advice used    
        public Friend()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this table is a motivator-comforter. User can get go here when suffering from a failure or looking for a praise
        private void buttonCoffee_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Imaginary_Friend", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFriend.DataSource = table;
        }

        private void dataGridViewFriend_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        // shows message boxes depending on the chosen option - actual problem of a user. Additionally, it counts forms of advices used. 
        private void buttonPour_Click(object sender, EventArgs e)
        {
            string problem = comboBoxFriend.Text;
            if (comboBoxFriend.Text == "I got a bad grade " || comboBoxFriend.Text == "I got a good grade" || comboBoxFriend.Text == "I just feel sad")
            {
                type = "Normie advices";
                nadvices ++;
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Imaginary_Friend SET [Advices used] ='{0}' WHERE [Type of advice] = '{1}'", nadvices, type), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (comboBoxFriend.Text == "I got a good grade")
                {
                    MessageBox.Show("Congrats! Keep it up! You deserved it.");
                }
                else if (comboBoxFriend.Text == "I got a bad grade ")
                {
                    MessageBox.Show("Don't worry. Your group had the hardest questions. They were just dumb. You will do better next time.");
                }
                else
                {
                    MessageBox.Show("Just watch your favourite TV show or call a friend. Don't overthink anything, that mood will pass.");
                }
                MessageBox.Show("Updated.");
                comboBoxFriend.Text = "";
            }
            else if (comboBoxFriend.Text == "I don't feel like studying" || comboBoxFriend.Text == "Somebody once told me ... ")
            {
                type = "Dank advices";
                dadvices++;
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Imaginary_Friend SET [Advices used] ='{0}' WHERE [Type of advice] = '{1}'", dadvices, type), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (comboBoxFriend.Text == "I don't feel like studying")
                {
                    MessageBox.Show("JUST DO IT! MAKE YOUR DREAMS COME TRUE. WHAT ARE YOU WAIING FOR? YES, YOU CAN");
                }
                else
                {
                    MessageBox.Show("The world is gonna roll me ( ͡° ͜ʖ ͡°)");
                }
                MessageBox.Show("Updated.");
                comboBoxFriend.Text = "";
            }
            else if (comboBoxFriend.Text == "Friend called me fat" || comboBoxFriend.Text == "I am actually fat" || comboBoxFriend.Text == "I won't manage to make a project for C# Course on time")
            {
                type = "Honest advices";
                hadvices++;
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Imaginary_Friend SET [Advices used] ='{0}' WHERE [Type of advice] = '{1}'", hadvices, type), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (comboBoxFriend.Text == "Friend called me fat")
                {
                    MessageBox.Show("That's quite rude. 'Overweight' would be more appropriate.");
                }
                else if (comboBoxFriend.Text == "I am actually fat")
                {
                    MessageBox.Show("That's quite right, sir");
                }
                else
                {
                    MessageBox.Show("That's seems like a serious problem. But I'm sure these rational people will understand and allow you to send the project later. ( ͡° ͜ʖ ͡°)");
                }
                MessageBox.Show("Updated.");
                comboBoxFriend.Text = "";
            }
            else if (comboBoxFriend.Text == "I got into a fight" || comboBoxFriend.Text == "I was wrong and made a mistake" || comboBoxFriend.Text == "My teacher doesn't like me" || comboBoxFriend.Text == "My favourite football team lost a match" || comboBoxFriend.Text == "My favourite football team won a match")
            {
                type = "Friend advices";
                fadvices++;
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Imaginary_Friend SET [Advices used] ='{0}' WHERE [Type of advice] = '{1}'", fadvices, type), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (comboBoxFriend.Text == "I got into a fight")
                {
                    MessageBox.Show("Don't worry. It was obviously the other person's fault. You did everything perfectly.");
                }
                else if (comboBoxFriend.Text == "I was wrong and made a mistake")
                {
                    MessageBox.Show("No way, of course you didn't. You were absolutely right and didn't make any mistake.");
                }
                else if (comboBoxFriend.Text == "My teacher doesn't like me")
                {
                    MessageBox.Show("Don't worry about him. He's totally a jackass");
                }
                else
                {
                    MessageBox.Show("Come on You REDS! Glory, Glory, Man United");
                }
                MessageBox.Show("Updated.");
                comboBoxFriend.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // deletes amount of advices of each form. Counting starts from 0 again.
        private void buttonSpill_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Imaginary_Friend SET [Advices used] ='-'"), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Nevermind.");
            nadvices = 0;
            dadvices = 0;
            hadvices = 0;
            fadvices = 0;
        }

    }
}
