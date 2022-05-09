using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Entities
{
    public class Kategori
    {
        public int Id { get; set; }
        public string KategoriName { get; set; }
        public string Acıklama { get; set; }
        public List<Stok> Stoklar { get; set; }
    }
}
