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

        string strconn = "server=localhost;port=3306; UID=root; pwd=Leh2019; database=lebi;";

        private void ConsultaPaciente_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(strconn);
            try
            {
                string cmd = "select * from consulta_paciente where cpfPaciente = '" + paciente + "'";
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
    }
}
