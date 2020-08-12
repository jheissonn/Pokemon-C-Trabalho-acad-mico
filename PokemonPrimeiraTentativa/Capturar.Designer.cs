namespace PokemonPrimeiraTentativa
{
    partial class Capturar
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
            this.comboBoxTreinador = new System.Windows.Forms.ComboBox();
            this.buttonCapturar = new System.Windows.Forms.Button();
            this.cmboxPokeSelvagem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTentativa = new System.Windows.Forms.TextBox();
            this.groupBoxTenta = new System.Windows.Forms.GroupBox();
            this.buttonTenta = new System.Windows.Forms.Button();
            this.groupBoxTenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxTreinador
            // 
            this.comboBoxTreinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreinador.FormattingEnabled = true;
            this.comboBoxTreinador.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTreinador.Name = "comboBoxTreinador";
            this.comboBoxTreinador.Size = new System.Drawing.Size(120, 21);
            this.comboBoxTreinador.TabIndex = 28;
            // 
            // buttonCapturar
            // 
            this.buttonCapturar.Location = new System.Drawing.Point(458, 32);
            this.buttonCapturar.Name = "buttonCapturar";
            this.buttonCapturar.Size = new System.Drawing.Size(133, 23);
            this.buttonCapturar.TabIndex = 29;
            this.buttonCapturar.Text = "Capturar";
            this.buttonCapturar.UseVisualStyleBackColor = true;
            this.buttonCapturar.Click += new System.EventHandler(this.buttonCapturar_Click);
            // 
            // cmboxPokeSelvagem
            // 
            this.cmboxPokeSelvagem.AccessibleName = "";
            this.cmboxPokeSelvagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboxPokeSelvagem.FormattingEnabled = true;
            this.cmboxPokeSelvagem.Location = new System.Drawing.Point(164, 12);
            this.cmboxPokeSelvagem.Name = "cmboxPokeSelvagem";
            this.cmboxPokeSelvagem.Size = new System.Drawing.Size(120, 21);
            this.cmboxPokeSelvagem.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Para tentar capturar digite um número de 1 a 5";
            // 
            // textBoxTentativa
            // 
            this.textBoxTentativa.Location = new System.Drawing.Point(400, 35);
            this.textBoxTentativa.MaxLength = 2;
            this.textBoxTentativa.Name = "textBoxTentativa";
            this.textBoxTentativa.Size = new System.Drawing.Size(40, 20);
            this.textBoxTentativa.TabIndex = 40;
            // 
            // groupBoxTenta
            // 
            this.groupBoxTenta.Controls.Add(this.buttonCapturar);
            this.groupBoxTenta.Controls.Add(this.textBoxTentativa);
            this.groupBoxTenta.Controls.Add(this.label1);
            this.groupBoxTenta.Location = new System.Drawing.Point(1, 39);
            this.groupBoxTenta.Name = "groupBoxTenta";
            this.groupBoxTenta.Size = new System.Drawing.Size(627, 83);
            this.groupBoxTenta.TabIndex = 41;
            this.groupBoxTenta.TabStop = false;
            // 
            // buttonTenta
            // 
            this.buttonTenta.Location = new System.Drawing.Point(313, 12);
            this.buttonTenta.Name = "buttonTenta";
            this.buttonTenta.Size = new System.Drawing.Size(172, 23);
            this.buttonTenta.TabIndex = 42;
            this.buttonTenta.Text = "Tentar capturar";
            this.buttonTenta.UseVisualStyleBackColor = true;
            this.buttonTenta.Click += new System.EventHandler(this.buttonTenta_Click);
            // 
            // Capturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonTenta);
            this.Controls.Add(this.groupBoxTenta);
            this.Controls.Add(this.cmboxPokeSelvagem);
            this.Controls.Add(this.comboBoxTreinador);
            this.Name = "Capturar";
            this.Text = "Capturar";
            this.groupBoxTenta.ResumeLayout(false);
            this.groupBoxTenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTreinador;
        private System.Windows.Forms.Button buttonCapturar;
        private System.Windows.Forms.ComboBox cmboxPokeSelvagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTentativa;
        private System.Windows.Forms.GroupBox groupBoxTenta;
        private System.Windows.Forms.Button buttonTenta;
    }
}