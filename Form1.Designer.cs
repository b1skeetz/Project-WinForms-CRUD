﻿
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_table = new System.Windows.Forms.DataGridView();
            this.control_panel = new System.Windows.Forms.MenuStrip();
            this.dataBaseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.поискКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDocs = new System.Windows.Forms.ToolStripComboBox();
            this.warning_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.searchBy_comboBox = new System.Windows.Forms.ComboBox();
            this.searchBy_label = new System.Windows.Forms.Label();
            this.searchBy_textBox = new System.Windows.Forms.TextBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).BeginInit();
            this.control_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_table
            // 
            this.main_table.Location = new System.Drawing.Point(12, 85);
            this.main_table.Name = "main_table";
            this.main_table.Size = new System.Drawing.Size(988, 512);
            this.main_table.TabIndex = 0;
            this.main_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_table_CellClick);
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
            this.control_panel.Size = new System.Drawing.Size(1222, 31);
            this.control_panel.TabIndex = 1;
            this.control_panel.Text = "menuStrip1";
            // 
            // dataBaseMenu
            // 
            this.dataBaseMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискКартыToolStripMenuItem,
            this.добавлениеКартыToolStripMenuItem,
            this.обновитьТаблицуToolStripMenuItem});
            this.dataBaseMenu.Name = "dataBaseMenu";
            this.dataBaseMenu.Size = new System.Drawing.Size(57, 27);
            this.dataBaseMenu.Text = "База";
            // 
            // поискКартыToolStripMenuItem
            // 
            this.поискКартыToolStripMenuItem.Name = "поискКартыToolStripMenuItem";
            this.поискКартыToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.поискКартыToolStripMenuItem.Text = "Поиск карты ";
            this.поискКартыToolStripMenuItem.Click += new System.EventHandler(this.поискКартыToolStripMenuItem_Click);
            // 
            // добавлениеКартыToolStripMenuItem
            // 
            this.добавлениеКартыToolStripMenuItem.Name = "добавлениеКартыToolStripMenuItem";
            this.добавлениеКартыToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.добавлениеКартыToolStripMenuItem.Text = "Добавление карты";
            this.добавлениеКартыToolStripMenuItem.Click += new System.EventHandler(this.добавлениеКартыToolStripMenuItem_Click);
            // 
            // обновитьТаблицуToolStripMenuItem
            // 
            this.обновитьТаблицуToolStripMenuItem.Name = "обновитьТаблицуToolStripMenuItem";
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            this.обновитьТаблицуToolStripMenuItem.Visible = false;
            this.обновитьТаблицуToolStripMenuItem.Click += new System.EventHandler(this.обновитьТаблицуToolStripMenuItem_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьСправкуToolStripMenuItem});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(84, 27);
            this.reference.Text = "Справка";
            // 
            // посмотретьСправкуToolStripMenuItem
            // 
            this.посмотретьСправкуToolStripMenuItem.Name = "посмотретьСправкуToolStripMenuItem";
            this.посмотретьСправкуToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.посмотретьСправкуToolStripMenuItem.Text = "Посмотреть справку";
            this.посмотретьСправкуToolStripMenuItem.Click += new System.EventHandler(this.посмотретьСправкуToolStripMenuItem_Click);
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
            // warning_label
            // 
            this.warning_label.AutoSize = true;
            this.warning_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(412, 49);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(380, 22);
            this.warning_label.TabIndex = 5;
            this.warning_label.Text = "ВНИМАНИЕ: сначала выберите отделение!";
            // 
            // delete_button
            // 
            this.delete_button.Enabled = false;
            this.delete_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button.Location = new System.Drawing.Point(1034, 464);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(158, 37);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Enabled = false;
            this.edit_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_button.Location = new System.Drawing.Point(1034, 412);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(158, 37);
            this.edit_button.TabIndex = 7;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // searchBy_comboBox
            // 
            this.searchBy_comboBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBy_comboBox.FormattingEnabled = true;
            this.searchBy_comboBox.Location = new System.Drawing.Point(1034, 151);
            this.searchBy_comboBox.Name = "searchBy_comboBox";
            this.searchBy_comboBox.Size = new System.Drawing.Size(158, 27);
            this.searchBy_comboBox.TabIndex = 8;
            this.searchBy_comboBox.TextChanged += new System.EventHandler(this.searchBy_comboBox_TextChanged);
            // 
            // searchBy_label
            // 
            this.searchBy_label.AutoSize = true;
            this.searchBy_label.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBy_label.Location = new System.Drawing.Point(1061, 115);
            this.searchBy_label.Name = "searchBy_label";
            this.searchBy_label.Size = new System.Drawing.Size(99, 19);
            this.searchBy_label.TabIndex = 9;
            this.searchBy_label.Text = " Поиск по:";
            // 
            // searchBy_textBox
            // 
            this.searchBy_textBox.Enabled = false;
            this.searchBy_textBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBy_textBox.Location = new System.Drawing.Point(1034, 192);
            this.searchBy_textBox.Name = "searchBy_textBox";
            this.searchBy_textBox.Size = new System.Drawing.Size(158, 26);
            this.searchBy_textBox.TabIndex = 11;
            this.searchBy_textBox.TextChanged += new System.EventHandler(this.searchBy_textBox_TextChanged);
            // 
            // clear_button
            // 
            this.clear_button.Enabled = false;
            this.clear_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_button.Location = new System.Drawing.Point(1034, 237);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(158, 37);
            this.clear_button.TabIndex = 12;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Enabled = false;
            this.reset_button.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reset_button.Location = new System.Drawing.Point(1034, 519);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(158, 37);
            this.reset_button.TabIndex = 13;
            this.reset_button.Text = "Сбросить";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1222, 623);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.searchBy_textBox);
            this.Controls.Add(this.searchBy_label);
            this.Controls.Add(this.searchBy_comboBox);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.main_table);
            this.Controls.Add(this.control_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.control_panel;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рецепшн";
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).EndInit();
            this.control_panel.ResumeLayout(false);
            this.control_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView main_table;
        private System.Windows.Forms.MenuStrip control_panel;
        private System.Windows.Forms.ToolStripMenuItem dataBaseMenu;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem поискКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКартыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox listOfDocs;
        private System.Windows.Forms.Label warning_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.ComboBox searchBy_comboBox;
        private System.Windows.Forms.Label searchBy_label;
        private System.Windows.Forms.TextBox searchBy_textBox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСправкуToolStripMenuItem;
        private System.Windows.Forms.Button reset_button;
    }
}

