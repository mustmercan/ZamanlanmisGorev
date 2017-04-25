using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanlanmisGorev.Common.Model
{
    public class Gorev
    {
        public string Ad { get; set; }
        public string Uygulama { get; set; }
        public string Parametreler { get; set; }
        public TimeSpan AcilisZamani { get; set; }
        public TimeSpan KapanisZamani { get; set; }
        public List<DayOfWeek> AktifGunler { get; set; }
        public Boolean OncesiniKapat { get; set; }
        public Boolean? Calisiyor { get; set; }
        public int? Sira { get; set; }
    }
}
