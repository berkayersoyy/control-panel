using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace IsletimSistemleri
{
    public partial class FormSound : Form
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;
         private void MakeButtonBorderless(Button bt)
        {
            bt.FlatStyle = FlatStyle.Flat;
            bt.FlatAppearance.BorderSize = 0;
        }

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void Mute()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }

        private void VolDown()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void VolUp()
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }
        public FormSound()
        {
            InitializeComponent();
            MakeButtonBorderless(buttonMute);
            MakeButtonBorderless(buttonVolDown);
            MakeButtonBorderless(buttonVolUp);
            MakeButtonBorderless(buttonBack);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonVolUp_Click(object sender, EventArgs e)
        {
            VolUp();
        }

        private void buttonMute_Click(object sender, EventArgs e)
        {
            Mute();
        }

        private void buttonVolDown_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
