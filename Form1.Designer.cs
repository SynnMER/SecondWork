namespace SecondWork
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьБдToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьТаблицыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сохрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dgAutor = new System.Windows.Forms.DataGridView();
            this.dgBooks = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьБДToolStripMenuItem,
            this.создатьТаблицыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьБДToolStripMenuItem
            // 
            this.выбратьБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьБдToolStripMenuItem1});
            this.выбратьБДToolStripMenuItem.Name = "выбратьБДToolStripMenuItem";
            this.выбратьБДToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.выбратьБДToolStripMenuItem.Text = "Файл";
            // 
            // выбратьБдToolStripMenuItem1
            // 
            this.выбратьБдToolStripMenuItem1.Name = "выбратьБдToolStripMenuItem1";
            this.выбратьБдToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.выбратьБдToolStripMenuItem1.Text = "выбрать бд";
            this.выбратьБдToolStripMenuItem1.Click += new System.EventHandler(this.выбратьБдToolStripMenuItem1_Click);
            // 
            // создатьТаблицыToolStripMenuItem
            // 
            this.создатьТаблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьТаблицыToolStripMenuItem1,
            this.сохрToolStripMenuItem});
            this.создатьТаблицыToolStripMenuItem.Name = "создатьТаблицыToolStripMenuItem";
            this.создатьТаблицыToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.создатьТаблицыToolStripMenuItem.Text = "Правка";
            // 
            // создатьТаблицыToolStripMenuItem1
            // 
            this.создатьТаблицыToolStripMenuItem1.Name = "создатьТаблицыToolStripMenuItem1";
            this.создатьТаблицыToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.создатьТаблицыToolStripMenuItem1.Text = "СоздатьТаблицы";
            this.создатьТаблицыToolStripMenuItem1.Click += new System.EventHandler(this.создатьТаблицыToolStripMenuItem1_Click);
            // 
            // сохрToolStripMenuItem
            // 
            this.сохрToolStripMenuItem.Name = "сохрToolStripMenuItem";
            this.сохрToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сохрToolStripMenuItem.Text = "Сохранить изменения";
            this.сохрToolStripMenuItem.Click += new System.EventHandler(this.сохрToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dgAutor
            // 
            this.dgAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutor.Location = new System.Drawing.Point(0, 27);
            this.dgAutor.Name = "dgAutor";
            this.dgAutor.Size = new System.Drawing.Size(319, 424);
            this.dgAutor.TabIndex = 3;
            // 
            // dgBooks
            // 
            this.dgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBooks.Location = new System.Drawing.Point(349, 27);
            this.dgBooks.Name = "dgBooks";
            this.dgBooks.Size = new System.Drawing.Size(451, 424);
            this.dgBooks.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgBooks);
            this.Controls.Add(this.dgAutor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьБдToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьТаблицыToolStripMenuItem1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dgAutor;
        private System.Windows.Forms.DataGridView dgBooks;
        private System.Windows.Forms.ToolStripMenuItem сохрToolStripMenuItem;
    }
}

