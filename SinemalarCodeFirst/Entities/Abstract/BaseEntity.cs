using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemalarCodeFirst.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
