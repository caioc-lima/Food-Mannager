using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Mannager
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SLIDE_Click(object sender, EventArgs e)
        {
            if (MENU_LATERAL.Width == 250)
            {
                MENU_LATERAL.Width = 55;
                //PICTURE_LOGO.Image = Properties.Resources.logo_market;
                //PICTURE_LOGO.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                //PICTURE_LOGO.Image = Properties.Resources.logo_market;
                //PICTURE_LOGO.SizeMode = PictureBoxSizeMode.Zoom;
                MENU_LATERAL.Width = 250;
            }
        }

        private void BTN_MINIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MENU_SUPERIOR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
