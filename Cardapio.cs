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
    public partial class Cardapio : Form
    {
        public Cardapio()
        {
            InitializeComponent();
        }
        public static string img3;
        public static int cod = 0;
        public string card = "";
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frm_cardapio car = new frm_cardapio();
            car.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Cardapio_Load(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;

            // ADAPTADOR UTILIZADO PARA EXECUTAR A CONSULTA SQL
            MySqlDataAdapter da;

            // ARMAZENAR A TABELA DE DADOS EM MEMÓRIA
            DataTable dt;

            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "SELECT cod_cardapio AS Codigo,tipo_cardapio AS Tipo,quantidade AS Quantidade,unidade AS Unidade,nome_alimento AS Alimento,imagem AS imagem FROM cardapio";

            // CRIANDO UM NOVA TABELA EM MEMÓRIA
            dt = new DataTable();

            // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
            da = new MySqlDataAdapter(sql, conexao);

            // PREENCHENDO A TABELA EM MEMÓRIA
            da.Fill(dt);

            // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
            dataGridView1.DataSource = dt;

            // FECHANDO A CONEXAO
            conexao.Close(); 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";


            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;

            // ADAPTADOR UTILIZADO PARA EXECUTAR A CONSULTA SQL
            MySqlDataAdapter da;


            // ARMAZENAR A TABELA DE DADOS EM MEMÓRIA
            DataTable dt;


            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            if (comboBox1.SelectedIndex == 0)
            {

                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "SELECT cod_cardapio AS Codigo,tipo_cardapio AS Tipo,quantidade AS Quantidade,unidade AS Unidade,nome_alimento AS Alimento,imagem AS imagem FROM cardapio WHERE cod_cardapio LIKE @cod_cardapio  ";


                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();


                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@cod_cardapio", txt_pesquisar.Text + "%");




                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;


            }
            else if (comboBox1.SelectedIndex == 1)
            {


                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "SELECT cod_cardapio AS Codigo,tipo_cardapio AS Tipo,quantidade AS Quantidade,unidade AS Unidade,nome_alimento AS Alimento,imagem AS imagem FROM cardapio WHERE tipo_cardapio LIKE @tipo_cardapio  ";

                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();

                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@tipo_cardapio", txt_pesquisar.Text + "%");


                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;



            }
            else if (comboBox1.SelectedIndex == 2)
            {


                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "SELECT cod_cardapio AS Codigo,tipo_cardapio AS Tipo,quantidade AS Quantidade,unidade AS Unidade,nome_alimento AS Alimento,imagem AS imagem FROM cardapio WHERE quantidade LIKE @quantidade";

                // CRIANDO UM NOVA TABELA EM MEMÓRIA
                dt = new DataTable();

                // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                da = new MySqlDataAdapter(sql, conexao);
                da.SelectCommand.Parameters.AddWithValue("@quantidade", txt_pesquisar.Text + "%");


                // PREENCHENDO A TABELA EM MEMÓRIA
                da.Fill(dt);

                // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                dataGridView1.DataSource = dt;


            }
            // FECHANDO A CONEXAO
            conexao.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
    }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;
            

            

            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "DELETE FROM cardapio WHERE quantidade like @c";



            
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@c", card);
            


            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frm_cardapio open_form = new frm_cardapio();
            open_form.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            card = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["quantidade"].FormattedValue.ToString());
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

            // VARIÁVEL QUE REPRESENTA A CONEXÃO
            MySqlConnection conexao;

            // ADAPTADOR UTILIZADO PARA EXECUTAR A CONSULTA SQL
            MySqlDataAdapter da;

            // ARMAZENAR A TABELA DE DADOS EM MEMÓRIA
            DataTable dt;

            // CRIANDO UM NOVA CONEXÃO
            conexao = new MySqlConnection(string_de_conexao);

            // ABRINDO A CONEXÃO
            conexao.Open();

            // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
            string sql = "SELECT cod_cardapio AS Codigo,tipo_cardapio AS Tipo,quantidade AS Quantidade,unidade AS Unidade,nome_alimento AS Alimento FROM cardapio";

            // CRIANDO UM NOVA TABELA EM MEMÓRIA
            dt = new DataTable();

            // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
            da = new MySqlDataAdapter(sql, conexao);

            // PREENCHENDO A TABELA EM MEMÓRIA
            da.Fill(dt);

            // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
            dataGridView1.DataSource = dt;

            // FECHANDO A CONEXAO
            conexao.Close(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            img3 nova_img = new img3();
            nova_img.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
              
            img3 = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["imagem"].FormattedValue.ToString());
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["cod_cardapio"].FormattedValue.ToString());
            Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
 }
}