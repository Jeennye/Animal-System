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
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }
        public static int Estoque_minimo;
        private void Estoque_Load(object sender, EventArgs e)
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
            string sql = "SELECT cod_entrada AS codigo, Unidade AS  Unidade,cod_prod AS produto,qtd_entrada AS Quantidade,Valor_unitario As Valor,Data_movimento AS movimento,Data_lancamento AS Lancamento FROM entrada_estoque";


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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
            
            // VERIFICAR SE O CONTEÚDO DA CÉLULA NÃO É VAZIO
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // VARIÁVEL PARA OBTER O SALDO ATUAL DA CÉLULA

                int Estoque = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["qtd_entrada"].Value);

                // VARIÁVEL PARA OBTER A QUANTIDADE DA CÉLULA

                DataGridViewCellStyle normal = new DataGridViewCellStyle { ForeColor = Color.White, BackColor = Color.Green };
                DataGridViewCellStyle baixo = new DataGridViewCellStyle { ForeColor = Color.Red, BackColor = Color.Yellow };
                DataGridViewCellStyle zerado = new DataGridViewCellStyle { ForeColor = Color.Yellow, BackColor = Color.Red };

                // SOMENTE SERÁ ALTERADA A COR, QUANDO O SALDO EM ESTOQUE FOR
                // estoque minimo
                if (Estoque < produtos.Estoque_minimo)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = baixo;


                }
                // estoque zerado

                else if (Estoque == 0)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = zerado;


                }


                 // Estoque cheio

                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = normal;


                }
           

            }
               
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Estoque_entrada es = new Estoque_entrada();
            es.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

                if (comboBox1.SelectedIndex == 0)
                {

                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT cod_entrada AS codigo, Unidade AS  Unidade,cod_prod AS produto,qtd_entrada AS Quantidade,Valor_unitario As Valor,Data_movimento AS movimento,Data_lancamento AS Lancamento FROM entrada_estoque WHERE cod_entrada LIKE @cod_entrada ";


                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();


                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@cod_entrada", txt_pesquisar.Text + "%");




                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;


                }
                else if (comboBox1.SelectedIndex == 1)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT cod_entrada AS codigo, Unidade AS  Unidade,cod_prod AS produto,qtd_entrada AS Quantidade,Valor_unitario As Valor,Data_movimento AS movimento,Data_lancamento AS Lancamento FROM entrada_estoque WHERE cod_prod LIKE @cod_prod ";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@cod_prod", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;



                }
                else if (comboBox1.SelectedIndex == 2)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT cod_entrada AS codigo, Unidade AS  Unidade,cod_prod AS produto,qtd_entrada AS Quantidade,Valor_unitario As Valor,Data_movimento AS movimento,Data_lancamento AS Lancamento FROM entrada_estoque WHERE qtd_entrada LIKE @qtd_entrada ";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@qtd_entrada", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;


                }
                // FECHANDO A CONEXAO
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Selecione um filtro de pesquisa");
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            string sql = "SELECT cod_entrada AS codigo, Unidade AS  Unidade,cod_prod AS produto,qtd_entrada AS Quantidade,Valor_unitario As Valor,Data_movimento AS movimento,Data_lancamento AS Lancamento FROM entrada_estoque";


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            saida s = new saida();
            s.ShowDialog();
        }
    }

}
    