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
    public partial class Cadastrar_animal : Form
    {
        public Cadastrar_animal()
        {
            InitializeComponent();
        }
        public string alter = "";
        public static double tamanho;
        public static double peso;
        
        private void Cadastrar_animal_Load(object sender, EventArgs e)
        {
            txt_codigo.Enabled = false;
            txt_nome.Enabled = false;
            txt_data.Enabled = false;
            txt_tamanho.Enabled = false;
            txt_peso.Enabled = false;
            txt_especieanimal.Enabled = false;
            txt_codalimentação.Enabled = false;
            txt_sexo.Enabled = false;
            

            if (Animal_consultar.alter == 1 )
            {

                txt_codigo.Enabled = true;
                txt_nome.Enabled = true;
                txt_data.Enabled = true;
                txt_tamanho.Enabled = true;
                txt_peso.Enabled = true;
                txt_especieanimal.Enabled = true;
                txt_codalimentação.Enabled = true;
                txt_sexo.Enabled = true;
            
                Animal_consultar.alter = 2;
                string sc = "Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(sc);

                // Abre a conexão
                conexao.Open();
                comando = new MySqlCommand("SELECT * FROM animal WHERE cod_animal = @cod_animal", conexao);
                comando.Parameters.AddWithValue("@cod_animal", Animal_consultar.cod);

                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txt_codigo.Text = dr["cod_animal"].ToString();
                    txt_nome.Text = dr["nome_animal"].ToString();
                    txt_data.Text = dr["data_animal"].ToString();
                    txt_tamanho.Text = dr["tamanho_animal"].ToString();
                    txt_peso.Text = dr["peso_animal"].ToString();
                    cb_tipo.Text = dr["tipo_animal"].ToString();
                    txt_sexo.Text = dr["sexo_animal"].ToString();
                    txt_especieanimal.Text = dr["especie_animal"].ToString();
                    txt_codalimentação.Text = dr["cod_alimentacao"].ToString();
                    
                }
                
                // Fecha a conexão
                conexao.Close();
            }

            txt_codigo.Enabled = false;
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
                cb_tipo.Items.Add("Mamifero");
                cb_tipo.Items.Add("Peixe");
                cb_tipo.Items.Add("Reptil");
                cb_tipo.Items.Add("Ave");
                cb_tipo.Items.Add("Anfibio");


     

                if  (txt_codalimentação.Text == "")
                {
                    MessageBox.Show("Insira Código da Alimentação");

                }
                 if (txt_especieanimal.Text == "")
                {
                    MessageBox.Show("Insira a Espécie");
                }
                else 
                {
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
                            comando = new MySqlCommand("UPDATE animal SET nome_animal=@nome_animal,tipo_animal=@tipo_animal,especie_animal=@especie_animal,tamanho_animal=@tamanho_animal,peso_animal=@peso_animal,sexo_animal=@sexo_animal WHERE cod_animal=@cod_animal", conexao);

                        }
                        else
                        {
                            comando = new MySqlCommand("insert into animal(cod_animal,nome_animal,tipo_animal,especie_animal,tamanho_animal,peso_animal,sexo_animal,cod_alimentacao,data_animal,imagem) values (@cod_animal,@nome_animal,@tipo_animal,@especie_animal,@tamanho_animal,@peso_animal,@sexo_animal,@cod_alimentacao,@data_animal,@imagem)", conexao);

                        }

                        comando.Parameters.AddWithValue("@cod_animal", txt_codigo.Text);
                        comando.Parameters.AddWithValue("@nome_animal", txt_nome.Text);
                        comando.Parameters.AddWithValue("@tipo_animal", cb_tipo.Text);
                        comando.Parameters.AddWithValue("@especie_animal", txt_especieanimal.Text);
                        comando.Parameters.AddWithValue("@tamanho_animal", txt_tamanho.Text);
                        comando.Parameters.AddWithValue("@peso_animal", txt_peso.Text);
                        comando.Parameters.AddWithValue("@sexo_animal", txt_sexo.Text);
                        comando.Parameters.AddWithValue("@cod_alimentacao", txt_codalimentação.Text);
                        comando.Parameters.AddWithValue("@data_animal", txt_data.Text);
                        comando.Parameters.AddWithValue("@imagem", pictureBox1.Image.Tag);



                        // Executa o comando SQL
                        comando.ExecuteNonQuery();

                        // Fecha a conexão
                        conexao.Close();
                        // Apresentando a mensagem de cadastro com sucesso
                        MessageBox.Show("Contato cadastrado com sucesso!");
                    }
                    catch
                    {
                        MessageBox.Show("Já existe um registro com esse código!");
                    }



                       
                    }
             
                
            
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cod_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txt_marca_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = true;
            button1.Enabled = true;
            txt_codigo.Enabled = true;
            txt_nome.Enabled = true;
            txt_data.Enabled = true;
            txt_tamanho.Enabled = true;
            txt_peso.Enabled = true;
            txt_especieanimal.Enabled = true;
            txt_codalimentação.Enabled = true;
            txt_sexo.Enabled = true;

            txt_codigo.Clear();
            txt_nome.Clear();
            txt_data.Clear();
            txt_tamanho.Clear();
            txt_peso.Clear();
            txt_especieanimal.Clear();
            txt_codalimentação.Clear();
            txt_sexo.Clear();

            
            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Especie esp = new Especie();
            esp.Show();
            if (Especie.especie != 0)
            {

                txt_especieanimal.Text = Convert.ToString(Especie.especie);
            }
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_ConsultaAlimentacao form = new Frm_ConsultaAlimentacao();
            form.ShowDialog();
            if (Frm_ConsultaAlimentacao.cod != 0)
            {

                txt_codalimentação.Text = Convert.ToString(Frm_ConsultaAlimentacao.cod);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Peso p = new Peso();
            p.ShowDialog();
            if (Peso.peso != 0)
            {

                txt_peso.Text = Convert.ToString(Peso.peso);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tamanho tam = new Tamanho();
            tam.ShowDialog();
            if (Tamanho.tamanho != 0)
            {
                
                txt_tamanho.Text = Convert.ToString(Tamanho.tamanho);
            }
            
            
        }

        private void txt_codigo_MouseClick(object sender, MouseEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
