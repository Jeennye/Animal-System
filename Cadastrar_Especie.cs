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
    public partial class Cadastrar_Especie : Form
    {
        public Cadastrar_Especie()
        {
            InitializeComponent();
        }

        private void Cadastrar_Especie_Load(object sender, EventArgs e)
        {

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

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();
            
            comando = new MySqlCommand("insert into especie(cod_especie,cod_descricao) values (@cod_especie,@cod_descricao) ", conexao);
            comando.Parameters.AddWithValue("@cod_especie", txt_cod.Text);
            comando.Parameters.AddWithValue("@cod_descricao", txt_descrição.Text);
            
            
            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = false;
            txt_cod.Clear();
            txt_descrição.Clear();
        }
        
    }
}
