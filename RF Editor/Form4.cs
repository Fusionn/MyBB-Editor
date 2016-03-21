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
    public partial class Form4 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string link, text;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(materialSingleLineTextField1.Text == "")
            {

            }
            else
            {
                link = materialSingleLineTextField1.Text;
                text = materialSingleLineTextField2.Text;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
        }
    }
}
