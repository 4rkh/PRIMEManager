﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prime_Gadgets.modulos.moduloCalculadora
{
    public partial class ConversorCalculadora : Form
    {
        public ConversorCalculadora()
        {
            InitializeComponent();
        }

        private void btConversorCalculadoraCancelar_Click(object sender, EventArgs e)
        {
            Form telaAtual = this.FindForm();
            telaAtual.Close();
        }

        private void btConversorCalculadoraConverter_Click(object sender, EventArgs e)
        {

        }
    }
}
