namespace PokemonPrimeiraTentativa
{
    partial class Treinamento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Treinamento));
            this.btnMostraPokemon = new System.Windows.Forms.Button();
            this.comboBoxTreinador = new System.Windows.Forms.ComboBox();
            this.comboBoxPoke = new System.Windows.Forms.ComboBox();
            this.pictureBoxEvoluindo = new System.Windows.Forms.PictureBox();
            this.groupBoxTreinamento = new System.Windows.Forms.GroupBox();
            this.labelEvoluindo = new System.Windows.Forms.Label();
            this.labelContagem = new System.Windows.Forms.Label();
            this.timerEvolucao = new System.Windows.Forms.Timer(this.components);
            this.comboBoxOqTreinar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvoluindo)).BeginInit();
            this.groupBoxTreinamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMostraPokemon
            // 
            this.btnMostraPokemon.Location = new System.Drawing.Point(410, 19);
            this.btnMostraPokemon.Name = "btnMostraPokemon";
            this.btnMostraPokemon.Size = new System.Drawing.Size(163, 23);
            this.btnMostraPokemon.TabIndex = 28;
            this.btnMostraPokemon.Text = "Treinar pokemon";
            this.btnMostraPokemon.UseVisualStyleBackColor = true;
            this.btnMostraPokemon.Click += new System.EventHandler(this.btnMostraPokemon_Click);
            // 
            // comboBoxTreinador
            // 
            this.comboBoxTreinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreinador.FormattingEnabled = true;
            this.comboBoxTreinador.Location = new System.Drawing.Point(12, 21);
            this.comboBoxTreinador.Name = "comboBoxTreinador";
            this.comboBoxTreinador.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTreinador.TabIndex = 27;
            this.comboBoxTreinador.SelectedIndexChanged += new System.EventHandler(this.comboBoxTreinador_SelectedIndexChanged);
            // 
            // comboBoxPoke
            // 
            this.comboBoxPoke.AccessibleName = "";
            this.comboBoxPoke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPoke.FormattingEnabled = true;
            this.comboBoxPoke.Location = new System.Drawing.Point(138, 21);
            this.comboBoxPoke.Name = "comboBoxPoke";
            this.comboBoxPoke.Size = new System.Drawing.Size(120, 21);
            this.comboBoxPoke.TabIndex = 26;
            // 
            // pictureBoxEvoluindo
            // 
            this.pictureBoxEvoluindo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEvoluindo.BackgroundImage")));
            this.pictureBoxEvoluindo.Location = new System.Drawing.Point(25, 19);
            this.pictureBoxEvoluindo.Name = "pictureBoxEvoluindo";
            this.pictureBoxEvoluindo.Size = new System.Drawing.Size(341, 151);
            this.pictureBoxEvoluindo.TabIndex = 29;
            this.pictureBoxEvoluindo.TabStop = false;
            // 
            // groupBoxTreinamento
            // 
            this.groupBoxTreinamento.Controls.Add(this.labelEvoluindo);
            this.groupBoxTreinamento.Controls.Add(this.labelContagem);
            this.groupBoxTreinamento.Controls.Add(this.pictureBoxEvoluindo);
            this.groupBoxTreinamento.Location = new System.Drawing.Point(37, 96);
            this.groupBoxTreinamento.Name = "groupBoxTreinamento";
            this.groupBoxTreinamento.Size = new System.Drawing.Size(751, 298);
            this.groupBoxTreinamento.TabIndex = 30;
            this.groupBoxTreinamento.TabStop = false;
            // 
            // labelEvoluindo
            // 
            this.labelEvoluindo.AutoSize = true;
            this.labelEvoluindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvoluindo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelEvoluindo.Location = new System.Drawing.Point(111, 202);
            this.labelEvoluindo.Name = "labelEvoluindo";
            this.labelEvoluindo.Size = new System.Drawing.Size(346, 25);
            this.labelEvoluindo.TabIndex = 31;
            this.labelEvoluindo.Text = "Seu Pokemon está evoluindo!!!!";
            // 
            // labelContagem
            // 
            this.labelContagem.AutoSize = true;
            this.labelContagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContagem.Location = new System.Drawing.Point(409, 50);
            this.labelContagem.Name = "labelContagem";
            this.labelContagem.Size = new System.Drawing.Size(0, 73);
            this.labelContagem.TabIndex = 30;
            // 
            // timerEvolucao
            // 
            this.timerEvolucao.Tick += new System.EventHandler(this.timerEvolucao_Tick);
            // 
            // comboBoxOqTreinar
            // 
            this.comboBoxOqTreinar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOqTreinar.FormattingEnabled = true;
            this.comboBoxOqTreinar.Items.AddRange(new object[] {
            "FORÇA",
            "ALTURA",
            "PESO",
            "EFEITO"});
            this.comboBoxOqTreinar.Location = new System.Drawing.Point(265, 21);
            this.comboBoxOqTreinar.Name = "comboBoxOqTreinar";
            this.comboBoxOqTreinar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOqTreinar.TabIndex = 31;
            // 
            // Treinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOqTreinar);
            this.Controls.Add(this.groupBoxTreinamento);
            this.Controls.Add(this.btnMostraPokemon);
            this.Controls.Add(this.comboBoxTreinador);
            this.Controls.Add(this.comboBoxPoke);
            this.Name = "Treinamento";
            this.Text = "Treinamento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Treinamento_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Treinamento_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvoluindo)).EndInit();
            this.groupBoxTreinamento.ResumeLayout(false);
            this.groupBoxTreinamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostraPokemon;
        private System.Windows.Forms.ComboBox comboBoxTreinador;
        private System.Windows.Forms.ComboBox comboBoxPoke;
        private System.Windows.Forms.PictureBox pictureBoxEvoluindo;
        private System.Windows.Forms.GroupBox groupBoxTreinamento;
        private System.Windows.Forms.Label labelEvoluindo;
        private System.Windows.Forms.Label labelContagem;
        private System.Windows.Forms.Timer timerEvolucao;
        private System.Windows.Forms.ComboBox comboBoxOqTreinar;
    }
}