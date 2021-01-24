
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
            this.txNomeMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBusca = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de especialidade";
            // 
            // txNomeMedico
            // 
            this.txNomeMedico.Location = new System.Drawing.Point(52, 139);
            this.txNomeMedico.Multiline = true;
            this.txNomeMedico.Name = "txNomeMedico";
            this.txNomeMedico.Size = new System.Drawing.Size(150, 21);
            this.txNomeMedico.TabIndex = 3;
            this.txNomeMedico.Text = "Especialidade";
            this.txNomeMedico.TextChanged += new System.EventHandler(this.txNomeMedico_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busque pelo especialista ou pela especialidade desejada";
            // 
            // btBusca
            // 
            this.btBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusca.Location = new System.Drawing.Point(338, 136);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(80, 25);
            this.btBusca.TabIndex = 5;
            this.btBusca.Text = "Buscar";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btBusca_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(266, 218);
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
            this.cbEspecialidade.Location = new System.Drawing.Point(214, 140);
            this.cbEspecialidade.Margin = new System.Windows.Forms.Padding(2);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(120, 21);
            this.cbEspecialidade.TabIndex = 7;
            this.cbEspecialidade.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidade_SelectedIndexChanged);
            // 
            // FiltroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.btBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNomeMedico);
            this.Controls.Add(this.label1);
            this.Name = "FiltroEspecialidade";
            this.Text = "FiltroEspecialidade";
            this.Load += new System.EventHandler(this.FiltroEspecialidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNomeMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.ComboBox cbEspecialidade;
    }
}