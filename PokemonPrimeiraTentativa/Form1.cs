using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonPrimeiraTentativa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void btnCadastroPkmon_Click(object sender, EventArgs e)
        {
            Form cadastroPoke = new CadastroPokemon();
            cadastroPoke.ShowDialog();
        }

        private void btnCadastroTreinador_Click(object sender, EventArgs e)
        {
            Form cadastroTreinador = new cadastroTreinador();
            cadastroTreinador.ShowDialog();
        }

        private void btnTreinamento_Click(object sender, EventArgs e)
        {
            Form treinamento = new Treinamento();
            treinamento.ShowDialog();
        }

        private void buttonCapturar_Click(object sender, EventArgs e)
        {
            Form capturar = new Capturar();
            capturar.ShowDialog();
        }
    }
}
