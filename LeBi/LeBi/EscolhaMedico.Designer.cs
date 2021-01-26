
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
            this.brAgendar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // brAgendar
            // 
            this.brAgendar.Location = new System.Drawing.Point(244, 320);
            this.brAgendar.Name = "brAgendar";
            this.brAgendar.Size = new System.Drawing.Size(75, 23);
            this.brAgendar.TabIndex = 3;
            this.brAgendar.Text = "Agendar";
            this.brAgendar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 272);
            this.dataGridView1.TabIndex = 9;
            // 
            // EscolhaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 355);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brAgendar);
            this.Name = "EscolhaMedico";
            this.Text = "EscolhaMedico";
            this.Load += new System.EventHandler(this.EscolhaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button brAgendar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}