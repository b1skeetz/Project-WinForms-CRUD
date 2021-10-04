
namespace Project
{
    partial class Search_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.control_panel = new System.Windows.Forms.MenuStrip();
            this.dataBaseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDocs = new System.Windows.Forms.ToolStripComboBox();
            this.warning_label = new System.Windows.Forms.Label();
            this.select_label = new System.Windows.Forms.Label();
            this.PatName = new System.Windows.Forms.RadioButton();
            this.Born_year = new System.Windows.Forms.RadioButton();
            this.Address = new System.Windows.Forms.RadioButton();
            this.Card_num = new System.Windows.Forms.RadioButton();
            this.Coming_Date = new System.Windows.Forms.RadioButton();
            this.Doctors_Name = new System.Windows.Forms.RadioButton();
            this.main_table = new System.Windows.Forms.DataGridView();
            this.cancel_button = new System.Windows.Forms.Button();
            this.content_panel = new System.Windows.Forms.Panel();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.посмотретьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.control_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).BeginInit();
            this.content_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.NavajoWhite;
            this.control_panel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseMenu,
            this.reference,
            this.listOfDocs});
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(1077, 31);
            this.control_panel.TabIndex = 3;
            this.control_panel.Text = "menuStrip1";
            // 
            // dataBaseMenu
            // 
            this.dataBaseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменаToolStripMenuItem});
            this.dataBaseMenu.Name = "dataBaseMenu";
            this.dataBaseMenu.Size = new System.Drawing.Size(57, 27);
            this.dataBaseMenu.Text = "База";
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьСправкуToolStripMenuItem});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(84, 27);
            this.reference.Text = "Справка";
            // 
            // listOfDocs
            // 
            this.listOfDocs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.listOfDocs.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listOfDocs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfDocs.Items.AddRange(new object[] {
            "Проктолог",
            "Гинеколог",
            "Уролог",
            "Маммолог",
            "Дерматолог",
            "Отоларинголог ",
            "Невропатолог "});
            this.listOfDocs.Name = "listOfDocs";
            this.listOfDocs.Size = new System.Drawing.Size(250, 27);
            this.listOfDocs.Text = "Выберите отделение";
            this.listOfDocs.Click += new System.EventHandler(this.listOfDocs_Click);
            this.listOfDocs.TextChanged += new System.EventHandler(this.listOfDocs_TextChanged);
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(378, 56);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(380, 22);
            this.warning_label.TabIndex = 6;
            this.warning_label.Text = "ВНИМАНИЕ: сначала выберите отделение!";
            // 
            // select_label
            // 
            this.select_label.AutoSize = true;
            this.select_label.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.select_label.Location = new System.Drawing.Point(356, 16);
            this.select_label.Name = "select_label";
            this.select_label.Size = new System.Drawing.Size(405, 32);
            this.select_label.TabIndex = 7;
            this.select_label.Text = "Как вы хотите найти карту?";
            // 
            // PatName
            // 
            this.PatName.AutoSize = true;
            this.PatName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatName.Location = new System.Drawing.Point(201, 50);
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(99, 23);
            this.PatName.TabIndex = 8;
            this.PatName.Text = "По Ф.И.О";
            this.PatName.UseVisualStyleBackColor = true;
            this.PatName.Click += new System.EventHandler(this.PatName_Click);
            // 
            // Born_year
            // 
            this.Born_year.AutoSize = true;
            this.Born_year.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Born_year.Location = new System.Drawing.Point(588, 51);
            this.Born_year.Name = "Born_year";
            this.Born_year.Size = new System.Drawing.Size(171, 23);
            this.Born_year.TabIndex = 9;
            this.Born_year.Text = "По году рождения";
            this.Born_year.UseVisualStyleBackColor = true;
            this.Born_year.Click += new System.EventHandler(this.Born_year_Click);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Address.Location = new System.Drawing.Point(306, 50);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(108, 23);
            this.Address.TabIndex = 10;
            this.Address.Text = "По адресу";
            this.Address.UseVisualStyleBackColor = true;
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // Card_num
            // 
            this.Card_num.AutoSize = true;
            this.Card_num.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Card_num.Location = new System.Drawing.Point(420, 51);
            this.Card_num.Name = "Card_num";
            this.Card_num.Size = new System.Drawing.Size(162, 23);
            this.Card_num.TabIndex = 11;
            this.Card_num.Text = "По номеру карты";
            this.Card_num.UseVisualStyleBackColor = true;
            this.Card_num.Click += new System.EventHandler(this.Card_num_Click);
            // 
            // Coming_Date
            // 
            this.Coming_Date.AutoSize = true;
            this.Coming_Date.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Coming_Date.Location = new System.Drawing.Point(765, 51);
            this.Coming_Date.Name = "Coming_Date";
            this.Coming_Date.Size = new System.Drawing.Size(162, 23);
            this.Coming_Date.TabIndex = 12;
            this.Coming_Date.Text = "По дате прихода";
            this.Coming_Date.UseVisualStyleBackColor = true;
            this.Coming_Date.Click += new System.EventHandler(this.Coming_Date_Click);
            // 
            // Doctors_Name
            // 
            this.Doctors_Name.AutoSize = true;
            this.Doctors_Name.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Doctors_Name.Location = new System.Drawing.Point(502, 80);
            this.Doctors_Name.Name = "Doctors_Name";
            this.Doctors_Name.Size = new System.Drawing.Size(99, 23);
            this.Doctors_Name.TabIndex = 13;
            this.Doctors_Name.Text = "По врачу";
            this.Doctors_Name.UseVisualStyleBackColor = true;
            this.Doctors_Name.Click += new System.EventHandler(this.Doctors_Name_Click);
            // 
            // main_table
            // 
            this.main_table.Enabled = false;
            this.main_table.Location = new System.Drawing.Point(10, 209);
            this.main_table.Name = "main_table";
            this.main_table.Size = new System.Drawing.Size(1029, 308);
            this.main_table.TabIndex = 14;
            this.main_table.Visible = false;
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel_button.Location = new System.Drawing.Point(555, 109);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(91, 34);
            this.cancel_button.TabIndex = 15;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // content_panel
            // 
            this.content_panel.Controls.Add(this.clear_button);
            this.content_panel.Controls.Add(this.search_label);
            this.content_panel.Controls.Add(this.search_textBox);
            this.content_panel.Controls.Add(this.main_table);
            this.content_panel.Controls.Add(this.cancel_button);
            this.content_panel.Controls.Add(this.select_label);
            this.content_panel.Controls.Add(this.PatName);
            this.content_panel.Controls.Add(this.Doctors_Name);
            this.content_panel.Controls.Add(this.Born_year);
            this.content_panel.Controls.Add(this.Coming_Date);
            this.content_panel.Controls.Add(this.Address);
            this.content_panel.Controls.Add(this.Card_num);
            this.content_panel.Enabled = false;
            this.content_panel.Location = new System.Drawing.Point(12, 82);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(1053, 528);
            this.content_panel.TabIndex = 16;
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(438, 109);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(91, 34);
            this.clear_button.TabIndex = 18;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_label.Location = new System.Drawing.Point(279, 165);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(135, 19);
            this.search_label.TabIndex = 17;
            this.search_label.Text = "Введите текст:";
            // 
            // search_textBox
            // 
            this.search_textBox.Enabled = false;
            this.search_textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search_textBox.Location = new System.Drawing.Point(420, 162);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(362, 26);
            this.search_textBox.TabIndex = 16;
            this.search_textBox.TextChanged += new System.EventHandler(this.search_textBox_TextChanged);
            // 
            // посмотретьСправкуToolStripMenuItem
            // 
            this.посмотретьСправкуToolStripMenuItem.Name = "посмотретьСправкуToolStripMenuItem";
            this.посмотретьСправкуToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.посмотретьСправкуToolStripMenuItem.Text = "Посмотреть справку";
            this.посмотретьСправкуToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСправкуToolStripMenuItem_Click);
            // 
            // Search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 622);
            this.Controls.Add(this.content_panel);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.control_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Search_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.Search_Form_Load);
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).EndInit();
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip control_panel;
        private System.Windows.Forms.ToolStripMenuItem dataBaseMenu;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripComboBox listOfDocs;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Label select_label;
        private System.Windows.Forms.RadioButton PatName;
        private System.Windows.Forms.RadioButton Born_year;
        private System.Windows.Forms.RadioButton Address;
        private System.Windows.Forms.RadioButton Card_num;
        private System.Windows.Forms.RadioButton Coming_Date;
        private System.Windows.Forms.RadioButton Doctors_Name;
        private System.Windows.Forms.DataGridView main_table;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСправкуToolStripMenuItem;
    }
}