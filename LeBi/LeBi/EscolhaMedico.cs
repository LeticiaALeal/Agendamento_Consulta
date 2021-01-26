using MySql.Data.MySqlClient;
using MySql.Data;
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
    public partial class EscolhaMedico : Form
    {
        MySqlDataAdapter daAgenda;
        DataSet dsAgenda;
        public string especialidade;

        public EscolhaMedico(string especialidade)
        {
            this.especialidade = especialidade;
            InitializeComponent();         
        }

        private void EscolhaMedico_Load(object sender, EventArgs e)
        {
            string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";
            MySqlConnection conn = new MySqlConnection(strconn);

            try
            {
                string cmd = "select m.nome, a.horario, a.dia from medicos m, agenda a, agenda_medico c where c.idMedico = m.id and c.idAgenda = a.id and m.especialidade = '" + especialidade + "'";
                daAgenda = new MySqlDataAdapter(cmd, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daAgenda);

                dsAgenda = new DataSet();
                daAgenda.Fill(dsAgenda, "Agenda");
                dataGridView1.DataSource = dsAgenda;
                dataGridView1.DataMember = "Agenda";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
