using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Xml;

namespace SecondWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SQLiteConnection conn;

        private void выбратьБдToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string filename;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                conn = new SQLiteConnection("DataSource=" + filename);
                conn.Open();
                string sqltext = "select name from sqlite_master where type ='table'";
                SQLiteCommand cmd = new SQLiteCommand(sqltext, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                //создатьТаблицыToolStripMenuItem.Enabled = !reader.HasRows;
                conn.Close();
                FillAutors();
                FillBooks();
            }
        }

        private void создатьТаблицыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string sqltext = "create table Autors (id int primary key, name varchar(20),description varchar(100));" +
                "create table Books( id int primary key,id_Autor int, name varchar(20),description varchar(100));";
            SQLiteCommand cmd = new SQLiteCommand(sqltext,conn);
            //cmd.Connection = conn; - можно и без нее
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            создатьТаблицыToolStripMenuItem.Enabled = false;
        }
        private DataTable dtAutor;
        private DataTable dtBooks;
        private SQLiteDataAdapter adAutor;
        private SQLiteDataAdapter adBooks;
        private void FillAutors()
        {
            string sqltext="select * from autors";
            adAutor = new SQLiteDataAdapter(sqltext,conn);
            SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adAutor);
            dtAutor = new DataTable();
            adAutor.Fill(dtAutor);
            dgAutor.DataSource = dtAutor;
        }
        private void FillBooks()
        {
            string sqltext = "select * from Books";
            dtBooks = new DataTable();
            adBooks = new SQLiteDataAdapter(sqltext, conn);
            SQLiteCommandBuilder cb1 = new SQLiteCommandBuilder(adBooks);
            adBooks.Fill(dtBooks);
            dgBooks.DataSource = dtBooks;
        }
        private void сохрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adAutor.Update(dtAutor);
            adBooks.Update(dtBooks);
        }

    }
}
