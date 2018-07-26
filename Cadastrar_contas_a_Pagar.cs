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
    public partial class Cadastrar_contas_a_Pagar : Form
    {
        public Cadastrar_contas_a_Pagar()
        {
            InitializeComponent();
        }
        public static int plan;
        public static int plan2;
        public static string forn2 = "";
        public static int forn = 0;

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            Fornecedor fornc = new Fornecedor();
            fornc.Show();
            if (Fornecedor.forn != 0)
            {

                textBox1.Text = Convert.ToString(Fornecedor.forn);
                textBox3.Text = Convert.ToString(Fornecedor.forn2);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Centrodecusto cent = new Centrodecusto();
            cent.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try{
                string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();

                comando = new MySqlCommand("insert into contas_a_pagar(cod_CAP,cod_fornecedor,nome_fornecedor,descricao,cod_contas,descrição,data_emissão,vencimento,valor_total,valor_parcela,dados_do_cheque,Plano_de_contas,formadecobranca) values (@cod_CAP,@cod_fornecedor,@nome_fornecedor,@descricao,@cod_contas,@descrição,@data_emissão,@vencimento,@valor_total,@valor_parcela,@dados_do_cheque,@Plano_de_contas,@formadecobranca)", conexao);
                comando.Parameters.AddWithValue("@cod_CAP", textBox7.Text);
                comando.Parameters.AddWithValue("@cod_fornecedor", textBox1.Text);
                comando.Parameters.AddWithValue("@nome_fornecedor", textBox3.Text);
                comando.Parameters.AddWithValue("@descricao", textBox4.Text);
                comando.Parameters.AddWithValue("@cod_contas", textBox2.Text);
                comando.Parameters.AddWithValue("@descrição", textBox6.Text);
                comando.Parameters.AddWithValue("@data_emissão",maskedTextBox1.Text);
                comando.Parameters.AddWithValue("@vencimento", maskedTextBox2.Text);
                comando.Parameters.AddWithValue("@valor_total", maskedTextBox3.Text);
                comando.Parameters.AddWithValue("@valor_parcela", maskedTextBox4.Text);
                comando.Parameters.AddWithValue("@dados_do_cheque", richTextBox1.Text);
                comando.Parameters.AddWithValue("@Plano_de_contas", textBox2.Text);
                comando.Parameters.AddWithValue("@formadecobranca", textBox6.Text);
                



                // Executa o comando SQL
                comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                // Apresentando a mensagem de cadastro com sucesso
                MessageBox.Show("Contato cadastrado com sucesso!");
        }
                  catch{
                     MessageBox.Show("Já existe um cadastro com esse código");
                 }
            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            calendario cal = new calendario();
            cal.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Planodecontas_consulta plan = new Planodecontas_consulta();
            plan.Show();
            if (Planodecontas_consulta.plan != 0)
            {

                textBox2.Text = Convert.ToString(Planodecontas_consulta.plan);
                textBox4.Text = Convert.ToString(Planodecontas_consulta.plan2);
            }
            
        }

        private void Cadastrar_contas_a_Pagar_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToShortDateString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
