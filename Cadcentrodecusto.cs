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
    public partial class Cadcentrodecusto : Form
    {
        public Cadcentrodecusto()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
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

            comando = new MySqlCommand("insert into centro_de_custo(cod_cdc,descrição,tipo,observação) values (@cod_cdc,@descrição,@tipo,@observação)", conexao);
            comando.Parameters.AddWithValue("@cod_cdc", textBox1.Text);
            comando.Parameters.AddWithValue("@descrição", textBox2.Text);
            comando.Parameters.AddWithValue("@tipo", textBox3.Text);
            comando.Parameters.AddWithValue("@observação", textBox4.Text);
      




            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }
    }
}
