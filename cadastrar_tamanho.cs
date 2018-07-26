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
    public partial class cadastrar_tamanho : Form
    {
        public cadastrar_tamanho()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_salvar.Enabled = false;
            btn_novo.Enabled = false;
            txt_cod.Clear();
            maskedTextBox1.Clear();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("insert into tamanho_do_animal(codigo_tamanho,data_tamanho) values (@codigo_tamanho,@data_tamanho) ", conexao);
            comando.Parameters.AddWithValue("@codigo_tamanho", txt_cod.Text);
            comando.Parameters.AddWithValue("@data_tamanho", maskedTextBox1.Text);


            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        private void cadastrar_tamanho_Load(object sender, EventArgs e)
        {

        }
    }
}
