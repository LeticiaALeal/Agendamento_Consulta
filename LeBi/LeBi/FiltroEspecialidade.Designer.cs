
namespace LeBi
{
    partial class FiltroEspecialidade
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btConsultas = new System.Windows.Forms.Button();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.txCPF = new System.Windows.Forms.TextBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de especialidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busque pela especialidade desejada";
            // 
            // btConsultas
            // 
            this.btConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(238, 224);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(152, 31);
            this.btConsultas.TabIndex = 6;
            this.btConsultas.Text = "Minhas consultas";
            this.btConsultas.UseVisualStyleBackColor = true;
            this.btConsultas.Click += new System.EventHandler(this.btConsultas_Click);
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Items.AddRange(new object[] {
            "cardiologia",
            "clinico geral",
            "dermatologia",
            "endocrinologia",
            "gastroenterologia",
            "ginecologia",
            "neurologia",
            "oftalmologia",
            "oncologia",
            "ortopedia",
            "otorrinolaringologia",
            "pediatria",
            "pneumologia"});
            this.cbEspecialidade.Location = new System.Drawing.Point(146, 136);
            this.cbEspecialidade.Margin = new System.Windows.Forms.Padding(2);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(164, 21);
            this.cbEspecialidade.TabIndex = 7;
            this.cbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidade_SelectedIndexChanged);
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(86, 230);
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(135, 20);
            this.txCPF.TabIndex = 8;
            this.txCPF.Text = "Seu CPF";
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(377, 12);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 9;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // FiltroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 284);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.txCPF);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FiltroEspecialidade";
            this.Text = "FiltroEspecialidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.TextBox txCPF;
        private System.Windows.Forms.Button btLogout;
    }
}