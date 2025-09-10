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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
            cmbOceanos.Items.AddRange(BibliotecaSubmarino.Submarino.OceanosValidos);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            // Verificar se o numero de tripulantes está vazio:
            if (txbTripulantes.Text == "")
            {
                MessageBox.Show("Informe o máximo de tripulantes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbResgatados.Text == "")
            {
                MessageBox.Show("Informe a capacidade do compartimento de resgatados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbOceanos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o oceano de origem!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Variaveis para receber os valores txbs:
                int maxTripulantes = int.Parse(txbTripulantes.Text);
                int maxResgatados = int.Parse(txbResgatados.Text);
                string oceanoOrigem = cmbOceanos.Text;
                double profundidade = double.Parse(txbProfundidade.Text);
                BibliotecaSubmarino.Submarino submarino1 = new BibliotecaSubmarino.Submarino(maxTripulantes, maxResgatados, oceanoOrigem,0 );
                // instanciar a janela gerenciador para conseguir chama-la:
                Gerenciador gerenciador = new Gerenciador(submarino1);

                // esconder a janela:
                Hide();

                // abrir a janela do gerenciador:
                gerenciador.ShowDialog();

                // Mostrar novamente a janela:
                Show();
            }

           

           




            

        }


    }
    
}
