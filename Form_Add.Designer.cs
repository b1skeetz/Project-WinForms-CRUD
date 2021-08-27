
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
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDocs = new System.Windows.Forms.ToolStripComboBox();
            this.отменаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_panel = new System.Windows.Forms.Panel();
            this.fio_Label = new System.Windows.Forms.Label();
            this.born_Label = new System.Windows.Forms.Label();
            this.fio_textBox = new System.Windows.Forms.TextBox();
            this.years_comboBox = new System.Windows.Forms.ComboBox();
            this.address_label = new System.Windows.Forms.Label();
            this.address_textBox = new System.Windows.Forms.TextBox();
            this.number_label = new System.Windows.Forms.Label();
            this.number_textBox = new System.Windows.Forms.TextBox();
            this.doc_comboBox = new System.Windows.Forms.ComboBox();
            this.doc_label = new System.Windows.Forms.Label();
            this.others_label = new System.Windows.Forms.Label();
            this.others_textBox = new System.Windows.Forms.TextBox();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.visit_textBox = new System.Windows.Forms.TextBox();
            this.visit_label = new System.Windows.Forms.Label();
            this.goldenCard_checkBox = new System.Windows.Forms.CheckBox();
            this.hospit_checkBox = new System.Windows.Forms.CheckBox();
            this.ref_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.listOfDocs});
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
            // reference
            // 
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(84, 27);
            this.reference.Text = "Справка";
            // 
            // listOfDocs
            // 
            this.listOfDocs.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.listOfDocs.BackColor = System.Drawing.Color.Plum;
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
            // отменаToolStripMenuItem
            // 
            this.отменаToolStripMenuItem.Name = "отменаToolStripMenuItem";
            this.отменаToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.отменаToolStripMenuItem.Text = "Отмена";
            this.отменаToolStripMenuItem.Click += new System.EventHandler(this.отменаToolStripMenuItem_Click);
            // 
            // поискКартыToolStripMenuItem
            // 
            this.поискКартыToolStripMenuItem.Name = "поискКартыToolStripMenuItem";
            this.поискКартыToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.поискКартыToolStripMenuItem.Text = "Поиск карты ";
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.ref_checkBox);
            this.main_panel.Controls.Add(this.hospit_checkBox);
            this.main_panel.Controls.Add(this.goldenCard_checkBox);
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
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fio_Label
            // 
            this.fio_Label.AutoSize = true;
            this.fio_Label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_Label.Location = new System.Drawing.Point(15, 17);
            this.fio_Label.Name = "fio_Label";
            this.fio_Label.Size = new System.Drawing.Size(136, 18);
            this.fio_Label.TabIndex = 0;
            this.fio_Label.Text = "Ф.И.О. пациента:";
            // 
            // born_Label
            // 
            this.born_Label.AutoSize = true;
            this.born_Label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.born_Label.Location = new System.Drawing.Point(15, 50);
            this.born_Label.Name = "born_Label";
            this.born_Label.Size = new System.Drawing.Size(120, 18);
            this.born_Label.TabIndex = 1;
            this.born_Label.Text = "Год рождения: ";
            // 
            // fio_textBox
            // 
            this.fio_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_textBox.Location = new System.Drawing.Point(166, 15);
            this.fio_textBox.Name = "fio_textBox";
            this.fio_textBox.Size = new System.Drawing.Size(493, 25);
            this.fio_textBox.TabIndex = 2;
            // 
            // years_comboBox
            // 
            this.years_comboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.years_comboBox.FormattingEnabled = true;
            this.years_comboBox.Location = new System.Drawing.Point(166, 50);
            this.years_comboBox.Name = "years_comboBox";
            this.years_comboBox.Size = new System.Drawing.Size(121, 26);
            this.years_comboBox.TabIndex = 3;
            this.years_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // address_label
            // 
            this.address_label.AutoSize = true;
            this.address_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_label.Location = new System.Drawing.Point(314, 53);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(56, 18);
            this.address_label.TabIndex = 4;
            this.address_label.Text = "Адрес:";
            // 
            // address_textBox
            // 
            this.address_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.address_textBox.Location = new System.Drawing.Point(376, 50);
            this.address_textBox.Name = "address_textBox";
            this.address_textBox.Size = new System.Drawing.Size(283, 25);
            this.address_textBox.TabIndex = 5;
            // 
            // number_label
            // 
            this.number_label.AutoSize = true;
            this.number_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_label.Location = new System.Drawing.Point(15, 88);
            this.number_label.Name = "number_label";
            this.number_label.Size = new System.Drawing.Size(112, 18);
            this.number_label.TabIndex = 6;
            this.number_label.Text = "Номер карты: ";
            // 
            // number_textBox
            // 
            this.number_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_textBox.Location = new System.Drawing.Point(166, 88);
            this.number_textBox.Name = "number_textBox";
            this.number_textBox.Size = new System.Drawing.Size(121, 25);
            this.number_textBox.TabIndex = 7;
            // 
            // doc_comboBox
            // 
            this.doc_comboBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc_comboBox.FormattingEnabled = true;
            this.doc_comboBox.Location = new System.Drawing.Point(376, 88);
            this.doc_comboBox.Name = "doc_comboBox";
            this.doc_comboBox.Size = new System.Drawing.Size(283, 26);
            this.doc_comboBox.TabIndex = 9;
            // 
            // doc_label
            // 
            this.doc_label.AutoSize = true;
            this.doc_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.doc_label.Location = new System.Drawing.Point(314, 91);
            this.doc_label.Name = "doc_label";
            this.doc_label.Size = new System.Drawing.Size(48, 18);
            this.doc_label.TabIndex = 8;
            this.doc_label.Text = "Врач:";
            // 
            // others_label
            // 
            this.others_label.AutoSize = true;
            this.others_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.others_label.Location = new System.Drawing.Point(15, 152);
            this.others_label.Name = "others_label";
            this.others_label.Size = new System.Drawing.Size(64, 18);
            this.others_label.TabIndex = 10;
            this.others_label.Text = "Другое:";
            // 
            // others_textBox
            // 
            this.others_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.others_textBox.Location = new System.Drawing.Point(166, 152);
            this.others_textBox.Name = "others_textBox";
            this.others_textBox.Size = new System.Drawing.Size(493, 25);
            this.others_textBox.TabIndex = 11;
            this.others_textBox.TextChanged += new System.EventHandler(this.others_textBox_TextChanged);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.Location = new System.Drawing.Point(252, 284);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(94, 33);
            this.save_button.TabIndex = 15;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(380, 284);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(94, 33);
            this.clear_button.TabIndex = 16;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // visit_textBox
            // 
            this.visit_textBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visit_textBox.Location = new System.Drawing.Point(166, 121);
            this.visit_textBox.Name = "visit_textBox";
            this.visit_textBox.Size = new System.Drawing.Size(493, 25);
            this.visit_textBox.TabIndex = 18;
            this.visit_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // visit_label
            // 
            this.visit_label.AutoSize = true;
            this.visit_label.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visit_label.Location = new System.Drawing.Point(15, 121);
            this.visit_label.Name = "visit_label";
            this.visit_label.Size = new System.Drawing.Size(104, 18);
            this.visit_label.TabIndex = 17;
            this.visit_label.Text = "Дата прихода";
            this.visit_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // goldenCard_checkBox
            // 
            this.goldenCard_checkBox.AutoSize = true;
            this.goldenCard_checkBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goldenCard_checkBox.Location = new System.Drawing.Point(258, 194);
            this.goldenCard_checkBox.Name = "goldenCard_checkBox";
            this.goldenCard_checkBox.Size = new System.Drawing.Size(219, 22);
            this.goldenCard_checkBox.TabIndex = 19;
            this.goldenCard_checkBox.Text = "Получил золотую карточку";
            this.goldenCard_checkBox.UseVisualStyleBackColor = true;
            // 
            // hospit_checkBox
            // 
            this.hospit_checkBox.AutoSize = true;
            this.hospit_checkBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hospit_checkBox.Location = new System.Drawing.Point(258, 222);
            this.hospit_checkBox.Name = "hospit_checkBox";
            this.hospit_checkBox.Size = new System.Drawing.Size(243, 22);
            this.hospit_checkBox.TabIndex = 20;
            this.hospit_checkBox.Text = "Отправлен на госпитализацию";
            this.hospit_checkBox.UseVisualStyleBackColor = true;
            // 
            // ref_checkBox
            // 
            this.ref_checkBox.AutoSize = true;
            this.ref_checkBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ref_checkBox.Location = new System.Drawing.Point(258, 250);
            this.ref_checkBox.Name = "ref_checkBox";
            this.ref_checkBox.Size = new System.Drawing.Size(139, 22);
            this.ref_checkBox.TabIndex = 21;
            this.ref_checkBox.Text = "Выдана справка";
            this.ref_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(223, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "ВНИМАНИЕ: сначала выберите отделение!";
            // 
            // Form_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.CheckBox hospit_checkBox;
        private System.Windows.Forms.CheckBox goldenCard_checkBox;
        private System.Windows.Forms.CheckBox ref_checkBox;
        private System.Windows.Forms.Label label1;
    }
}