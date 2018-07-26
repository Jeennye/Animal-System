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
    public partial class Pesquisa_plano_de_contas : Form
    {
        public Pesquisa_plano_de_contas()
        {
            InitializeComponent();
        }
        public static int plan;
        public static int plan2;


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pesquisa_plano_de_contas_Load(object sender, EventArgs e)
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
            string sql = "SELECT cod_pedido AS Codigo, qtd AS Quantidade,data_pedido AS Data,hora_pedido AS Hora,data_entrega AS entrega,hora_entrega AS entr,cod_fornecedor AS Fornecedor,cod_prod AS Produto,Unidade AS Unidade  FROM pedido_de_compra";

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
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PlanoDeContas plan = new PlanoDeContas();
            plan.Show();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            plan = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cod_pedido"].FormattedValue.ToString());
            plan2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["qtd"].FormattedValue.ToString());
            MessageBox.Show("" + plan );
            Close();
        }
    }
}
