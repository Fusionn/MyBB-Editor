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
    public partial class Form8 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string name, desc, temp;

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            name = materialSingleLineTextField1.Text;
            desc = materialSingleLineTextField2.Text;
            for(int i = 0, n = richTextBox1.Lines.Count(); i < n; i++)
            {
                temp = temp + richTextBox1.Lines[i] + " + Enviornment.NewLine + ";
            }
        }

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
        }
    }
}
