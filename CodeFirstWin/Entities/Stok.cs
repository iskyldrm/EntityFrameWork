using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Entities
{
    public class Stok
    {
        public int Id { get; set; }
        public string StokAdi { get; set; }
        public string StokAciklama { get; set; }
        public Kategori Kategori { get; set; }

    }
}
