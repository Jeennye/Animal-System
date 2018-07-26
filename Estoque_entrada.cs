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
    public partial class Estoque_entrada : Form
    {
        public Estoque_entrada()
        {
            InitializeComponent();
        }
        public static int cod;

        private void Estoque_entrada_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            maskedTextBox1.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            produtos prod = new produtos();
            prod.Show();
            if (produtos.cod != 0)
            {

                textBox2.Text = Convert.ToString(produtos.cod);
            }
           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try{
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlCommand comando2;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("insert into entrada_estoque(cod_entrada,Unidade,qtd_entrada,cod_prod,Valor_unitario,Data_movimento,Data_lancamento) values (@cod_entrada,@Unidade,@qtd_entrada,@cod_prod,@Valor_unitario,@Data_movimento,@Data_lancamento) ", conexao);
            comando.Parameters.AddWithValue("@cod_entrada", txt_cod.Text);
            comando.Parameters.AddWithValue("@Unidade", cb_unidade.Text);
            comando.Parameters.AddWithValue("@qtd_entrada", textBox1.Text);
            comando.Parameters.AddWithValue("@cod_prod", textBox2.Text);
            comando.Parameters.AddWithValue("@Valor_unitario", maskedTextBox3.Text);
            comando.Parameters.AddWithValue("@Data_movimento", maskedTextBox2.Text);
            comando.Parameters.AddWithValue("@Data_lancamento", maskedTextBox1.Text);

            comando2 = new MySqlCommand("insert into entrada(cod_entrada,Unidade,qtd_entrada,cod_prod,Valor_unitario,Data_movimento,Data_lancamento) values (@cod_entrada,@Unidade,@qtd_entrada,@cod_prod,@Valor_unitario,@Data_movimento,@Data_lancamento) ", conexao);
            comando2.Parameters.AddWithValue("@cod_entrada", txt_cod.Text);
            comando2.Parameters.AddWithValue("@Unidade", cb_unidade.Text);
            comando2.Parameters.AddWithValue("@qtd_entrada", textBox1.Text);
            comando2.Parameters.AddWithValue("@cod_prod", textBox2.Text);
            comando2.Parameters.AddWithValue("@Valor_unitario", maskedTextBox3.Text);
            comando2.Parameters.AddWithValue("@Data_movimento", maskedTextBox2.Text);
            comando2.Parameters.AddWithValue("@Data_lancamento", maskedTextBox1.Text);



            // Executa o comando SQL
            comando.ExecuteNonQuery();
            comando2.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Já exite um cadastro com esse código!");
            }
        }
        

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = false;
            txt_cod.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            textBox2.Clear();
            textBox1.Clear();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

           
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            maskedTextBox1.Enabled = true;
            maskedTextBox2.Enabled = true;
            txt_cod.Enabled = true;
            

            Consulta_entrar entrar = new Consulta_entrar();
            entrar.ShowDialog();

            string sc = "Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlDataReader dr = null;

            // Conexão do banco de dados
            conexao = new MySqlConnection(sc);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("SELECT * FROM entrada WHERE cod_entrada = @cod_entrada", conexao);
            comando.Parameters.AddWithValue("@cod_entrada", entrar.entrar);

            // Executa o comando SQL
            dr = comando.ExecuteReader();

            while (dr.Read())
            {




                txt_cod.Text = dr["cod_entrada"].ToString();
                maskedTextBox2.Text = dr["data_do_movimento_entrada"].ToString();
                maskedTextBox1.Text = dr["quantidade_entrada"].ToString();
                textBox2.Text = dr["data_do_lancamento"].ToString();
                textBox1.Text = dr["cod_prod"].ToString();
                

            }
            // Fecha a conexão
            conexao.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}
