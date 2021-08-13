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
using MySql.Data.MySqlClient;

namespace Food_Mannager
{
    public partial class Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Connection_MySql()
        {
            MySqlConnection con_mysql = new MySqlConnection("server=localhost; database=""; username=""; password="";");

            if (con_mysql != null)
            {
                //MessageBox.Show("Conectado");
            }
            else
            {
                //MessageBox.Show("Erro de conexão");
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BT_MINIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            Connection_MySql();
            IMG_PROCESSING.Visible = true;
            LABEL_AGUARDE_LOGIN.Visible = true;

            if(IMG_PROCESSING.Visible == true)
            {
                // HIDE
                LABEL_EMAIL_LOGIN.Visible = false;
                LABEL_SENHA_LOGIN.Visible = false;
                LABEL_CODE_LOGIN.Visible = false;

                // SHOW
                TXT_EMAIL_LOGIN.Visible = false;
                TXT_SENHA_LOGIN.Visible = false;
                TXT_CODE_LOGIN.Visible = false;            
            }
        }

        private void TXT_SENHA_LOGIN_TextChanged(object sender, EventArgs e)
        {
            if(TXT_EMAIL_LOGIN.Text != "" && TXT_SENHA_LOGIN.Text != "")
            {
                LABEL_CODE_LOGIN.Visible = true;
                TXT_CODE_LOGIN.Visible = true;
            }
            else
            {
                LABEL_CODE_LOGIN.Visible = false;
                TXT_CODE_LOGIN.Visible = false;
            }
        }

        private void TXT_EMAIL_LOGIN_TextChanged(object sender, EventArgs e)
        {
            if (TXT_EMAIL_LOGIN.Text != "" && TXT_SENHA_LOGIN.Text != "")
            {
                LABEL_CODE_LOGIN.Visible = true;
                TXT_CODE_LOGIN.Visible = true;
            }
            else
            {
                LABEL_CODE_LOGIN.Visible = false;
                TXT_CODE_LOGIN.Visible = false;
            }
        }

        private void BTN_RESGISTRAR_Click(object sender, EventArgs e)
        {
            Register form = new Register();
            this.Hide();
            form.ShowDialog();
        }

        private void MENU_SUPERIOR_LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
