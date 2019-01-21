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
    public partial class Leany_Home : MetroFramework.Forms.MetroForm
    {
        public Leany_Home()
        {
            InitializeComponent();
            Console.WriteLine("Home Opgestart");
            int duration = 400;//in milliseconds
            int steps = 70;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

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

        private void Leany_Home_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CefSharp Test Opgestart");
            this.Hide();
            Defaulcef sistema = new Defaulcef();
            sistema.ShowDialog();
            this.Close();
        }

        private void OneNote_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CefSharp Test Opgestart");
            this.Hide();
            OneNote sistema = new OneNote();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
