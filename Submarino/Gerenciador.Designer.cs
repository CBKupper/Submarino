namespace Submarino
{
    partial class ControleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControleForm));
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblResgatados = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAddTripulantes = new System.Windows.Forms.Button();
            this.grbResgatados = new System.Windows.Forms.GroupBox();
            this.btnLiberarResgatados = new System.Windows.Forms.Button();
            this.btnAddResgatados = new System.Windows.Forms.Button();
            this.grbOceanos = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMudarOceano = new System.Windows.Forms.Button();
            this.cmbOceanos = new System.Windows.Forms.ComboBox();
            this.grbProfundidade = new System.Windows.Forms.GroupBox();
            this.btnAjustarProfundidade = new System.Windows.Forms.Button();
            this.txbProfundidade = new System.Windows.Forms.TextBox();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbResgatados.SuspendLayout();
            this.grbOceanos.SuspendLayout();
            this.grbProfundidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblResgatados);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(46, 28);
            this.grbInformacoes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbInformacoes.Size = new System.Drawing.Size(220, 194);
            this.grbInformacoes.TabIndex = 1;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(6, 147);
            this.btnDesligar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(206, 35);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Location = new System.Drawing.Point(6, 106);
            this.btnLigar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(206, 35);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblResgatados
            // 
            this.lblResgatados.AutoSize = true;
            this.lblResgatados.Location = new System.Drawing.Point(27, 78);
            this.lblResgatados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResgatados.Name = "lblResgatados";
            this.lblResgatados.Size = new System.Drawing.Size(67, 13);
            this.lblResgatados.TabIndex = 2;
            this.lblResgatados.Text = "Resgatados:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(27, 53);
            this.lblTripulantes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(27, 28);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAddTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(46, 237);
            this.grbTripulantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbTripulantes.Size = new System.Drawing.Size(220, 226);
            this.grbTripulantes.TabIndex = 2;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(7, 106);
            this.btnRemoverTripulantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(206, 59);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAddTripulantes
            // 
            this.btnAddTripulantes.Location = new System.Drawing.Point(7, 23);
            this.btnAddTripulantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddTripulantes.Name = "btnAddTripulantes";
            this.btnAddTripulantes.Size = new System.Drawing.Size(206, 58);
            this.btnAddTripulantes.TabIndex = 0;
            this.btnAddTripulantes.Text = "Adicionar";
            this.btnAddTripulantes.UseVisualStyleBackColor = true;
            this.btnAddTripulantes.Click += new System.EventHandler(this.btnAddTripulantes_Click);
            // 
            // grbResgatados
            // 
            this.grbResgatados.Controls.Add(this.btnLiberarResgatados);
            this.grbResgatados.Controls.Add(this.btnAddResgatados);
            this.grbResgatados.Location = new System.Drawing.Point(333, 28);
            this.grbResgatados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbResgatados.Name = "grbResgatados";
            this.grbResgatados.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbResgatados.Size = new System.Drawing.Size(220, 194);
            this.grbResgatados.TabIndex = 3;
            this.grbResgatados.TabStop = false;
            this.grbResgatados.Text = "Resgatados";
            // 
            // btnLiberarResgatados
            // 
            this.btnLiberarResgatados.Location = new System.Drawing.Point(7, 106);
            this.btnLiberarResgatados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLiberarResgatados.Name = "btnLiberarResgatados";
            this.btnLiberarResgatados.Size = new System.Drawing.Size(206, 59);
            this.btnLiberarResgatados.TabIndex = 1;
            this.btnLiberarResgatados.Text = "Liberar resgatado";
            this.btnLiberarResgatados.UseVisualStyleBackColor = true;
            this.btnLiberarResgatados.Click += new System.EventHandler(this.btnLiberarResgatados_Click);
            // 
            // btnAddResgatados
            // 
            this.btnAddResgatados.Location = new System.Drawing.Point(7, 23);
            this.btnAddResgatados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddResgatados.Name = "btnAddResgatados";
            this.btnAddResgatados.Size = new System.Drawing.Size(206, 58);
            this.btnAddResgatados.TabIndex = 0;
            this.btnAddResgatados.Text = "Resgatar";
            this.btnAddResgatados.UseVisualStyleBackColor = true;
            this.btnAddResgatados.Click += new System.EventHandler(this.btnAddResgatados_Click);
            // 
            // grbOceanos
            // 
            this.grbOceanos.Controls.Add(this.lblPlaneta);
            this.grbOceanos.Controls.Add(this.btnRetornar);
            this.grbOceanos.Controls.Add(this.btnMudarOceano);
            this.grbOceanos.Controls.Add(this.cmbOceanos);
            this.grbOceanos.Location = new System.Drawing.Point(340, 237);
            this.grbOceanos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOceanos.Name = "grbOceanos";
            this.grbOceanos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grbOceanos.Size = new System.Drawing.Size(220, 226);
            this.grbOceanos.TabIndex = 4;
            this.grbOceanos.TabStop = false;
            this.grbOceanos.Text = "Oceanos";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(27, 196);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(0, 13);
            this.lblPlaneta.TabIndex = 5;
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(8, 130);
            this.btnRetornar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(205, 55);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMudarOceano
            // 
            this.btnMudarOceano.Location = new System.Drawing.Point(8, 67);
            this.btnMudarOceano.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMudarOceano.Name = "btnMudarOceano";
            this.btnMudarOceano.Size = new System.Drawing.Size(205, 57);
            this.btnMudarOceano.TabIndex = 1;
            this.btnMudarOceano.Text = "Mudar de Oceano";
            this.btnMudarOceano.UseVisualStyleBackColor = true;
            this.btnMudarOceano.Click += new System.EventHandler(this.btnMudarOceano_Click);
            // 
            // cmbOceanos
            // 
            this.cmbOceanos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOceanos.FormattingEnabled = true;
            this.cmbOceanos.Location = new System.Drawing.Point(8, 25);
            this.cmbOceanos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbOceanos.Name = "cmbOceanos";
            this.cmbOceanos.Size = new System.Drawing.Size(205, 21);
            this.cmbOceanos.TabIndex = 0;
            // 
            // grbProfundidade
            // 
            this.grbProfundidade.Controls.Add(this.txbProfundidade);
            this.grbProfundidade.Controls.Add(this.btnAjustarProfundidade);
            this.grbProfundidade.Location = new System.Drawing.Point(195, 484);
            this.grbProfundidade.Name = "grbProfundidade";
            this.grbProfundidade.Size = new System.Drawing.Size(210, 124);
            this.grbProfundidade.TabIndex = 5;
            this.grbProfundidade.TabStop = false;
            this.grbProfundidade.Text = "Ajustar Profundidade";
            // 
            // btnAjustarProfundidade
            // 
            this.btnAjustarProfundidade.Location = new System.Drawing.Point(21, 45);
            this.btnAjustarProfundidade.Name = "btnAjustarProfundidade";
            this.btnAjustarProfundidade.Size = new System.Drawing.Size(170, 48);
            this.btnAjustarProfundidade.TabIndex = 0;
            this.btnAjustarProfundidade.Text = "Ajustar Profundidade";
            this.btnAjustarProfundidade.UseVisualStyleBackColor = true;
            this.btnAjustarProfundidade.Click += new System.EventHandler(this.btnAjustarProfundidade_Click);
            // 
            // txbProfundidade
            // 
            this.txbProfundidade.Location = new System.Drawing.Point(21, 19);
            this.txbProfundidade.Name = "txbProfundidade";
            this.txbProfundidade.Size = new System.Drawing.Size(170, 20);
            this.txbProfundidade.TabIndex = 1;
            // 
            // ControleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(615, 620);
            this.Controls.Add(this.grbProfundidade);
            this.Controls.Add(this.grbOceanos);
            this.Controls.Add(this.grbResgatados);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControleForm";
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbResgatados.ResumeLayout(false);
            this.grbOceanos.ResumeLayout(false);
            this.grbOceanos.PerformLayout();
            this.grbProfundidade.ResumeLayout(false);
            this.grbProfundidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.Label lblResgatados;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAddTripulantes;
        private System.Windows.Forms.GroupBox grbResgatados;
        private System.Windows.Forms.Button btnLiberarResgatados;
        private System.Windows.Forms.Button btnAddResgatados;
        private System.Windows.Forms.GroupBox grbOceanos;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnMudarOceano;
        private System.Windows.Forms.ComboBox cmbOceanos;
        private System.Windows.Forms.GroupBox grbProfundidade;
        private System.Windows.Forms.Button btnAjustarProfundidade;
        private System.Windows.Forms.TextBox txbProfundidade;
    }
}