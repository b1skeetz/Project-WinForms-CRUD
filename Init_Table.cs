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

        public void add_query(string database, string tablename, TextBox fio, ComboBox year, TextBox number, TextBox address, ComboBox doc, TextBox time, TextBox other, MySqlConnection connect)
        {
            try
            {
                string query = "INSERT INTO " + database + "." + tablename + "(PatName, Born_year, Card_num, Address, Doctors_Name, Coming_Date, Other) VALUES ('" + fio.Text + "', '" + year.Text +
                "', '" + number.Text + "', '" + address.Text + "', '" + doc.Text + "', '" + time.Text + "', '" + other.Text + "');";
       

                MySqlCommand command = new MySqlCommand(query, connect);
                connect.Open();
                //command.Connection.Open();
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                connect.Close();
            }
        }

        public DataTable searchBy(string tableName, string database, TextBox text, ComboBox comboBox, string password)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost; User Id=root; Password=" + password + ";";
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally
            {
                command.Connection.Close();
            }
            return data;
        }

        public DataTable InitTable(string tableName, string database, string password)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            string query = "SELECT * FROM " + database + "." + tableName + ";";
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

        public void table_changed(ComboBox comboBox, string tableName, string database, DataGridView dataGridView, string password)
        {
            comboBox.Items.Clear();
            dataGridView.DataSource = InitTable(tableName, database, password);
            autosize(dataGridView);
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                comboBox.Items.Add(dataGridView.Columns[i].Name);
            }
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

        public DataGridView table_get(string tableName, string database, string password)
        {
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            string query = "SELECT * FROM " + database + "." + tableName + ";";
            MySqlCommand command = new MySqlCommand(query, connect);


            MySqlDataReader reader;
            try
            {
                command.Connection.Open();
                reader = command.ExecuteReader();
                dataGridView1.Columns.Add("idField", "ID");
                dataGridView1.Columns["idField"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns["idField"].Visible = false;
                dataGridView1.Columns.Add("nameField", "Name");
                dataGridView1.Columns["nameField"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["doctorID"].ToString(), reader["DocName"].ToString());
                }
                reader.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            return dataGridView1;

        }
    }
}
