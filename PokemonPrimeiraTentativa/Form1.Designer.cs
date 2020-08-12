namespace PokemonPrimeiraTentativa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCadastroPkmon = new System.Windows.Forms.Button();
            this.btnCadastroTreinador = new System.Windows.Forms.Button();
            this.btnTreinamento = new System.Windows.Forms.Button();
            this.buttonCapturar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroPkmon
            // 
            this.btnCadastroPkmon.Location = new System.Drawing.Point(78, 46);
            this.btnCadastroPkmon.Name = "btnCadastroPkmon";
            this.btnCadastroPkmon.Size = new System.Drawing.Size(217, 23);
            this.btnCadastroPkmon.TabIndex = 0;
            this.btnCadastroPkmon.Text = "cadastrar pokemon";
            this.btnCadastroPkmon.UseVisualStyleBackColor = true;
            this.btnCadastroPkmon.Click += new System.EventHandler(this.btnCadastroPkmon_Click);
            // 
            // btnCadastroTreinador
            // 
            this.btnCadastroTreinador.Location = new System.Drawing.Point(78, 75);
            this.btnCadastroTreinador.Name = "btnCadastroTreinador";
            this.btnCadastroTreinador.Size = new System.Drawing.Size(217, 23);
            this.btnCadastroTreinador.TabIndex = 1;
            this.btnCadastroTreinador.Text = "cadastrar Treinador";
            this.btnCadastroTreinador.UseVisualStyleBackColor = true;
            this.btnCadastroTreinador.Click += new System.EventHandler(this.btnCadastroTreinador_Click);
            // 
            // btnTreinamento
            // 
            this.btnTreinamento.Location = new System.Drawing.Point(78, 104);
            this.btnTreinamento.Name = "btnTreinamento";
            this.btnTreinamento.Size = new System.Drawing.Size(217, 23);
            this.btnTreinamento.TabIndex = 2;
            this.btnTreinamento.Text = "Treinamento";
            this.btnTreinamento.UseVisualStyleBackColor = true;
            this.btnTreinamento.Click += new System.EventHandler(this.btnTreinamento_Click);
            // 
            // buttonCapturar
            // 
            this.buttonCapturar.Location = new System.Drawing.Point(78, 133);
            this.buttonCapturar.Name = "buttonCapturar";
            this.buttonCapturar.Size = new System.Drawing.Size(217, 23);
            this.buttonCapturar.TabIndex = 3;
            this.buttonCapturar.Text = "Capturar Pokemon";
            this.buttonCapturar.UseVisualStyleBackColor = true;
            this.buttonCapturar.Click += new System.EventHandler(this.buttonCapturar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCapturar);
            this.Controls.Add(this.btnTreinamento);
            this.Controls.Add(this.btnCadastroTreinador);
            this.Controls.Add(this.btnCadastroPkmon);
            this.Name = "Form1";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroPkmon;
        private System.Windows.Forms.Button btnCadastroTreinador;
        private System.Windows.Forms.Button btnTreinamento;
        private System.Windows.Forms.Button buttonCapturar;
    }
}

