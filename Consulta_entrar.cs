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
    public partial class Consulta_entrar : Form
    {
        public Consulta_entrar()
        {
            InitializeComponent();
        }
        public int entrar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Consulta_entrar_Load(object sender, EventArgs e)
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

            string sql = "SELECT cod_entrada AS Codigo,data_do_movimento_entrada AS Data,quantidade_entrada AS Quantidade,data_do_lancamento AS Lancamento,unidade AS Unidade,cod_prod AS Produto  FROM entrada";

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
            entrar = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
            Close();
        }
    }
}
