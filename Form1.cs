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

        string database = "clinic";
        public Form1()
        {
            InitializeComponent();


        }
        /*switch (listOfDocs.SelectedItem.ToString())
            {
                case 'Гинеколог': ;
            }*/

        

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
                        init.table_changed(searchBy_comboBox, tablename_patients_proktolog, database, main_table);
                        break;
                    case 1:
                        init.table_changed(searchBy_comboBox, tablename_patients_ginekolog, database, main_table);
                        break;
                    case 2:
                        init.table_changed(searchBy_comboBox, tablename_patients_urolog, database, main_table);
                        break;
                    case 3:
                        init.table_changed(searchBy_comboBox, tablename_patients_urolog, database, main_table);
                        break;
                    case 4:
                        init.table_changed(searchBy_comboBox, tablename_patients_mammolog, database, main_table);
                        break;
                    case 5:
                        init.table_changed(searchBy_comboBox, tablename_patients_dermatolog, database, main_table);
                        break;
                    case 6:
                        init.table_changed(searchBy_comboBox, tablename_patients_lor, database, main_table);
                        break;
                    case 7:
                        init.table_changed(searchBy_comboBox, tablename_patients_nevropatolog, database, main_table);
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
            main_table.DataSource = init.InitTable(tablename_patients_ginekolog, database);
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
                    case 1:
                        main_table.DataSource = init.searchBy(tablename_patients_ginekolog, database, searchBy_textBox, searchBy_comboBox);
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
                }

                
            }
        }

     

        private void searchBy_comboBox_TextChanged(object sender, EventArgs e)
        {
            searchBy_textBox.Enabled = true;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            searchBy_textBox.Clear();
            searchBy_comboBox.Items.Clear();
            searchBy_comboBox.Text = "";
            main_table.DataSource = init.InitTable(tablename_patients_ginekolog, database);
            init.autosize(main_table);
            for (int i = 0; i < main_table.Columns.Count; i++)
            {
                searchBy_comboBox.Items.Add(main_table.Columns[i].Name);
            }
        }
    }
}
