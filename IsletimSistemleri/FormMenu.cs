using System;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonMonitor);
            MakeButtonBorderless(buttonApplications);
            MakeButtonBorderless(buttonSound);
            MakeButtonBorderless(buttonSettings);
            MakeButtonBorderless(buttonMonitoring);
        }

        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            FormMonitor form = new FormMonitor();
            form.Show();
        }
        private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }

        private void buttonSound_Click(object sender, EventArgs e)
        {
            FormSound form = new FormSound();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormApplications form = new FormApplications();
            form.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings form = new FormSettings();
            form.Show();
        }

        private void buttonMonitoring_Click(object sender, EventArgs e)
        {
            FormMonitoring form = new FormMonitoring();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
