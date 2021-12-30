using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models.Classlar
{
    public class Blog
    {
       
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}