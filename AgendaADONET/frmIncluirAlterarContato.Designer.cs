namespace AgendaADONET
{
    partial class frmIncluirAlterarContato
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
            label1 = new Label();
            txbNome = new TextBox();
            txbEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txbTelefone = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome: ";
            // 
            // txbNome
            // 
            txbNome.Location = new Point(70, 6);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(269, 23);
            txbNome.TabIndex = 1;
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(70, 35);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(269, 23);
            txbEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 38);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Email: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 67);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // txbTelefone
            // 
            txbTelefone.Location = new Point(70, 64);
            txbTelefone.Name = "txbTelefone";
            txbTelefone.Size = new Size(269, 23);
            txbTelefone.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(264, 93);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(183, 93);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmIncluirAlterarContato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 126);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txbTelefone);
            Controls.Add(label3);
            Controls.Add(txbEmail);
            Controls.Add(label2);
            Controls.Add(txbNome);
            Controls.Add(label1);
            Name = "frmIncluirAlterarContato";
            Text = "Inclusão/Alteração de Contatos";
            Load += frmIncluirAlterarContato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbNome;
        private TextBox txbEmail;
        private Label label2;
        private Label label3;
        private TextBox txbTelefone;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}