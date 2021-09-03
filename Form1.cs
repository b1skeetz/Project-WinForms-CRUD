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
        string tablename_doc = "doctors";
        string tablename_patients_ginekolog = "ginekolog";
        string database = "patients";
        public Form1()
        {
            InitializeComponent();


        }
        /*switch (listOfDocs.SelectedItem.ToString())
            {
                case 'Гинеколог': ;
            }*/

        private void control_panel_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listOfDocs_Click(object sender, EventArgs e)
        {

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
                    case 1: main_table.DataSource = init.InitTable(tablename_patients_ginekolog, database);
                        main_table.Columns["idPatients"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Born_year"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Card_num"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Doctors_Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Coming_Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        main_table.Columns["Other"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        //main_table.Columns["idPatients"].Resizable 
                        break;
                }
                
                //main_panel.Enabled = true;
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
