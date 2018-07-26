namespace Animal_System
{
    partial class Pesquisa_plano_de_contas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisa_plano_de_contas));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_entrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(649, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_pedido,
            this.qtd,
            this.data_pedido,
            this.hora_pedido,
            this.data_entrega,
            this.hora_entrega,
            this.cod_fornecedor,
            this.cod_prod,
            this.Unidade});
            this.dataGridView1.Location = new System.Drawing.Point(3, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 334);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // cod_pedido
            // 
            this.cod_pedido.DataPropertyName = "Codigo";
            this.cod_pedido.HeaderText = "Código";
            this.cod_pedido.Name = "cod_pedido";
            this.cod_pedido.Width = 50;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "Quantidade";
            this.qtd.HeaderText = "Quantidade";
            this.qtd.Name = "qtd";
            this.qtd.Width = 50;
            // 
            // data_pedido
            // 
            this.data_pedido.DataPropertyName = "Data";
            this.data_pedido.HeaderText = "Data do Pedido";
            this.data_pedido.Name = "data_pedido";
            // 
            // hora_pedido
            // 
            this.hora_pedido.DataPropertyName = "Hora";
            this.hora_pedido.HeaderText = "Hora do Pedido";
            this.hora_pedido.Name = "hora_pedido";
            // 
            // data_entrega
            // 
            this.data_entrega.DataPropertyName = "entrega";
            this.data_entrega.HeaderText = "Data da Entrega";
            this.data_entrega.Name = "data_entrega";
            // 
            // hora_entrega
            // 
            this.hora_entrega.DataPropertyName = "entr";
            this.hora_entrega.HeaderText = "Hora da Entrega";
            this.hora_entrega.Name = "hora_entrega";
            // 
            // cod_fornecedor
            // 
            this.cod_fornecedor.DataPropertyName = "Fornecedor";
            this.cod_fornecedor.HeaderText = "Código do Fornecedor";
            this.cod_fornecedor.Name = "cod_fornecedor";
            this.cod_fornecedor.Width = 50;
            // 
            // cod_prod
            // 
            this.cod_prod.DataPropertyName = "Produto";
            this.cod_prod.HeaderText = "Código do Produto";
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.Width = 50;
            // 
            // Unidade
            // 
            this.Unidade.DataPropertyName = "Unidade";
            this.Unidade.HeaderText = "Unidade";
            this.Unidade.Name = "Unidade";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "incluir";
            this.label6.UseWaitCursor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(89, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 51;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(97, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Imprimir";
            this.label9.UseWaitCursor = true;
            // 
            // Pesquisa_plano_de_contas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 416);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pesquisa_plano_de_contas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa_plano_de_contas";
            this.Load += new System.EventHandler(this.Pesquisa_plano_de_contas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_entrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidade;
    }
}