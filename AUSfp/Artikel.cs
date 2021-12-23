using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUSfp
{
    public class Artikel
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public string Categorie { get; set; }

        public string Lener { get; set; }

        public DateTime? Inleverdatum { get; set; }
        
        public int Status { get; set; }

        public string StatusString { get; set; }
        
        public int? Leerlingnummer { get; set; }
        
        public string Beschrijving { get; set; }
        
        public string Toevoeger { get; set; }

        public DateTime? ToegevoegdOp { get; set; }

        public string img { get; set; }

    }
}
