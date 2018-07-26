using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Animal_System
{
    public partial class frm_alimentação : Form
    {
        public frm_alimentação()
        {
            InitializeComponent();
        }
        public static int cod = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Cancelar";
            string MessageBoxContent = "Deseja Cancelar?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Cancelando !!!");
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string string_de_conexao = " Database=animalsystem; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("insert into alimentacao(Codigo_alimentação,codigo_animal,codigo_cardapio,horario,cod_funcionario,Dataf) values (@Codigo_alimentação,@codigo_animal,@codigo_cardapio,@horario,@cod_funcionario,@Dataf)", conexao);
            comando.Parameters.AddWithValue("@Codigo_alimentação", txt_cod_alimentação.Text);
            comando.Parameters.AddWithValue("@codigo_animal", txt_codanimal.Text);
            comando.Parameters.AddWithValue("@codigo_cardapio", txt_codigocardapio.Text);
            comando.Parameters.AddWithValue("@horario", txt_horario.Text);
            comando.Parameters.AddWithValue("@cod_funcionario", txt_codigofuncionario.Text);
            comando.Parameters.AddWithValue("@Dataf", txt_data.Text);
            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();

            comando = new MySqlCommand("insert into ali(cod_alimentacao,horario,data_ali,cod_cardapio) values (@cod_alimentacao,@horario,@data_ali,@cod_cardapio) ", conexao);
            comando.Parameters.AddWithValue("@cod_alimentacao", txt_codigo.Text);
            comando.Parameters.AddWithValue("@horario", maskedTextBox2.Text);
            comando.Parameters.AddWithValue("@data_ali", maskedTextBox1.Text);
            comando.Parameters.AddWithValue("@cod_cardapio", maskedTextBox3.Text);
            
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
            button1.Enabled = false;
            button5.Enabled = false;
            txt_codigo.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cardapio car = new Cardapio();
            car.ShowDialog();
            if (Cardapio.cod != 0)
            {

                maskedTextBox3.Text = Convert.ToString(Cardapio.cod);
            }
            
        }
        }
    
}
