using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.SqlServer;

namespace WinDbFirst1
{
    public partial class EFSorgular : Form
    {
        NorthwindEntities1 db = new NorthwindEntities1();
        public EFSorgular()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region soru
            //Fiyatı 20 ile 50 arasından olan stokların ıd,urunadı,fiyatı,stokları gelsin
            #endregion


            #region Linq to SQL(METHOT YONTEMİ)
            //var query = db.Products
            //    .Where(x => x.UnitPrice >= 20 && x.UnitPrice <= 50)
            //    .Select(p => new
            //    {
            //        p.ProductID,
            //        p.ProductName,
            //        p.UnitPrice,
            //        p.QuantityPerUnit
            //    });
            //query.OrderBy(x => x.ProductName);


            //dataGridView1.DataSource = query.ToList();
            #endregion

            #region SQL
            var query2 = from p in db.Products
                         where p.UnitPrice >= 20 && p.UnitPrice <= 51
                         select new
                         {
                             p.ProductID,
                             p.ProductName,
                             p.UnitPrice,
                             p.QuantityPerUnit
                         };
            dataGridView1.DataSource = query2.ToList();
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region soru2
            // siparişler tablosundan musteri sirketadi,çalışan adı,calısan soyadı,siparişıd,spariş tarihi,kargo çşirketi
            #endregion

            //db.Services.Join(db.ServiceAssignments,
            //     s => s.Id,
            //     sa => sa.ServiceId,
            //     (s, sa) => new { service = s, asgnmt = sa })
            //.Where(ssa => ssa.asgnmt.LocationId == 1)
            //.Select(ssa => ssa.service);

            #region LINQ TO METHOD
            var result = db.Orders.Select(p => new
            {
                MusteriAdı = p.Customers.CompanyName,
                CalsıanAdı = p.Employees.FirstName,
                calsanSoyad = p.Employees.LastName,
                siparişId = p.OrderID,
                sipariştarihi = p.OrderDate,
                kargo = p.Shippers.CompanyName
            });

            dataGridView1.DataSource = result.ToList();
            #endregion




        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region soru3
            // müşterilerimin isimlerinde Restaurante yazan kaç kişş var Restaurante
            #endregion

            //var guery3 = db.Customers.Where(p => p.CompanyName.Contains("Restaurante"));

            //dataGridView1.DataSource = guery3.ToList();

            //LINQ TO SQL

            var result = from p in db.Customers
                         where p.CompanyName.Contains("Restaurante")
                         select p;

            dataGridView1.DataSource = result.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Kategoriys, SeaFood olan Midyedolma urunu product tablosuna
            //fiyatı 3,5 adetii 50 tane oalrak şekilde ekleyin.Where(x => x.CategoryName == "SeaFood").FirstOrDefault();

            Products products = new Products();
            products.ProductName = "Midye Dolma";
            products.UnitPrice = 3.5m;
            products.UnitsInStock = 50;
            var cat = db.Categories.Where(x => x.CategoryName == "SeaFood").FirstOrDefault();

            products.CategoryID = cat.CategoryID;

            db.Products.Add(products);
            db.SaveChanges();


            //2.yol

            db.Products.Add(new Products
            {
                ProductName = "Kokoreç",
                UnitPrice = 30,
                UnitsInStock = 0,
                CategoryID = db.Categories.Where(c => c.CategoryName == "SeaFood").FirstOrDefault().CategoryID

            });

            db.SaveChanges();


            //3.yol
            db.Categories
                .Where(c => c.CategoryName == "SeaFood")
                .FirstOrDefault()
                .Products.Add(new Products
                {
                    ProductName = "Kola",
                    UnitPrice = 30,
                    UnitsInStock = 0,
                });

            db.SaveChanges();



        }

        private void button5_Click(object sender, EventArgs e)
        {
            var guery = db.Employees.Select(p => new
            {
                ÇalışanAdı = p.FirstName,
                Soyadı = p.LastName,
                DoğumTarihi = p.BirthDate,
                yas = SqlFunctions.DateDiff("year",p.BirthDate,DateTime.Now)
                

            }
            );

            dataGridView1.DataSource = guery.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region Kategoirlerine göre ürün sayısı
            var result = db.Products
                .GroupBy(p => p.Categories.CategoryName)
                .Select(g => new
                {
                    kategoriADI = g.Key,
                    Toplastok = g.Sum(q => q.UnitsInStock)
                });

            dataGridView1.DataSource = result.ToList();

            #endregion
        }
    }
}
