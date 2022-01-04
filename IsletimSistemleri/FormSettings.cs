using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            MakeButtonBorderless(buttonSleepMode);
            MakeButtonBorderless(buttonShutdown);
            MakeButtonBorderless(buttonRestart);
            MakeButtonBorderless(buttonBack);
        }
        private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }
        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonSleepMode_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetBattery()
        {
            PowerStatus status = SystemInformation.PowerStatus;
            int percent = (int)(status.BatteryLifePercent * 100);
            labelBattery.Text = percent.ToString() + " %";
            progressBarBattery.Value = percent;
        }
        private void GetTime()
        {
            DateTime datetime = DateTime.Now;
            this.labelCurrentDate.Text = datetime.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetTime();
          
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            GetBattery();
        }
    }
}
