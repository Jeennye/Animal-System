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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }
         public static int forn = 0;
         public static string forn2 = "";

        private void btn_novo_Click(object sender, EventArgs e)
        {
            novo_fornecedor novo_for = new novo_fornecedor();
            novo_for.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            // STRING DE CONEXÃO COM OS DADOS DO BANCO DE DADOS
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
            string sql = "SELECT cod_fornecedor AS Codigo, nome AS Nome,tipo AS Tipo,fone AS Telefone  FROM fornecedor";

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            novo_fornecedor forn = new novo_fornecedor();
            forn.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;




            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "DELETE FROM fornecedor WHERE cod_fornecedor like @forn";


            

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@forn", forn);



            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            forn = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            forn = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
            forn2 = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nome"].FormattedValue.ToString());
            Close();
        }
    }
}
