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
    public partial class Form_Add : Form
    {
        public Form_Add()
        {
            InitializeComponent();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
            goldenCard_checkBox.Checked = false;
            hospit_checkBox.Checked = false;
            ref_checkBox.Checked = false;
            
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

        private void others_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hospit_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listOfDocs_TextChanged(object sender, EventArgs e)
        {
            if(listOfDocs.Text != "Выберите отделение")
            {
                warning_label.Hide();
                main_panel.Enabled = true;
            }
        }
    }
}
