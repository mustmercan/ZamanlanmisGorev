using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanlanmisGorev.Common
{
    public static class UygulamaKontrol
    {
        public static int UygulamaKapat(string UygulamaAdi)
        {
            int count = 0;
            foreach (var process in Process.GetProcesses())
            {
                if (UygulamaAdi.Contains(process.ProcessName))
                {
                    try
                    {
                        process.Kill();
                        count++;
                    }
                    catch (Exception)
                    {

                        
                    }
                   
                }
            }
            return count;
        }

        

        public static void UygulamaBaslat(string uygulamaAdi,string parametre)
        {
       
            try
            {
                var processInfo = new ProcessStartInfo();
                processInfo.FileName = uygulamaAdi;
                processInfo.Arguments = parametre;
                processInfo.CreateNoWindow = false;
                processInfo.UseShellExecute = true;
                Process.Start(processInfo);
            }
            catch
            {

            }
            
        }

        private static string GetProcessesName(string uygulamaAdi)
        {
            string uygulama = "";
            var parca = uygulamaAdi.Split('\\');
            if(parca.Length>0)
            {
                uygulama = parca.LastOrDefault();
            }
            return uygulama;
        }

    }
}
