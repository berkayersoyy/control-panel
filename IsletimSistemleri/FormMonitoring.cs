using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormMonitoring : Form
    {
        PerformanceCounter cpuCounter=new PerformanceCounter("Processor", "% Processor Time", "_Total");
        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "Available MBytes");

        public FormMonitoring()
        {
            InitializeComponent();
            timer1.Start();
            MakeButtonBorderless(buttonBack);
        }
        private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }

        private void GetCPUUsage()
        {
            var usage = (int)cpuCounter.NextValue();
            spinnerCPU.Value = usage;
            labelCPU.Text = usage.ToString() + " %";
        }
        private void GetRamUsage()
        {
            var usage = (int)ramCounter.NextValue();
            spinnerRam.Value = usage;
            labelRam.Text = usage.ToString() + " mb";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetCPUUsage();
            GetRamUsage();
        }

        private void FormMonitoring_Load(object sender, EventArgs e)
        {

        }

        private void spinnerCPU_Click(object sender, EventArgs e)
        {

        }
    }
}
