using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Form_Add : Form
    {
        Init_Table init = new Init_Table();
        string database = "clinic";
        string tablename_doctors_proktolog     = "doctors_proktolog";
        string tablename_patients_proktolog     = "patients_proktolog";
        string tablename_doctors_ginekolog     = "doctors_ginecolog";
        string tablename_patients_ginekolog     = "patients_ginecolog";
        string tablename_doctors_dermatolog    = "doctors_dermatolog";
        string tablename_patients_dermatolog    = "patients_dermatolog";
        string tablename_doctors_urolog        = "doctors_urolog";
        string tablename_patients_urolog        = "patients_urolog";
        string tablename_doctors_mammolog      = "doctors_mammolog";
        string tablename_patients_mammolog      = "patients_mammolog";
        string tablename_doctors_lor           = "doctors_lor";
        string tablename_patients_lor           = "patients_lor";
        string tablename_doctors_nevropatolog  = "doctors_nevropatolog";
        string tablename_patients_nevropatolog  = "patients_nevropatolog";
        string password = "wsk2020";


        public Form_Add()
        {
            InitializeComponent();
            
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            address_textBox.Clear();
            fio_textBox.Clear();
            years_comboBox.Text = "";
            number_textBox.Clear();
            doc_comboBox.Text = "";
            listOfDocs.Text = "Выберите отделение";
            others_textBox.Clear();
            doc_comboBox.Items.Clear();
            doc_comboBox.Text = "";
            visit_textBox.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            if (listOfDocs.Text != "Выберите отделение")
            {
                if (listOfDocs.Text != "Выберите отделение")
                {
                    switch (listOfDocs.SelectedIndex)
                    {
                        case 0:
                            init.add_query(database, tablename_patients_proktolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);   
                            this.Close();

                            break;
                        case 1:
                            init.add_query(database, tablename_patients_ginekolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 2:
                            init.add_query(database, tablename_patients_urolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 3:
                            init.add_query(database, tablename_patients_mammolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 4:
                            init.add_query(database, tablename_patients_dermatolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 5:
                            init.add_query(database, tablename_patients_lor, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 6:
                            init.add_query(database, tablename_patients_nevropatolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        default:
                            MessageBox.Show("Table error!");
                            break;
                    }
                }
            }

            
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            for (int i = 1920; i <= 2050; i++)
            {
                years_comboBox.Items.Add(i);
            }
        }
       
        private void listOfDocs_TextChanged(object sender, EventArgs e)
        {

            
            if (listOfDocs.Text != "Выберите отделение")
            {
                main_panel.Enabled = true;
                if (listOfDocs.Text != "Выберите отделение")
                {
                    
                    warning_label.Hide();
                    switch (listOfDocs.SelectedIndex)
                    {

                        case 0:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            DataGridView dataGridView = new DataGridView();
                            dataGridView = init.table_get(tablename_doctors_proktolog, database, password);            
                            for(int i = 0; i < dataGridView.Rows.Count-1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }
                            

                            break;
                        case 1:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_ginekolog, database, password);                            
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        case 2:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_urolog, database, password);
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        case 3:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_mammolog, database, password);
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        case 4:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_dermatolog, database, password);
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        case 5:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_lor, database, password);                            
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        case 6:
                            doc_comboBox.Items.Clear();
                            doc_comboBox.Text = "";
                            visit_textBox.Clear();
                            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                            dataGridView = init.table_get(tablename_doctors_nevropatolog, database, password);                            
                            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }

                            break;
                        default:
                            MessageBox.Show("Table error!");
                            break;
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            if (listOfDocs.Text != "Выберите отделение")
            {
                if (listOfDocs.Text != "Выберите отделение")
                {
                    switch (listOfDocs.SelectedIndex)
                    {
                        case 0:
                            init.add_query(database, tablename_patients_proktolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 1:
                            init.add_query(database, tablename_patients_ginekolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 2:
                            init.add_query(database, tablename_patients_urolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 3:
                            init.add_query(database, tablename_patients_mammolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 4:
                            init.add_query(database, tablename_patients_dermatolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 5:
                            init.add_query(database, tablename_patients_lor, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        case 6:
                            init.add_query(database, tablename_patients_nevropatolog, fio_textBox, years_comboBox, number_textBox, address_textBox, doc_comboBox, visit_textBox, others_textBox, connect);
                            this.Close();

                            break;
                        default:
                            MessageBox.Show("Table error!");
                            break;
                    }
                }
            }
        }
    }
}
