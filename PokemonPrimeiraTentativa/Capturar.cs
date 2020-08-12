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
    public partial class Capturar : Form
    {
        public Capturar()
        {
            InitializeComponent();
            carregaComboxTreinador();
            carregaComboxPokemon();
            groupBoxTenta.Visible = false;
        }
        private int pegaId(string tudo)/*Pega os ultimos numeros de uma string*/
        {
            string tudoId = string.Empty;
            for (int i = tudo.Length - 1; i != 0; i--)
            {
                if (tudo[i] == ' ')
                    break;
                tudoId = tudo[i].ToString() + tudoId;
            }
            return Convert.ToInt16(tudoId);
        }
        private string pegaConection()
        {
            return "server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456";
        }
        private void carregaComboxTreinador()/*Carrega os treinadores*/
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456");
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT NOME,IDTREINADOR FROM TREINADOR", conexao);
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                comboBoxTreinador.Items.Clear();
                int contador = 0;
                while (leitor.Read())
                {   /*adiciona no combobox*/
                    comboBoxTreinador.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDTREINADOR"].ToString());
                    contador++;
                }
                conexao.Close();
                if (contador > 0)
                    comboBoxTreinador.SelectedIndex = 0;
            }
            catch {
                MessageBox.Show("Ocorreu um erro ao Carregar Pokemon", "ERRO");
            }
        }
        private bool CapturaPokemon()/*Muda o ID_TREINADOR DE acordo com o selecionado ou seja captura*/
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456");
                string captura = "UPDATE POKEMON SET ID_TREINADOR =  " +pegaId( comboBoxTreinador.SelectedItem.ToString())
                    +" WHERE IDPOKEMON = " + pegaId(cmboxPokeSelvagem.SelectedItem.ToString());
                if (cmboxPokeSelvagem.SelectedItem == null)
                    return false;
                MySqlCommand capPoke = new MySqlCommand(captura, conexao);
                conexao.Open();
                capPoke.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro Ao capturar Pokemon.", "ERRO");
                return false;
            }
            
        }
        private bool carregaComboxPokemon() /*adiciona os Pokemons selvagens caso exista*/
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456");
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT NOME,IDPOKEMON FROM POKEMON WHERE ID_TREINADOR IS NULL", conexao);
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                cmboxPokeSelvagem.Items.Clear();
                int contador = 0;
                while (leitor.Read())
                {
                    cmboxPokeSelvagem.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString());
                    contador++;
                }
                conexao.Close();
                if (contador > 0)
                {
                    cmboxPokeSelvagem.SelectedIndex = 0;
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao buscar dados.", "ERRO");
                return false;
            }

        }
        private void buttonCapturar_Click(object sender, EventArgs e)
        {
            if (comboBoxTreinador.SelectedItem == null)/*validação se existe treinador*/
            {
                MessageBox.Show("Voce deve ter um treinador para capturar um Pokemon", "ERRO");
                buttonTenta.Enabled = true;
                groupBoxTenta.Visible = false;
                return;
            }
            Random aleatorio = new Random();
            int tenta = 0;
            int.TryParse(textBoxTentativa.Text, out tenta);
            int tenta1 = aleatorio.Next(0, 5);
            /*Gera um numero aleatorio Para o treinador ter 1 chance em 5 de capturar o Pokemon*/
            if (tenta == tenta1)/*em caso de Sucesso ele captura o pokemon*/
            {
                if(CapturaPokemon())
                MessageBox.Show("Pokemon Capturado com sucesso");
                buttonTenta.Enabled = true;
                groupBoxTenta.Visible = false;
                carregaComboxPokemon();
            }
            else
            {
                MessageBox.Show("Seu número é "+tenta.ToString() + " e o sorteado foi " + tenta1 + " então você  FALHOU");
                buttonTenta.Enabled = true;
                groupBoxTenta.Visible = false;
            }
        }

        private void buttonTenta_Click(object sender, EventArgs e)/*Habilita o groupBox para tentativa de Captura do Pokemon*/
        {   
            if (cmboxPokeSelvagem.SelectedItem == null)
            {
                MessageBox.Show("Precisa ter algum pokemon selvagem para que possa capturar", "Falta Pokemon");
                return;
            }
            groupBoxTenta.Visible = true;
            buttonTenta.Enabled = false;
        }
    }
}
