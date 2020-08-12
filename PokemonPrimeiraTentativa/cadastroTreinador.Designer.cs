namespace PokemonPrimeiraTentativa
{
    partial class cadastroTreinador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroTreinador));
            this.comboBoxTreinador = new System.Windows.Forms.ComboBox();
            this.btnSalvarTreinador = new System.Windows.Forms.Button();
            this.btnExcluirTreinador = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnEditarTreinador = new System.Windows.Forms.Button();
            this.btnNvoTreinador = new System.Windows.Forms.Button();
            this.groupBoxTrei = new System.Windows.Forms.GroupBox();
            this.labelIdTreinador = new System.Windows.Forms.Label();
            this.cmboxPokeSelvagem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxOrdenarPor = new System.Windows.Forms.ComboBox();
            this.groupBoxTrei.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTreinador
            // 
            this.comboBoxTreinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreinador.FormattingEnabled = true;
            this.comboBoxTreinador.Location = new System.Drawing.Point(321, 166);
            this.comboBoxTreinador.Name = "comboBoxTreinador";
            this.comboBoxTreinador.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTreinador.TabIndex = 33;
            this.comboBoxTreinador.SelectedIndexChanged += new System.EventHandler(this.comboBoxTreinador_SelectedIndexChanged);
            // 
            // btnSalvarTreinador
            // 
            this.btnSalvarTreinador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvarTreinador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarTreinador.BackgroundImage")));
            this.btnSalvarTreinador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvarTreinador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarTreinador.FlatAppearance.BorderSize = 5;
            this.btnSalvarTreinador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalvarTreinador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvarTreinador.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarTreinador.Image")));
            this.btnSalvarTreinador.Location = new System.Drawing.Point(460, 211);
            this.btnSalvarTreinador.Name = "btnSalvarTreinador";
            this.btnSalvarTreinador.Size = new System.Drawing.Size(106, 63);
            this.btnSalvarTreinador.TabIndex = 32;
            this.btnSalvarTreinador.Text = "Salvar";
            this.btnSalvarTreinador.UseVisualStyleBackColor = false;
            this.btnSalvarTreinador.Click += new System.EventHandler(this.btnSalvarPokemon_Click);
            // 
            // btnExcluirTreinador
            // 
            this.btnExcluirTreinador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirTreinador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluirTreinador.BackgroundImage")));
            this.btnExcluirTreinador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluirTreinador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirTreinador.FlatAppearance.BorderSize = 5;
            this.btnExcluirTreinador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExcluirTreinador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluirTreinador.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirTreinador.Image")));
            this.btnExcluirTreinador.Location = new System.Drawing.Point(348, 211);
            this.btnExcluirTreinador.Name = "btnExcluirTreinador";
            this.btnExcluirTreinador.Size = new System.Drawing.Size(106, 63);
            this.btnExcluirTreinador.TabIndex = 31;
            this.btnExcluirTreinador.Text = "Excluir";
            this.btnExcluirTreinador.UseVisualStyleBackColor = false;
            this.btnExcluirTreinador.Click += new System.EventHandler(this.btnExcluirTreinador_Click);
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
            this.btnLimpar.Location = new System.Drawing.Point(236, 211);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 63);
            this.btnLimpar.TabIndex = 30;
            this.btnLimpar.Text = "Limpar/Cancelar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnEditarTreinador
            // 
            this.btnEditarTreinador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditarTreinador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditarTreinador.BackgroundImage")));
            this.btnEditarTreinador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditarTreinador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarTreinador.FlatAppearance.BorderSize = 5;
            this.btnEditarTreinador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEditarTreinador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditarTreinador.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTreinador.Image")));
            this.btnEditarTreinador.Location = new System.Drawing.Point(124, 211);
            this.btnEditarTreinador.Name = "btnEditarTreinador";
            this.btnEditarTreinador.Size = new System.Drawing.Size(106, 63);
            this.btnEditarTreinador.TabIndex = 29;
            this.btnEditarTreinador.Text = "Editar";
            this.btnEditarTreinador.UseVisualStyleBackColor = false;
            this.btnEditarTreinador.Click += new System.EventHandler(this.btnEditarTreinador_Click);
            // 
            // btnNvoTreinador
            // 
            this.btnNvoTreinador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNvoTreinador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNvoTreinador.BackgroundImage")));
            this.btnNvoTreinador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNvoTreinador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNvoTreinador.FlatAppearance.BorderSize = 5;
            this.btnNvoTreinador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNvoTreinador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNvoTreinador.Image = ((System.Drawing.Image)(resources.GetObject("btnNvoTreinador.Image")));
            this.btnNvoTreinador.Location = new System.Drawing.Point(12, 211);
            this.btnNvoTreinador.Name = "btnNvoTreinador";
            this.btnNvoTreinador.Size = new System.Drawing.Size(106, 63);
            this.btnNvoTreinador.TabIndex = 28;
            this.btnNvoTreinador.Text = "Novo";
            this.btnNvoTreinador.UseVisualStyleBackColor = false;
            this.btnNvoTreinador.Click += new System.EventHandler(this.btnNvoTreinador_Click);
            // 
            // groupBoxTrei
            // 
            this.groupBoxTrei.Controls.Add(this.labelIdTreinador);
            this.groupBoxTrei.Controls.Add(this.cmboxPokeSelvagem);
            this.groupBoxTrei.Controls.Add(this.label2);
            this.groupBoxTrei.Controls.Add(this.textBoxNome);
            this.groupBoxTrei.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTrei.Name = "groupBoxTrei";
            this.groupBoxTrei.Size = new System.Drawing.Size(775, 145);
            this.groupBoxTrei.TabIndex = 36;
            this.groupBoxTrei.TabStop = false;
            // 
            // labelIdTreinador
            // 
            this.labelIdTreinador.AutoSize = true;
            this.labelIdTreinador.Location = new System.Drawing.Point(12, 71);
            this.labelIdTreinador.Name = "labelIdTreinador";
            this.labelIdTreinador.Size = new System.Drawing.Size(0, 13);
            this.labelIdTreinador.TabIndex = 16;
            // 
            // cmboxPokeSelvagem
            // 
            this.cmboxPokeSelvagem.AccessibleName = "";
            this.cmboxPokeSelvagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxPokeSelvagem.FormattingEnabled = true;
            this.cmboxPokeSelvagem.Location = new System.Drawing.Point(290, 18);
            this.cmboxPokeSelvagem.Name = "cmboxPokeSelvagem";
            this.cmboxPokeSelvagem.Size = new System.Drawing.Size(120, 21);
            this.cmboxPokeSelvagem.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insira o nome do Treinador:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(156, 19);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Ordenar por:";
            // 
            // comboBoxOrdenarPor
            // 
            this.comboBoxOrdenarPor.AccessibleName = "";
            this.comboBoxOrdenarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrdenarPor.FormattingEnabled = true;
            this.comboBoxOrdenarPor.Items.AddRange(new object[] {
            "NOME",
            "Ordem de cadastro"});
            this.comboBoxOrdenarPor.Location = new System.Drawing.Point(128, 166);
            this.comboBoxOrdenarPor.Name = "comboBoxOrdenarPor";
            this.comboBoxOrdenarPor.Size = new System.Drawing.Size(120, 21);
            this.comboBoxOrdenarPor.TabIndex = 37;
            this.comboBoxOrdenarPor.SelectedIndexChanged += new System.EventHandler(this.comboBoxOrdenarPor_SelectedIndexChanged);
            // 
            // cadastroTreinador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 284);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOrdenarPor);
            this.Controls.Add(this.groupBoxTrei);
            this.Controls.Add(this.comboBoxTreinador);
            this.Controls.Add(this.btnSalvarTreinador);
            this.Controls.Add(this.btnExcluirTreinador);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEditarTreinador);
            this.Controls.Add(this.btnNvoTreinador);
            this.Name = "cadastroTreinador";
            this.Text = "cadastroTreinador";
            this.groupBoxTrei.ResumeLayout(false);
            this.groupBoxTrei.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxTreinador;
        private System.Windows.Forms.Button btnSalvarTreinador;
        private System.Windows.Forms.Button btnExcluirTreinador;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnEditarTreinador;
        private System.Windows.Forms.Button btnNvoTreinador;
        private System.Windows.Forms.GroupBox groupBoxTrei;
        private System.Windows.Forms.Label labelIdTreinador;
        private System.Windows.Forms.ComboBox cmboxPokeSelvagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOrdenarPor;
    }
}