using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSayfam.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Resim { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public DateTime eklenmeTarihi { get; set; }
        public bool IsHomepage { get; set; }


    }
}