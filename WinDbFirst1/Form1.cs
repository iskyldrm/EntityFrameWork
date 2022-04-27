using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbFirst1
{
    public partial class Form1 : Form
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        public Form1()
        {
            InitializeComponent();
            refreshgrid();
            
        }
        
        public void refreshgrid()
        {
            dataGridView1.DataSource = db.Shippers.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            Shippers shippers = new Shippers(); 
            shippers.Phone = textBox2.Text; 
            shippers.CompanyName = textBox1.Text; 
            db.Shippers.Add(shippers); 
            db.SaveChanges();
            refreshgrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. yol

            int shipperId = int.Parse(textBox3.Text);

            var shipper = db.Shippers.Where(x => x.ShipperID == shipperId).FirstOrDefault();
            //shipper.Phone = "649846 498 664 46 ";
            //db.SaveChanges();

            //2. yol

            var silinen = db.Shippers.Find(shipperId);
            if (shipper != null)
            {
                shipper.Phone = " 89998899899898";
            }
            db.Entry<Shippers>(shipper).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            refreshgrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1yolll
            int shipperId = int.Parse(textBox3.Text);
            //var silinen = db.Shippers.Find(shipperId);
            //db.Shippers.Remove(silinen);
            //db.SaveChanges();

            //2yollll
            var silinen = db.Shippers.Find(shipperId);
            db.Entry<Shippers>(silinen).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            refreshgrid();

        }
    }
}
