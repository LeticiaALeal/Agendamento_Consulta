using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeBi
{
    public partial class FiltroEspecialidade : Form
    {
        public FiltroEspecialidade()
        {
            InitializeComponent();
        }

        //string strconn = "server=localhost;port=3306; UID=root; pwd=1234; database=lebi;";
        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void FiltroEspecialidade_Load(object sender, EventArgs e)
        {
          txLogado.Text = PessoaLogada.email;
        }

        private void btConsultas_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from consulta_paciente where email = '" + txLogado.Text + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            ConsultaPaciente consultas = new ConsultaPaciente(txLogado.Text);


                while (reader.Read())
                {
                    if (txLogado.Text == reader.GetString("email"))
                    {
                        consultas.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Você não tem consultas agendadas");
                    }
                }                         

            conn.Close();
        }


        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from medicos where especialidade = '" + cbEspecialidade.SelectedItem.ToString() + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            string espec = cbEspecialidade.SelectedItem.ToString();
            EscolhaMedico medicos = new EscolhaMedico(espec);

            while (reader.Read())
            {
                if (cbEspecialidade.SelectedItem.ToString() == reader.GetString("especialidade"))
                {                   
                    medicos.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Médico não encontrado");
                }
            }

            conn.Close();

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }
    }
}
