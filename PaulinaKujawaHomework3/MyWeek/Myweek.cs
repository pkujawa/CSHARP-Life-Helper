using PaulinaKujawaHomework3.MyWeek;
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

namespace PaulinaKujawaHomework3
{
    public partial class Myweek : Form
    {
        Plan WindowPlan = new Plan();
        SqlConnection connection;
        public Myweek()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this table shows plan of the week - subject, day of the week and time of classes 
        private void buttonRefreshMyweek_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter ("SELECT * FROM My_week", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // adds subject, day of the week and time of classes
        // adds automatically name of the subject into the table "Plan_of_action"
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject.Text;
            string day = textBoxDay.Text;
            string time = textBoxTime.Text;
            if (subject != String.Empty && day != String.Empty && time != String.Empty)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("INSERT INTO My_week (Subject, [Day of the week], Time) VALUES('{0}','{1}','{2}')", subject, day, time), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                SqlDataAdapter adapter2 = new SqlDataAdapter(String.Format("INSERT INTO Plan_of_action (Subject) VALUES('{0}')", subject), connection);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                MessageBox.Show("Added.");
                textBoxSubject.Text = "";
                textBoxDay.Text = "";
                textBoxTime.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // when typing subject, day and time - it deletes all these data
        //it automatically deletes all data about that subject from another tables 
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject.Text;
            string day = textBoxDay.Text;
            string time = textBoxTime.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("DELETE FROM My_week WHERE(Subject = '{0}' AND[Day of the week] = '{1}' AND Time = '{2}')", subject, day, time), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlDataAdapter adapter2 = new SqlDataAdapter(String.Format("DELETE FROM Plan_of_action WHERE(Subject = '{0}')", subject), connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            SqlDataAdapter adapter3 = new SqlDataAdapter(String.Format("DELETE FROM DutyDetails WHERE(Subject = '{0}')", subject), connection);
            DataTable table3 = new DataTable();
            adapter3.Fill(table3);
            MessageBox.Show("Deleted.");
            textBoxSubject.Text = "";
            textBoxDay.Text = "";
            textBoxTime.Text = "";
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            WindowPlan.Show();
        }
    }
}
