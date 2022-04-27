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
    public partial class iliskilikayitlar : Form
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        public iliskilikayitlar()
        {
            InitializeComponent();
        }
        private void iliskilikayitlar_Load(object sender, EventArgs e)
         {
            dataGridView1.DataSource = db.Customers.ToList();        

         }              
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            string CustumerId = row.Cells[0].Value.ToString();


            var orderResult = db.Orders.Where(o => o.CustomerID == CustumerId);

            dataGridView2.DataSource = orderResult.ToList();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DataGridViewRow row = dataGridView2.Rows[rowIndex];

            int orderId = (int)row.Cells[0].Value;


            var orderResult = db.Order_Details.Where(o => o.OrderID == orderId);

            dataGridView3.DataSource = orderResult.ToList();

        }
    }
}
