using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LeBi
{
    public partial class CadastroPaciente : Form
    {
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        //string de conexão:
        /* Conexão Bianca
        string strconn = "server=localhost;port=3306; UID=root; pwd=1234; database=lebi;";
        */

        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                //instanciando a conexão com o strconn.
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                //instanciando o comando de inserir os dados na conexão criada conn.
                MySqlCommand cmd = new MySqlCommand("insert into Pacientes (nome, email, cpf, telefone, endereco, dataNascimento, senha) values (@nome, @email, @cpf, @telefone, @endereco, @dataNascimento, @senha)", conn);
                //definindo os valores do parâmetro:

                this.maskTel.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                String telefone = this.maskTel.Text;

                cmd.Parameters.Add("@nome", MySqlDbType.String).Value = txNome.Text;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = txEmail.Text;
                cmd.Parameters.Add("@cpf", MySqlDbType.String).Value = maskCPF.Text;
                cmd.Parameters.Add("@telefone", MySqlDbType.String).Value = maskTel.Text;
                cmd.Parameters.Add("@endereco", MySqlDbType.String).Value = txEndereco.Text;
                cmd.Parameters.AddWithValue("@dataNascimento", DateTime.Parse(maskNasc.Text));
                cmd.Parameters.Add("@senha", MySqlDbType.String).Value = txSenha.Text;
                cmd.ExecuteNonQuery(); //vai adicionar, remover ou add dados da tabela.

                txNome.Clear();
                txEmail.Clear();
                maskCPF.Clear();
                maskTel.Clear();
                txEndereco.Clear();
                maskNasc.Clear();
                txSenha.Clear();
             
                conn.Close();
                MessageBox.Show("Usuário cadastrado com sucesso");
                Hide();
                

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }    

    }
}
