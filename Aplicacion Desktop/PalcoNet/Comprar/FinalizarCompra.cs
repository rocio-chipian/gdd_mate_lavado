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

namespace PalcoNet.Comprar
{
    public partial class FinalizarCompra : MiForm
    {
        Compra compra;

        public Compra Compra
        {
            get { return compra; }
            set { compra = value; }
        }

        public FinalizarCompra(MiForm anterior, Compra compra) : base(anterior)
        {
            if (Sesion.getInstance().rol.Nombre == "Cliente"){
                Cliente cliente = (Cliente)Sesion.getInstance().usuario;
                this.Compra = compra;
                

                //Estaria bueno hacer alguna magia para que en la compra aparezca el total calculado y la cantidad de entradas calculada

                this.textBoxEspectaculo.Text = this.Compra.Publicacion.Descripcion;
                this.textBoxCantidad.Text = this.Compra.CantidadEntradas.ToString();
                this.textBoxTotal.Text = this.Compra.Importe.ToString();
                this.textBoxFecha.Text = this.Compra.Fecha.ToString();
            } else{
                button2.Enabled = false;
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cerrarAnteriores();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //hay que guardar las cosas en la base

            MessageBox.Show("La compra se realizó exitosamente!", "Compra", MessageBoxButtons.OK);
            this.cerrarAnteriores();
        }

        private void FinalizarCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
