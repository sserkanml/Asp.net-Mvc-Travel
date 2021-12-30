using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models.Classlar
{
    public class Adres
    {
       
        public int Id {
           set ; get; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }

        public string AdresAcik { get; set; }

        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Konum { get; set; }



    }
}