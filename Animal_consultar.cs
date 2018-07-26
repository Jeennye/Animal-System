using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Animal_System
{
    public partial class Animal_consultar : Form
    {
        public Animal_consultar()
        {
            InitializeComponent();
        }
        public static string img;
        public string ani = "";
        public static int cod = 0;
        public static int alter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cod = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Codigo"].FormattedValue.ToString());
           
             
            img = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["imagem"].FormattedValue.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Animal_consultar_Load(object sender, EventArgs e)
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
            string sql = "SELECT cod_animal AS Codigo,nome_animal AS Animal,tipo_animal AS tipo,especie_animal AS Especie,tamanho_animal AS Tamanho,peso_animal AS Peso,sexo_animal AS sexo,cod_alimentacao AS Alimentacao,imagem AS Imagem FROM animal";

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
            img2 i = new img2();
            i.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            try
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
                    string sql = "SELECT cod_animal AS Codigo,nome_animal AS Animal,tipo_animal AS tipo,especie_animal AS Especie,tamanho_animal AS Tamanho,peso_animal AS Peso,sexo_animal AS sexo,cod_alimentacao AS Alimentacao,imagem AS Imagem FROM animal WHERE cod_animal LIKE @cod_animal ";


                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();


                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@cod_animal", txt_pesquisar.Text + "%");




                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;


                }
                else if (comboBox1.SelectedIndex == 1)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT cod_animal AS Codigo,nome_animal AS Animal,tipo_animal AS tipo,especie_animal AS Especie,tamanho_animal AS Tamanho,peso_animal AS Peso,sexo_animal AS sexo,cod_alimentacao AS Alimentacao,imagem AS Imagem FROM animal where nome_animal like @nome_animal  ";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@nome_animal", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;



                }
                else if (comboBox1.SelectedIndex == 2)
                {


                    // COMANDO SQL PARA SELECIONAR TODOS OS DADOS DO PETSHOP
                    string sql = "SELECT cod_animal AS Codigo,nome_animal AS Animal,tipo_animal AS tipo,especie_animal AS Especie,tamanho_animal AS Tamanho,peso_animal AS Peso,sexo_animal AS sexo,cod_alimentacao AS Alimentacao,imagem AS Imagem FROM animal where tipo_animal like @tipo_animal";

                    // CRIANDO UM NOVA TABELA EM MEMÓRIA
                    dt = new DataTable();

                    // CRIANDO UM NOVO ADAPTADOR E EXECUTANDO A CONSULTA
                    da = new MySqlDataAdapter(sql, conexao);
                    da.SelectCommand.Parameters.AddWithValue("@tipo_animal", txt_pesquisar.Text + "%");


                    // PREENCHENDO A TABELA EM MEMÓRIA
                    da.Fill(dt);

                    // LIGANDO A GRADE COM OS RESULTADOS DA TABELA EM MEMÓRIA
                    dataGridView1.DataSource = dt;



                    // FECHANDO A CONEXAO
                    conexao.Close();
                }
            }
            catch{
                MessageBox.Show("Selecione um filtro de pesquisa");
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cadastrar_animal ani = new Cadastrar_animal();
            ani.Show();

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
            string sql = "DELETE FROM animal WHERE nome_animal like @a";




            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@a", ani);



            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            ani = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["animal"].FormattedValue.ToString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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
            string sql = "SELECT cod_animal AS Codigo,nome_animal AS Animal,tipo_animal AS tipo,especie_animal AS Especie,tamanho_animal AS Tamanho,peso_animal AS Peso,sexo_animal AS sexo,cod_alimentacao AS Alimentacao,imagem AS Imagem FROM animal";

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            alter = 1;
            Cadastrar_animal frm_ani = new Cadastrar_animal();
            frm_ani.ShowDialog();

            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }
        
    }
}
