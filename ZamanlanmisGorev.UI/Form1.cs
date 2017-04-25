using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZamanlanmisGorev.Common;
using ZamanlanmisGorev.Common.Model;

namespace ZamanlanmisGorev.UI
{
    public partial class Form1 : Form
    {
        private List<Gorev> GorevList;
        private AyarProvider ayarProvider;
        private GorevTakibi gorevTakibi;
        private Boolean gorevDuzenle=false;
        private RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        private bool gizle = false;
        public Form1()
        {
            InitializeComponent();

            if (rkApp.GetValue("ZamanlanmisGorev") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                checkBox1.Checked = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                checkBox1.Checked = true;
            }
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() > 0)
            {
                gizle = args.Contains("hide");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ayarProvider = new AyarProvider(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ZamanlanmisGorevAyar.json");
            
            GorevListesiYukle();
            //GorevList = ayarProvider.GorevList;
            //GorevList.Add(new Common.Model.Gorev
            //{
            //    Uygulama = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe",
            //    Ad = "Firefox",
            //    Parametreler = "google.com",
            //    AcilisZamani = new TimeSpan(9, 0, 0),
            //    KapanisZamani = new TimeSpan(22, 0, 0),
            //    OncesiniKapat = true,
            //    Sira = 1
            //});
            //ayarProvider.GorevList = GorevList;
            // UygulamaKontrol.UygulamaKapat(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
            //ayarProvider.GorevList = GorevList;
            GorevPanelVeriYukle();
            gorevTakibi.Basla();

            button1.Text = "Durdur";

           


        }

        private void GorevListesiYukle()
        {
            GorevList = ayarProvider.GorevList.Select(x => new Gorev
            {
                AcilisZamani = x.AcilisZamani,
                Calisiyor = null,
                AktifGunler = x.AktifGunler,
                KapanisZamani = x.KapanisZamani,
                OncesiniKapat = x.OncesiniKapat,
                Parametreler = x.Parametreler,
                Sira = x.Sira,
                Ad = x.Ad,
                Uygulama = x.Uygulama
            }).ToList();
            gorevTakibi = new GorevTakibi(GorevList);
            gorevTakibi.notifyIcon = notifyIcon1;
            dataGridView1.DataSource = GorevList;
            notifyIcon1.Text = string.Format("{0} Adet Zamanlanmış Görev Var.", GorevList.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if(button1.Text=="Durdur")
            {
                gorevTakibi.Durdur();
                button1.Text = "Basla";
            }
            else
            {
                gorevTakibi.Basla();
                button1.Text = "Durdur";
            }
            
       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                UygulamaText.Text = openFileDialog1.FileName;
        }

        private void GorevPanelVeriYukle(Gorev gorev=null)
        {
            if(gorev==null)
            {
                AdText.Text = "";
                UygulamaText.Text = "";
                ParamterelerText.Text = "";
                OncesiniKapatCheck.Checked = true;
                AcilisSaatiTimePicker.Value =new DateTime(1991,3,10,02,02,00);
                KapanisSaatiTimePicker.Value =new DateTime(1991, 3, 10, 07, 58, 00);
                PazartesiCheck.Checked = true;
                SaliCheck.Checked = true;
                CarsambaCheck.Checked = true;
                PersembeCheck.Checked = true;
                CumaCheck.Checked = true;
                CumartesiCheck.Checked = true;
                PazarCheck.Checked = true;
                SiraText.Text = (GorevList.Count() > 0 ? GorevList.Max(x => x.Sira).Value+1 : 1).ToString();
            }
            else
            {
                AdText.Text = gorev.Ad;
                UygulamaText.Text = gorev.Uygulama;
                ParamterelerText.Text = gorev.Parametreler;
                OncesiniKapatCheck.Checked = gorev.OncesiniKapat;
               
                AcilisSaatiTimePicker.Value = new DateTime(1991, 3, 10, gorev.AcilisZamani.Hours, gorev.AcilisZamani.Minutes, gorev.AcilisZamani.Seconds);
                KapanisSaatiTimePicker.Value = new DateTime(1991, 3, 10, gorev.KapanisZamani.Hours, gorev.KapanisZamani.Minutes, gorev.KapanisZamani.Seconds);
                if(gorev.AktifGunler==null || gorev.AktifGunler.Count==0)
                {
                    PazartesiCheck.Checked = true;
                    SaliCheck.Checked = true;
                    CarsambaCheck.Checked = true;
                    PersembeCheck.Checked = true;
                    CumaCheck.Checked = true;
                    CumartesiCheck.Checked = true;
                    PazarCheck.Checked = true;
                }
                else
                {
                    PazartesiCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Monday);
                    SaliCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Tuesday);
                    CarsambaCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Wednesday);
                    PersembeCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Thursday);
                    CumaCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Friday);
                    CumartesiCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Saturday);
                    PazarCheck.Checked = gorev.AktifGunler.Contains(DayOfWeek.Sunday);
                }
                SiraText.Text = (gorev.Sira !=null ? gorev.Sira : 1).ToString();


            }
        }

        private Gorev GorevPanelVeriOku()
        {
            Gorev gorev = new Gorev();
            string hata="";
            gorev.Ad=AdText.Text ;
            gorev.Uygulama= UygulamaText.Text ;
            gorev.Parametreler = ParamterelerText.Text;
            gorev.OncesiniKapat = OncesiniKapatCheck.Checked ;
            gorev.AcilisZamani= AcilisSaatiTimePicker.Value.TimeOfDay;
            gorev.KapanisZamani= KapanisSaatiTimePicker.Value.TimeOfDay;
            gorev.AktifGunler = new List<DayOfWeek>();
            if(PazartesiCheck.Checked == true)gorev.AktifGunler.Add(DayOfWeek.Monday);
            if (SaliCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Tuesday);
            if (CarsambaCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Wednesday);
            if (PersembeCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Thursday);
            if (CumaCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Friday);
            if (CumartesiCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Saturday);
            if (PazarCheck.Checked == true) gorev.AktifGunler.Add(DayOfWeek.Sunday);
            try
            {
                gorev.Sira = Convert.ToInt32(SiraText.Text);
            }
            catch
            {
                gorev.Sira = (GorevList.Count() > 0 ? GorevList.Max(x => x.Sira).Value + 1 : 1);
            }

            if (string.IsNullOrEmpty(gorev.Ad)) hata += "Lütfen Bir Ad Giriniz!\n";
            if (string.IsNullOrEmpty(gorev.Uygulama)) hata += "Lütfen Bir Uygulama Seçiniz!\n";
            if (gorev.AktifGunler.Count==0) hata += "Lütfen Bir Gün Seçiniz!\n";

            if(string.IsNullOrEmpty(hata)==false)
            {
                MessageBox.Show(hata);
                gorev = null;
            }

            return gorev;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
       
                       // GorevPanelVeriYukle(SeciliGorev());
                 
        }
           
        private Gorev SeciliGorev()
        {
            Gorev gorev=null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return GorevList.Where(x => x.Ad == dataGridView1.SelectedRows[0].Cells[0].Value.ToString()
                           && x.Uygulama == dataGridView1.SelectedRows[0].Cells[1].Value.ToString()
                           && x.Parametreler == dataGridView1.SelectedRows[0].Cells[2].Value.ToString()
                           ).FirstOrDefault();
               
            }
            return gorev;
        }

        private void KaydeVeIptalButtonGoster()
        {
            button3.Enabled =! button3.Enabled;
            button4.Enabled =! button4.Enabled;
            button6.Enabled =! button6.Enabled;
            button2.Enabled =! button2.Enabled;
            button5.Enabled =! button5.Enabled;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            GorevPanel.Enabled = true;
            GorevPanelVeriYukle();
            KaydeVeIptalButtonGoster();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var gorev = GorevPanelVeriOku();
            if (gorev != null)
            {
                if(gorevDuzenle==true)
                {
                    var eskiGorev = SeciliGorev();
                    eskiGorev.AcilisZamani= gorev.AcilisZamani;
                    eskiGorev.KapanisZamani= gorev.KapanisZamani;
                    eskiGorev.Ad= gorev.Ad;
                    eskiGorev.AktifGunler= gorev.AktifGunler;
                    eskiGorev.OncesiniKapat= gorev.OncesiniKapat;
                    eskiGorev.Sira = gorev.Sira;
                    eskiGorev.Uygulama = gorev.Uygulama;
                    eskiGorev.Parametreler = gorev.Parametreler;
                    
                    gorevDuzenle = false;
                    
                }
                else
                { 
                    GorevList.Add(gorev);
                }
                ayarProvider.GorevList = GorevList;
                GorevListesiYukle();
                GorevPanel.Enabled = false;
                KaydeVeIptalButtonGoster();
            }
                

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gorev gorev = SeciliGorev();
            if(gorev!=null)
            {
                if(MessageBox.Show("Silme işlemini onaylıyor musunuz?","Onay",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==DialogResult.OK)
                {
                    GorevList.Remove(gorev);
                    ayarProvider.GorevList = GorevList;
                    GorevListesiYukle();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GorevPanel.Enabled = false;
            KaydeVeIptalButtonGoster();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            GorevPanelVeriYukle(SeciliGorev());
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Gizle();
            }
        }

        private void Gizle()
        {
            Hide();
            notifyIcon1.Icon = this.Icon;
            notifyIcon1.Visible = true;           
            //notifyIcon1.BalloonTipTitle = Name;
            //notifyIcon1.BalloonTipText ="Zamanlanmış Görevler Başlatıldı" ;            
            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.ShowBalloonTip(5000);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            
            notifyIcon1.Visible = false;
            Show();
            Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("ZamanlanmisGorev", "\""+Application.ExecutablePath+"\" hide");
                //rkApp.SetValue("ZamanlanmisGorev", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("ZamanlanmisGorev");
            }
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(gizle)
            {
                Gizle();
                gizle = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var gorev = SeciliGorev();
            if (gorev != null)
            {
                gorevDuzenle = true;
                GorevPanelVeriYukle(gorev);
                KaydeVeIptalButtonGoster();
                GorevPanel.Enabled = true;
            }
                
        }
    }
}
