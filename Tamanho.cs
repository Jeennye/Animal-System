using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Animal_System
{
    public partial class Tamanho : Form
    {
        public Tamanho()
        {
            InitializeComponent();
        }
        public static double tamanho ;
        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            cadastrar_tamanho ct = new cadastrar_tamanho();
            ct.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            tamanho = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
            Close();
            
        }

        private void Tamanho_Load(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;

            // ADAPTADOR UTILIZADO PARA EXECUTAR A CONSULTA SQL
            MySqlDataAdapter da;

            // ARMAZENAR A TABELA DE DADOS EM MEMÓRIA
            DataTable dt;

            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "SELECT codigo_tamanho AS Codigo,data_tamanho AS Data FROM tamanho_do_animal";

            // CRIANDO UM NOVA TABELA EM MEMÓRIA
            dt = new DataTable();

            // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
            da = new MySqlDataAdapter(sql, conexao);

            // PREENCHENDO A TABELA EM MEMÓRIA
            da.Fill(dt);

            // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
            dataGridView1.DataSource = dt;

            // FECHANDO A CONEXAO
            conexao.Close(); 
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
