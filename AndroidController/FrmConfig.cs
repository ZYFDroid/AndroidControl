using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidController
{
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            new FormTranslator(this);
            lblAuthor.Text = "Made by ZYFDroid";
            if (!Translator.overTran.ContainsKey("Translator")) {
                lblLanguage.Text = "Not Translated Language: " + Translator.SystemLanguage;
            }
        }
    }
}
