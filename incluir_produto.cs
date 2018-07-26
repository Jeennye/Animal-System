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
    public partial class incluir_produto : Form
    {
        public incluir_produto()
        {
            InitializeComponent();

        }
        public static string categoria;
        public static string nome;
        public static int cod;

      
      

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image.Tag = openFileDialog1.FileName;
                pictureBox1.Refresh();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void incluir_produto_Load(object sender, EventArgs e)
        {
            txt_cod.Focus();
            txt_cod.Select();
            txt_cod.Enabled = false;
            cb_unidade.Enabled = false;
            txt_descrição.Enabled = false;
            txt_marca.Enabled = false;
            txt_categoria.Enabled = false;
            txt_estoquemin.Enabled = false;
            txt_validade.Enabled = false;
            textBox1.Enabled = false;
            txt_comentario.Enabled = false;
                
            if (produtos.alter == 1)
            {

                txt_cod.Enabled = true;
                cb_unidade.Enabled = true;
                txt_descrição.Enabled = true;
                txt_marca.Enabled = true;
                txt_categoria.Enabled = true;
                txt_estoquemin.Enabled = true;
                txt_validade.Enabled = true;
                textBox1.Enabled = true;
                txt_comentario.Enabled = true;
            
            
                produtos.alter = 2;
                string sc = "Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(sc);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT * FROM produto WHERE cod_prod = @cod_prod", conexao);
                comando.Parameters.AddWithValue("@cod_prod", produtos.cod);

                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                   txt_cod.Text = dr["cod_prod"].ToString();
                   textBox1.Text = dr["cod_fornecedor"].ToString();
                   cb_unidade.Text = dr["unidade"].ToString();
                   txt_validade.Text = dr["validade_produto"].ToString();
                   txt_estoquemin.Text = dr["Estoque_minimo"].ToString();
                   txt_descrição.Text = dr["Descricao_prod"].ToString();
                   txt_marca.Text = dr["cod_marca"].ToString();
                   txt_categoria.Text = dr["cod_categoria"].ToString();
                   txt_comentario.Text = dr["comentario"].ToString();
                }
                
                // Fecha a conexão
                conexao.Close();
               
            }
            txt_cod.Enabled = false;
            
        

            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cb_unidade.Items.Add("UNI");
            cb_unidade.Items.Add("KG");
            cb_unidade.Items.Add("PC");
            cb_unidade.Items.Add("CX");
            cb_unidade.Items.Add("PAR");
            cb_unidade.Items.Add("ML");
            cb_unidade.Items.Add("MT");
            cb_unidade.Items.Add("MTL");
            cb_unidade.Items.Add("MTR");
            cb_unidade.Items.Add("MT2");
            cb_unidade.Items.Add("MT3");
            cb_unidade.Items.Add("MIL");
            cb_unidade.Items.Add("BAR");
            cb_unidade.Items.Add("LTR");
            cb_unidade.Items.Add("PCT");
            cb_unidade.Items.Add("CNJ");
            cb_unidade.Items.Add("PCA");
            try
            {

                string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;

                // Conexão do banco de dados
                conexao = new MySqlConnection(string_de_conexao);

                // Abre a conexão
                conexao.Open();
                if (Animal_consultar.alter == 2)
                {
                    comando = new MySqlCommand("UPDATE produto SET cod_fornecedor=@cod_fornecedor,unidade=@unidade,validade_produto=@validade_produto,Estoque_minimo=@Estoque_minimo,Descricao_prod=@Descriçao_prod,cod_marca=@cod_marca,cod_categoria=@cod_categoria,comentario=@comentario,imagem1=@imagem1 WHERE cod_prod=@cod_prod", conexao);

                }
                else
                {
                    comando = new MySqlCommand("insert into produto(cod_prod,cod_fornecedor,unidade,validade_produto,Estoque_minimo,Descricao_prod,cod_marca,cod_categoria,comentario,imagem1) values (@cod_prod,@cod_fornecedor,@unidade,@validade_produto,@Estoque_minimo,@Descricao_prod,@cod_marca,@cod_categoria,@comentario,@imagem1) ", conexao);
                }
                comando.Parameters.AddWithValue("@cod_prod", txt_cod.Text);
                comando.Parameters.AddWithValue("@cod_fornecedor", textBox1.Text);
                comando.Parameters.AddWithValue("@unidade", cb_unidade.Text);
                comando.Parameters.AddWithValue("@validade_produto", txt_validade.Text);
                comando.Parameters.AddWithValue("@Estoque_minimo", txt_estoquemin.Text);
                comando.Parameters.AddWithValue("@Descricao_prod", txt_descrição.Text);
                comando.Parameters.AddWithValue("@cod_marca", txt_marca.Text);
                comando.Parameters.AddWithValue("@cod_categoria", txt_categoria.Text);
                comando.Parameters.AddWithValue("@comentario", txt_comentario.Text);
                comando.Parameters.AddWithValue("@imagem1", pictureBox1.Image.Tag);



                // Executa o comando SQL
                comando.ExecuteNonQuery();

                // Fecha a conexão
                conexao.Close();

                // Apresentando a mensagem de cadastro com sucesso
                MessageBox.Show("Contato cadastrado com sucesso!");
            }
            catch
            {
                MessageBox.Show("Peencha os campos corretamente!, verefique se os campos código,marca ou categoria estão preenchido");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txt_comentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_cod.Enabled = true;
            cb_unidade.Enabled = true;
            txt_descrição.Enabled = true;
            txt_marca.Enabled = true;
            txt_categoria.Enabled = true;
            txt_estoquemin.Enabled = true;
            txt_validade.Enabled = true;
            textBox1.Enabled = true;
            txt_comentario.Enabled = true;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            txt_cod.Clear();
            txt_descrição.Clear();
            txt_marca.Clear();
            txt_categoria.Clear();
            txt_estoquemin.Clear();
            txt_validade.Clear();
            txt_comentario.Clear();
          
            
            



            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Marca form_marca = new Marca();
            form_marca.Show();
            if (Marca.nome != "")
            {

                txt_marca.Text = Convert.ToString(Marca.nome);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fornecedor forn = new Fornecedor();
            forn.Show();
            if (Fornecedor.forn != 0)
            {

                textBox1.Text = Convert.ToString(Fornecedor.forn);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            cat.Show();
            if (Categoria.categoria != "")
            {

                txt_categoria.Text = Convert.ToString(Categoria.categoria);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pesquisa_plano_de_contas ped = new Pesquisa_plano_de_contas();
            ped.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
