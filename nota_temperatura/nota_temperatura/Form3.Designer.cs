namespace nota_temperatura
{
    partial class frmTemperatura
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblPorcentagem = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.txtBoxResultado = new System.Windows.Forms.TextBox();
            this.numPorcentagem = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(130, 69);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(85, 16);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura";
            // 
            // lblPorcentagem
            // 
            this.lblPorcentagem.AutoSize = true;
            this.lblPorcentagem.Location = new System.Drawing.Point(504, 69);
            this.lblPorcentagem.Name = "lblPorcentagem";
            this.lblPorcentagem.Size = new System.Drawing.Size(174, 16);
            this.lblPorcentagem.TabIndex = 1;
            this.lblPorcentagem.Text = "Porcentagem de Acréscimo";
            this.lblPorcentagem.Click += new System.EventHandler(this.lblPorcentagem_Click);
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(93, 101);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(163, 22);
            this.txtTemperatura.TabIndex = 2;
            // 
            // txtBoxResultado
            // 
            this.txtBoxResultado.Location = new System.Drawing.Point(304, 187);
            this.txtBoxResultado.Name = "txtBoxResultado";
            this.txtBoxResultado.Size = new System.Drawing.Size(161, 22);
            this.txtBoxResultado.TabIndex = 3;
            // 
            // numPorcentagem
            // 
            this.numPorcentagem.DecimalPlaces = 2;
            this.numPorcentagem.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numPorcentagem.Location = new System.Drawing.Point(495, 102);
            this.numPorcentagem.Name = "numPorcentagem";
            this.numPorcentagem.Size = new System.Drawing.Size(183, 22);
            this.numPorcentagem.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(126, 314);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 50);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(328, 314);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 50);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(546, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(100, 50);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numPorcentagem);
            this.Controls.Add(this.txtBoxResultado);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.lblPorcentagem);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "frmTemperatura";
            this.Text = "Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblPorcentagem;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.TextBox txtBoxResultado;
        private System.Windows.Forms.NumericUpDown numPorcentagem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
    }
}