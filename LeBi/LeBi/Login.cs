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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CadastroPaciente cadastro = new CadastroPaciente();
            cadastro.ShowDialog();
        }


       // public static string usuarioConectado;


        //string de conexão:

        //string strconn = "server=localhost;port=3306; UID=root; pwd=1234; database=lebi;";
        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select * from Pacientes where email = '" + txEmail.Text + "'", conn); 
                MySqlDataReader reader = cmd.ExecuteReader(); // vai armazenar na variável reader tudo o que o comando pegar no txEmail.

                while (reader.Read())
                {
                    if (txEmail.Text == reader.GetString("email"))
                    {
                        if (txSenha.Text == reader.GetString("senha"))
                        {
                            PessoaLogada.email = txEmail.Text;
                            FiltroEspecialidade home = new FiltroEspecialidade();
                            home.Show();                            
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Algo está incorreto. Verifique se senha e e-mail estão corretos!");
                        }
                    }
                }

                conn.Close();


            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
