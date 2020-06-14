using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcKütüphane.Models.Entity;//bu clasın amacı vitrin sayfasına iki ayrı tablodan veri çekecek olmam
namespace MvcKütüphane.Models.Siniflarim
{
    public class Class1
    {
        public IEnumerable<TBLKITAP> Deger1 { get; set; }
        public IEnumerable<TBLHAKKIMIZDA> Deger2 { get; set; }
    }
}