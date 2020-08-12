using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonPrimeiraTentativa
{
    public partial class cadastroTreinador : Form
    {
        public cadastroTreinador()
        {
            InitializeComponent();
            groupBoxTrei.Enabled = false;
            trazTreinador();
        }
        private string pegaConection()
        {
            return "server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456";
        }

        private bool carregaComboxPokemon()/*Carrega ComboBox com os pokemons selvagens*/
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT NOME,IDPOKEMON FROM POKEMON WHERE ID_TREINADOR IS NULL", conexao);

                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                cmboxPokeSelvagem.Items.Clear();
                int contador = 0;
                while (leitor.Read())/*Adiciona no comboBox*/
                {
                    cmboxPokeSelvagem.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString());
                    contador++;
                }
                conexao.Close();
                if (contador > 0)/*caso Tenha algum pokemon ele seta o primeiro*/
                {
                    cmboxPokeSelvagem.SelectedIndex = 0;
                    return true;
                }
                else
                {   /*Se não, nao poderá cadastrar Treinador sem pokemon selvagem*/
                    MessageBox.Show("Voce precisa de um pokemon selvagem para cadastrar um Treinador");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao buscar dados.", "ERRO");
                return false;
            }
        }
        private void trazTreinador()/*Traz Treinador Caso exista e adiciona no ComboBox*/
        {
            try
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
                    contador++;
                }
                conexao.Close();
                if (contador > 0)/*caso exista ele habilita editar ou excluir*/
                {
                    comboBoxTreinador.SelectedIndex = 0;
                    btnEditarTreinador.Enabled = true;
                    btnExcluirTreinador.Enabled = true;
                    btnNvoTreinador.Enabled = true;
                }
                else {/*caso não exista desabilita editar e excluir*/
                    btnEditarTreinador.Enabled = false;
                    btnExcluirTreinador.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao buscar dados.", "ERRO");
            }
        }

        private int pegaIdDeTreinador(string tudo)/*Pega o iD da string que seria os ultimos números*/
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

        private void btnSalvarPokemon_Click(object sender, EventArgs e)
        {   /*Faz as validações minimas*/
            if (groupBoxTrei.Enabled == false)
                return;
            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Voce deve preencher o nome", "Incompleto");
                return;
            }   /*termino das validações minimas*/
            if (labelIdTreinador.Text == string.Empty)/*Caso esteja vazio é um treinador Novo*/
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection(pegaConection());
                    conexao.Open();
                    MySqlCommand pegaId = new MySqlCommand("select max(IDTREINADOR) from TREINADOR;", conexao);
                    MySqlCommand salvaTreinador = new MySqlCommand("INSERT INTO TREINADOR" +
                        "(NOME, ID_POKEMON)  VALUES(?,?)", conexao);/*Pega o ID  do ultimo treinador inserido*/
                    salvaTreinador.Parameters.Add("@NOME", MySqlDbType.VarChar, 30).Value = textBoxNome.Text;
                    salvaTreinador.Parameters.Add("@ID_POKEMON", MySqlDbType.Int16, 2).Value
                        = pegaIdDeTreinador(cmboxPokeSelvagem.SelectedItem.ToString());
                    salvaTreinador.ExecuteNonQuery();
                    int idtreinador = 0;
                    idtreinador = (int)pegaId.ExecuteScalar();
                    MySqlCommand mudaTreinadorPoke = new MySqlCommand("UPDATE POKEMON SET ID_TREINADOR = @USER WHERE IDPOKEMON = @USE", conexao);
                    mudaTreinadorPoke.Parameters.Add("@USE", MySqlDbType.Int16, 2).Value /*Muda o ID_TRREINADOR COM O MAX assim ficam ligados*/
                        = pegaIdDeTreinador(cmboxPokeSelvagem.SelectedItem.ToString());
                    mudaTreinadorPoke.Parameters.Add("@USER", MySqlDbType.Int16, 2).Value = idtreinador;
                    mudaTreinadorPoke.ExecuteNonQuery();
                    MessageBox.Show("Treinador adicionado com sucesso");
                    textBoxNome.Text = string.Empty;
                    groupBoxTrei.Enabled = false;
                    cmboxPokeSelvagem.Items.Clear();/*limpa os selvagens*/
                    trazTreinador();/*atualiza os treinadores*/
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o Treinador", "ERRO");
                }
            }
            else {  /*Se não estiver vazio é edição*/
                try
                {
                    MySqlConnection conexao = new MySqlConnection(pegaConection());
                    MySqlCommand alteraPokemon;
                    alteraPokemon = new MySqlCommand("UPDATE TREINADOR SET NOME = ? WHERE IDTREINADOR= ?", conexao);
                    alteraPokemon.Parameters.Add("@NOME", MySqlDbType.VarChar, 30).Value = textBoxNome.Text;
                    alteraPokemon.Parameters.Add("@IDTREINADOR", MySqlDbType.Int16).Value = labelIdTreinador.Text;
                    conexao.Open();/*E edita executando a query de update*/
                    alteraPokemon.ExecuteNonQuery();
                    conexao.Close();
                    trazTreinador();
                    MessageBox.Show("Treinador alterado com sucesso", "Alteração");
                }
                catch {
                    MessageBox.Show("Ocorreu um erro ao alterar seu Treinador procure o desenvolvedor", "ERRO");
                }
                trazTreinador();/*limpa para funcionamento da tela*/
                labelIdTreinador.Text = string.Empty;
                textBoxNome.Text = string.Empty;
                groupBoxTrei.Enabled = false;
            }
        }

        private void btnNvoTreinador_Click(object sender, EventArgs e)
        {
            if (carregaComboxPokemon())/*Caso exista pokemon selvagem ele habilita se não ele já dara a mensagem*/
            {
                groupBoxTrei.Enabled = true;
                btnNvoTreinador.Enabled = false;
                btnEditarTreinador.Enabled = false;
                btnExcluirTreinador.Enabled = false;
            }
        }

        

        private void btnExcluirTreinador_Click(object sender, EventArgs e)/*Exclui o Treinador selecionado*/
        {
            DialogResult confirm = MessageBox.Show("Deseja Excluir o Treinador selecionado.?", "Excluir Treinador",
              MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection(pegaConection());
                    conexao.Open();
                    MySqlCommand transformaPokemon = new MySqlCommand("UPDATE POKEMON SET ID_TREINADOR = NULL WHERE ID_TREINADOR = @USE", conexao);
                    transformaPokemon.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDeTreinador(comboBoxTreinador.SelectedItem.ToString());
                    transformaPokemon.ExecuteNonQuery();
                    /*Instancia todos os pokemons com treinador nulo,ou poderia deletar os pokemons filhos*/
                    MySqlCommand excluiTreinador = new MySqlCommand("DELETE FROM TREINADOR  WHERE IDTREINADOR = @USE", conexao);
                    excluiTreinador.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDeTreinador(comboBoxTreinador.SelectedItem.ToString());
                    excluiTreinador.ExecuteNonQuery();/*Deleta o treinador selecionado*/
                    MessageBox.Show("Treinador excluido com sucesso", "Treinador Excluido");
                    trazTreinador();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro ao excluir pokemon", "Erro");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)/*Limpa e cancela tudo*/
        {
            groupBoxTrei.Enabled = false;
            textBoxNome.Text = string.Empty;
            trazTreinador();
        }

        private void btnEditarTreinador_Click(object sender, EventArgs e)
        {
            try
            {   /*Instancia Treinador selecionado e joga no label O id e no textBox o nome para ediçãp*/
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                groupBoxTrei.Enabled = true;
                MySqlCommand editapokemon = new MySqlCommand("SELECT IDTREINADOR,NOME FROM TREINADOR WHERE IDTREINADOR = @USE", conexao);
                editapokemon.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDeTreinador(comboBoxTreinador.SelectedItem.ToString());
                MySqlDataReader leitor;
                leitor = editapokemon.ExecuteReader();
                
                while (leitor.Read())
                {
                    textBoxNome.Text = leitor["NOME"].ToString();
                    labelIdTreinador.Text = leitor["IDTREINADOR"].ToString();
                }
                conexao.Close();
                btnNvoTreinador.Enabled = false;
                btnExcluirTreinador.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao editar o Treinador procure o desenvolvedor", "ERRO");
            }
        }

        private void comboBoxTreinador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                string ordenarPor;
                if (comboBoxOrdenarPor.SelectedIndex == 1) // De acordo com o comboBox ele ordena descrescente ou ascendente
                    ordenarPor = "SELECT NOME,IDTREINADOR FROM TREINADOR ORDER BY NOME ASC";
                else
                    ordenarPor = "SELECT NOME,IDTREINADOR FROM TREINADOR ORDER BY NOME DESC";
                MySqlCommand teste = new MySqlCommand(ordenarPor, conexao);
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                comboBoxTreinador.Items.Clear();
                int CONTADOR = 0;
                while (leitor.Read())//Lê de acordo com O select executado e adiciona no comboBox
                {
                    if (!(leitor["NOME"].ToString() == "") || !(leitor["IDTREINADOR"].ToString() == ""))
                        comboBoxTreinador.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDTREINADOR"].ToString());
                    CONTADOR++;
                }
                conexao.Close();
                if (CONTADOR - 1 > 0 || CONTADOR == 1)// ele faz a validação se há registros no  e se há ele valida ou invalida os botões 
                {
                    comboBoxTreinador.SelectedIndex = 0;
                    btnEditarTreinador.Enabled = true;
                    btnNvoTreinador.Enabled = true;
                    btnExcluirTreinador.Enabled = true;
                }
                else
                {
                    btnEditarTreinador.Enabled = false;
                    btnNvoTreinador.Enabled = true;
                    btnExcluirTreinador.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro ao listar treinadores", "ERRO");
            }
        }
    }
}
