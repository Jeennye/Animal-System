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
    public partial class novo_fornecedor : Form
    {
        public novo_fornecedor()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = false;
            txt_cod.Clear();
            txt_nome.Clear();
            txt_endereço.Clear();
            txt_fone.Clear();
            Descrição.Clear();
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

            comando = new MySqlCommand("insert into fornecedor(cod_fornecedor,nome,tipo,fone,endereço,descricão) values (@cod_fornecedor,@nome,@tipo,@fone,@endereço,@descricão)", conexao);
            comando.Parameters.AddWithValue("@cod_fornecedor", txt_cod.Text);
            comando.Parameters.AddWithValue("@nome", txt_nome.Text);
            comando.Parameters.AddWithValue("@tipo", cb_tipo.Text);
            comando.Parameters.AddWithValue("@fone", txt_fone.Text);
            comando.Parameters.AddWithValue("@endereço", txt_endereço.Text);
            comando.Parameters.AddWithValue("@descricão", Descrição.Text);
           

            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
