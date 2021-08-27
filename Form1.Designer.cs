
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
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfDocs = new System.Windows.Forms.ToolStripComboBox();
            this.поискКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеКартыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.main_table)).BeginInit();
            this.control_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_table
            // 
            this.main_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_table.Location = new System.Drawing.Point(12, 43);
            this.main_table.Name = "main_table";
            this.main_table.Size = new System.Drawing.Size(609, 478);
            this.main_table.TabIndex = 0;
            this.main_table.Visible = false;
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
            this.control_panel.Size = new System.Drawing.Size(871, 31);
            this.control_panel.TabIndex = 1;
            this.control_panel.Text = "menuStrip1";
            this.control_panel.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.control_panel_ItemClicked);
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
            // reference
            // 
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 23);
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
            this.listOfDocs.Click += new System.EventHandler(this.listOfDocs_Click);
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
            this.обновитьТаблицуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обновитьТаблицуToolStripMenuItem.Text = "Обновить таблицу";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 533);
            this.Controls.Add(this.main_table);
            this.Controls.Add(this.control_panel);
            this.MainMenuStrip = this.control_panel;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

