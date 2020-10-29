﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO.IsolatedStorage;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;

namespace Tlr_controls
{
    public class SW_Textbox:TextBox
    {
        public SW_Textbox() {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SW_Textbox
            // 
            this.Enter += new System.EventHandler(this.SW_Textbox_Enter);
            this.Leave += new System.EventHandler(this.SW_Textbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SW_Textbox_Validating);
            this.ResumeLayout(false);
        }
        public enum TipusDada
        {
            Number,
            Text,
            Data,
            Codi
        }
        private TipusDada _DadaPermesa;
        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
            }
        }

        private void SW_Textbox_Validating(object sender, CancelEventArgs e)
        {
            Regex Texto = new Regex("^[a-zA-Z]+$");
            Regex Numero = new Regex("^[0-9]+$");
            Regex Fecha = new Regex("^([0-2][0-9]|3[0-1])(\\/|-)(0[1-9]|1[0-2])\\2(\\d{4})+$");
            Regex Codigo = new Regex("^[A-Z][A-Z][A-Z][A-Z]-[0-9][0-9][0-9]/[13579][AEIOU]+$");

            switch (DadaPermesa)
            {

                case TipusDada.Text:
                    if (Texto.IsMatch(this.Text)) {
                        MessageBox.Show("Esto es un texto");
                    }
                    else {
                        e.Cancel = true;
                        this.Clear();
                    }
                    break;
                case TipusDada.Number:
<<<<<<< HEAD
                    if (Numero.IsMatch(this.Text) {
=======
                    if (Numero.IsMatch(this.Text)) {
>>>>>>> 601d22acad02ffa9466907e8c0621ae943b4c87d
                        MessageBox.Show("Esto es un numero");
                    }
                    else {
                        e.Cancel = true;
                        this.Clear();
                    }
                    break;
                case TipusDada.Data:
                    if (Fecha.IsMatch(this.Text)) {
                        MessageBox.Show("Esto es una fecha");
                    }
                    else {
                        e.Cancel = true;
                        this.Clear();
                    }
                    break;
                case TipusDada.Codi:
                    if (Codigo.IsMatch(this.Text)) {
                        MessageBox.Show("Esto es un codigo");
                    }
                    else {
                        e.Cancel = true;
                        this.Clear();
                    }
                    break;
            }
        }

        private void SW_Textbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.MistyRose;
        }

        private void SW_Textbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSalmon;
        }
    }
}
