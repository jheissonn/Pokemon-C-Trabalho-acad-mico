using MySql.Data.MySqlClient;
using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace PokemonPrimeiraTentativa
{
    public partial class Treinamento : Form
    {
        public Treinamento()
        {
            InitializeComponent();
            carregaComboxPokemon();
            comboBoxOqTreinar.SelectedIndex = 0;
            groupBoxTreinamento.Visible = false;
        }
        private string pegaConection()
        {
            return "server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456";
        }
        private void carregaComboxPokemon()/*Carrega o comboBox com os treinadores*/
        {
            MySqlConnection conexao = new MySqlConnection(pegaConection());
            conexao.Open();
            MySqlCommand teste = new MySqlCommand("SELECT NOME,IDTREINADOR FROM TREINADOR", conexao);
            MySqlDataReader leitor;
            leitor = teste.ExecuteReader();
            comboBoxTreinador.Items.Clear();
            int contador = 0;
            while (leitor.Read())
            {
                comboBoxTreinador.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDTREINADOR"].ToString());
                contador++;/*Adiciona os Treinadores existentes no ComboBox*/
            }
            conexao.Close();
            if (contador  > 0) 
            comboBoxTreinador.SelectedIndex = 0;
        }

        private int pegaId(string tudo)/*Pega os ultimos numeros da string*/
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

        private void carregaPokemons(int IDdoTreinador)/*Carrega os Pokemons de cada Treinador selecionado*/
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand pegaTreinador = new MySqlCommand("SELECT NOME,IDPOKEMON FROM POKEMON WHERE ID_TREINADOR = @USER", conexao);
                pegaTreinador.Parameters.Add("@USER", MySqlDbType.Int16).Value = IDdoTreinador;
                MySqlDataReader leitor;
                leitor = pegaTreinador.ExecuteReader();
                comboBoxPoke.Items.Clear();
                while (leitor.Read()) /*Adiciona os pokemons do Treinador selecionado*/
                    comboBoxPoke.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString());
                conexao.Close();
            }
            catch {

                MessageBox.Show("Ocorreu um erro ao buscar dados", "ERRO");
            }
        }

        private void comboBoxTreinador_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaPokemons(pegaId(comboBoxTreinador.SelectedItem.ToString()));/*Adiciona os Pokemons de cada Treinador Selecionado*/
            comboBoxPoke.SelectedIndex=0;
        }

        private void btnMostraPokemon_Click(object sender, EventArgs e)/*Botão de treinamento*/
        {   if (comboBoxTreinador.SelectedItem == null)
            {/*Caso não tenha treinador Não poderá evoluir*/
                MessageBox.Show("Você precisa de um treinador para treinar seu pokemon", "Corre se cadastrar");
                return;
            }
            groupBoxTreinamento.Visible = true; /*Começa o Treinamento*/
            labelContagem.Text = "00:59:59";/*Inicia o Tempo*/
            timerEvolucao.Enabled = true;
            timerEvolucao.Interval =1000;
        }

        private void timerEvolucao_Tick(object sender, EventArgs e)
        {   /*Tempo*/
            string x = labelContagem.Text;
            string y = x.Replace(@":", "");
            int Hora =Convert.ToInt16(y.Substring(0, 2));
            int minuto = Convert.ToInt16(y.Substring(2, 2));
            int segundo = Convert.ToInt16(y.Substring(y.Length - 2, 2));
            if (segundo > 0)
                segundo--;
            else if (minuto > 0 && segundo == 0)
            {
                minuto--;
                segundo = 59;
            }
            else if (Hora > 0 && minuto == 0)
            {
                Hora--;
                minuto = 59;
                segundo = 59;
            }
            string h, m, s;
            h= Hora.ToString();
            m = minuto.ToString();
            s = segundo.ToString();
            if (segundo < 10) s = "0" + segundo.ToString();
            if(minuto<10) m = "0" + minuto.ToString();
            if(Hora<10)h  ="0" + Hora.ToString();
            labelContagem.Text =h +":"+m+":"+s;
            /*Final do relógio Decrescente*/
            if (Hora == 0 && minuto == 0 && segundo == 0)/*Quando chega em ZERO ele fará o update*/
            {
                timerEvolucao.Enabled = false;
                try
                {
                    string[] atributos = new string[] { "FORCA", "ALTURA", "PESO", "EFEITO" };
                    MySqlConnection conexao = new MySqlConnection(pegaConection());
                    conexao.Open();
                    string pegas = "SELECT " + atributos[comboBoxOqTreinar.SelectedIndex].ToString() +
                        " FROM POKEMON WHERE IDPOKEMON = " + pegaId(comboBoxPoke.SelectedItem.ToString());

                    MySqlCommand pegaAtributo = new MySqlCommand(pegas, conexao);
                    MySqlDataReader leitor;
                    leitor = pegaAtributo.ExecuteReader();
                    int atributo = 0;
                    string coca = atributos[comboBoxOqTreinar.SelectedIndex].ToString();
                    while (leitor.Read())
                    {
                        coca = leitor.GetString(0);/*Guarda o Valor Original do atributo selecionado*/
                        break;
                    }
                    atributo = Convert.ToInt16(coca) + 10;
                    coca = "";
                    if (atributo > 999)
                    {
                        atributo = 999;
                        coca = " Seu pokemon já está evoluido ao máximo";
                    }
                    { }
                    leitor.Close();/*Acrescenta 10 no Atributo selecionado*/
                    string altera = "UPDATE POKEMON SET " + atributos[comboBoxOqTreinar.SelectedIndex].ToString() +
                         " = " + atributo.ToString() + " WHERE IDPOKEMON = " + pegaId(comboBoxPoke.SelectedItem.ToString());
                    MySqlCommand alteraPokemon = new MySqlCommand(altera, conexao);
                    alteraPokemon.ExecuteNonQuery();
                    carregaComboxPokemon();
                    conexao.Close();
                    leitor.Close();/*Em caso de sucesso manda mensagem*/
                    MessageBox.Show("Pokemon evoluido com sucesso" + coca, "EVOLUÇÃO");
                    groupBoxTreinamento.Visible = false;
                }
                catch {
                    MessageBox.Show("Ocorreu um erro ao evoluir seu pokemon","ERRO");
                }
            }
        }

        private void Treinamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Treinamento_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Se sair agora todo progresso será perdido, Deseja Continuar? ", "Excluir Treinador",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                timerEvolucao.Enabled = false;

            }
            else
                e.Cancel = true;

        }
    }
}
