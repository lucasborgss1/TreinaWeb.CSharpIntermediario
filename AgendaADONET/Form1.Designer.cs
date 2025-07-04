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
            dgvAgenda.Size = new Size(776, 426);
            dgvAgenda.TabIndex = 0;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAgenda);
            Name = "frmAgenda";
            Text = "Agenda";
            Load += frmAgenda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAgenda;
    }
}
