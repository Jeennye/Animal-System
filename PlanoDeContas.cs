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
    public partial class PlanoDeContas : Form
    {
        public PlanoDeContas()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
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

            comando = new MySqlCommand("insert into plano_de_contas(cod_pdc,descricao_da_conta,cod_cdc) values (@cod_pdc,@descricao_da_conta,@cod_cdc)", conexao);
            comando.Parameters.AddWithValue("@cod_pdc", textBox1.Text);
            comando.Parameters.AddWithValue("@descricao_da_conta", textBox2.Text);
            comando.Parameters.AddWithValue("@cod_cdc", textBox3.Text);
          




            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PlanoDeContas_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Centrodecusto cen = new Centrodecusto();
            cen.ShowDialog();
        }
    }
}
