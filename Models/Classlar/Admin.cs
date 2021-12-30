using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models.Classlar
{
    public class Admin
    {
        
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Password { get; set; }
    }
}