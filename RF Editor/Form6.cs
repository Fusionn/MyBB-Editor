using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RF_Editor
{
    public partial class Form6 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string link;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string changeLog = wc.DownloadString("https://raw.githubusercontent.com/Fusionn/versioncontrol/master/changes.md");
            materialLabel2.Text = changeLog;
            // no smaller than design time size
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);

            // no larger than screen size
            this.MaximumSize = new System.Drawing.Size((int)Screen.PrimaryScreen.WorkingArea.Width, (int)Screen.PrimaryScreen.WorkingArea.Height);

            this.AutoSize = true;

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
    }
}
