
namespace Project
{
    partial class Form_Add
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
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDocs = new System.Windows.Forms.ToolStripComboBox();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьБазуДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel = new System.Windows.Forms.Panel();
            this.visit_textBox = new System.Windows.Forms.TextBox();
            this.visit_label = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.others_textBox = new System.Windows.Forms.TextBox();
            this.others_label = new System.Windows.Forms.Label();
            this.doc_comboBox = new System.Windows.Forms.ComboBox();
            this.doc_label = new System.Windows.Forms.Label();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.address_label = new System.Windows.Forms.Label();
            this.years_comboBox = new System.Windows.Forms.ComboBox();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.born_Label = new System.Windows.Forms.Label();
            this.fio_Label = new System.Windows.Forms.Label();
            this.warning_label = new System.Windows.Forms.Label();
            this.control_panel.SuspendLayout();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // control_panel
            // 
            this.control_panel.BackColor = System.Drawing.Color.NavajoWhite;
            this.control_panel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.control_panel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseMenu,
            this.reference,
            this.listOfDocs,
            this.настройкиToolStripMenuItem});
            this.control_panel.Location = new System.Drawing.Point(0, 0);
            this.control_panel.Name = "control_panel";
            this.control_panel.Size = new System.Drawing.Size(800, 31);
            this.control_panel.TabIndex = 2;
            this.control_panel.Text = "menuStrip1";
            // 
            // dataBaseMenu
            // 
            this.dataBaseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.поискКартыToolStripMenuItem,
            this.отменаToolStripMenuItem});
            this.dataBaseMenu.Name = "dataBaseMenu";
            this.dataBaseMenu.Size = new System.Drawing.Size(57, 27);
            this.dataBaseMenu.Text = "База";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // поискКартыToolStripMenuItem
            // 
            this.поискКартыToolStripMenuItem.Name = "поискКартыToolStripMenuItem";
            this.поискКартыToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.поискКартыToolStripMenuItem.Text = "Поиск карты ";
            // 
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // reference
            // 
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
            this.listOfDocs.TextChanged += new System.EventHandler(this.listOfDocs_TextChanged);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьБазуДанныхToolStripMenuItem,
            this.создатьТаблицуToolStripMenuItem,
            this.удалитьТаблицуToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // создатьБазуДанныхToolStripMenuItem
            // 
            this.создатьБазуДанныхToolStripMenuItem.Name = "создатьБазуДанныхToolStripMenuItem";
            this.создатьБазуДанныхToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.создатьБазуДанныхToolStripMenuItem.Text = "Создать базу данных";
            // 
            // создатьТаблицуToolStripMenuItem
            // 
            this.создатьТаблицуToolStripMenuItem.Name = "создатьТаблицуToolStripMenuItem";
            this.создатьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.создатьТаблицуToolStripMenuItem.Text = "Создать таблицу";
            // 
            // удалитьТаблицуToolStripMenuItem
            // 
            this.удалитьТаблицуToolStripMenuItem.Name = "удалитьТаблицуToolStripMenuItem";
            this.удалитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.удалитьТаблицуToolStripMenuItem.Text = "Удалить таблицу";
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.visit_textBox);
            this.main_panel.Controls.Add(this.visit_label);
            this.main_panel.Controls.Add(this.clear_button);
            this.main_panel.Controls.Add(this.save_button);
            this.main_panel.Controls.Add(this.others_textBox);
            this.main_panel.Controls.Add(this.others_label);
            this.main_panel.Controls.Add(this.doc_comboBox);
            this.main_panel.Controls.Add(this.doc_label);
            this.main_panel.Controls.Add(this.number_textBox);
            this.main_panel.Controls.Add(this.number_label);
            this.main_panel.Controls.Add(this.address_textBox);
            this.main_panel.Controls.Add(this.address_label);
            this.main_panel.Controls.Add(this.years_comboBox);
            this.main_panel.Controls.Add(this.fio_textBox);
            this.main_panel.Controls.Add(this.born_Label);
            this.main_panel.Controls.Add(this.fio_Label);
            this.main_panel.Enabled = false;
            this.main_panel.Location = new System.Drawing.Point(38, 83);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(721, 340);
            this.main_panel.TabIndex = 3;
            // 
            // visit_textBox
            // 
            this.visit_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visit_textBox.Location = new System.Drawing.Point(182, 149);
            this.visit_textBox.Name = "visit_textBox";
            this.visit_textBox.Size = new System.Drawing.Size(493, 25);
            this.visit_textBox.TabIndex = 18;
            this.visit_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // visit_label
            // 
            this.visit_label.AutoSize = true;
            this.visit_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visit_label.Location = new System.Drawing.Point(31, 149);
            this.visit_label.Name = "visit_label";
            this.visit_label.Size = new System.Drawing.Size(104, 18);
            this.visit_label.TabIndex = 17;
            this.visit_label.Text = "Дата прихода";
            this.visit_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(392, 244);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(94, 33);
            this.clear_button.TabIndex = 16;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(264, 244);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(94, 33);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Добавить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // others_textBox
            // 
            this.others_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.others_textBox.Location = new System.Drawing.Point(182, 180);
            this.others_textBox.Name = "others_textBox";
            this.others_textBox.Size = new System.Drawing.Size(493, 25);
            this.others_textBox.TabIndex = 11;
            // 
            // others_label
            // 
            this.others_label.AutoSize = true;
            this.others_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.others_label.Location = new System.Drawing.Point(31, 180);
            this.others_label.Name = "others_label";
            this.others_label.Size = new System.Drawing.Size(64, 18);
            this.others_label.TabIndex = 10;
            this.others_label.Text = "Другое:";
            // 
            // doc_comboBox
            // 
            this.doc_comboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc_comboBox.FormattingEnabled = true;
            this.doc_comboBox.Location = new System.Drawing.Point(392, 116);
            this.doc_comboBox.Name = "doc_comboBox";
            this.doc_comboBox.Size = new System.Drawing.Size(283, 26);
            this.doc_comboBox.TabIndex = 9;
            // 
            // doc_label
            // 
            this.doc_label.AutoSize = true;
            this.doc_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc_label.Location = new System.Drawing.Point(330, 119);
            this.doc_label.Name = "doc_label";
            this.doc_label.Size = new System.Drawing.Size(48, 18);
            this.doc_label.TabIndex = 8;
            this.doc_label.Text = "Врач:";
            // 
            // number_textBox
            // 
            this.number_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textBox.Location = new System.Drawing.Point(182, 116);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(121, 25);
            this.number_textBox.TabIndex = 7;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_label.Location = new System.Drawing.Point(31, 116);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(112, 18);
            this.number_label.TabIndex = 6;
            this.number_label.Text = "Номер карты: ";
            // 
            // address_textBox
            // 
            this.address_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_textBox.Location = new System.Drawing.Point(392, 78);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(283, 25);
            this.address_textBox.TabIndex = 5;
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_label.Location = new System.Drawing.Point(330, 81);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(56, 18);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Адрес:";
            // 
            // years_comboBox
            // 
            this.years_comboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years_comboBox.FormattingEnabled = true;
            this.years_comboBox.Location = new System.Drawing.Point(182, 78);
            this.years_comboBox.Name = "years_comboBox";
            this.years_comboBox.Size = new System.Drawing.Size(121, 26);
            this.years_comboBox.TabIndex = 3;
            // 
            // fio_textBox
            // 
            this.fio_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(182, 43);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(493, 25);
            this.fio_textBox.TabIndex = 2;
            // 
            // born_Label
            // 
            this.born_Label.AutoSize = true;
            this.born_Label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.born_Label.Location = new System.Drawing.Point(31, 78);
            this.born_Label.Name = "born_Label";
            this.born_Label.Size = new System.Drawing.Size(120, 18);
            this.born_Label.TabIndex = 1;
            this.born_Label.Text = "Год рождения: ";
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_Label.Location = new System.Drawing.Point(31, 45);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(136, 18);
            this.fio_Label.TabIndex = 0;
            this.fio_Label.Text = "Ф.И.О. пациента:";
            // 
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(223, 68);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(380, 22);
            this.warning_label.TabIndex = 4;
            this.warning_label.Text = "ВНИМАНИЕ: сначала выберите отделение!";
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.control_panel);
            this.Name = "Form_Add";
            this.Text = "Form_Add";
            this.Load += new System.EventHandler(this.Form_Add_Load);
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip control_panel;
        private System.Windows.Forms.ToolStripMenuItem dataBaseMenu;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripComboBox listOfDocs;
        private System.Windows.Forms.ToolStripMenuItem поискКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменаToolStripMenuItem;
        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label fio_Label;
        private System.Windows.Forms.ComboBox years_comboBox;
        private System.Windows.Forms.TextBox fio_textBox;
        private System.Windows.Forms.Label born_Label;
        private System.Windows.Forms.Label number_label;
        private System.Windows.Forms.TextBox address_textBox;
        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox number_textBox;
        private System.Windows.Forms.TextBox others_textBox;
        private System.Windows.Forms.Label others_label;
        private System.Windows.Forms.ComboBox doc_comboBox;
        private System.Windows.Forms.Label doc_label;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox visit_textBox;
        private System.Windows.Forms.Label visit_label;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьБазуДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТаблицуToolStripMenuItem;
    }
}