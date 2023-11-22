namespace Crud
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.SalvarContato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listaContatos = new System.Windows.Forms.ListView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.BuscarContatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(113, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(110, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(20, 136);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(108, 20);
            this.txtTelefone.TabIndex = 5;
            // 
            // SalvarContato
            // 
            this.SalvarContato.Location = new System.Drawing.Point(46, 178);
            this.SalvarContato.Name = "SalvarContato";
            this.SalvarContato.Size = new System.Drawing.Size(56, 19);
            this.SalvarContato.TabIndex = 6;
            this.SalvarContato.Text = "Salvar";
            this.SalvarContato.UseVisualStyleBackColor = true;
            this.SalvarContato.Click += new System.EventHandler(this.SalvarContato_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "BuscarContatos";
            // 
            // listaContatos
            // 
            this.listaContatos.HideSelection = false;
            this.listaContatos.Location = new System.Drawing.Point(162, 65);
            this.listaContatos.Name = "listaContatos";
            this.listaContatos.Size = new System.Drawing.Size(231, 90);
            this.listaContatos.TabIndex = 8;
            this.listaContatos.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(162, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // BuscarContatos
            // 
            this.BuscarContatos.Location = new System.Drawing.Point(344, 40);
            this.BuscarContatos.Name = "BuscarContatos";
            this.BuscarContatos.Size = new System.Drawing.Size(48, 19);
            this.BuscarContatos.TabIndex = 10;
            this.BuscarContatos.Text = "Buscar";
            this.BuscarContatos.UseVisualStyleBackColor = true;
            this.BuscarContatos.Click += new System.EventHandler(this.BuscarContatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 210);
            this.Controls.Add(this.BuscarContatos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.listaContatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalvarContato);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button SalvarContato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listaContatos;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button BuscarContatos;
    }
}

