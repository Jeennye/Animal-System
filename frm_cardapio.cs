using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace Animal_System
{
    public partial class frm_cardapio : Form
    {
        public frm_cardapio()
        {
            InitializeComponent();
        }
        string alter = "";
        private void frm_cardapio_Load(object sender, EventArgs e)
        {
            if (Cardapio.cod > 0)
            {

                string sc = "Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

                MySqlConnection conexao;
                MySqlCommand comando;
                MySqlDataReader dr = null;

                // Conexão do banco de dados
                conexao = new MySqlConnection(sc);

                // Abre a conexão
                conexao.Open();

                comando = new MySqlCommand("SELECT * FROM cardapio WHERE cod_cardapio = @cod_cardapio", conexao);
                comando.Parameters.AddWithValue("@cod_cardapio", Cardapio.cod);

                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txt_codigo.Text = dr["cod_cardapio"].ToString();
                    txt_nome.Text = dr["nome_alimento"].ToString();
                    txt_quantidade.Text = dr["quantidade"].ToString();
                    cb_unidade.Text = dr["unidade"].ToString();
                    cb_tipoalimento.Text = dr["tipo_cardapio"].ToString();
                    
                }
                // Fecha a conexão
                conexao.Close();

                alter = "OK";
            }
            else { alter = ""; }


        }

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

        private void button3_Click(object sender, EventArgs e)
        {
           





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Cardapio consulta = new Cardapio();
            consulta.Show();
        }

        private void cb_tipoalimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_tipoalimento.Items.Add("Grupo1(Cereais");
            cb_tipoalimento.Items.Add("Grupo2(Raizes)");
            cb_tipoalimento.Items.Add("Grupo3(Pães e Massa)");
            cb_tipoalimento.Items.Add("Grupo4(Frutas)");
            cb_tipoalimento.Items.Add("Grupo5(Verduras)");
            cb_tipoalimento.Items.Add("Grupo6(Leguminosos)");
            cb_tipoalimento.Items.Add("Grupo7(Carnes/Feijão/Ovo)");
            cb_tipoalimento.Items.Add("Grupo8(Leites e Derivados)");
            cb_tipoalimento.Items.Add("Grupo9(Doces e açucares)");
            cb_tipoalimento.Items.Add("Grupo9(Óleos e Gorduras)");
            cb_tipoalimento.Items.Add("Grupo9(Hortaliças)");


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            button1.Enabled = false;
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_quantidade.Clear();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cb_unidade.Items.Add("UNI");
            cb_unidade.Items.Add("KG");
            cb_unidade.Items.Add("PC");
            cb_unidade.Items.Add("CX");
            cb_unidade.Items.Add("PAR");
            cb_unidade.Items.Add("ML");
            cb_unidade.Items.Add("MRT");
            cb_unidade.Items.Add("MT2");
            cb_unidade.Items.Add("MT3");
            cb_unidade.Items.Add("MIL");
            cb_unidade.Items.Add("BAR");
            cb_unidade.Items.Add("LTR");
            cb_unidade.Items.Add("PCT");
            cb_unidade.Items.Add("CNJ");
            cb_unidade.Items.Add("PAC");

            cb_tipoalimento.Items.Add("Cereais");
            cb_tipoalimento.Items.Add("Raízes");
            cb_tipoalimento.Items.Add("Pães e Massa");
            cb_tipoalimento.Items.Add("Frutas");
            cb_tipoalimento.Items.Add("Verduras");
            cb_tipoalimento.Items.Add("Leguminosos");
            cb_tipoalimento.Items.Add("Carnes/Feijão/Ovo");
            cb_tipoalimento.Items.Add("Leites e Derivados");
            cb_tipoalimento.Items.Add("Doces e Açucares");
            cb_tipoalimento.Items.Add("Óleos e Gorduras");
            cb_tipoalimento.Items.Add("Hortaliças");


            string string_de_conexao = " Database=animal system; Data Source=127.0.0.1; Port=3306; User Id=root; Password= ;";

            MySqlConnection conexao;
            MySqlCommand comando;

            // Conexão do banco de dados
            conexao = new MySqlConnection(string_de_conexao);

            // Abre a conexão
            conexao.Open();
            if (alter == "OK")
            {
                comando = new MySqlCommand("UPDATE  cardapio SET tipo_cardapio = @tipo_cardapio ,quantidade = @quantidade,unidade = @unidade,nome_alimento = @nome_alimento WHERE cod_cardapio = @cod_cardapio ", conexao);
            }
            else
            {
                comando = new MySqlCommand("insert into cardapio(cod_cardapio,tipo_cardapio,quantidade,unidade,nome_alimento,imagem,tipo_cardapio2,tipo_cardapio3,tipo_cardapio4,quantidade2,quantidade3,quantidade4,unidade2,unidade3,unidade4,nome_alimento2,nome_alimento3,nome_alimento4,imagem2,imagem3,imagem4) values (@cod_cardapio,@tipo_cardapio,@quantidade,@unidade,@nome_alimento,@imagem,@tipo_cardapio2,@tipo_cardapio3,@tipo_cardapio4,@quantidade2,@quantidade3,@quantidade4,@unidade2,@unidade3,@unidade4,@nome_alimento2,@nome_alimento3,@nome_alimento4,@imagem2,@imagem3,@imagem4) ", conexao);
            }
            comando.Parameters.AddWithValue("@cod_cardapio", txt_codigo.Text);
            comando.Parameters.AddWithValue("@tipo_cardapio", cb_tipoalimento.Text);
            comando.Parameters.AddWithValue("@quantidade", txt_quantidade.Text);
            comando.Parameters.AddWithValue("@unidade", cb_unidade.Text);
            comando.Parameters.AddWithValue("@nome_alimento", txt_nome.Text);
            comando.Parameters.AddWithValue("@imagem", pictureBox1.Image.Tag);
            comando.Parameters.AddWithValue("@tipo_cardapio2", comboBox2.Text);
            comando.Parameters.AddWithValue("@tipo_cardapio3", comboBox4.Text);
            comando.Parameters.AddWithValue("@tipo_cardapio4", comboBox6.Text);
            comando.Parameters.AddWithValue("@quantidade2", maskedTextBox1.Text);
            comando.Parameters.AddWithValue("@quantidade3", maskedTextBox2.Text);
            comando.Parameters.AddWithValue("@quantidade4", maskedTextBox3.Text);
            comando.Parameters.AddWithValue("@unidade2", comboBox1.Text);
            comando.Parameters.AddWithValue("@unidade3", comboBox3.Text);
            comando.Parameters.AddWithValue("@unidade4", comboBox5.Text);
            comando.Parameters.AddWithValue("@nome_alimento2", textBox1.Text);
            comando.Parameters.AddWithValue("@nome_alimento3", textBox2.Text);
            comando.Parameters.AddWithValue("@nome_alimento4", textBox3.Text);
            comando.Parameters.AddWithValue("@imagem2", pictureBox2.Image.Tag);
            comando.Parameters.AddWithValue("@imagem3", pictureBox3.Image.Tag);
            comando.Parameters.AddWithValue("@imagem4", pictureBox4.Image.Tag);
           
            
           

            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();
            alter = "";
            Cardapio.cod = 0;
            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");
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
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image.Tag = openFileDialog1.FileName;
                pictureBox2.Refresh();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog3.InitialDirectory = "c:\\";
            openFileDialog3.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog3.FilterIndex = 2;
            openFileDialog3.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox3.Image.Tag = openFileDialog1.FileName;
                pictureBox3.Refresh();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog4.InitialDirectory = "c:\\";
            openFileDialog4.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            openFileDialog4.FilterIndex = 2;
            openFileDialog4.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox4.Image.Tag = openFileDialog1.FileName;
                pictureBox4.Refresh();

            }
        }
    }
}
