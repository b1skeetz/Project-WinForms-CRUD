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
        string tablename_doctors_ginekolog     = "doctors_ginecolog";
        string tablename_doctors_dermatolog    = "doctors_dermatolog";
        string tablename_doctors_urolog        = "doctors_urolog";
        string tablename_doctors_mammolog      = "doctors_mammolog";
        string tablename_doctors_lor           = "doctors_lor";
        string tablename_doctors_nevropatolog  = "doctors_nevropatolog";


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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_button_Click(object sender, EventArgs e)
        {
           
        }

        private void Form_Add_Load(object sender, EventArgs e)
        {
            for (int i = 1990; i <= 2050; i++)
            {
                years_comboBox.Items.Add(i);
            }
            visit_textBox.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");

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
                            DataGridView dataGridView = new DataGridView();
                            dataGridView = init.table_get(tablename_doctors_proktolog, database);

                            //buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_proktolog, database);
                            for(int i = 0; i < dataGridView.Rows.Count-1; i++)
                            {
                                doc_comboBox.Items.Add(dataGridView[1, i].Value);
                            }
                            

                            break;
                        case 1:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_ginekolog, database);

                            break;
                        case 2:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_urolog, database);

                            break;
                        case 3:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_mammolog, database);

                            break;
                        case 4:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_dermatolog, database);

                            break;
                        case 5:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_lor, database);

                            break;
                        case 6:
                            buffer_dataGridView.DataSource = init.InitTable(tablename_doctors_nevropatolog, database);

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
