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
    public partial class cadastrarCategoria : Form
    {
        public cadastrarCategoria()
        {
            InitializeComponent();
        }
        string alter = "";
        private void btn_novo_Click(object sender, EventArgs e)
        {

            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            txt_cod.Clear();
            txt_descrição.Clear();
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

            comando = new MySqlCommand("insert into categoria(cod_categoria,descrição) values (@cod_categoria,@descrição) ", conexao);
            comando.Parameters.AddWithValue("@cod_categoria", txt_cod.Text);
            comando.Parameters.AddWithValue("@descrição", txt_descrição.Text);


            // Executa o comando SQL
            comando.ExecuteNonQuery();

            // Fecha a conexão
            conexao.Close();

            // Apresentando a mensagem de cadastro com sucesso
            MessageBox.Show("Contato cadastrado com sucesso!");

            if (alter == "OK")
            {
                comando = new MySqlCommand("UPDATE  categoria SET cod_categoria = @cod_categoria ,descrição = @descrição WHERE cod_categoria = @cod_categoria ", conexao);
            }
            else
            {
                comando = new MySqlCommand("insert into cardapio(cod_categoria,descrição) values (@cod_categoria,@descrição) ", conexao);
            }
            alter = "";
            Cardapio.cod = 0;


        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void cadastrarCategoria_Load(object sender, EventArgs e)
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

                comando = new MySqlCommand("SELECT * FROM categoria WHERE cod_categoria = @cod_categoria", conexao);
                comando.Parameters.AddWithValue("@cod_categoria", Categoria.cod);

                // Executa o comando SQL
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txt_cod.Text = dr["cod_categoria"].ToString();
                    txt_descrição.Text = dr["descrição"].ToString();
                    

                }
                // Fecha a conexão
                conexao.Close();

                alter = "OK";
            }
            else { alter = ""; }

        }
    }
}
