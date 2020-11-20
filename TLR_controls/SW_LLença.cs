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
    public partial class SW_LLença : UserControl
    {
        public SW_LLença()
        {
            InitializeComponent();
        }

        private String _Classe;
        private String _Form;

        public String Classe
        {
            get { return _Classe; }
            set
            {
                _Classe = value;
            }
        }
        public String Form
        {
            get { return _Form; }
            set
            {
                _Form = value;
            }
        }

    }
}
