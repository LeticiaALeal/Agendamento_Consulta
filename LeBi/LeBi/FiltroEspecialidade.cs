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

        private void txNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltroEspecialidade_Load(object sender, EventArgs e)
        {

        }


        private void btConsultas_Click(object sender, EventArgs e)
        {

        }

        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";
        private void cbEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand("select * from medicos where especialidade = '" + cbEspecialidade.SelectedItem.ToString() + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            

            while (reader.Read())
            {
                if (cbEspecialidade.SelectedItem.ToString() == reader.GetString("especialidade"))
                {
                    string espec = cbEspecialidade.SelectedItem.ToString();
                    EscolhaMedico medicos = new EscolhaMedico(espec);
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

        private void btBusca_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            conn.Open();

           MySqlCommand cmd = new MySqlCommand("select * from medicos where nome = '" + txNomeMedico.Text + "'", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
           
            while (reader.Read())
            {
                if (txNomeMedico.Text == reader.GetString("nome"))
                {
                    string espec = cbEspecialidade.SelectedItem.ToString();
                    EscolhaMedico medicos = new EscolhaMedico(espec);
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
    }
}
