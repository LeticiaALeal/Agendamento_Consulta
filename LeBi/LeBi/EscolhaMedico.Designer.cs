
namespace LeBi
{
    partial class EscolhaMedico
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEspecialidade = new System.Windows.Forms.Label();
            this.brAgendar = new System.Windows.Forms.Button();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.rbHorario = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(57, 92);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome";
            // 
            // lbEspecialidade
            // 
            this.lbEspecialidade.AutoSize = true;
            this.lbEspecialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecialidade.Location = new System.Drawing.Point(105, 18);
            this.lbEspecialidade.Name = "lbEspecialidade";
            this.lbEspecialidade.Size = new System.Drawing.Size(134, 25);
            this.lbEspecialidade.TabIndex = 2;
            this.lbEspecialidade.Text = "Especialidade";
            // 
            // brAgendar
            // 
            this.brAgendar.Location = new System.Drawing.Point(145, 218);
            this.brAgendar.Name = "brAgendar";
            this.brAgendar.Size = new System.Drawing.Size(75, 23);
            this.brAgendar.TabIndex = 3;
            this.brAgendar.Text = "Agendar";
            this.brAgendar.UseVisualStyleBackColor = true;
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(57, 116);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(53, 13);
            this.lbEndereco.TabIndex = 4;
            this.lbEndereco.Text = "Endereço";
            // 
            // rbHorario
            // 
            this.rbHorario.AutoSize = true;
            this.rbHorario.Location = new System.Drawing.Point(60, 143);
            this.rbHorario.Name = "rbHorario";
            this.rbHorario.Size = new System.Drawing.Size(59, 17);
            this.rbHorario.TabIndex = 5;
            this.rbHorario.TabStop = true;
            this.rbHorario.Text = "Horario";
            this.rbHorario.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Endereço";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(236, 143);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Horario";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // EscolhaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 276);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbHorario);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.brAgendar);
            this.Controls.Add(this.lbEspecialidade);
            this.Controls.Add(this.lbNome);
            this.Name = "EscolhaMedico";
            this.Text = "EscolhaMedico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEspecialidade;
        private System.Windows.Forms.Button brAgendar;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.RadioButton rbHorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}