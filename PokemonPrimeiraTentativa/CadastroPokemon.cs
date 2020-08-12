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
using MySql.Data.MySqlClient;

namespace PokemonPrimeiraTentativa
{
    public partial class CadastroPokemon : Form
    {
        public CadastroPokemon()
        { 
            InitializeComponent();
            groupBoxPoke.Enabled = false;
            comboBoxOrdenarPor.SelectedIndex = 0;
            carregaComboxPokemon();
        }

        private string pegaConection()
        {
            return "server=127.0.0.1;port=3306;userId=root;" +
                      "database=ConectandoPokemon;SslMode=none;password=123456";
        }

        private void buttonImg_Click(object sender, EventArgs e)//Chama imagem e coloca no picturebox
        {
            openFileDialogImg.Filter = "(*.jpg; *.jpeg;)| *.jpg; *.jpeg";
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
                pictureBoxImg.ImageLocation = openFileDialogImg.FileName;
        }

        private string pegaNomeTreinador(int ID)/*Faz uma busca no banco para resgatar o nome do treinador*/
        {
            string retorno = string.Empty;
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand treinador = new MySqlCommand("SELECT NOME FROM TREINADOR WHERE ID_POKEMON = @USE", conexao);
                treinador.Parameters.Add("@USE", MySqlDbType.Int16).Value = ID;
                MySqlDataReader leitor2;
                leitor2 = treinador.ExecuteReader();
                while (leitor2.Read())
                    retorno = leitor2.GetString(0);
                conexao.Close();
                return retorno;
            }
            catch {

                retorno = " ";
            }
            return retorno;
        }

        private int pegaIdDePokemon(string tudo)//Função para pegar o Id de uma string inverte e pegas os ultimos numeros
        { 
            string tudoId=string.Empty;
            for (int i = tudo.Length - 1; i != 0; i--)
            {
                if (tudo[i] == ' ')
                    break;
                tudoId = tudo[i].ToString()+tudoId  ;
            }
            return Convert.ToInt16(tudoId); 
        }

        private void carregaComboxPokemon() //Função carrega os pokemons existentes
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                string ordenarPor;
                if (comboBoxOrdenarPor.SelectedIndex == 0) // De acordo com o comboBox ele ordena descrescente ou ascendente
                    ordenarPor = "SELECT NOME,IDPOKEMON FROM POKEMON ORDER BY " + comboBoxOrdenarPor.SelectedItem.ToString() + " ASC";
                else
                    ordenarPor = "SELECT NOME,IDPOKEMON FROM POKEMON ORDER BY " + comboBoxOrdenarPor.SelectedItem.ToString() + " DESC";
                MySqlCommand teste = new MySqlCommand(ordenarPor, conexao); 
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                comboBoxPoke.Items.Clear();
                int CONTADOR = 0;
                while (leitor.Read())//Lê de acordo com O select executado e adiciona no comboBox
                {
                    if (!(leitor["NOME"].ToString() == "") || !(leitor["IDPOKEMON"].ToString() == ""))
                      comboBoxPoke.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString());
                    CONTADOR++;
                }
                conexao.Close();
                if (CONTADOR - 1 > 0 || CONTADOR == 1)// ele faz a validação se há registros no  e se há ele valida ou invalida os botões 
                {
                    comboBoxPoke.SelectedIndex = 0;
                    btnEditarPokemon.Enabled = true;
                    btnNvoPokemon.Enabled = true;
                    btnExcluirPokemon.Enabled = true;
                }
                else
                {
                    btnEditarPokemon.Enabled = false;
                    btnNvoPokemon.Enabled = true;
                    btnExcluirPokemon.Enabled = false;
                    richTboxMostraPo.Clear();
                    pictureBoxMostraPoke.Image = null;
                }
            }
            catch
            { MessageBox.Show("Ocorreu um erro procure o desenvolvedor", "ERRO"); }
        }

        private void pictureBoxImg_Click(object sender, EventArgs e)
        {

        }

        private void btnNvoPokemon_Click(object sender, EventArgs e)
        {   /*Habilita e desabilita para que o cadastro ocorra sem interrupções */
            groupBoxPoke.Enabled = true;
            btnNvoPokemon.Enabled = false;
            btnEditarPokemon.Enabled = false;
            btnExcluirPokemon.Enabled = false;
        }

        private void btnSalvarPokemon_Click(object sender, EventArgs e)
        {
            if (groupBoxPoke.Enabled == false) /*Validações para que possa salvar sem Erros*/
                return;
            if (textBoxNome.Text == string.Empty) {
                MessageBox.Show("Você deve digitar um nome.", "Incompleto");
                return;
            }
            if (pictureBoxImg.Image == null)
            {
                MessageBox.Show("Você deve inserir uma imagem.", "Incompleto");
                return;
            }
           /*Validações minimas FIM */
            if (labelIdPokemon.Text == string.Empty)// Se o label estiver vazio significa que ele etá inserindo um novo Pokemon
            {
                var length = new System.IO.FileInfo(openFileDialogImg.FileName).Length;//Guarda o tamanho da imagem

                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (length >= 2777215)
                {
                    MessageBox.Show("Foto Maior que 1MB!");
                    return;
                }
                /*Inicia os Adicionar as caracteristicas do Pokemon*/
                Random aleatorio = new Random();
                int altura, peso, efeito;
                double forca;
                altura = aleatorio.Next(0, 99);
                peso = aleatorio.Next(0, 99);
                efeito = aleatorio.Next(1, 5);
                forca = Math.Sqrt((altura * peso) + efeito);
                byte[] imagem_byte = null;
                BinaryReader b;
                b = new BinaryReader(File.Open(openFileDialogImg.FileName, FileMode.Open));//lê a imagem e transforma em binários
                imagem_byte = b.ReadBytes((int)b.BaseStream.Length);// guarda a imagem em um array de binários
                /*FIM os Adicionar as caracteristicas do Pokemon*/
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                MySqlCommand guardaPokemon = new MySqlCommand("INSERT INTO POKEMON  (NOME,EVOLUCAO,ALTURA,PESO,FOTOPOKEMON,EFEITO,FORCA,ID_TREINADOR)  VALUES (?,?,?,?,?,?,?,?)", conexao);
                guardaPokemon.Parameters.Add("@NOME", MySqlDbType.VarChar, 30).Value = textBoxNome.Text;
                guardaPokemon.Parameters.Add("@EVOLUCAO", MySqlDbType.VarChar, 30).Value = "SUPER" + textBoxNome.Text;
                guardaPokemon.Parameters.Add("@ALTURA", MySqlDbType.Int16, 2).Value = altura;
                guardaPokemon.Parameters.Add("@PESO", MySqlDbType.Int16, 2).Value = peso;
                guardaPokemon.Parameters.Add("@FOTOPOKEMON", MySqlDbType.MediumBlob).Value = imagem_byte;
                guardaPokemon.Parameters.Add("@EFEITO", MySqlDbType.Int16, 2).Value = efeito;
                guardaPokemon.Parameters.Add("@FORCA", MySqlDbType.Int16, 2).Value = Convert.ToInt16(forca);
                guardaPokemon.Parameters.Add("@ID_TREINADOR", MySqlDbType.Int16, 2).Value = null;
                /*Feito a QUERY e adicionado os parametros abre a conexão e executa a query*/
                try
                {
                    conexao.Open();
                    guardaPokemon.ExecuteNonQuery();
                    conexao.Close();
                }
                catch {
                    MessageBox.Show("oOcorreu um erro ao cadastrar seu pokemon","ERRO");
                    return;
                }
                /*Se a falha na execução da query ele manda mensagem e retorna*/
                MessageBox.Show("Pokemon registrado com sucesso.", "Pikachu");// em caso de sucesso manda uma mensagem
                /*faz a validação de funcionamento da tela*/
                textBoxNome.Text = string.Empty;
                pictureBoxImg.Image = null;
                carregaComboxPokemon();// atualiza o combox
            }
            else
            {
                byte[] imagem_byte = null;
                BinaryReader b;
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                
                MySqlCommand alteraPokemon = new MySqlCommand("UPDATE POKEMON SET NOME = ? WHERE IDPOKEMON= ?", conexao);
                try
                {
                    b = new BinaryReader(File.Open(openFileDialogImg.FileName, FileMode.Open));
                    imagem_byte = b.ReadBytes((int)b.BaseStream.Length);
                    alteraPokemon = new MySqlCommand("UPDATE POKEMON SET NOME = ? , FOTOPOKEMON = ? WHERE IDPOKEMON= ?", conexao);
                    alteraPokemon.Parameters.Add("@NOME", MySqlDbType.VarChar, 30).Value = textBoxNome.Text;
                    alteraPokemon.Parameters.Add("@FOTOPOKEMON", MySqlDbType.MediumBlob).Value = imagem_byte;
                    alteraPokemon.Parameters.Add("@IDPOKEMON", MySqlDbType.Int16).Value = labelIdPokemon.Text;
                }
                catch
                {
                    alteraPokemon.Parameters.Add("@NOME", MySqlDbType.VarChar, 30).Value = textBoxNome.Text;
                    alteraPokemon.Parameters.Add("@IDPOKEMON", MySqlDbType.Int16).Value = labelIdPokemon.Text;
                }
                /*ele tenta pegar a imagem que está no filedialog se falhar significa que ele não alterou a imagem*/
                try
                {
                    conexao.Open();
                    alteraPokemon.ExecuteNonQuery();
                    conexao.Close();
                }
                catch
                {
                    MessageBox.Show("oOcorreu um erro ao alterar seu pokemon", "ERRO");
                    return;
                }
                /*Se a falha na execução da query ele manda mensagem e retorna em caso de sucesso faz as validações necessárias*/
                labelIdPokemon.Text = string.Empty;
                textBoxNome.Text = string.Empty;
                pictureBoxImg.Image = null;
                groupBoxPoke.Enabled = false;
                MessageBox.Show("Pokemon alterado com sucesso.","");
                carregaComboxPokemon();
            }
        }
        private void groupBoxPoke_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditarPokemon_Click(object sender, EventArgs e)
        { /*apenas faz o select e joga nos campos do groupBox e habilita para edição */
            try
            {  
                btnNvoPokemon.Enabled = false;
                groupBoxPoke.Enabled = true;
                btnExcluirPokemon.Enabled = false;
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT IDPOKEMON,NOME,FOTOPOKEMON FROM POKEMON WHERE IDPOKEMON = @USE", conexao);
                teste.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDePokemon(comboBoxPoke.SelectedItem.ToString()); 
                MySqlDataReader leitor;// manda como parametro o id que esta no comboBox na query
                leitor = teste.ExecuteReader();
                byte[] IMG;
                MemoryStream imgStream;
                Image imagem2;
                while (leitor.Read())
                {
                    textBoxNome.Text = leitor["NOME"].ToString();//Joga o valor do select no text
                    labelIdPokemon.Text = leitor["IDPOKEMON"].ToString();//Joga o valor do IDselect no label
                    IMG = (byte[])leitor["FOTOPOKEMON"];
                    imgStream = new MemoryStream(IMG);// faz as conversões necessárias 
                    imgStream.Position = 0;
                    imagem2 = Image.FromStream(imgStream);
                    pictureBoxImg.Image = System.Drawing.Image.FromStream(imgStream);//e coloca no picture box
                }
                conexao.Close();
            }
            catch {

                MessageBox.Show("Ocorreu um erro ao editar o pokemon procure o desenvolvedor", "ERRO");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)/*Limpa tudo os campos e desabilita o que é  necessário*/
        {
            DialogResult confirm = MessageBox.Show("Deseja Continuar?", "Limpar campos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            /*abre a caixa de dialogo e em caso de sim ele faz a limpeza*/
            if (confirm.ToString().ToUpper() == "YES")
            {   
                labelIdPokemon.Text = string.Empty;
                textBoxNome.Text = string.Empty;
                pictureBoxImg.Image = null;
                groupBoxPoke.Enabled = false;
                richTboxMostraPo.Clear();
                pictureBoxMostraPoke.Image = null;
                btnExcluirPokemon.Enabled = true;
                btnNvoPokemon.Enabled = true;
                carregaComboxPokemon();
            }
        }

        private void btnExcluirPokemon_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja Excluir o Pokemon selecionado.?", "Excluir Pokemon",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            /*Abre a caixa de dialogo em caso de sucesso ele far[a a exclusão*/
            if (confirm.ToString().ToUpper() == "YES")
            {
                try
                {
                    MySqlConnection conexao = new MySqlConnection(pegaConection());
                    conexao.Open();
                    string exclui = "SELECT ID_TREINADOR FROM POKEMON WHERE IDPOKEMON = " + pegaIdDePokemon(comboBoxPoke.SelectedItem.ToString());
                    MySqlCommand qualTreinador = new MySqlCommand(exclui, conexao);

                    MySqlDataReader leitor;
                    leitor = qualTreinador.ExecuteReader();
                    int treinador = 0;
                    while (leitor.Read())
                        if (leitor.HasRows)
                            if (!leitor.IsDBNull(0))
                                treinador = leitor.GetInt32(0);
                    leitor.Close();
                    string trei = "SELECT COUNT(*) FROM POKEMON WHERE ID_TREINADOR = " + treinador;
                    MySqlCommand possoDeletar = new MySqlCommand(trei, conexao);
                    leitor = possoDeletar.ExecuteReader();
                    int quantosTreinador = 0;
                    while (leitor.Read())/*Busca quantos treinador existe*/
                        quantosTreinador = leitor.GetInt32(0);
                    leitor.Close();
                    if (quantosTreinador > 1 || quantosTreinador == 0)
                    {   /*Deleta o Pokemon caso não exista treinador */
                        MySqlCommand teste = new MySqlCommand("DELETE FROM POKEMON WHERE IDPOKEMON = @USE", conexao);
                        teste.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDePokemon(comboBoxPoke.SelectedItem.ToString());
                        teste.ExecuteNonQuery();
                        conexao.Close();
                        MessageBox.Show("Pokemon " + comboBoxPoke.SelectedItem.ToString() + " Excluido com Sucesso");
                        carregaComboxPokemon();
                    }
                    else
                        MessageBox.Show("Voce não pode Excluir este pokemon deve antes excluir seu treinador", "ERRO");
                }
                catch {

                    MessageBox.Show("Ocorreu um erro ao Excluir Pokemon", "ERRO");
                }
            }
        }

        private void comboBoxOrdenarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboxPokemon();
        }

        private void comboBoxPoke_SelectedIndexChanged(object sender, EventArgs e)
        {   /*Quando voce seleciona um item no ComboBox ele faz o select e instancia no richtexBox E NO PICTURE*/
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT IDPOKEMON,NOME,EVOLUCAO,ALTURA,PESO,FOTOPOKEMON,EFEITO,FORCA,ID_TREINADOR FROM POKEMON WHERE IDPOKEMON = @USE", conexao);
                teste.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDePokemon(comboBoxPoke.SelectedItem.ToString());
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                richTboxMostraPo.Clear();
                byte[] IMG;
                MemoryStream imgStream;
                Image imagem2;
                while (leitor.Read())
                {
                    richTboxMostraPo.AppendText("Nome: " + leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Evolução: " + leitor["EVOLUCAO"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Altura: " + leitor["ALTURA"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Efeito: " + leitor["EFEITO"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("FORCA: " + leitor["FORCA"].ToString() + Environment.NewLine);
                    IMG = (byte[])leitor["FOTOPOKEMON"];
                    imgStream = new MemoryStream(IMG);
                    imgStream.Position = 0;
                    imagem2 = Image.FromStream(imgStream);
                    pictureBoxMostraPoke.Image = System.Drawing.Image.FromStream(imgStream);
                    if (leitor["ID_TREINADOR"] == DBNull.Value)/*Caso não exista Treinador exibe esta mensagem*/
                        richTboxMostraPo.AppendText("Este é um Pokemon selvagem." + Environment.NewLine);
                    else
                        richTboxMostraPo.AppendText("Treinador: " + pegaNomeTreinador(Convert.ToInt16(leitor["ID_TREINADOR"])) +
                            " - " + leitor["ID_TREINADOR"].ToString() + Environment.NewLine);
                }
                conexao.Close();
            }
            catch {

                MessageBox.Show("Ocorreu um erro procure o desenvolvedor", "Erro Ao mostrar Pokemon");
            }
        }
        
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                string ordenarPor = "SELECT NOME,IDPOKEMON FROM POKEMON WHERE NOME =  '" +textBoxPesquisar.Text+"'";
                /*Faz o select com o texto do textBox*/
                MySqlCommand teste = new MySqlCommand(ordenarPor, conexao);
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                comboBoxPesquisa.Items.Clear(); 
                int CONTADOR = 0;
                while (leitor.Read())
                { 
                    if (!(leitor["NOME"].ToString() == "") || !(leitor["IDPOKEMON"].ToString() == ""))
                        comboBoxPesquisa.Items.Add(leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString());
                    CONTADOR++;
                }
                if (CONTADOR - 1 > 0 || CONTADOR == 1)/*Caso exista Pokemon ele adiciona no comboBox pois pode existir mais de um com o mesmo nome*/
                {
                    comboBoxPesquisa.SelectedIndex = 0;
                    comboBoxPesquisa_SelectedIndexChanged(sender, e);
                }
                else
                    MessageBox.Show("Não existe Pokemon com este nome");/*se não existe ele manda msg*/
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro no localizar procure o desenvolvedor", "ERRO");
            }
        }

        private void comboBoxPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {           /*Pega o PokemoN selecionado e instancia no richtextbox e no pictureBox */
            try
            {
                MySqlConnection conexao = new MySqlConnection(pegaConection());
                conexao.Open();
                MySqlCommand teste = new MySqlCommand("SELECT IDPOKEMON,NOME,EVOLUCAO,ALTURA,PESO,FOTOPOKEMON,EFEITO,FORCA,ID_TREINADOR FROM POKEMON WHERE IDPOKEMON = @USE", conexao);
                teste.Parameters.Add("@USE", MySqlDbType.Int16).Value = pegaIdDePokemon(comboBoxPesquisa.SelectedItem.ToString());
                MySqlDataReader leitor;
                leitor = teste.ExecuteReader();
                richTboxMostraPo.Clear();
                byte[] IMG;
                MemoryStream imgStream;
                Image imagem2;
                while (leitor.Read())
                {       /*Instancia no pictureBox*/
                    richTboxMostraPo.AppendText("Nome: " + leitor["NOME"].ToString() + " - " + leitor["IDPOKEMON"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Evolução: " + leitor["EVOLUCAO"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Altura: " + leitor["ALTURA"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("Efeito: " + leitor["EFEITO"].ToString() + Environment.NewLine);
                    richTboxMostraPo.AppendText("FORCA: " + leitor["FORCA"].ToString() + Environment.NewLine);
                    IMG = (byte[])leitor["FOTOPOKEMON"];
                    imgStream = new MemoryStream(IMG);
                    imgStream.Position = 0;
                    imagem2 = Image.FromStream(imgStream);
                    pictureBoxMostraPoke.Image = System.Drawing.Image.FromStream(imgStream);
                    if (leitor["ID_TREINADOR"] == DBNull.Value)
                        richTboxMostraPo.AppendText("Este é um Pokemon selvagem." + Environment.NewLine);
                    else
                        richTboxMostraPo.AppendText("Treinador: " + pegaNomeTreinador(Convert.ToInt16(leitor["ID_TREINADOR"])) +
                            " - " + leitor["ID_TREINADOR"].ToString() + Environment.NewLine);
                }
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Ocorreu um erro procure o desenvolvedor", "Erro Ao mostrar Pokemon");
            }
        }
    }
}
