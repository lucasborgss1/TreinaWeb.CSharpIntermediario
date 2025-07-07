namespace AgendaADONET
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAgenda = new DataGridView();
            btnAdicionar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            SuspendLayout();
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(12, 12);
            dgvAgenda.MultiSelect = false;
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.ReadOnly = true;
            dgvAgenda.Size = new Size(776, 367);
            dgvAgenda.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 385);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(93, 385);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(174, 385);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdicionar);
            Controls.Add(dgvAgenda);
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgenda;
        private Button btnAdicionar;
        private Button btnAlterar;
        private Button btnExcluir;
    }
}
