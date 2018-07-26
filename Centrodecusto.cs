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
    public partial class Centrodecusto : Form
    {
        public Centrodecusto()
        {
            InitializeComponent();
        }
        public static int cod = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Centrodecusto_Load(object sender, EventArgs e)
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
            string sql = "SELECT cod_cdc AS Codigo,descrição AS Descricao,tipo AS Tipo,observação AS Observacao FROM centro_de_custo";

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
            Cadcentrodecusto cad_custo = new Cadcentrodecusto();
            cad_custo.Show();
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
            string sql = "DELETE FROM centro_de_custo WHERE cod_cdc = @cat";




            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@cat", cod);



            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cod_cdc"].FormattedValue.ToString());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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
                string sql = "SELECT cod_cdc FROM centro_de_custo WHERE cod_cdc LIKE @cod_cdc ";


                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();


                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@cod_cdc", txt_pesquisar.Text + "%");




                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;


            }
            else if (comboBox1.SelectedIndex == 1)
            {


                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "SELECT descrição  AS Descrição FROM centro_de_custo ";

                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();

                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@descrição", txt_pesquisar.Text + "%");


                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;



            }
            else if (comboBox1.SelectedIndex == 2)
            {


                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "SELECT tipo  AS Tipo  FROM centro_de_custo ";

                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();

                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@tipo", txt_pesquisar.Text + "%");


                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;


            }
            // FECHANDO A CONEXAO
            conexao.Close();
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
            string sql = "SELECT cod_cdc AS Codigo,descrição AS Descricao,tipo AS Tipo,observação AS Observacao FROM centro_de_custo";

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
