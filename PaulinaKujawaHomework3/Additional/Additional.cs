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

namespace PaulinaKujawaHomework3.Additional
{
    public partial class Additional : Form
    {
        SqlConnection connection;
        public Additional()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source = ACER\PKSQL; database = LifeHelper; Trusted_Connection = yes");
        }
        // this table shows additional activities. User can isert day, form of activity and details
        private void buttonRefreshAdditional_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Additional_activities", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewAdditional.DataSource = table;
        }

        private void dataGridViewAdditional_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // inserts day, activity and details into table
        private void buttonAddAdditional_Click(object sender, EventArgs e)
        {
            string day = textBoxAdditionalDay.Text;
            string activity = textBoxAdditionalActivity.Text;
            string details = textBoxAdditionalDetails.Text;
            if (day != String.Empty && activity != String.Empty && details != String.Empty)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(String.Format("INSERT INTO Additional_activities ([Day of the week], [Additional activity], Details) VALUES('{0}','{1}','{2}')", day, activity, details), connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                MessageBox.Show("Added.");
                textBoxAdditionalDay.Text = "";
                textBoxAdditionalActivity.Text = "";
                textBoxAdditionalDetails.Text = "";
            }
            else
            {
                MessageBox.Show("Wrong data!");
            }
        }
        // deletes day, activity and details
        private void buttonDeleteAdditional_Click(object sender, EventArgs e)
        {
            string day = textBoxAdditionalDay.Text;
            string activity = textBoxAdditionalActivity.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(String.Format("DELETE FROM Additional_activities WHERE([Day of the week] = '{0}' AND [Additional activity] = '{1}')", day, activity), connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            MessageBox.Show("Deleted.");
            textBoxAdditionalDay.Text = "";
            textBoxAdditionalActivity.Text = "";
            textBoxAdditionalDetails.Text = "";
        }

        private void Additional_Load(object sender, EventArgs e)
        {

        }
    }
}
