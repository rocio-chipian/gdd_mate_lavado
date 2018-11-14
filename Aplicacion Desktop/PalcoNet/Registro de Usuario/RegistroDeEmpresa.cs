﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PalcoNet.Dominio;

namespace PalcoNet.Registro_de_Usuario
{
    public partial class RegistroDeEmpresa : MiForm
    {
        Empresa empresa;

        internal Empresa Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        } 

        public RegistroDeEmpresa(Empresa empresa, MiForm formAnterior) : base(formAnterior)
        {
            this.empresa = empresa;
            InitializeComponent();
        }

        private RegistroDeEmpresa() { }

        private bool camposCompletos()
        {
            return !string.IsNullOrWhiteSpace(textBoxRazonSocial.Text)
                && !string.IsNullOrWhiteSpace(textBoxCUIT.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SeleccionarFuncionalidad().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Anterior.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.camposCompletos()){
                Empresa.RazonSocial = textBoxRazonSocial.Text;
                Empresa.Cuit = Int32.Parse(textBoxCUIT.Text);
                Empresa.FechaDeCreacion = DateTime.Now;
                if (!string.IsNullOrWhiteSpace(textBoxMail.Text)) { Empresa.Mail = textBoxMail.Text; }
                if (!string.IsNullOrWhiteSpace(textBoxTelefono.Text)) { Empresa.Telefono = Int32.Parse(textBoxTelefono.Text); }
                new RegistroDomicilio(this, this.Empresa).Show();
                this.Hide();
            }
        }

    }
}
