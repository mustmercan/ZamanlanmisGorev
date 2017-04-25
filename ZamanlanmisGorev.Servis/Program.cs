using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace ZamanlanmisGorev.Servis
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            string[] args = { @"C:\Users\mmercan\Documents\Visual Studio 2015\Projects\ZamanlanmisGorev\ZamanlanmisGorev.UI\bin\Debug\Ayar.json" };
            if (args.Length > 0)
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[]
                {
                new ZamanlanmisGorevServis(args[0])
                };
                ServiceBase.Run(ServicesToRun);
            }
            else
            {
                throw new System.ArgumentException("Ayar Dosyası belirtilmeli");
            }
        }
    }
}
