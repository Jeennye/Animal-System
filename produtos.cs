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
    public partial class produtos : Form
    {
        public produtos()
        {
            InitializeComponent();
        }
        public string prod = "";
        public static int cod;
        public static string img;
        public static int alter = 0;
        public static int Estoque_minimo;
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            incluir_produto incluir_prod = new incluir_produto();
            incluir_prod.ShowDialog();
        }

        private void produtos_Load(object sender, EventArgs e)

        {
           // STRING DE CONEXÃO COM OS DADOS DO BANCO DE DADOS
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
            string sql = "SELECT Descricao_prod AS Produto, Estoque_minimo AS  minimo,cod_prod AS codigo,imagem1 AS Imagem FROM produto";
          

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

        private void button2_Click(object sender, EventArgs e)
        {

             
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            string sql = "DELETE FROM Produto WHERE Descriçao_prod like @d";



            
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@d", prod);
            


            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
 
        }
       

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            
            
            // try
            //{
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
                    string sql = "SELECT Descricao_prod AS Produto,Estoque_minimo AS Minimo,cod_prod AS codigo FROM produto WHERE cod_prod LIKE @cod_prod ";


                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();


                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@cod_prod", txt_pesquisar.Text + "%");




                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;


                }
                else if (comboBox1.SelectedIndex == 1)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT Descricao_prod AS Produto,Estoque_minimo AS Minimo,cod_prod AS codigo FROM produto WHERE Descricao_prod LIKE @Descricao_prod  ";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@Descricao_prod", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;



                }
                else if (comboBox1.SelectedIndex == 2)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT Descricao_prod AS Produto,Estoque_minimo AS Minimo,cod_prod AS codigo FROM produto WHERE Estoque_minimo LIKE @Estoque_minimo";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@Estoque_minimo", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;


                
                // FECHANDO A CONEXAO
                conexao.Close();
            }
           // catch{
               // MessageBox.Show("Selecione um filtro de pesquisa");
            //}
            
        
            

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cod = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString());
            img = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["imagem1"].FormattedValue.ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            IMG imagem = new IMG();
            imagem.Show();
            //imagem.img = img;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            prod = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["produto"].FormattedValue.ToString());
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            cod = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["codigo"].FormattedValue.ToString());
            Close();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string string_de_conexao = "Database=animal system; Data Source=127.0.0.1; Port=3306; User id=root; Password=;";

                // VARIÁVEL QUE REPRESENTA A CONEXÃO
                MySqlConnection conexao;




                // CRIANDO UM NOVA CONEXÃO
                conexao = new MySqlConnection(string_de_conexao);

                // ABRINDO A CONEXÃO
                conexao.Open();

                // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                string sql = "DELETE FROM produto WHERE Descricao_prod like @p";




                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@p", prod);



                cmd.ExecuteNonQuery();

                // FECHANDO A CONEXAO
                conexao.Close();

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Esse registro não pode ser apagado pois está relacionado com outra tabela");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            alter = 1;
            incluir_produto prod = new incluir_produto();
            prod.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // STRING DE CONEXÃO COM OS DADOS DO BANCO DE DADOS
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
            string sql = "SELECT cod_prod AS codigo,Descricao_prod AS Produto,Estoque_minimo AS minimo,imagem1 AS Imagem FROM produto";


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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
