﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgendaADONET.Classes;
using AgendaADONET.DAO;

namespace AgendaADONET
{
    public partial class frmIncluirAlterarContato : Form
    {

        private Contato contato;

        public frmIncluirAlterarContato(Contato contato = null)
        {
            this.contato = contato;
            InitializeComponent();
        }

        public frmIncluirAlterarContato()
        {
            InitializeComponent();
        }

        private void frmIncluirAlterarContato_Load(object sender, EventArgs e)
        {
            if (this.contato != null)
            {
                txbNome.Text = contato.Nome;
                txbEmail.Text = contato.Email;
                txbTelefone.Text = contato.Telefone.ToString();
            }
            else
            {
                txbNome.Text = string.Empty;
                txbEmail.Text = string.Empty;
                txbTelefone.Text = string.Empty;
            }
            txbNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContatoDAO contatoDAO = new ContatoDAO();
            if (this.contato == null)
            {
                Contato contato = new Contato
                {
                    Nome = txbNome.Text,
                    Email = txbEmail.Text,
                    Telefone = Convert.ToInt32(txbTelefone.Text)
                };
                contatoDAO.Inserir(contato.Nome, contato.Email, contato.Telefone);
            }
            else
            {
                this.contato.Nome = txbNome.Text;   
                this.contato.Email = txbEmail.Text; 
                this.contato.Telefone = Convert.ToInt32(txbTelefone.Text);
                contatoDAO.Atualizar(this.contato.Id, this.contato.Nome, this.contato.Email, this.contato.Telefone);
            }
            this.Close();
        }

        //private void frmIncluirAlterarContato_Load(object sender, EventArgs e)
        //{
        //    if (this.contato != null)
        //    {
        //        Contato contato = new Contato
        //        {
        //            Nome = txbNome.Text,
        //            Email = txbEmail.Text,
        //            Telefone = Convert.ToInt32(txbTelefone.Text)
        //        };
        //        ContatoDAO.Inserir(Contato);
        //    }
        //    else
        //    {

        //    }
        //}

    }
}

