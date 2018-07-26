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
    public partial class Recibo : Form
    {
        public Recibo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Recibo_Load(object sender, EventArgs e)
        {
           
            maskedTextBox1.Text = "00050,00";
            textBox2.Text = "Recedi(emos) do(a) Animal System v1";
            textBox3.Text = "a importância SUPRA de R$  " + maskedTextBox1.Text;
            textBox5.Text = "REFERENTE AO TITULO  Exemplo     DO DIA 00/00/0000   NO VALOR TOTAL DE R$     00000,00";
            textBox7.Text = "Valor da Parcela .......... R$      00050,00   Vencimento.:  00/00/0000    Parcela .:  x";
            textBox8.Text = "Valor da Parcela PAGA R$       00050,00   Pagamento .:  00/00/0000    Forma ...:  xxxx          ";
            textBox9.Text = "Histórico .:                                              ";
            textBox10.Text = "Histórico .:                                              ";
            textBox11.Text = "Histórico .:                                              ";
            textBox12.Text = "SUA CIDADE - UF xx de xxxxx de xxx - Dia da semana";
            textBox13.Text = "EXEMPLO DE CADASTRO";


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

            comando = new MySqlCommand("insert into recibo(cod_recibo,valor_recibo,txt1,txt2,txt3,txt4,txt5,txt6,txt7,txt8,txt9,txt10,txt11) values (@cod_recibo,@valor_recibo,@txt1,@txt2,@txt3,@txt4,@txt5,@txt6,@txt7,@txt8,@txt9,@txt10,@txt11)", conexao);
            comando.Parameters.AddWithValue("@cod_recibo", textBox1.Text);
            comando.Parameters.AddWithValue("@valor_recibo", maskedTextBox1.Text);
            comando.Parameters.AddWithValue("@txt1", textBox2.Text);
            comando.Parameters.AddWithValue("@txt2", textBox3.Text);
            comando.Parameters.AddWithValue("@txt3", textBox4.Text);
            comando.Parameters.AddWithValue("@txt4", textBox5.Text);
            comando.Parameters.AddWithValue("@txt5", textBox7.Text);
            comando.Parameters.AddWithValue("@txt6", textBox8.Text);
            comando.Parameters.AddWithValue("@txt7", textBox9.Text);
            comando.Parameters.AddWithValue("@txt8", textBox10.Text);
            comando.Parameters.AddWithValue("@txt9", textBox11.Text);
            comando.Parameters.AddWithValue("@txt10", textBox12.Text);
            comando.Parameters.AddWithValue("@txt11", textBox13.Text);










            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
        }
    }
}
