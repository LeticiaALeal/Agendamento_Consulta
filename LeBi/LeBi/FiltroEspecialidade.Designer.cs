
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
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.txNomeMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brBusca = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
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
            // cbEspecialidade
            // 
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(208, 139);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbEspecialidade.Size = new System.Drawing.Size(120, 21);
            this.cbEspecialidade.Sorted = true;
            this.cbEspecialidade.TabIndex = 2;
            this.cbEspecialidade.Text = "Especialidade";
            // 
            // txNomeMedico
            // 
            this.txNomeMedico.Location = new System.Drawing.Point(52, 139);
            this.txNomeMedico.Multiline = true;
            this.txNomeMedico.Name = "txNomeMedico";
            this.txNomeMedico.Size = new System.Drawing.Size(150, 21);
            this.txNomeMedico.TabIndex = 3;
            this.txNomeMedico.Text = "Nome do médico";
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
            // brBusca
            // 
            this.brBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brBusca.Location = new System.Drawing.Point(338, 136);
            this.brBusca.Name = "brBusca";
            this.brBusca.Size = new System.Drawing.Size(80, 25);
            this.brBusca.TabIndex = 5;
            this.brBusca.Text = "Buscar";
            this.brBusca.UseVisualStyleBackColor = true;
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
            // 
            // FiltroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 284);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.brBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNomeMedico);
            this.Controls.Add(this.cbEspecialidade);
            this.Controls.Add(this.label1);
            this.Name = "FiltroEspecialidade";
            this.Text = "FiltroEspecialidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.TextBox txNomeMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button brBusca;
        private System.Windows.Forms.Button btConsultas;
    }
}