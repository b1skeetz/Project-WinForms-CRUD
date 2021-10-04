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

    public partial class Form_Edit : Form
    {
        Init_Table init = new Init_Table();
        string database = "clinic";
        string tablename_doctors_proktolog = "doctors_proktolog";
        string tablename_patients_proktolog = "patients_proktolog";
        string tablename_doctors_ginekolog = "doctors_ginecolog";
        string tablename_patients_ginekolog = "patients_ginecolog";
        string tablename_doctors_dermatolog = "doctors_dermatolog";
        string tablename_patients_dermatolog = "patients_dermatolog";
        string tablename_doctors_urolog = "doctors_urolog";
        string tablename_patients_urolog = "patients_urolog";
        string tablename_doctors_mammolog = "doctors_mammolog";
        string tablename_patients_mammolog = "patients_mammolog";
        string tablename_doctors_lor = "doctors_lor";
        string tablename_patients_lor = "patients_lor";
        string tablename_doctors_nevropatolog = "doctors_nevropatolog";
        string tablename_patients_nevropatolog = "patients_nevropatolog";
        string password = "wsk2020";
        string[] row = new string[8];
        int listOfDocs;

        public Form_Edit(string[] _mass, int index)
        {
            listOfDocs = index;
            for (int i = 0; i < 8; i++)
            {
                row[i] = _mass[i];
            }

            InitializeComponent();
        }

        private void Form_Edit_Load(object sender, EventArgs e)
        {
            fio_textBox.Text = row[1];
            years_comboBox.Text = row[2];
            number_textBox.Text = row[3];
            address_textBox.Text = row[4];
            doc_comboBox.Text = row[5];
            visit_textBox.Text = row[6];
            others_textBox.Text = row[7];

            for (int i = 1920; i <= 2050; i++)
            {
                years_comboBox.Items.Add(i);
            }


            switch (listOfDocs)
            {

                case 0:
                    doc_comboBox.Items.Clear();
                    visit_textBox.Clear();
                    visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                    DataGridView dataGridView = new DataGridView();
                    dataGridView = init.table_get(tablename_doctors_proktolog, database, password);
                    for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                    {
                        doc_comboBox.Items.Add(dataGridView[1, i].Value);
                    }


                    break;
                case 1:
                    doc_comboBox.Items.Clear();
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            switch (listOfDocs)
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            address_textBox.Clear();
            fio_textBox.Clear();
            years_comboBox.Text = "";
            number_textBox.Clear();
            doc_comboBox.Text = "";
            others_textBox.Clear();
            doc_comboBox.Items.Clear();
            doc_comboBox.Text = "";
            visit_textBox.Clear();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);
            if (fio_textBox.Text != "" && years_comboBox.Text != "" && address_textBox.Text != "" && doc_comboBox.Text != "" && visit_textBox.Text != "" && number_textBox.Text != "")
            {
                switch (listOfDocs)
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
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Database=" + database + ";Data Source=localhost;User Id=root;Password=" + password + ";";
            MySqlConnection connect = new MySqlConnection(dbconnect);

            fio_textBox.Text = row[1];
            years_comboBox.Text = row[2];
            number_textBox.Text = row[3];
            address_textBox.Text = row[4];
            doc_comboBox.Text = row[5];
            visit_textBox.Text = row[6];
            others_textBox.Text = row[7];
            if (fio_textBox.Text != "" && years_comboBox.Text != "" && address_textBox.Text != "" && doc_comboBox.Text != "" && visit_textBox.Text != "" && number_textBox.Text != "")
            {
                switch (listOfDocs)
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
            else
            {
                MessageBox.Show("Заполните все поля!");
            }
            this.Close();
        }

        private void посмотретьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support sup = new Support();
            sup.ShowDialog();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            address_textBox.Clear();
            fio_textBox.Clear();
            years_comboBox.Text = "";
            number_textBox.Clear();
            doc_comboBox.Text = "";
            others_textBox.Clear();
            doc_comboBox.Items.Clear();
            doc_comboBox.Text = "";
            visit_textBox.Clear();

            fio_textBox.Text = row[1];
            years_comboBox.Text = row[2];
            number_textBox.Text = row[3];
            address_textBox.Text = row[4];
            doc_comboBox.Text = row[5];
            visit_textBox.Text = row[6];
            others_textBox.Text = row[7];
        }
    }
}

