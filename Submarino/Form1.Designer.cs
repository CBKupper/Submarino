namespace Submarino
{
    partial class TelaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.txbResgatados = new System.Windows.Forms.TextBox();
            this.cmbOceanos = new System.Windows.Forms.ComboBox();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblResgatados = new System.Windows.Forms.Label();
            this.lblOceano = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProfundidade = new System.Windows.Forms.Label();
            this.txbProfundidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbResgatados
            // 
            this.txbResgatados.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbResgatados.Location = new System.Drawing.Point(271, 124);
            this.txbResgatados.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbResgatados.Name = "txbResgatados";
            this.txbResgatados.Size = new System.Drawing.Size(180, 29);
            this.txbResgatados.TabIndex = 0;
            // 
            // cmbOceanos
            // 
            this.cmbOceanos.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOceanos.FormattingEnabled = true;
            this.cmbOceanos.Location = new System.Drawing.Point(271, 171);
            this.cmbOceanos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cmbOceanos.Name = "cmbOceanos";
            this.cmbOceanos.Size = new System.Drawing.Size(180, 29);
            this.cmbOceanos.TabIndex = 1;
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTripulantes.Location = new System.Drawing.Point(271, 83);
            this.txbTripulantes.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(180, 29);
            this.txbTripulantes.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(139, 30);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(416, 27);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Bem-Vindo ao Submarino Nautilus 3000";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTripulantes.Location = new System.Drawing.Point(87, 83);
            this.lblTripulantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(181, 21);
            this.lblTripulantes.TabIndex = 5;
            this.lblTripulantes.Text = "Máximo de tripulantes:";
            // 
            // lblResgatados
            // 
            this.lblResgatados.AutoSize = true;
            this.lblResgatados.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResgatados.Location = new System.Drawing.Point(82, 132);
            this.lblResgatados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResgatados.Name = "lblResgatados";
            this.lblResgatados.Size = new System.Drawing.Size(186, 21);
            this.lblResgatados.TabIndex = 6;
            this.lblResgatados.Text = "Máximo de resgatados:";
            // 
            // lblOceano
            // 
            this.lblOceano.AutoSize = true;
            this.lblOceano.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOceano.Location = new System.Drawing.Point(104, 171);
            this.lblOceano.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOceano.Name = "lblOceano";
            this.lblOceano.Size = new System.Drawing.Size(159, 21);
            this.lblOceano.TabIndex = 7;
            this.lblOceano.Text = "Oceano de Origem:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(201, 269);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(281, 76);
            this.btnIniciar.TabIndex = 8;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Submarino.Properties.Resources.Nautilus_3000;
            this.pictureBox1.Location = new System.Drawing.Point(478, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblProfundidade
            // 
            this.lblProfundidade.AutoSize = true;
            this.lblProfundidade.Location = new System.Drawing.Point(101, 210);
            this.lblProfundidade.Name = "lblProfundidade";
            this.lblProfundidade.Size = new System.Drawing.Size(162, 21);
            this.lblProfundidade.TabIndex = 10;
            this.lblProfundidade.Text = "Profundidade Inicial:";
            // 
            // txbProfundidade
            // 
            this.txbProfundidade.Location = new System.Drawing.Point(270, 210);
            this.txbProfundidade.Name = "txbProfundidade";
            this.txbProfundidade.Size = new System.Drawing.Size(181, 29);
            this.txbProfundidade.TabIndex = 11;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 394);
            this.Controls.Add(this.txbProfundidade);
            this.Controls.Add(this.lblProfundidade);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.lblOceano);
            this.Controls.Add(this.lblResgatados);
            this.Controls.Add(this.lblTripulantes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.cmbOceanos);
            this.Controls.Add(this.txbResgatados);
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missão submarina: Controle de Navegação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbResgatados;
        private System.Windows.Forms.ComboBox cmbOceanos;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblResgatados;
        private System.Windows.Forms.Label lblOceano;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblProfundidade;
        private System.Windows.Forms.TextBox txbProfundidade;
    }
}

