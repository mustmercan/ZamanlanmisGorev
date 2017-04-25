using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZamanlanmisGorev.Common.Model;
using System.Timers;
using System.Windows.Forms;

namespace ZamanlanmisGorev.Common
{
    public class GorevTakibi
    {
        private List<Gorev> GorevList;
        private System.Timers.Timer GTTimer;
        public NotifyIcon notifyIcon;
        public GorevTakibi(List<Gorev> Gorevler)
        {
            this.GorevList = Gorevler;
            GTTimer = new System.Timers.Timer();
            GTTimer.Interval = 3000;
            GTTimer.AutoReset = true;
            GTTimer.Elapsed += new ElapsedEventHandler(TimerTick);
        }

        private void UyariVer(string baslik, string mesaj)
        {
            if(notifyIcon!=null)
            {
                var visible = notifyIcon.Visible;
                notifyIcon.Visible = true;
                notifyIcon.BalloonTipTitle = baslik;
                notifyIcon.BalloonTipText = mesaj;
                notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon.ShowBalloonTip(5000);
                notifyIcon.Visible = visible;
            }
        }

        private void TimerTick(object sender, ElapsedEventArgs e)
        {
            TimeSpan nowTime = DateTime.Now.TimeOfDay;

            var zamaniGelmisGorevler = GorevList.Where(x => x.Calisiyor == (false | null) && (x.AktifGunler == null || x.AktifGunler.Count() == 0 || x.AktifGunler.Contains(DateTime.Now.DayOfWeek)) && x.AcilisZamani <= nowTime && nowTime < x.KapanisZamani).OrderBy(x => x.Sira).ToList();
            var zamaniGecmisGorevler = GorevList.Where(x => x.Calisiyor == (true | null) && (x.AktifGunler == null || x.AktifGunler.Count() == 0 || x.AktifGunler.Contains(DateTime.Now.DayOfWeek)) && nowTime >= x.KapanisZamani).OrderBy(x => x.Sira).ToList();
            //this.EventLog.WriteEntry("Tick" );
            foreach (var item in zamaniGelmisGorevler)
            {
                if (item.OncesiniKapat)
                {
                    UygulamaKontrol.UygulamaKapat(item.Uygulama);
                    
                }
                UygulamaKontrol.UygulamaBaslat(item.Uygulama, item.Parametreler);
                item.Calisiyor = true;
                UyariVer("Uygulama başlatıldı", string.Format("{0} uygulaması başlatıldı.", item.Ad));
                //this.EventLog.WriteEntry("Uygulama Başlatıldı:" + item.Ad);
            }

            foreach (var item in zamaniGecmisGorevler)
            {
                UygulamaKontrol.UygulamaKapat(item.Uygulama);
                item.Calisiyor = false;
                UyariVer("Uygulama kapatıldı", string.Format("{0} uygulaması kapatıldı.", item.Ad));

                //this.EventLog.WriteEntry("Uygulama Kapatıldı:" + item.Ad);
            }//

        }

        public void Basla()
        {
            GTTimer.Start();
        }

        public void Durdur()
        {
            GTTimer.Stop();
        }


    }
}
