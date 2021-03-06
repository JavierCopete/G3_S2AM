﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLR_Dades;

namespace Project_1
{
    public partial class Log_in : Form
    {
        public static string idUser;

        public Log_in()
        {
            InitializeComponent();
        }

        int Error = 0;
        int contador_s = 0;

        private void txtContrasenya_Validating(object sender, CancelEventArgs e)
        {

            //Dades bbdd = new Dades();

            //string queryUsers = "select * from Users where " +
            //    "Login = '" + txtUsuari.Text + "' and Password = '" + txtContrasenya.Text + "'";
            //DataSet dtsUsers = bbdd.PortarPerConsulta(queryUsers);

            String Hash = GetMD5Hash(txtContrasenya.Text);
            Dades bbdd = new Dades();

            string queryUsers = "select * from Users where " +
                "Login = '" + txtUsuari.Text + "' and Hash = '" + Hash + "'";
            DataSet dtsUsers = bbdd.PortarPerConsulta(queryUsers);
            idUser = dtsUsers.Tables[0].Rows[0][0].ToString();

            if (dtsUsers.Tables[0].Rows.Count > 0)
            {
                label5.Hide();
                txtUsuari.Enabled = false;
                txtContrasenya.Enabled = false;
                label6.Text = ("Bon dia " + txtUsuari.Text + ", estem validant les seves credencials");
                pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\IMG\gif_conejo.gif");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                timer1.Enabled = true;
                timer1.Start();
            }
            else
            {
                Error++;
                txtUsuari.Clear();
                txtContrasenya.Clear();

                if (Error == 3)
                {
                    Application.Exit();
                }
                else
                {
                    label6.Text = ("Usuari i Contrasenya incorrectes, intents restants " + (String)(3 - Error).ToString());
                }
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            contador_s++;
        if (contador_s == 5)
            {
                Menu_usuari obj = new Menu_usuari();
                obj.nom_user = txtUsuari.Text;
                obj.idUser = idUser;
                obj.Show();
                this.Hide();
            }
        }

        public static String GetMD5Hash(String input)
        {
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            String hash = s.ToString();
            return hash;
        }

    }
}
