﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Models.Classlar
{
    public class Hakkimizda
    {
       
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}