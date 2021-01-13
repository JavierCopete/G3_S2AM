using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TLR_Forms;

namespace TLR_Taules_Menu
{
    public partial class Gestio_Usuari : BaseForm
    {


        GestioUsuarisEntities db;
        List<User> userls;
        bool EsNou = false;


        public Gestio_Usuari()
        {
            InitializeComponent();
        }

        private void Gestio_Usuari_Load(object sender, EventArgs e)
        {
            db = new GestioUsuarisEntities();

            userls = db.Users.ToList();
            dtg1.DataSource = userls;


            //fer binding
            sW_idUser.Clear();
            sW_idUser.DataBindings.Add("Text", userls, sW_idUser.NomCamp.ToString());

            sW_CodeUser.Clear();
            sW_CodeUser.DataBindings.Add("Text", userls, sW_CodeUser.NomCamp.ToString());

            sW_UserName.Clear();
            sW_UserName.DataBindings.Add("Text", userls, sW_UserName.NomCamp.ToString());

            sW_Login.Clear();
            sW_Login.DataBindings.Add("Text", userls, sW_Login.NomCamp.ToString());

            sW_Password.Clear();
            sW_Password.DataBindings.Add("Text", userls, sW_Password.NomCamp.ToString());

            sW_Photo.Clear();
            sW_Photo.DataBindings.Add("Text", userls, sW_Photo.NomCamp.ToString());


            //Faltan combo
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EsNou = true;
            sW_idUser.Clear();
            sW_idUser.Text = "";

            sW_CodeUser.Clear();
            sW_CodeUser.Text = "";

            sW_UserName.Clear();
            sW_UserName.Text = "";

            sW_Login.Clear();
            sW_Login.Text = "";

            sW_Password.Clear();
            sW_Password.Text = "";

            sW_Photo.Clear();
            sW_Photo.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                User UsersC = new User
                {
                    CodeUser = sW_CodeUser.Text,
                    UserName = sW_UserName.Text,
                    Login = sW_Login.Text,
                    Password = sW_Password.Text,
                    Photo = sW_Photo.Text,
                };
                db.Users.Add(UsersC);
            }
            db.SaveChanges();
        }
    }
}
