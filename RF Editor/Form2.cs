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
    public partial class Form2 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string fontStyle;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(nochange.Checked)
            {
                fontStyle = "nochange";
            }
            else if(materialRadioButton1.Checked)
            {
                fontStyle = "Arial";
            }
            else if (materialRadioButton2.Checked)
            {
                fontStyle = "Arial Black";
            }
            else if (materialRadioButton3.Checked)
            {
                fontStyle = "Comic Sans MS";
            }
            else if (materialRadioButton4.Checked)
            {
                fontStyle = "Courier New";
            }
            else if (materialRadioButton5.Checked)
            {
                fontStyle = "Georgia";
            }
            else if (materialRadioButton6.Checked)
            {
                fontStyle = "Impact";
            }
            else if (materialRadioButton7.Checked)
            {
                fontStyle = "Sans-serif";
            }
            else if (materialRadioButton8.Checked)
            {
                fontStyle = "Serif";
            }
            else if (materialRadioButton9.Checked)
            {
                fontStyle = "Times New Roman";
            }
            else if (materialRadioButton10.Checked)
            {
                fontStyle = "Trebuchet MS";
            }
            else if (materialRadioButton11.Checked)
            {
                fontStyle = "Verdana";
            }
        }
    }
}
