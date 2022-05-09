using CodeFirstWin.Entities;
using CodeFirstWin1.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirstWin1
{
    public partial class Form1 : Form
    {
        PostgreContext postgredb;
        public Form1()
        {
            InitializeComponent();
            postgredb = new PostgreContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategori kategori = new Kategori();
            kategori.KategoriName = textBox1.Text;
            kategori.Acıklama = textBox2.Text;
            kategori.CreateFate = DateTime.Now;
            postgredb.Kategoriler.Add(kategori);
            postgredb.SaveChanges();
            dataGridView1.DataSource = postgredb.Kategoriler.ToList();
        }
    }
}
