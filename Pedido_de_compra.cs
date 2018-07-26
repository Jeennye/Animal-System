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
    public partial class Pedido_de_compra : Form
    {
        public Pedido_de_compra()
        {
            InitializeComponent();
        }
        public static string forn = "";

        private void button10_Click(object sender, EventArgs e)
        {
            Fornecedor form = new Fornecedor();
            form.ShowDialog();
            if (Fornecedor.forn != 0)
            {

                textBox1.Text = Convert.ToString(Fornecedor.forn);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Insira o Código do Fornecedor ");

            }
            if (textBox2.Text == "")
            {
                MessageBox.Show("Insira o Código do Produto");
            }
            else
            {
                try
                {
                    string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                    MySqlConnection conexao;
                    MySqlCommand comando;

                    // Conexão do banco de dados
                    conexao = new MySqlConnection(string_de_conexao);

                    // Abre a conexão
                    conexao.Open();
                    comando = new MySqlCommand("insert into pedido_de_compra(cod_pedido,qtd,data_pedido,hora_pedido,data_entrega,hora_entrega,cod_fornecedor,cod_prod,Unidade) values (@cod_pedido,@qtd,@data_pedido,@hora_pedido,@data_entrega,@hora_entrega,@cod_fornecedor,@cod_prod,@Unidade)", conexao);
                    comando.Parameters.AddWithValue("@cod_pedido", txt_cod.Text);
                    comando.Parameters.AddWithValue("@qtd", textBox3.Text);
                    comando.Parameters.AddWithValue("@data_pedido", maskedTextBox1.Text);
                    comando.Parameters.AddWithValue("@hora_pedido", maskedTextBox2.Text);
                    comando.Parameters.AddWithValue("@data_entrega", maskedTextBox4.Text);
                    comando.Parameters.AddWithValue("@hora_entrega", maskedTextBox3.Text);
                    comando.Parameters.AddWithValue("@cod_fornecedor", textBox1.Text);
                    comando.Parameters.AddWithValue("@cod_prod", textBox2.Text);
                    comando.Parameters.AddWithValue("@Unidade", cb_unidade.Text);



                    // Executa o comando SQL
                    comando.ExecuteNonQuery();

                    // Fecha a conexão
                    conexao.Close();
                    // Apresentando a mensagem de cadastro com sucesso
                    MessageBox.Show("Contato cadastrado com sucesso!");
                }
                catch
                {
                    MessageBox.Show("Já existe um registro com esse código!");
                }




            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            produtos pro = new produtos();
            pro.ShowDialog();
            if (produtos.cod != 0)
            {

                textBox2.Text = Convert.ToString(produtos.cod);
            }
        }

        private void Pedido_de_compra_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
        }
    }
}
