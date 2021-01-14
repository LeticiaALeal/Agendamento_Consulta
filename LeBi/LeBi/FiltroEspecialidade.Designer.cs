
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
            this.brBusca = new System.Windows.Forms.Button();
            this.btConsultas = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro de especialidade";
            // 
            // txNomeMedico
            // 
            this.txNomeMedico.Location = new System.Drawing.Point(69, 171);
            this.txNomeMedico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txNomeMedico.Multiline = true;
            this.txNomeMedico.Name = "txNomeMedico";
            this.txNomeMedico.Size = new System.Drawing.Size(199, 25);
            this.txNomeMedico.TabIndex = 3;
            this.txNomeMedico.Text = "Especialidade";
            this.txNomeMedico.TextChanged += new System.EventHandler(this.txNomeMedico_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busque pelo especialista ou pela especialidade desejada";
            // 
            // brBusca
            // 
            this.brBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brBusca.Location = new System.Drawing.Point(451, 167);
            this.brBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brBusca.Name = "brBusca";
            this.brBusca.Size = new System.Drawing.Size(107, 31);
            this.brBusca.TabIndex = 5;
            this.brBusca.Text = "Buscar";
            this.brBusca.UseVisualStyleBackColor = true;
            this.brBusca.Click += new System.EventHandler(this.brBusca_Click);
            // 
            // btConsultas
            // 
            this.btConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultas.Location = new System.Drawing.Point(355, 268);
            this.btConsultas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConsultas.Name = "btConsultas";
            this.btConsultas.Size = new System.Drawing.Size(203, 38);
            this.btConsultas.TabIndex = 6;
            this.btConsultas.Text = "Minhas consultas";
            this.btConsultas.UseVisualStyleBackColor = true;
            this.btConsultas.Click += new System.EventHandler(this.btConsultas_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cardiologista",
            "Gastroenterologista",
            "Neurologista",
            "Oftalmologista"});
            this.comboBox1.Location = new System.Drawing.Point(285, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // FiltroEspecialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 350);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btConsultas);
            this.Controls.Add(this.brBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNomeMedico);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button brBusca;
        private System.Windows.Forms.Button btConsultas;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}