using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSayfam.Models
{
    public class BlogModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }

        public int BlogSayisi { get; set; }
        public DateTime eklenmeTarihi { get; set; }
    }
}