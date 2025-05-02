namespace nota_temperatura
{
    partial class frmMedia
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
            this.lblMedia1 = new System.Windows.Forms.Label();
            this.lblMedia2 = new System.Windows.Forms.Label();
            this.lblMedia3 = new System.Windows.Forms.Label();
            this.lblMedia4 = new System.Windows.Forms.Label();
            this.numMedia1 = new System.Windows.Forms.NumericUpDown();
            this.numMedia2 = new System.Windows.Forms.NumericUpDown();
            this.numMedia3 = new System.Windows.Forms.NumericUpDown();
            this.numMedia4 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblMediaFinal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMedia1
            // 
            this.lblMedia1.AutoSize = true;
            this.lblMedia1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia1.Location = new System.Drawing.Point(88, 68);
            this.lblMedia1.Name = "lblMedia1";
            this.lblMedia1.Size = new System.Drawing.Size(87, 23);
            this.lblMedia1.TabIndex = 0;
            this.lblMedia1.Text = "Média 1";
            // 
            // lblMedia2
            // 
            this.lblMedia2.AutoSize = true;
            this.lblMedia2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia2.Location = new System.Drawing.Point(88, 118);
            this.lblMedia2.Name = "lblMedia2";
            this.lblMedia2.Size = new System.Drawing.Size(87, 23);
            this.lblMedia2.TabIndex = 1;
            this.lblMedia2.Text = "Média 2";
            // 
            // lblMedia3
            // 
            this.lblMedia3.AutoSize = true;
            this.lblMedia3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia3.Location = new System.Drawing.Point(88, 177);
            this.lblMedia3.Name = "lblMedia3";
            this.lblMedia3.Size = new System.Drawing.Size(87, 23);
            this.lblMedia3.TabIndex = 2;
            this.lblMedia3.Text = "Média 3";
            // 
            // lblMedia4
            // 
            this.lblMedia4.AutoSize = true;
            this.lblMedia4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia4.Location = new System.Drawing.Point(88, 237);
            this.lblMedia4.Name = "lblMedia4";
            this.lblMedia4.Size = new System.Drawing.Size(87, 23);
            this.lblMedia4.TabIndex = 3;
            this.lblMedia4.Text = "Média 4";
            // 
            // numMedia1
            // 
            this.numMedia1.DecimalPlaces = 1;
            this.numMedia1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMedia1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia1.Location = new System.Drawing.Point(213, 71);
            this.numMedia1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia1.Name = "numMedia1";
            this.numMedia1.Size = new System.Drawing.Size(120, 27);
            this.numMedia1.TabIndex = 4;
            // 
            // numMedia2
            // 
            this.numMedia2.DecimalPlaces = 1;
            this.numMedia2.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMedia2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia2.Location = new System.Drawing.Point(213, 121);
            this.numMedia2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia2.Name = "numMedia2";
            this.numMedia2.Size = new System.Drawing.Size(120, 27);
            this.numMedia2.TabIndex = 5;
            // 
            // numMedia3
            // 
            this.numMedia3.DecimalPlaces = 1;
            this.numMedia3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMedia3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia3.Location = new System.Drawing.Point(213, 180);
            this.numMedia3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia3.Name = "numMedia3";
            this.numMedia3.Size = new System.Drawing.Size(120, 27);
            this.numMedia3.TabIndex = 6;
            // 
            // numMedia4
            // 
            this.numMedia4.DecimalPlaces = 1;
            this.numMedia4.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMedia4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numMedia4.Location = new System.Drawing.Point(213, 240);
            this.numMedia4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMedia4.Name = "numMedia4";
            this.numMedia4.Size = new System.Drawing.Size(120, 27);
            this.numMedia4.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(213, 330);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 33);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(376, 330);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 33);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(557, 330);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 33);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(517, 68);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(164, 23);
            this.lbl5.TabIndex = 11;
            this.lbl5.Text = "Média do Aluno";
            // 
            // lblMediaFinal
            // 
            this.lblMediaFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMediaFinal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaFinal.Location = new System.Drawing.Point(516, 121);
            this.lblMediaFinal.Name = "lblMediaFinal";
            this.lblMediaFinal.Size = new System.Drawing.Size(165, 65);
            this.lblMediaFinal.TabIndex = 12;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMediaFinal);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.numMedia4);
            this.Controls.Add(this.numMedia3);
            this.Controls.Add(this.numMedia2);
            this.Controls.Add(this.numMedia1);
            this.Controls.Add(this.lblMedia4);
            this.Controls.Add(this.lblMedia3);
            this.Controls.Add(this.lblMedia2);
            this.Controls.Add(this.lblMedia1);
            this.Name = "frmMedia";
            this.Text = "Média de Nota";
            ((System.ComponentModel.ISupportInitialize)(this.numMedia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMedia4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMedia1;
        private System.Windows.Forms.Label lblMedia2;
        private System.Windows.Forms.Label lblMedia4;
        private System.Windows.Forms.NumericUpDown numMedia1;
        private System.Windows.Forms.NumericUpDown numMedia2;
        private System.Windows.Forms.NumericUpDown numMedia3;
        private System.Windows.Forms.NumericUpDown numMedia4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblMediaFinal;
        private System.Windows.Forms.Label lblMedia3;
    }
}