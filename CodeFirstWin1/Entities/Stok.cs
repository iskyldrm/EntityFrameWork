using CodeFirstWin1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Entities
{
    public class Stok:BaseEntity
    {
        
        public string StokAdi { get; set; }
        public string StokAciklama { get; set; }
        public List<Kategori> Kategori { get; set; }

    }

    
}
