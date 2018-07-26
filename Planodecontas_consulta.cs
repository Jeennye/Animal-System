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
    public partial class Planodecontas_consulta : Form
    {
        public Planodecontas_consulta()
        {
            InitializeComponent();
        }
        public static int plan;
        public static string plan2 = "";
        private void Planodecontas_consulta_Load(object sender, EventArgs e)
        {
            try
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
                string sql = "SELECT cod_pdc AS Codigo,descricao_da_conta AS Descricao,cod_cdc AS cod_cdc FROM plano_de_contas";

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
            catch
            {
                MessageBox.Show("Abra o EasyPHP");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlanoDeContas plan = new PlanoDeContas();
            plan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            string sql = "SELECT cod_pdc AS Codigo,descricao_da_conta AS Descricao,cod_cdc AS cod_cdc FROM plano_de_contas";

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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            plan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cod_cdc"].FormattedValue.ToString());
            plan2 = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["descricao"].FormattedValue.ToString());
            Close();
        }
    }
}
