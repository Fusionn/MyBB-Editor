using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RF_Editor
{
    public partial class Form3 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string fontSize;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(nochange.Checked)
            {
                fontSize = "none";
            }
            else if(materialRadioButton1.Checked)
            {
                fontSize = "xx-small";
            }
            else if (materialRadioButton2.Checked)
            {
                fontSize = "x-small";
            }
            else if (materialRadioButton3.Checked)
            {
                fontSize = "small";
            }
            else if (materialRadioButton4.Checked)
            {
                fontSize = "medium";
            }
            else if (materialRadioButton5.Checked)
            {
                fontSize = "large";
            }
            else if (materialRadioButton6.Checked)
            {
                fontSize = "x-large";
            }
            else if (materialRadioButton7.Checked)
            {
                fontSize = "xx-large";
            }
        }
    }
}
