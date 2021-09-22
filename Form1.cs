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
    public partial class Form1 : Form
    {
        Init_Table init = new Init_Table();
        //string tablename_doc = "doctors";
        string tablename_patients_proktolog = "patients_proktolog";
        string tablename_patients_ginekolog = "patients_ginecolog";
        string tablename_patients_dermatolog = "patients_dermatolog";
        string tablename_patients_urolog = "patients_urolog";
        string tablename_patients_mammolog = "patients_mammolog";
        string tablename_patients_lor = "patients_lor";
        string tablename_patients_nevropatolog = "patients_nevropatolog";
        string password = "wsk2020";

        string database = "clinic";
        public Form1()
        {
            InitializeComponent();


        }
       
        private void поискКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search_Form search = new Search_Form();
            search.Show();
            warning_label.Hide();

        }

        private void добавлениеКартыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Add add = new Form_Add();
            add.ShowDialog();
        }

        private void listOfDocs_TextChanged(object sender, EventArgs e)
        {
            if (listOfDocs.Text != "Выберите отделение")
            {
                warning_label.Hide();
                switch (listOfDocs.SelectedIndex)
                {
                    case 0:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_proktolog, database, main_table, password);
                        break;
                    case 1:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_ginekolog, database, main_table, password);
                        break;
                    case 2:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_urolog, database, main_table, password);
                        break;
                    case 3:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_mammolog, database, main_table, password);
                        break;
                    case 4:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_dermatolog, database, main_table, password);
                        break;
                    case 5:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_lor, database, main_table, password);
                        break;
                    case 6:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_nevropatolog, database, main_table, password);
                        break;
                    default: MessageBox.Show("Table error!");
                        break;
                }
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchBy_textBox.Clear();
            searchBy_comboBox.Items.Clear();
            searchBy_comboBox.Text = "";
            if (listOfDocs.Text != "Выберите отделение")
            {
                warning_label.Hide();
                switch (listOfDocs.SelectedIndex)
                {
                    case 0:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_proktolog, database, main_table, password);
                        break;
                    case 1:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_ginekolog, database, main_table, password);
                        break;
                    case 2:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_urolog, database, main_table, password);
                        break;
                    case 3:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_mammolog, database, main_table, password);
                        break;
                    case 4:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_dermatolog, database, main_table, password);
                        break;
                    case 5:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_lor, database, main_table, password);
                        break;
                    case 6:
                        searchBy_textBox.Clear();
                        searchBy_comboBox.Text = "";
                        init.table_changed(searchBy_comboBox, tablename_patients_nevropatolog, database, main_table, password);
                        break;
                    default:
                        MessageBox.Show("Table error!");
                        break;
                }
            }
            init.autosize(main_table);
            for (int i = 0; i < main_table.Columns.Count; i++)
            {
                searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

     

        private void searchBy_textBox_TextChanged(object sender, EventArgs e)
        {
            if (listOfDocs.Text != "Выберите отделение")
            {
                warning_label.Hide();
                switch (listOfDocs.SelectedIndex)
                {
                    case 0:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_proktolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 1:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_ginekolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 2:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_urolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 3:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_mammolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 4:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_dermatolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 5:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_lor, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    case 6:
                        searchBy_comboBox.Items.Clear();
                        main_table.DataSource = init.searchBy(tablename_patients_nevropatolog, database, searchBy_textBox, searchBy_comboBox, password);
                        main_table.Columns["patientID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["PatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        for (int i = 0; i < main_table.Columns.Count; i++)
                        {
                            searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
                        }
                        break;
                    default:
                        MessageBox.Show("Sorting error!");
                        break;
                }

            }
        }

     

        private void searchBy_comboBox_TextChanged(object sender, EventArgs e)
        {
            searchBy_textBox.Enabled = true;
            clear_button.Enabled = true;
            if(searchBy_comboBox.Text == "")
            {
                searchBy_textBox.Clear();
                clear_button.Enabled = false;
                searchBy_textBox.Enabled = false;
            }
            else if(searchBy_comboBox.Text == "" && searchBy_textBox.Text != "")
            {
                searchBy_textBox.Clear();
                clear_button.Enabled = false;
                searchBy_textBox.Enabled = false;
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            searchBy_textBox.Clear();
            searchBy_comboBox.Items.Clear();
            searchBy_comboBox.Text = "";
            main_table.DataSource = init.InitTable(tablename_patients_ginekolog, database, password);
            init.autosize(main_table);
            for (int i = 0; i < main_table.Columns.Count; i++)
            {
                searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
            }
        }
    }
}
