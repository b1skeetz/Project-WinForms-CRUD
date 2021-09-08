using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace Project
{
    class Init_Table
    {
        public void autosize(DataGridView table)
        {
            table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public DataTable searchBy(string tableName, string database, TextBox text, ComboBox comboBox)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost; User Id=root; Password=wsk2020;";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            string query = "SELECT * FROM " + database + "." + tableName + " WHERE " + comboBox.Text + " LIKE '%" + text.Text + "%';";
            MySqlCommand command = new MySqlCommand(query, connect);
            DataTable data = new DataTable();

            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                data.Load(reader);
                reader.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                command.Connection.Close();
            }
            return data;
        }

        public DataTable InitTable(string tableName, string database)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=wsk2020;";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            string query = "SELECT * FROM "+ database + "." + tableName + ";";
            MySqlCommand command = new MySqlCommand(query, connect);
            DataTable data = new DataTable();

            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                data.Load(reader);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            return data;
        }


        public DataTable InitTable(string query, bool status)
        {
            string dbconnect = "Database=patients;Data Source=localhost;User Id=root;Password=wsk2020;";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            //string query = "SELECT * FROM damir." + tableName + ";";
            MySqlCommand command = new MySqlCommand(query, connect);
            DataTable data = new DataTable();

            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                data.Load(reader);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            return data;
        }
    }
}
