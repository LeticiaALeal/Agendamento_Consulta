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
        //string strconn = "server=localhost;port=3306; UID=root; pwd=1234; database=lebi;";
        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void EscolhaMedico_Load(object sender, EventArgs e)
        {          
            MySqlConnection conn = new MySqlConnection(strconn);
            txLogado.Text = PessoaLogada.email;

            try
            {
                string cmd = "select c.id, m.especialidade, m.nome as 'Médico', a.horario as 'Horário', a.dia as 'Dia' from medicos m, agenda a, agenda_medico c where c.idMedico = m.id and c.idAgenda = a.id and m.especialidade = '" + especialidade + "'";
                daAgenda = new MySqlDataAdapter(cmd, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daAgenda);

                dsAgenda = new DataSet();
                daAgenda.Fill(dsAgenda, "Agenda");
                dataGridView1.DataSource = dsAgenda;
                dataGridView1.DataMember = "Agenda";

                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["especialidade"].Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        public string idAgenda;
        public string espec;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idAgenda = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            espec = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txMedico.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txHorario.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txDia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                     
        }

        private void brAgendar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("insert into consulta_paciente (email, medico, especialidade, horario, dia) values (@email, @medico, @especialidade, @horario, @dia)", conn);
                MySqlCommand cmdDel = new MySqlCommand("delete from agenda_medico where id ='" + idAgenda + "'", conn);

                cmd.Parameters.Add("@medico", MySqlDbType.String).Value = txMedico.Text;
                cmd.Parameters.Add("@especialidade", MySqlDbType.String).Value = espec;
                cmd.Parameters.Add("@horario", MySqlDbType.String).Value = txHorario.Text;
                cmd.Parameters.Add("@dia", MySqlDbType.String).Value = txDia.Text;
                cmd.Parameters.Add("@email", MySqlDbType.String).Value = txLogado.Text;

                cmdDel.Parameters.AddWithValue("id", idAgenda);
                cmdDel.ExecuteNonQuery();

                cmd.ExecuteNonQuery();

                string paciente = txLogado.Text;
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
