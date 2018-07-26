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
    public partial class IMG : Form
    {

        public IMG()
        {
            InitializeComponent();
        }
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IMG_Load(object sender, EventArgs e)
        {

            Image imagem = Image.FromFile(@produtos.img);
            // atribui a imagem construída à propriedade Image
            pictureBox1.Image = imagem;  
           
         

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
