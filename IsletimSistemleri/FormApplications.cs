using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormApplications : Form
    {
        private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }
        public FormApplications()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonCalculator);
            MakeButtonBorderless(buttonBack);
            MakeButtonBorderless(buttonBrowser);
            MakeButtonBorderless(buttonCmd);
            MakeButtonBorderless(buttonMagnifyingGlass);
        }
        
        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\calc.exe");
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
        }

        private void buttonMagnifyingGlass_Click(object sender, EventArgs e)
        {
            ProcessStartInfo myProcess = new ProcessStartInfo(@"C:\WINDOWS\system32\magnify.exe");
            myProcess.UseShellExecute = true;
            myProcess.Verb = "runas";
            Process.Start(myProcess);
        }

        private void buttonCmd_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\cmd.exe");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
