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
    public partial class NuevoMP : Form
    {
        Tarjeta tarjeta;

        internal Tarjeta Tarjeta
        {
            get { return tarjeta; }
            set { tarjeta = value; }
        }

        public NuevoMP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Agregar el medio de pago a la tabla
        }
    }
}
