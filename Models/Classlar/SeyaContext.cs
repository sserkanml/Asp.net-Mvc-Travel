using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Travel.Models.Classlar
{
    public class SeyaContext : DbContext
    {
        public DbSet<Yorumlar> Yorumlars { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Adres> Adresses { get; set; }

        public DbSet<İletisim> iletisims { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
    }
}