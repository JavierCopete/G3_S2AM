using System;
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
    public partial class SW_ComboFK : ComboBox
    {
        public SW_ComboFK()
        {
            InitializeComponent();
        }

        public SW_ComboFK(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private String _ControlID;
        private String _CampMostrar;
        private String _CampID;

        public String ControlID
        {
            get { return _ControlID; }
            set
            {
                _ControlID = value;
            }
        }

        public String CampMostrar
        {
            get { return _CampMostrar; }
            set
            {
                _CampMostrar = value;
            }
        }

        public String CampID
        {
            get { return _CampID; }
            set
            {
                _CampID = value;
            }
        }

        private void SW_ComboFK_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Form frm = this.FindForm();

            foreach (Control ctr in frm.Controls)
            {
                if (ctr.GetType() == typeof(SW_Textbox) && _ControlID == ctr.Name)
                {
                  //  ctr.Text = SelectedValue.toString();
                }
            }
        }

        private void SW_ComboFK_Click(object sender, EventArgs e)
        {

        }
    }
}
