using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;





namespace Animal_System
{
 
    public partial class Form1 : Form
       
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string usuario = "";

        private void button1_Click(object sender, EventArgs e)
        {
            cb_usuario.Items.Add("Adiministrador");
            cb_usuario.Items.Add("Simples");
            if (cb_usuario.Text == "Administrador")
            {
                if (txt_senha.Text == "etec")
                {
                    usuario = "Adiministrador";
                    Close();  

                  
                                     
                }

            }
            if (cb_usuario.Text == "Simples")
            {
                if (txt_senha.Text == "123")
                {
                    usuario = "Simples";
                    Close();

                }
            }
            else
            {
                MessageBox.Show("Usuario  ou Senha incorreto");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();                                                                                                                                                                                                                                                                            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cb_usuario.Items.Add("Adiministrador");
            cb_usuario.Items.Add("Simples");
            if (cb_usuario.Text == "Adiministrador")
            {
                if (txt_senha.Text == "etec")
                {
                    Menu_administrador menu = new Menu_administrador();
                    menu.Show(); 

                    usuario = "Administrador";
                     
                    this.Visible = false;

                    
                                      

                     


                }

            }
            else if  (cb_usuario.Text == "Simples")
            {
                if (txt_senha.Text == "123")
                {

                    usuario = "Simples";
                    Menu_administrador menu = new Menu_administrador();
                    menu.Show();

                    

                    this.Visible = false;

                }
            }
            else
            {
                MessageBox.Show("Usuario  ou Senha incorreto");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();                                                                                                                                                                                                                                                     
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        }
    }

