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
                main_panel.Enabled = true;
                
            }
        }

        private void main_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_Form_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            address_textBox.Clear();
            fio_textBox.Clear();
            years_comboBox.Text = "";
            number_textBox.Clear();
            doc_comboBox.Text = "";
            doc_comboBox.Items.Clear();
            //listOfDocs.Text = "Выберите отделение";
            others_textBox.Clear();
        }
    }
}
