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

namespace PaulinaKujawaHomework3.MyWeek
{
    public partial class Plan : Form
    {
        Details WindowDetails = new Details();
        SqlConnection connection;
        public Plan()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this is a table which has a subject name, duty connected to it, deadline and amount of time which will probably be spent on that
        private void buttonRefreshPlan_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Plan_of_action", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewPlan.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // inserts data about the subject which already exists - was added in previous table, when adding the subject.
        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject2.Text;
            string duty = textBoxDuty.Text;
            string deadline = textBoxDeadline.Text;
            string howlong = textBoxHowlong.Text;
            if (subject != String.Empty && duty != String.Empty && deadline != String.Empty && howlong != String.Empty)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE Plan_of_action SET Duty ='{0}', Deadline = '{1}', [How long will it take? [min]]] = '{2}' WHERE Subject = '{3}'", duty, deadline, howlong, subject), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                SqlDataAdapter adapter2 = new SqlDataAdapter(String.Format("INSERT INTO DutyDetails (Subject, Duty) VALUES('{0}','{1}')", subject, duty), connection);
                DataTable table2 = new DataTable();
                adapter2.Fill(table2);
                MessageBox.Show("Added.");
                textBoxSubject2.Text = "";
                textBoxDuty.Text = "";
                textBoxDeadline.Text = "";
                textBoxHowlong.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // deletes all data when typed into textBoxes
        //autimaticall deletes data about that subject and duty connected to it from "DutyDetails" table
        private void buttonDelete2_Click_1(object sender, EventArgs e)
        {
            string subject = textBoxSubject2.Text;
            string duty = textBoxDuty.Text;
            string deadline = textBoxDeadline.Text;
            string howlong = textBoxHowlong.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("DELETE FROM Plan_of_action WHERE(Subject = '{0}' AND Duty = '{1}' AND Deadline = '{2}' AND [How long will it take? [min]]] = '{3}')", subject, duty, deadline, howlong), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            SqlDataAdapter adapter2 = new SqlDataAdapter(String.Format("DELETE FROM DutyDetails WHERE(Subject = '{0}' AND Duty = '{1}')", subject, duty), connection);
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            MessageBox.Show("Deleted.");
            textBoxSubject2.Text = "";
            textBoxDuty.Text = "";
            textBoxDeadline.Text = "";
            textBoxHowlong.Text = "";
        }
        private void buttonDetails_Click(object sender, EventArgs e)
        {
            WindowDetails.Show();
        }
    }
}
