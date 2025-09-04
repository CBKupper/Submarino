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
            }

            string oceano = cmbOceanos.SelectedItem.ToString();
            Submarino submarino = new Submarino(maxTripulantes, maxResg, oceano, profundidade); 
            
            ControleForm controle = new ControleForm(submarino);
            controle.Show();
            this.Hide();

        }


    }
    
}
