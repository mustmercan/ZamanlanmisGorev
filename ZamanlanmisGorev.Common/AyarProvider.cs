using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ZamanlanmisGorev.Common.Model;

namespace ZamanlanmisGorev.Common
{
    public class AyarProvider
    {
        private string ayarDosyasi;
        public List<Gorev> GorevList
        {
            get
            {
                return AyarlariOku();
            }
            set
            {
                AyarlariYaz(value);
            }

        }
        public AyarProvider(string AyarDosyasi)
        {
            if (String.IsNullOrEmpty(AyarDosyasi))
            {
                throw new System.ArgumentException("AyarDosyası belirtilmeli"); 
            }
            else
            {
                ayarDosyasi = AyarDosyasi;
                 
            }

            
        }

        private List<Gorev> AyarlariOku()
        {
            if(File.Exists(ayarDosyasi))
            {
                string file = File.ReadAllText(ayarDosyasi);                

                return JsonConvert.DeserializeObject<List<Gorev>>(file);
            }
            else
            {
                return new List<Gorev>();
            }
        }

        private void AyarlariYaz(IEnumerable<Gorev> Gorevler)
        {
            
                string file = JsonConvert.SerializeObject(Gorevler);
                File.WriteAllText(ayarDosyasi, file);
            
        }




    }
}
