using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ZamanlanmisGorev.Common;
using ZamanlanmisGorev.Common.Model;
using System.Timers;

namespace ZamanlanmisGorev.Servis
{
    public partial class ZamanlanmisGorevServis : ServiceBase
    {
        private List<Gorev> GorevList;
        private AyarProvider ayarProvider;
        private string ayarDosyasi;
        private Timer timer;
        public ZamanlanmisGorevServis(string AyarDosyasi)
        {
            InitializeComponent();
            //if (!System.Diagnostics.EventLog.SourceExists("ZamanlanmisGorevLog"))
            //{
            //    System.Diagnostics.EventLog.CreateEventSource(
            //        "ZamanlanmisGorevLog", "Log");
            //}
            //eventLog1.Source = "ZamanlanmisGorevLog";
            //eventLog1.Log = "Log";
            ayarDosyasi = AyarDosyasi;            

        }

        protected override void OnStart(string[] args)
        {
            this.EventLog.WriteEntry("Uygulama Args:" + String.Join(",",args),EventLogEntryType.Warning);
            this.EventLog.WriteEntry("Uygulama Başladı Ayar Dosyası:"+ayarDosyasi);
            
            ayarProvider = new AyarProvider(ayarDosyasi);
            GorevList = ayarProvider.GorevList.ToList().Select(x => new Gorev {
                AcilisZamani = x.AcilisZamani,
                Calisiyor = null,
                AktifGunler = x.AktifGunler,
                KapanisZamani = x.KapanisZamani,
                OncesiniKapat=x.OncesiniKapat,
                Parametreler=x.Parametreler,
                Sira=x.Sira,
                Ad=x.Ad,
                Uygulama=x.Uygulama                
            }).ToList();

            this.EventLog.WriteEntry("Görev Sayısı:" + GorevList.Count().ToString());
            if (GorevList.Count()>0)
            {
                timer = new Timer();
                timer.Elapsed += new ElapsedEventHandler(TimerTick);
                timer.AutoReset = true;
                timer.Enabled = true;
                timer.Interval = 1000;
                timer.Start();
                this.EventLog.WriteEntry("Zamanlayıcı Başladı.");

            }
            



        }

        protected override void OnStop()
        {
           // ayarProvider.GorevList = GorevList;
        }

        private void TimerTick(object sender,ElapsedEventArgs e)
        {
            TimeSpan nowTime = DateTime.Now.TimeOfDay;

            var zamaniGelmisGorevler = GorevList.Where(x => x.Calisiyor == (false|null) && (x.AktifGunler == null || x.AktifGunler.Count()==0|| x.AktifGunler.Contains(DateTime.Now.DayOfWeek)) &&  x.AcilisZamani <= nowTime &&  nowTime < x.KapanisZamani).OrderBy(x => x.Sira).ToList();
            var zamaniGecmisGorevler = GorevList.Where(x => x.Calisiyor == (true|null) && (x.AktifGunler == null || x.AktifGunler.Count() == 0 || x.AktifGunler.Contains(DateTime.Now.DayOfWeek)) &&  nowTime >= x.KapanisZamani).OrderBy(x => x.Sira).ToList();
            //this.EventLog.WriteEntry("Tick" );
            foreach (var item in zamaniGelmisGorevler)
            {
                if(item.OncesiniKapat)
                {
                    UygulamaKontrol.UygulamaKapat(item.Uygulama);
                }
                UygulamaKontrol.UygulamaBaslat(item.Uygulama, item.Parametreler);
                item.Calisiyor = true;
                this.EventLog.WriteEntry("Uygulama Başlatıldı:" + item.Ad);
            }

            foreach (var item in zamaniGecmisGorevler)
            {
                UygulamaKontrol.UygulamaKapat(item.Uygulama);
                item.Calisiyor = false;
                this.EventLog.WriteEntry("Uygulama Kapatıldı:" + item.Ad);
            }
            
        }



    }
}
