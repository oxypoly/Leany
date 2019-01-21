using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leany
{
    public partial class OneNote : MetroFramework.Forms.MetroForm
    {
        public OneNote()
        {
            InitializeComponent();
            Console.WriteLine("Browser Geopend");
            int duration = 400;//in milliseconds
            int steps = 70;
            Timer timer = new Timer
            {
                Interval = duration / steps
            };

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        ChromiumWebBrowser chrome;

        private void OneNote_Load(object sender, EventArgs e)
        {
            if (Cef.IsInitialized){
                ;goto cefstarted;
            }
            else
            {
                goto cefstarting;
            }
            cefstarting:
            Console.WriteLine("Cef Starten");
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            weblink.Text = "https://www.onenote.com/notebooks";
            chrome = new ChromiumWebBrowser(weblink.Text);
            this.webframe.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;

        cefstarted:
            Console.WriteLine("Cef al gestart");
            weblink.Text = "https://www.onenote.com/notebooks";
            chrome = new ChromiumWebBrowser(weblink.Text);
            this.webframe.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
            chrome.AddressChanged += Chrome_AddressChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                weblink.Text = e.Address;
            }));
        }

        private void webgo_Click(object sender, EventArgs e)
        {
            chrome.Load(weblink.Text);
            Console.WriteLine("Link Laden");
        }

        private void webframe_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Vorige Scherm");
            this.Hide();
            Leany_Home sistema = new Leany_Home();
            sistema.ShowDialog();
            this.Close();
        }

        private void webrld_Click(object sender, EventArgs e)
        {
            chrome.Refresh();
            Console.WriteLine("Herladen");
        }

        private void webname_Click(object sender, EventArgs e)
        {

        }
    }
}
