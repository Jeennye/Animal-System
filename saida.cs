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
    public partial class saida : Form
    {
        public saida()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void saida_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
            maskedTextBox1.Enabled = false;
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

        private void button4_Click(object sender, EventArgs e)
        {
            produtos saida = new produtos();
            saida.ShowDialog();
            if (produtos.cod != 0)
            {

                textBox2.Text = Convert.ToString(produtos.cod);
            }
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;
            MySqlCommand comando2;


            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();
            
            comando = new MySqlCommand("UPDATE entrada_estoque SET qtd_entrada=qtd_entrada-@qtd_saida where cod_entrada=@cod_entrada", conexao);
            comando.Parameters.AddWithValue("@qtd_saida", textBox1.Text);
            comando.Parameters.AddWithValue("@cod_entrada", txt_cod.Text);

            comando2 = new MySqlCommand("insert into saida(cod_saida,data_do_movimento_saida,quantidade_saida,data_do_sistema,unidade,cod_prod,Valor_unitario) values (@cod_saida,@data_do_movimento_saida,@quantidade_saida,@data_do_sistema,@unidade,@cod_prod,@Valor_unitario) ", conexao);
            comando2.Parameters.AddWithValue("@cod_saida", txt_cod.Text);
            comando2.Parameters.AddWithValue("@data_do_movimento_saida", maskedTextBox2.Text);
            comando2.Parameters.AddWithValue("@quantidade_saida", textBox1.Text);
            comando2.Parameters.AddWithValue("@data_do_sistema", maskedTextBox1.Text);
            comando2.Parameters.AddWithValue("@unidade", cb_unidade.Text);
            comando2.Parameters.AddWithValue("@cod_prod", textBox2.Text);
            comando2.Parameters.AddWithValue("@Valor_unitario", maskedTextBox3.Text);


            // Executa o comando SQL
            comando.ExecuteNonQuery();
            comando2.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Produto retirado com sucesso!");
        }
    }
}
