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
    public partial class Cadastrar_Marca : Form
    {
        public Cadastrar_Marca()
        {
            InitializeComponent();
        }

        private void txt_cod_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

            comando = new MySqlCommand("insert into marca(cod_marca,descrição) values (@cod_marca,@descrição) ", conexao);
            comando.Parameters.AddWithValue("@cod_marca", txt_cod.Text);
            comando.Parameters.AddWithValue("@descrição", txt_descrição.Text);
            
            
            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            btn_salvar.Enabled = false;
            txt_cod.Clear();
            txt_descrição.Clear();
            
        }

        private void Cadastrar_Marca_Load(object sender, EventArgs e)
        {

        }

        private void txt_descrição_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        }
    }

