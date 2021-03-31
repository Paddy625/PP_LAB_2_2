using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PP_LAB_2_2
{
    public class records : DbContext
    {
        public virtual DbSet<currency> currencies { get; set; }
    }
}
