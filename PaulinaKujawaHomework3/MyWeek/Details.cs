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
    public partial class Details : Form
    {
        SqlConnection connection;
        public Details()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this table shows details connected to table "Plan_of_action" - to the specific subject and duty
        private void buttonRefreshDetails_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DutyDetails", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewDetails.DataSource = table;
        }

        private void dataGridViewDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // adds details for a subject and duty which are already in a table from previous one
        private void buttonAdd3_Click_1(object sender, EventArgs e)
        {
            string subject = textBoxSubject3.Text;
            string duty = textBoxDuty2.Text;
            string details = textBoxDetails.Text;
            if (subject != String.Empty && duty != String.Empty && details != String.Empty)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("UPDATE DutyDetails SET Details = '{0}' WHERE (Subject = '{1}' AND Duty = '{2}')", details, subject, duty), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MessageBox.Show("Updated.");
                textBoxSubject3.Text = "";
                textBoxDuty2.Text = "";
                textBoxDetails.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // when typing subject, it deletes all data about it - name of subject, duty and details
        private void buttonDelete3_Click(object sender, EventArgs e)
        {
            string subject = textBoxSubject3.Text;
            string duty = textBoxDuty2.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("DELETE FROM DutyDetails WHERE(Subject = '{0}' AND Duty = '{1}')", subject, duty), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Deleted.");
            textBoxSubject3.Text = "";
            textBoxDuty2.Text = "";
            textBoxDetails.Text = "";
        }
    }
}
