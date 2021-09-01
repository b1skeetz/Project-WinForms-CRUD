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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                //main_panel.Enabled = true;
            }
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
