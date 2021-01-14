
namespace LeBi
{
    partial class frmLogin
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
            this.tituloLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.lkCadastroLogin = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tituloLogin
            // 
            this.tituloLogin.AutoSize = true;
            this.tituloLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLogin.Location = new System.Drawing.Point(139, 44);
            this.tituloLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloLogin.Name = "tituloLogin";
            this.tituloLogin.Size = new System.Drawing.Size(186, 29);
            this.tituloLogin.TabIndex = 0;
            this.tituloLogin.Text = "LeBi Campinas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marcar consultas nunca foi tão fácil";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(132, 149);
            this.txEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(199, 30);
            this.txEmail.TabIndex = 2;
            this.txEmail.Text = "Email";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(132, 203);
            this.txSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(199, 30);
            this.txSenha.TabIndex = 3;
            this.txSenha.Text = "Senha";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(132, 270);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(200, 31);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Entrar";
            this.btLogin.UseVisualStyleBackColor = true;
            // 
            // lkCadastroLogin
            // 
            this.lkCadastroLogin.AutoSize = true;
            this.lkCadastroLogin.Location = new System.Drawing.Point(265, 324);
            this.lkCadastroLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkCadastroLogin.Name = "lkCadastroLogin";
            this.lkCadastroLogin.Size = new System.Drawing.Size(64, 17);
            this.lkCadastroLogin.TabIndex = 5;
            this.lkCadastroLogin.TabStop = true;
            this.lkCadastroLogin.Text = "inscreva!";
            this.lkCadastroLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkCadastroLogin_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Novo por aqui? Se";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lkCadastroLogin);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.Text = "Login LeBi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.LinkLabel lkCadastroLogin;
        private System.Windows.Forms.Label label2;
    }
}

