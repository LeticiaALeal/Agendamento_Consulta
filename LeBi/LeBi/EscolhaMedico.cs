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

        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void EscolhaMedico_Load(object sender, EventArgs e)
        {          
            MySqlConnection conn = new MySqlConnection(strconn);

            try
            {
                string cmd = "select m.nome as 'Médico', a.horario as 'Horário', a.dia as 'Dia' from medicos m, agenda a, agenda_medico c where c.idMedico = m.id and c.idAgenda = a.id and m.especialidade = '" + especialidade + "'";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txMedico.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txHorario.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txDia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                     
        }

        private void brAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into consulta_paciente (cpfPaciente, medico, horario, dia) values (@cpfPaciente, @medico, @horario, @dia)", conn);

                cmd.Parameters.Add("@medico", MySqlDbType.String).Value = txMedico.Text;
                cmd.Parameters.Add("@horario", MySqlDbType.String).Value = txHorario.Text;
                cmd.Parameters.Add("@dia", MySqlDbType.String).Value = txDia.Text;
                cmd.Parameters.Add("@cpfPaciente", MySqlDbType.String).Value = txCpf.Text;

                cmd.ExecuteNonQuery();

                string paciente = txCpf.Text;
                ConsultaPaciente consultas = new ConsultaPaciente(paciente);
                consultas.Show();
                Hide();

                conn.Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FiltroEspecialidade filtro = new FiltroEspecialidade();
            filtro.Show();
            Hide();
        }
    }
}
