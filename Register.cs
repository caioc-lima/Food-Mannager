using MySql.Data.MySqlClient;
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
using Food_Mannager.Control;

namespace Food_Mannager
{
    public partial class Register : Form
    {
        String CODE = "";

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private static MySqlConnection con = new MySqlConnection("server=""; database=""; username=""; password="";");

        public Register()
        {
            InitializeComponent();
            con.Open();
            string teste = con.State.ToString();
        }

        private void BTN_CLOSE_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja cancelar o cadastramento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void BT_MINIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MENU_SUPERIOR_REGISTER_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_CANCELAR_REGISTER_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o cadastramento?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void BTN_SALVAR_REGISTER_Click(object sender, EventArgs e)
        {

            if (TXT_NOME_LOJA_REGISTER.Text != "" &&
                TXT_SEGUIMENTO_REGISTER.Text != "" &&
                TXT_RESPONSAVEL_REGISTER.Text != "" &&
                TXT_ENDERECO_REGISTER.Text != "" &&
                TXT_NUMERO_REGISTER.Text != "" &&
                TXT_CIDADE_REGISTER.Text != "" &&
                TXT_ESTADO_REGISTER.Text != "" &&
                TXT_CEP_REGISTER.Text != "     -" &&
                TXT_CNPJ_REGISTER.Text != "  .   .   /    -" &&
                TXT_TELEFONE_REGISTER.Text != "(  )       -" &&
                TXT_EMAIL_REGISTER.Text != "")
            {
                GERADOR_CODE();

                Parameters parameters = new Parameters();

                parameters.NOME_LOJA = TXT_NOME_LOJA_REGISTER.Text;
                parameters.SEGUIMENTO_LOJA = TXT_SEGUIMENTO_REGISTER.Text;
                parameters.RESPONSAVEL_LOJA = TXT_RESPONSAVEL_REGISTER.Text;
                parameters.ENDERECO_LOJA = TXT_ENDERECO_REGISTER.Text;
                parameters.NUMERO_LOJA = TXT_NUMERO_REGISTER.Text;
                parameters.CIDADE_LOJA = TXT_CIDADE_REGISTER.Text;
                parameters.ESTADO_LOJA = TXT_ESTADO_REGISTER.Text;
                parameters.CEP_LOJA = TXT_CEP_REGISTER.Text;
                parameters.CNPJ_LOJA = TXT_CNPJ_REGISTER.Text;
                parameters.TELEFONE_LOJA = TXT_TELEFONE_REGISTER.Text;
                parameters.EMAIL_LOJA = TXT_EMAIL_REGISTER.Text;
                parameters.CODE_LOJA = CODE;

                if (SendData.SAVE_LOJA(parameters))
                {
                    //MessageBox.Show("Cadastro feito com sucesso");
                    LABEL_ERROR.Visible = false;
                    LABEL_ERROR1.Visible = false;
                    LABEL_ERROR2.Visible = false;
                    LABEL_ERROR3.Visible = false;
                    LABEL_ERROR4.Visible = false;
                    LABEL_ERROR5.Visible = false;
                    LABEL_ERROR6.Visible = false;
                    LABEL_ERROR7.Visible = false;
                    LABEL_ERROR8.Visible = false;
                    LABEL_ERROR9.Visible = false;
                    LABEL_ERROR9.Visible = false;
                    LABEL_ERROR10.Visible = false;
                }
                else
                {
                    //MessageBox.Show("Cadastro bão realizado");
                }
            }
            else
            {
                // SHOW
                LABEL_ERROR.Visible = true;
                LABEL_ERROR1.Visible = true;
                LABEL_ERROR2.Visible = true;
                LABEL_ERROR3.Visible = true;
                LABEL_ERROR4.Visible = true;
                LABEL_ERROR5.Visible = true;
                LABEL_ERROR6.Visible = true;
                LABEL_ERROR7.Visible = true;
                LABEL_ERROR8.Visible = true;
                LABEL_ERROR9.Visible = true;
                LABEL_ERROR9.Visible = true;
                LABEL_ERROR10.Visible = true;
            }
        }

        public void GERADOR_CODE()
        {
            if(TXT_NOME_LOJA_REGISTER.Text != "" && TXT_CNPJ_REGISTER.Text != " .   .   /    -")
            {
                var nome = TXT_NOME_LOJA_REGISTER.Text.ToString().Substring(0, 3);

                var cnpj = TXT_CNPJ_REGISTER.Text.ToString().Substring(0, 2);

                var chars = "0123456789";

                var random = new Random();

                var code_random = new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray());

                CODE = nome + cnpj + code_random;
            }


        }
    }
}
