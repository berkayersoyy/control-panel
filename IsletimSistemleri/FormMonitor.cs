using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormMonitor : Form
    {
        [DllImport("gdi32.dll")]
        private static extern unsafe bool SetDeviceGammaRamp(Int32 hdc, void* ramp);
        private static bool initialized = false;
        private static Int32 hdc;
        private static int _brightness;
  
        private static void InitializeClass()
        {
            if (initialized)
                return;
            hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();
            initialized = true;
        }

        public static unsafe bool SetBrightness(int brightness)
        {
            InitializeClass();
            if (brightness > 255)
                brightness = 255;
            if (brightness < 0)
                brightness = 0;
            short* gArray = stackalloc short[3 * 256];
            short* idx = gArray;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    int arrayVal = i * (brightness + 128);
                    if (arrayVal > 65535)
                        arrayVal = 65535;
                    *idx = (short)arrayVal;
                    idx++;
                }
            }
            bool retVal = SetDeviceGammaRamp(hdc, gArray);
            return retVal;
        }
        public FormMonitor()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonBack);
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _brightness = trackBar1.Value;
            SetBrightness(_brightness);
        }

        

        private void radioButtonMaxPower_CheckedChanged(object sender, EventArgs e)
        {
            _brightness = 128;
            trackBar1.Value = _brightness;
            SetBrightness(_brightness);

        }

        private void radioButtonAveragePower_CheckedChanged(object sender, EventArgs e)
        {
            _brightness = 50;
            trackBar1.Value = _brightness;
            SetBrightness(_brightness);
        }

        private void radioButtonLowPower_CheckedChanged(object sender, EventArgs e)
        {
            _brightness = 10;
            trackBar1.Value = _brightness;
            SetBrightness(_brightness);
        }

        private void buttonSleepMode_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/r /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void buttonShutdown_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "/s /t 0");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
      
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
