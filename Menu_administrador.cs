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
    public partial class Menu_administrador : Form
    {
        public Menu_administrador()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = "Sair";
            string MessageBoxContent = "Deseja Sair?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Saindo !!!");
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar_animal animais = new Cadastrar_animal();
            animais.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Animal_consultar consultar = new Animal_consultar();
            consultar.ShowDialog();

        }

        private void alimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void cardapioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

   

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();

        }

        private void individuoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            produtos produto = new produtos();
            produto.ShowDialog();

        }

        private void Menu_administrador_Load(object sender, EventArgs e)
        {
            
            
            if (Form1.usuario == "Simples") { 
            financeiroToolStripMenuItem.Visible= false;
            toolStripButton4.Visible = false;
            cadastrarToolStripMenuItem.Visible = false;
            produtosToolStripMenuItem.Visible = false;
            toolStripButton1.Visible = false;
            toolStripButton6.Visible = false;
            toolStripButton7.Visible = false;
            toolStripButton8.Visible = false;
            toolStripSeparator8.Visible = false;
            toolStripSeparator7.Visible = false;
            toolStripSeparator5.Visible = false;
            toolStripSeparator4.Visible = false;
            toolStripSeparator2.Visible = false;
            toolStripSeparator1.Visible = false;


            this.Text = Form1.usuario;
            }

            else { }
            this.Visible = true;
            
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contas_a_pagar pagar = new Contas_a_pagar();
            pagar.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Contas_a_pagar pagar = new Contas_a_pagar();
            pagar.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            produtos produto = new produtos();
            produto.ShowDialog();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planodecontas_consulta consu = new Planodecontas_consulta();
            consu.ShowDialog();

        }
       
        private void centroDeCustoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Centrodecusto c = new Centrodecusto();
            c.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            incluir_produto inc = new incluir_produto();
            inc.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Centrodecusto cen = new Centrodecusto();
            cen.ShowDialog();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            PlanoDeContas plan = new PlanoDeContas();
            plan.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Estoque pro = new Estoque();
            pro.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Animal_consultar ani = new Animal_consultar();
            ani.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cadastrar_animal cadani = new Cadastrar_animal();
            cadani.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            produtos pro = new produtos();
            pro.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendario cal = new calendario();
            cal.ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque_entrada est = new Estoque_entrada();
            est.ShowDialog();

        }

        private void saidaNoEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saida saida = new saida();
            saida.ShowDialog();

        }

        private void cadastrarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frm_alimentação alimentacao = new frm_alimentação();
            alimentacao.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ConsultaAlimentacao alimentacao = new Frm_ConsultaAlimentacao();
            alimentacao.ShowDialog();
        }

        private void estoqueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estoque es = new Estoque();
            es.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Cardapio cardapio = new Cardapio();
            cardapio.ShowDialog();

        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frm_cardapio cad = new frm_cardapio();
            cad.ShowDialog();
        }
    }
}
