using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Search_Form : Form
    {
        Init_Table init = new Init_Table();
        string tablename_patients_proktolog = "patients_proktolog";
        string tablename_patients_ginekolog = "patients_ginecolog";
        string tablename_patients_dermatolog = "patients_dermatolog";
        string tablename_patients_urolog = "patients_urolog";
        string tablename_patients_mammolog = "patients_mammolog";
        string tablename_patients_lor = "patients_lor";
        string tablename_patients_nevropatolog = "patients_nevropatolog";
        string password = "wsk2020";
        string database = "clinic";
        string column = "";



        ComboBox searchBy_comboBox = new ComboBox();
        public Search_Form()
        {
            InitializeComponent();
        }

        private void listOfDocs_Click(object sender, EventArgs e)
        {

        }

        private void listOfDocs_TextChanged(object sender, EventArgs e)
        {
            if (listOfDocs.Text != "Выберите отделение")
            {
                warning_label.Hide();
                content_panel.Enabled = true;
                main_table.Visible = true;
                switch (listOfDocs.SelectedIndex)
                {
                    case 0:
                        init.table_changed(tablename_patients_proktolog, database, main_table, password);
                        break;
                    case 1:
                        init.table_changed(tablename_patients_ginekolog, database, main_table, password);
                        break;
                    case 2:
                        init.table_changed(tablename_patients_urolog, database, main_table, password);
                        break;
                    case 3:
                        init.table_changed(tablename_patients_mammolog, database, main_table, password);
                        break;
                    case 4:
                        init.table_changed(tablename_patients_dermatolog, database, main_table, password);
                        break;
                    case 5:
                        init.table_changed(tablename_patients_lor, database, main_table, password);
                        break;
                    case 6:
                        init.table_changed(tablename_patients_nevropatolog, database, main_table, password);
                        break;
                    default:
                        MessageBox.Show("Table error!");
                        break;
                }

            }
        }

        private void Search_Form_Load(object sender, EventArgs e)
        {

        }

        private void PatName_Click(object sender, EventArgs e)
        {
            //fio_radioButton.Visible = false;
            Born_year.Visible = false;
            Doctors_Name.Visible = false;
            Coming_Date.Visible = false;
            Card_num.Visible = false;
            Address.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "PatName";
        }
       

        private void cancel_button_Click(object sender, EventArgs e)
        {
            search_textBox.Clear();
            PatName.Visible = true;
            PatName.Checked = false;
            Born_year.Visible = true;
            Born_year.Checked = false;
            Doctors_Name.Visible = true;
            Doctors_Name.Checked = false;
            Coming_Date.Visible = true;
            Coming_Date.Checked = false;
            Card_num.Visible = true;
            Card_num.Checked = false;
            Address.Visible = true;
            Address.Checked = false;
            main_table.DataSource = new DataTable();
            main_table.Enabled = false;
            content_panel.Enabled = false;
            warning_label.Visible = true;
            listOfDocs.Text = "Выберите отделение";
        }
        private void Address_Click(object sender, EventArgs e)
        {
            PatName.Visible = false;
            Born_year.Visible = false;
            Doctors_Name.Visible = false;
            Coming_Date.Visible = false;
            Card_num.Visible = false;
            //address_radioButton.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "Address";
        }

        private void Card_num_Click(object sender, EventArgs e)
        {
            PatName.Visible = false;
            Born_year.Visible = false;
            Doctors_Name.Visible = false;
            Coming_Date.Visible = false;
            //number_radioButton.Visible = false;
            Address.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "Card_num";
        }
   
        private void Born_year_Click(object sender, EventArgs e)
        {
            PatName.Visible = false;
            //year_radioButton.Visible = false;
            Doctors_Name.Visible = false;
            Coming_Date.Visible = false;
            Card_num.Visible = false;
            Address.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "Born_year";

        }

        private void Coming_Date_Click(object sender, EventArgs e)
        {
            PatName.Visible = false;
            Born_year.Visible = false;
            Doctors_Name.Visible = false;
            //visit_radioButton.Visible = false;
            Card_num.Visible = false;
            Address.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "Coming_Date";

        }

        private void Doctors_Name_Click(object sender, EventArgs e)
        {
            PatName.Visible = false;
            //Doctors_Name.Visible = false;
            Coming_Date.Visible = false;
            Card_num.Visible = false;
            Address.Visible = false;
            main_table.Enabled = true;
            search_textBox.Enabled = true;
            column = "Doctors_Name";
        }
        private void search_textBox_TextChanged(object sender, EventArgs e)
        {
            switch (listOfDocs.SelectedIndex)
            {
                case 0:
                    searchBy_comboBox.Items.Clear();
                    main_table.DataSource = init.searchBy(tablename_patients_proktolog, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_ginekolog, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_urolog, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_mammolog, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_dermatolog, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_lor, database, search_textBox, column, password);
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
                    main_table.DataSource = init.searchBy(tablename_patients_nevropatolog, database, search_textBox, column, password);
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            search_textBox.Clear();
            PatName.Visible = true;
            PatName.Checked = false;
            Born_year.Visible = true;
            Born_year.Checked = false;
            Doctors_Name.Visible = true;
            Doctors_Name.Checked = false;
            Coming_Date.Visible = true;
            Coming_Date.Checked = false;
            Card_num.Visible = true;
            Card_num.Checked = false;
            Address.Visible = true;
            Address.Checked = false;
        }

        private void отменаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void посмотретьСправкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support sup = new Support();
            sup.ShowDialog();
        }
    }
}
