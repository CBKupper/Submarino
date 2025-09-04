using BibliotecaSubmarino;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Submarino
{

    public partial class ControleForm : Form
    {

        private Submarino submarino;

        public ControleForm(Submarino sub)
        {
            InitializeComponent();
            submarino = sub;
            AtualizarStatus();
        }

        private void AtualizarStatus()
        {
            grbInformacoes.Text = submarino.Operacional ? "Ligado" : "Desligado";
            grbOceanos.Text = submarino.OceanoAtual;
            grbTripulantes.Text = submarino.QtdTripulantes.ToString();
            grbResgatados.Text = submarino.QtdResgatados.ToString();
            grbProfundidade.Text = submarino.NivelProfundidade.ToString("F2") + " m";
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            if (submarino.Ligar())
            {

                MessageBox.Show("Submarino ligado!");
            }
            else
            {
                MessageBox.Show("Já está ligado.");
            }
            AtualizarStatus();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            if (submarino.Desligar())
            {
                MessageBox.Show("Submarino desligado!");
            }
            else
            {
                MessageBox.Show("Já está desligado.");
            }
            AtualizarStatus();
        }

        private void btnAddTripulantes_Click(object sender, EventArgs e)
        {

            if (submarino.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante adicionado.");
            }
            else
            {
                MessageBox.Show("Não foi possível adicionar.");
            }
            AtualizarStatus();

        }

        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (submarino.RemoverTripulante())
            {
                MessageBox.Show("Tripulante removido.");
            }
            else
            {
                MessageBox.Show("Não há tripulantes para remover.");
            }
            AtualizarStatus();
        }

        private void btnAddResgatados_Click(object sender, EventArgs e)
        {
            if (submarino.Resgatar())
            {
                MessageBox.Show("Resgatado com sucesso.");
            }
            else
            {
                MessageBox.Show("Não foi possível resgatar.");
            }
            AtualizarStatus();
        }

        private void btnLiberarResgatados_Click(object sender, EventArgs e)
        {
            if (submarino.LiberarResgatado())
            {
                MessageBox.Show("Resgatado liberado.");
            }
            else
            {
                MessageBox.Show("Não há resgatados.");
            }
            AtualizarStatus();
        }

        private void btnMudarOceano_Click(object sender, EventArgs e)
        {
            string novoOceano = cmbOceanos.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(novoOceano)) return;
            {

                if (submarino.MudarOceano(novoOceano))
                {
                    MessageBox.Show("Oceano alterado.");
                }
                else
                {
                    MessageBox.Show("Não foi possível mudar de oceano.");
                }
                AtualizarStatus();
            }
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            if (submarino.RetornarAoOceanoOrigem())
            {
                MessageBox.Show("Retornou ao oceano de origem.");
            }
            else
            {
                MessageBox.Show("Já está no oceano de origem.");
            }
            AtualizarStatus();
        }

        private void btnAjustarProfundidade_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txbProfundidade.Text, out double novaProf))
            {
                if (submarino.AjustarProfundidade(novaProf))
                {
                    MessageBox.Show("Profundidade ajustada.");
                }
                else
                    MessageBox.Show("Falha ao ajustar profundidade.");
                AtualizarStatus();
            }
            else
            {
                MessageBox.Show("Digite uma profundidade válida.");
            }
        }
    }
}
