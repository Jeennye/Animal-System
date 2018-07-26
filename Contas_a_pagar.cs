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
    public partial class Contas_a_pagar : Form
    {
        public Contas_a_pagar()
        {
            InitializeComponent();
        }
        public string pagar;


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Cadastrar_contas_a_Pagar cadd = new Cadastrar_contas_a_Pagar();
            cadd.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Parcelamento parc = new Parcelamento();
            parc.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Recibo rec = new Recibo();
            rec.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Pagar pg = new Pagar();
            pg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Contas_a_pagar_Load(object sender, EventArgs e)
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
        

            string sql = "SELECT cod_CAP AS Codigo,descrição AS Descricao,data_emissão AS emissao,vencimento AS Vencimento,valor_total AS total,valor_parcela AS percela,dados_do_cheque AS cheque,Plano_de_contas AS contas,Titlulo AS titulo FROM contas_a_pagar";
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            string sql = "DELETE FROM contas_a_pagar WHERE descrição like @d";
            MessageBox.Show(pagar);

            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@d", pagar);



            cmd.ExecuteNonQuery();

            // FECHANDO A CONEXAO
            conexao.Close();

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pagar = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["descrição"].FormattedValue.ToString());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
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


            string sql = "SELECT cod_CAP AS Codigo,descrição AS Descricao,data_emissão AS emissao,vencimento AS Vencimento,valor_total AS total,valor_parcela AS percela,dados_do_cheque AS cheque,Plano_de_contas AS contas,Titlulo AS titulo FROM contas_a_pagar";

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

        

        }
    }

