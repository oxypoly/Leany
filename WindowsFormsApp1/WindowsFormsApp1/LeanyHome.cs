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
            InitializeComponent();
            int duration = 400;//in milliseconds
            int steps = 100;
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
    }
}
