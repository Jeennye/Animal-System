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
    public partial class Pagar : Form
    {
        public Pagar()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("UPDATE contas_a_pagar SET valor_total=valor_total-@valor_totalpago where cod_CAP=@cod_CAP", conexao);
            comando.Parameters.AddWithValue("@valor_totalpago", maskedTextBox8.Text);
            comando.Parameters.AddWithValue("@cod_CAP", textBox2.Text);


            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Produto retirado com sucesso!");
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

            comando = new MySqlCommand("insert into pagar(cod_pagar,confirmacao_cobranca,data_pagamento,valor_juros,valor_desconto,valor_total,valor_multa,numero_cheque,porcentagem_juros,porcentagem_desconto,porcentagem_multa) values (@cod_pagar,@confirmacao_cobranca,@data_pagamento,@valor_juros,@valor_desconto,@valor_total,@valor_multa,@numero_cheque,@porcentagem_juros,@porcentagem_desconto,@porcentagem_multa)", conexao);
            comando.Parameters.AddWithValue("@cod_pagar", textBox2.Text);
            comando.Parameters.AddWithValue("@confirmacao_cobranca", textBox3.Text);
            comando.Parameters.AddWithValue("@data_pagamento", maskedTextBox1.Text);
            comando.Parameters.AddWithValue("@valor_juros", maskedTextBox2.Text);
            comando.Parameters.AddWithValue("@valor_desconto", maskedTextBox6.Text);
            comando.Parameters.AddWithValue("@valor_total", maskedTextBox8.Text);
            comando.Parameters.AddWithValue("@valor_multa", maskedTextBox5.Text);
            comando.Parameters.AddWithValue("@numero_cheque", textBox1.Text);
            comando.Parameters.AddWithValue("@porcentagem_juros", maskedTextBox3.Text);
            comando.Parameters.AddWithValue("@porcentagem_desconto", maskedTextBox7.Text);
            comando.Parameters.AddWithValue("@porcentagem_multa", maskedTextBox4.Text);
           
           

            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calendario cal = new calendario();
            cal.Show();
        }
    }
}
