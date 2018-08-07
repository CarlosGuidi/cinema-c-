namespace Cinema
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFilme = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpCinema = new System.Windows.Forms.GroupBox();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.txtprecoNormal = new System.Windows.Forms.TextBox();
            this.lblPrecoNormal = new System.Windows.Forms.Label();
            this.txtFilme = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.grpCinema.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(72, 39);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(31, 13);
            this.lblFilme.TabIndex = 0;
            this.lblFilme.Text = "Filme";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(281, 39);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Data";
            // 
            // lblDesconto
            // 
            this.lblDesconto.AutoSize = true;
            this.lblDesconto.Location = new System.Drawing.Point(281, 141);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(53, 13);
            this.lblDesconto.TabIndex = 2;
            this.lblDesconto.Text = "Desconto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(47, 225);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(87, 41);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(261, 225);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // grpCinema
            // 
            this.grpCinema.Controls.Add(this.cmbData);
            this.grpCinema.Controls.Add(this.txtprecoNormal);
            this.grpCinema.Controls.Add(this.lblPrecoNormal);
            this.grpCinema.Controls.Add(this.txtFilme);
            this.grpCinema.Controls.Add(this.txtDesconto);
            this.grpCinema.Controls.Add(this.btnLimpar);
            this.grpCinema.Controls.Add(this.lblDesconto);
            this.grpCinema.Controls.Add(this.btnCalcular);
            this.grpCinema.Controls.Add(this.lblData);
            this.grpCinema.Controls.Add(this.lblFilme);
            this.grpCinema.Location = new System.Drawing.Point(12, 12);
            this.grpCinema.Name = "grpCinema";
            this.grpCinema.Size = new System.Drawing.Size(435, 301);
            this.grpCinema.TabIndex = 5;
            this.grpCinema.TabStop = false;
            this.grpCinema.Text = "Cinema";
            // 
            // cmbData
            // 
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sabádo",
            "Domingo"});
            this.cmbData.Location = new System.Drawing.Point(227, 71);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(121, 21);
            this.cmbData.TabIndex = 10;
            // 
            // txtprecoNormal
            // 
            this.txtprecoNormal.Location = new System.Drawing.Point(47, 174);
            this.txtprecoNormal.Name = "txtprecoNormal";
            this.txtprecoNormal.ReadOnly = true;
            this.txtprecoNormal.Size = new System.Drawing.Size(100, 20);
            this.txtprecoNormal.TabIndex = 9;
            this.txtprecoNormal.Text = "30";
            // 
            // lblPrecoNormal
            // 
            this.lblPrecoNormal.AutoSize = true;
            this.lblPrecoNormal.Location = new System.Drawing.Point(63, 141);
            this.lblPrecoNormal.Name = "lblPrecoNormal";
            this.lblPrecoNormal.Size = new System.Drawing.Size(71, 13);
            this.lblPrecoNormal.TabIndex = 8;
            this.lblPrecoNormal.Text = "Preco Normal";
            // 
            // txtFilme
            // 
            this.txtFilme.Location = new System.Drawing.Point(47, 72);
            this.txtFilme.Name = "txtFilme";
            this.txtFilme.Size = new System.Drawing.Size(100, 20);
            this.txtFilme.TabIndex = 7;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(248, 174);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(100, 20);
            this.txtDesconto.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 327);
            this.Controls.Add(this.grpCinema);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCinema.ResumeLayout(false);
            this.grpCinema.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grpCinema;
        private System.Windows.Forms.TextBox txtprecoNormal;
        private System.Windows.Forms.Label lblPrecoNormal;
        private System.Windows.Forms.TextBox txtFilme;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ComboBox cmbData;
    }
}

