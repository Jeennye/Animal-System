namespace Animal_System
{
    partial class Consultar_saida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_saida));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cod_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_do_movimento_entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_do_lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(58, 46);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 57;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "Imprimir";
            this.label9.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(375, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_entrada,
            this.cod_prod,
            this.quantidade_entrada,
            this.unidade,
            this.data_do_movimento_entrada,
            this.data_do_lancamento});
            this.dataGridView1.Location = new System.Drawing.Point(11, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 300);
            this.dataGridView1.TabIndex = 54;
            // 
            // cod_entrada
            // 
            this.cod_entrada.DataPropertyName = "Codigo";
            this.cod_entrada.HeaderText = "Código";
            this.cod_entrada.Name = "cod_entrada";
            // 
            // cod_prod
            // 
            this.cod_prod.DataPropertyName = "Produto";
            this.cod_prod.HeaderText = "Código do Produto";
            this.cod_prod.Name = "cod_prod";
            // 
            // quantidade_entrada
            // 
            this.quantidade_entrada.DataPropertyName = "Quantidade";
            this.quantidade_entrada.HeaderText = "Quantidade";
            this.quantidade_entrada.Name = "quantidade_entrada";
            // 
            // unidade
            // 
            this.unidade.DataPropertyName = "Unidade";
            this.unidade.HeaderText = "Unidade";
            this.unidade.Name = "unidade";
            // 
            // data_do_movimento_entrada
            // 
            this.data_do_movimento_entrada.DataPropertyName = "Data";
            this.data_do_movimento_entrada.HeaderText = "Data do Movimento";
            this.data_do_movimento_entrada.Name = "data_do_movimento_entrada";
            // 
            // data_do_lancamento
            // 
            this.data_do_lancamento.DataPropertyName = "Lancamento";
            this.data_do_lancamento.HeaderText = "Data do lançamento";
            this.data_do_lancamento.Name = "data_do_lancamento";
            // 
            // Consultar_saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 378);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultar_saida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar_saida";
            this.Load += new System.EventHandler(this.Consultar_saida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_do_movimento_entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_do_lancamento;
    }
}