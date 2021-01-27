
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
            this.components = new System.ComponentModel.Container();
            this.brAgendar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txMedico = new System.Windows.Forms.TextBox();
            this.txHorario = new System.Windows.Forms.TextBox();
            this.txDia = new System.Windows.Forms.TextBox();
            this.txCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // brAgendar
            // 
            this.brAgendar.Location = new System.Drawing.Point(634, 243);
            this.brAgendar.Name = "brAgendar";
            this.brAgendar.Size = new System.Drawing.Size(75, 23);
            this.brAgendar.TabIndex = 3;
            this.brAgendar.Text = "Agendar";
            this.brAgendar.UseVisualStyleBackColor = true;
            this.brAgendar.Click += new System.EventHandler(this.brAgendar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(498, 272);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txMedico
            // 
            this.txMedico.Location = new System.Drawing.Point(618, 53);
            this.txMedico.Name = "txMedico";
            this.txMedico.ReadOnly = true;
            this.txMedico.Size = new System.Drawing.Size(149, 20);
            this.txMedico.TabIndex = 10;
            // 
            // txHorario
            // 
            this.txHorario.Location = new System.Drawing.Point(618, 89);
            this.txHorario.Name = "txHorario";
            this.txHorario.ReadOnly = true;
            this.txHorario.Size = new System.Drawing.Size(100, 20);
            this.txHorario.TabIndex = 11;
            // 
            // txDia
            // 
            this.txDia.Location = new System.Drawing.Point(618, 125);
            this.txDia.Name = "txDia";
            this.txDia.ReadOnly = true;
            this.txDia.Size = new System.Drawing.Size(100, 20);
            this.txDia.TabIndex = 12;
            // 
            // txCpf
            // 
            this.txCpf.Location = new System.Drawing.Point(618, 161);
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(130, 20);
            this.txCpf.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Médico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Horário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(557, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Seu CPF:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EscolhaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCpf);
            this.Controls.Add(this.txDia);
            this.Controls.Add(this.txHorario);
            this.Controls.Add(this.txMedico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brAgendar);
            this.Name = "EscolhaMedico";
            this.Text = "EscolhaMedico";
            this.Load += new System.EventHandler(this.EscolhaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button brAgendar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txMedico;
        private System.Windows.Forms.TextBox txHorario;
        private System.Windows.Forms.TextBox txDia;
        private System.Windows.Forms.TextBox txCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}