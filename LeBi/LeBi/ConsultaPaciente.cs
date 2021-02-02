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
    public partial class ConsultaPaciente : Form
    {
        MySqlDataAdapter daConsulta;
        DataSet dsConsulta;
        public string paciente;

        public ConsultaPaciente(string paciente)
        {
            this.paciente = paciente;
            InitializeComponent();
        }

       //string strconn = "server=localhost;port=3306; UID=root; pwd=1234; database=lebi;";
        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void ConsultaPaciente_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            try
            {
                string cmd = "select id as 'Código', medico as 'Médico', horario as 'Horário', dia as 'Dia' from consulta_paciente where email = '" + paciente + "'";
                daConsulta = new MySqlDataAdapter(cmd, conn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(daConsulta);

                dsConsulta = new DataSet();
                daConsulta.Fill(dsConsulta, "Consulta");
                dataGridView1.DataSource = dsConsulta;
                dataGridView1.DataMember = "Consulta";
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
                FiltroEspecialidade filtro = new FiltroEspecialidade();
                filtro.Show();
                Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            try
            {
                MySqlConnection conn = new MySqlConnection(strconn);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("delete from consulta_paciente where id =" + id, conn);

                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
