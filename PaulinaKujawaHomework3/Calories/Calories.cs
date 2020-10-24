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

namespace PaulinaKujawaHomework3.Calories
{
    public partial class Calories : Form
    {
        SqlConnection connection;
        double cal;
        public Calories()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this table collects data about form of sport, user's weight, time of exercising and calculates calories burnt.
        private void buttonRefreshSport_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Calories", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSport.DataSource = table;
        }

        private void dataGridViewSport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // adds form of sport, time of exercising and caltulates calories burnt depending on form of sport, time and weight of a user
        private void buttonAddSport_Click_1(object sender, EventArgs e)
        {
            string day = textBoxSportDay.Text;
            string form = comboBoxSport.Text;
            string time = textBoxSportTime.Text;
            string weight = textBoxWeight.Text;
            if (comboBoxSport.Text == "Cycling")
            {
                cal = 1.92 * double.Parse(weight) * double.Parse(time) / 30;
            }
            if (comboBoxSport.Text == "Swimming")
            {
                cal = 2.4 * double.Parse(weight) * double.Parse(time) / 30;
            }
            if (comboBoxSport.Text == "Running")
            {
                cal = 2.16 * double.Parse(weight) * double.Parse(time) / 30;
            }
            if (comboBoxSport.Text == "Beer")
            {
                MessageBox.Show("Well, no need to put that information here. But that was a good, productive day.");
            }
            if (comboBoxSport.Text == "Project for C# Course")
            {
                MessageBox.Show("Much enough calories burnt. But still doesn't count as sport. Didn't really need your weight, sir.");
            }

            if (day != String.Empty && form != String.Empty && time != String.Empty && weight != String.Empty && form != "Beer" && form != "Project for C# Course")
            {
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Calories SET [Form of sport] = '{0}', [Time of exercising [min]]] = '{1}', [Calories burnt] = '{2}' WHERE [Day of the week] = '{3}'", form, time, cal, day), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MessageBox.Show("Added.");
                textBoxSportDay.Text = "";
                comboBoxSport.Text = "";
                textBoxSportTime.Text = "";
                textBoxWeight.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // deletes form of sport, time and calories burnt from a row, leaving a day-row filled only.
        private void buttonDeleteSport_Click(object sender, EventArgs e)
        {
            string day = textBoxSportDay.Text;
            string form = comboBoxSport.Text;
            string time = textBoxSportTime.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("DELETE FROM Calories WHERE [Day of the week] = '{0}'", day), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlDataAdapter adapter2 = new SqlDataAdapter(String.Format("INSERT INTO Calories ([Day of the week]) VALUES('{0}')", day), connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            MessageBox.Show("Deleted.");
            textBoxSportDay.Text = "";
            comboBoxSport.Text = "";
            textBoxSportTime.Text = "";
        }
    }
}
