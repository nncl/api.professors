using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.AplicativoMOB
{
    public class MobDbContext : DbContext
    {
        public MobDbContext() : base("name=FiapConnection") { }

        public System.Data.Entity.DbSet<API.AplicativoMOB.Models.Professor> Professors { get; set; }
    }
}