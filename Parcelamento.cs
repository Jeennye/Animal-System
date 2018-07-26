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
    public partial class Parcelamento : Form
    {
        public Parcelamento()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click_1(object sender, EventArgs e)
        {
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("insert into parcelamento(cod_parcelamento,numero_titulo,titular,numero_parcelas,primeiro_vencimento,total_parcelas) values (@cod_parcelamento,@numero_titulo,@titular,@numero_parcelas,@primeiro_vencimento,@total_parcelas)", conexao);
            comando.Parameters.AddWithValue("@cod_parcelamento", textBox4.Text);
            comando.Parameters.AddWithValue("@numero_titulo", textBox1.Text);
            comando.Parameters.AddWithValue("@titular", textBox2.Text);
            comando.Parameters.AddWithValue("@numero_parcelas", textBox3.Text);
            comando.Parameters.AddWithValue("@primeiro_vencimento", maskedTextBox1.Text);
            comando.Parameters.AddWithValue("@total_parcelas", maskedTextBox2.Text);




            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Parcelamento_Load(object sender, EventArgs e)
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
            string sql = "SELECT cod_parcelamento AS Codigo,numero_titulo AS Numero,titular AS titular,numero_parcelas AS  parcelas,primeiro_vencimento AS Vencimento,total_parcelas AS Total  FROM parcelamento";
            string sql2 = " SELECT SUM(numero_parcelas) FROM parcelamento";
            MessageBox.Show("", sql2);
            maskedTextBox2.Text = sql2;

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
    }
}
