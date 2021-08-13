using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Mannager.Control
{
    class SendData
    {
        private static MySqlConnection conMysql = new MySqlConnection("server=""; database=""; username=""; password="";");

        public static bool SAVE_LOJA(Parameters add)
        {
            conMysql.Open();

            string INSERT_NEW_LOJA = "INSERT INTO [Lojas] (" +
                "Nome_Loja, " +
                "Seguimento," +
                "Proprietario," +
                "Endereco," +
                "Numero," +
                "Cidade," +
                "Estado," +
                "Cep," +
                "CNPJ," +
                "Telefone," +
                "Email," +
                "Code_loja) " +
                "VALUES (" +
                "@nome, " +
                "@seguimento, " +
                "@proprietario, " +
                "@endereco, " +
                "@numero, " +
                "@cidade, " +
                "@estado, " +
                "@cep, " +
                "@cnpj, " +
                "@telefone, " +
                "@email, " +
                "@code)";

            MySqlCommand INL = new MySqlCommand(INSERT_NEW_LOJA, conMysql);
            INL.Parameters.AddWithValue("nome", add.NOME_LOJA);
            INL.Parameters.AddWithValue("cnpj", add.CNPJ_LOJA);
            INL.Parameters.AddWithValue("seguimento", add.SEGUIMENTO_LOJA);
            INL.Parameters.AddWithValue("responsavel", add.RESPONSAVEL_LOJA);
            INL.Parameters.AddWithValue("endereco", add.ENDERECO_LOJA);
            INL.Parameters.AddWithValue("numero", add.NUMERO_LOJA);
            INL.Parameters.AddWithValue("cidade", add.CIDADE_LOJA);
            INL.Parameters.AddWithValue("estado", add.ESTADO_LOJA);
            INL.Parameters.AddWithValue("cep", add.CEP_LOJA);
            INL.Parameters.AddWithValue("telefone", add.TELEFONE_LOJA);
            INL.Parameters.AddWithValue("email", add.EMAIL_LOJA);
            INL.Parameters.AddWithValue("code", add.CODE_LOJA);

            if (INL.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Cadastro da loja realizada com sucesso!");
                conMysql.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Cadastro da loja não realizada!");
                conMysql.Close();
                return false;
            }

        }

    }
}
