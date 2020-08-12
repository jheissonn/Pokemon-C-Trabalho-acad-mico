namespace PokemonPrimeiraTentativa
{
    partial class CadastroPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPokemon));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonImg = new System.Windows.Forms.Button();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxPoke = new System.Windows.Forms.ComboBox();
            this.btnNvoPokemon = new System.Windows.Forms.Button();
            this.btnEditarPokemon = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluirPokemon = new System.Windows.Forms.Button();
            this.btnSalvarPokemon = new System.Windows.Forms.Button();
            this.groupBoxPoke = new System.Windows.Forms.GroupBox();
            this.labelIdPokemon = new System.Windows.Forms.Label();
            this.pictureBoxMostraPoke = new System.Windows.Forms.PictureBox();
            this.richTboxMostraPo = new System.Windows.Forms.RichTextBox();
            this.comboBoxOrdenarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPesquisar = new System.Windows.Forms.TextBox();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.comboBoxPesquisa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.groupBoxPoke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraPoke)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o nome do pokemon: ";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(156, 19);
            this.textBoxNome.MaxLength = 23;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Location = new System.Drawing.Point(423, 19);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(145, 91);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 4;
            this.pictureBoxImg.TabStop = false;
            this.pictureBoxImg.Click += new System.EventHandler(this.pictureBoxImg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adicione uma imagem: ";
            // 
            // buttonImg
            // 
            this.buttonImg.Location = new System.Drawing.Point(384, 16);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(31, 23);
            this.buttonImg.TabIndex = 6;
            this.buttonImg.Text = "...";
            this.buttonImg.UseVisualStyleBackColor = true;
            this.buttonImg.Click += new System.EventHandler(this.buttonImg_Click);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            // 
            // comboBoxPoke
            // 
            this.comboBoxPoke.AccessibleName = "";
            this.comboBoxPoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPoke.FormattingEnabled = true;
            this.comboBoxPoke.Location = new System.Drawing.Point(254, 235);
            this.comboBoxPoke.Name = "comboBoxPoke";
            this.comboBoxPoke.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPoke.TabIndex = 16;
            this.comboBoxPoke.SelectedIndexChanged += new System.EventHandler(this.comboBoxPoke_SelectedIndexChanged);
            // 
            // btnNvoPokemon
            // 
            this.btnNvoPokemon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNvoPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNvoPokemon.BackgroundImage")));
            this.btnNvoPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNvoPokemon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNvoPokemon.FlatAppearance.BorderSize = 5;
            this.btnNvoPokemon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNvoPokemon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNvoPokemon.Image = ((System.Drawing.Image)(resources.GetObject("btnNvoPokemon.Image")));
            this.btnNvoPokemon.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNvoPokemon.Location = new System.Drawing.Point(44, 335);
            this.btnNvoPokemon.Name = "btnNvoPokemon";
            this.btnNvoPokemon.Size = new System.Drawing.Size(106, 63);
            this.btnNvoPokemon.TabIndex = 17;
            this.btnNvoPokemon.Text = "Novo";
            this.btnNvoPokemon.UseVisualStyleBackColor = false;
            this.btnNvoPokemon.Click += new System.EventHandler(this.btnNvoPokemon_Click);
            // 
            // btnEditarPokemon
            // 
            this.btnEditarPokemon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarPokemon.BackgroundImage")));
            this.btnEditarPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarPokemon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarPokemon.FlatAppearance.BorderSize = 5;
            this.btnEditarPokemon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEditarPokemon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditarPokemon.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPokemon.Image")));
            this.btnEditarPokemon.Location = new System.Drawing.Point(156, 335);
            this.btnEditarPokemon.Name = "btnEditarPokemon";
            this.btnEditarPokemon.Size = new System.Drawing.Size(106, 63);
            this.btnEditarPokemon.TabIndex = 18;
            this.btnEditarPokemon.Text = "Editar";
            this.btnEditarPokemon.UseVisualStyleBackColor = false;
            this.btnEditarPokemon.Click += new System.EventHandler(this.btnEditarPokemon_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpar.BackgroundImage")));
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpar.FlatAppearance.BorderSize = 5;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(268, 335);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 63);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "Limpar/Cancelar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcluirPokemon
            // 
            this.btnExcluirPokemon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirPokemon.BackgroundImage")));
            this.btnExcluirPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirPokemon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirPokemon.FlatAppearance.BorderSize = 5;
            this.btnExcluirPokemon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExcluirPokemon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirPokemon.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirPokemon.Image")));
            this.btnExcluirPokemon.Location = new System.Drawing.Point(380, 335);
            this.btnExcluirPokemon.Name = "btnExcluirPokemon";
            this.btnExcluirPokemon.Size = new System.Drawing.Size(106, 63);
            this.btnExcluirPokemon.TabIndex = 20;
            this.btnExcluirPokemon.Text = "Excluir";
            this.btnExcluirPokemon.UseVisualStyleBackColor = false;
            this.btnExcluirPokemon.Click += new System.EventHandler(this.btnExcluirPokemon_Click);
            // 
            // btnSalvarPokemon
            // 
            this.btnSalvarPokemon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarPokemon.BackgroundImage")));
            this.btnSalvarPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarPokemon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarPokemon.FlatAppearance.BorderSize = 5;
            this.btnSalvarPokemon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalvarPokemon.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvarPokemon.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarPokemon.Image")));
            this.btnSalvarPokemon.Location = new System.Drawing.Point(492, 335);
            this.btnSalvarPokemon.Name = "btnSalvarPokemon";
            this.btnSalvarPokemon.Size = new System.Drawing.Size(106, 63);
            this.btnSalvarPokemon.TabIndex = 21;
            this.btnSalvarPokemon.Text = "Salvar";
            this.btnSalvarPokemon.UseVisualStyleBackColor = false;
            this.btnSalvarPokemon.Click += new System.EventHandler(this.btnSalvarPokemon_Click);
            // 
            // groupBoxPoke
            // 
            this.groupBoxPoke.Controls.Add(this.labelIdPokemon);
            this.groupBoxPoke.Controls.Add(this.pictureBoxImg);
            this.groupBoxPoke.Controls.Add(this.label2);
            this.groupBoxPoke.Controls.Add(this.textBoxNome);
            this.groupBoxPoke.Controls.Add(this.label3);
            this.groupBoxPoke.Controls.Add(this.buttonImg);
            this.groupBoxPoke.Location = new System.Drawing.Point(13, 13);
            this.groupBoxPoke.Name = "groupBoxPoke";
            this.groupBoxPoke.Size = new System.Drawing.Size(775, 126);
            this.groupBoxPoke.TabIndex = 23;
            this.groupBoxPoke.TabStop = false;
            this.groupBoxPoke.Enter += new System.EventHandler(this.groupBoxPoke_Enter);
            // 
            // labelIdPokemon
            // 
            this.labelIdPokemon.AutoSize = true;
            this.labelIdPokemon.Location = new System.Drawing.Point(12, 71);
            this.labelIdPokemon.Name = "labelIdPokemon";
            this.labelIdPokemon.Size = new System.Drawing.Size(0, 13);
            this.labelIdPokemon.TabIndex = 16;
            // 
            // pictureBoxMostraPoke
            // 
            this.pictureBoxMostraPoke.Location = new System.Drawing.Point(660, 165);
            this.pictureBoxMostraPoke.Name = "pictureBoxMostraPoke";
            this.pictureBoxMostraPoke.Size = new System.Drawing.Size(209, 164);
            this.pictureBoxMostraPoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMostraPoke.TabIndex = 17;
            this.pictureBoxMostraPoke.TabStop = false;
            // 
            // richTboxMostraPo
            // 
            this.richTboxMostraPo.Location = new System.Drawing.Point(397, 165);
            this.richTboxMostraPo.Name = "richTboxMostraPo";
            this.richTboxMostraPo.Size = new System.Drawing.Size(257, 164);
            this.richTboxMostraPo.TabIndex = 24;
            this.richTboxMostraPo.Text = "";
            // 
            // comboBoxOrdenarPor
            // 
            this.comboBoxOrdenarPor.AccessibleName = "";
            this.comboBoxOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenarPor.FormattingEnabled = true;
            this.comboBoxOrdenarPor.Items.AddRange(new object[] {
            "NOME",
            "FORCA",
            "PESO",
            "ALTURA",
            "EFEITO"});
            this.comboBoxOrdenarPor.Location = new System.Drawing.Point(128, 235);
            this.comboBoxOrdenarPor.Name = "comboBoxOrdenarPor";
            this.comboBoxOrdenarPor.Size = new System.Drawing.Size(120, 21);
            this.comboBoxOrdenarPor.TabIndex = 26;
            this.comboBoxOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenarPor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Pesquisar Pokemon:";
            // 
            // textBoxPesquisar
            // 
            this.textBoxPesquisar.Location = new System.Drawing.Point(162, 142);
            this.textBoxPesquisar.MaxLength = 23;
            this.textBoxPesquisar.Name = "textBoxPesquisar";
            this.textBoxPesquisar.Size = new System.Drawing.Size(100, 20);
            this.textBoxPesquisar.TabIndex = 17;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.Location = new System.Drawing.Point(278, 142);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buttonPesquisar.TabIndex = 29;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = true;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // comboBoxPesquisa
            // 
            this.comboBoxPesquisa.AccessibleName = "";
            this.comboBoxPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPesquisa.FormattingEnabled = true;
            this.comboBoxPesquisa.Location = new System.Drawing.Point(233, 168);
            this.comboBoxPesquisa.Name = "comboBoxPesquisa";
            this.comboBoxPesquisa.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPesquisa.TabIndex = 30;
            this.comboBoxPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboBoxPesquisa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Ordenar por:";
            // 
            // CadastroPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPesquisa);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.textBoxPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxOrdenarPor);
            this.Controls.Add(this.richTboxMostraPo);
            this.Controls.Add(this.pictureBoxMostraPoke);
            this.Controls.Add(this.groupBoxPoke);
            this.Controls.Add(this.btnSalvarPokemon);
            this.Controls.Add(this.btnExcluirPokemon);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditarPokemon);
            this.Controls.Add(this.btnNvoPokemon);
            this.Controls.Add(this.comboBoxPoke);
            this.Name = "CadastroPokemon";
            this.Text = "CadastroPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.groupBoxPoke.ResumeLayout(false);
            this.groupBoxPoke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMostraPoke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.ComboBox comboBoxPoke;
        private System.Windows.Forms.Button btnNvoPokemon;
        private System.Windows.Forms.Button btnEditarPokemon;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluirPokemon;
        private System.Windows.Forms.Button btnSalvarPokemon;
        private System.Windows.Forms.GroupBox groupBoxPoke;
        private System.Windows.Forms.Label labelIdPokemon;
        private System.Windows.Forms.PictureBox pictureBoxMostraPoke;
        private System.Windows.Forms.RichTextBox richTboxMostraPo;
        private System.Windows.Forms.ComboBox comboBoxOrdenarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPesquisar;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.ComboBox comboBoxPesquisa;
        private System.Windows.Forms.Label label4;
    }
}