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
    public partial class Gestio_Categoria_Usuari : BaseForm
    {
        public Gestio_Categoria_Usuari()
        {
            InitializeComponent();
        }

        UserCategoriesEntities db;
        List<UserCategory> UserCat;
        bool EsNou = false;

        private void CarregaDades()
        {
            db = new UserCategoriesEntities();

            UserCat = db.UserCategories.ToList();
            dtg.DataSource = UserCat;
            FerBinding();
        }


        private void TreuBinding()
        {
            sW_idUserCategory.DataBindings.Clear();
            sW_idUserCategory.Text = "";

            sW_CodeCategory.DataBindings.Clear();
            sW_CodeCategory.Text = "";

            sW_DescCategory.DataBindings.Clear();
            sW_DescCategory.Text = "";

            sW_AccessLevel.DataBindings.Clear();
            sW_AccessLevel.Text = "";
        }


        private void FerBinding()
        {
            sW_idUserCategory.DataBindings.Clear();
            sW_idUserCategory.DataBindings.Add("Text", UserCat, sW_idUserCategory.NomCamp.ToString());

            sW_CodeCategory.DataBindings.Clear();
            sW_CodeCategory.DataBindings.Add("Text", UserCat, sW_CodeCategory.NomCamp.ToString());

            sW_DescCategory.DataBindings.Clear();
            sW_DescCategory.DataBindings.Add("Text", UserCat, sW_DescCategory.NomCamp.ToString());

            sW_AccessLevel.DataBindings.Clear();
            sW_AccessLevel.DataBindings.Add("Text", UserCat, sW_AccessLevel.NomCamp.ToString());
        }


        private void Gestio_Categoria_Usuari_Load(object sender, EventArgs e)
        {
            CarregaDades();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreuBinding();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                UserCategory UsersCats = new UserCategory
                {
                    CodeCategory = sW_CodeCategory.Text,
                    DescCategory = sW_DescCategory.Text,
                    AccessLevel = int.Parse(sW_AccessLevel.Text),

                };
                db.UserCategories.Add(UsersCats);
            }
            db.SaveChanges();
            CarregaDades();

            
        }
    }
}
