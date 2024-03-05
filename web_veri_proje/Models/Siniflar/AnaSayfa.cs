using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_veri_proje.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int ID { get; set; }
        public String Baslik { get; set; }
        public string Aciklama { get; set; }

    }
}