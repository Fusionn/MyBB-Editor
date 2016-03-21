using Cyotek.Web.BbCodeFormatter;
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
    public partial class Form5 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        string css = @"csharp.css";
        public string fuckme;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
            timer1.Interval = 50;
            timer1.Start();
            string clipboard = fuckme;
            string html = BbCodeProcessor.Format(clipboard);
            webBrowser1.DocumentText =
                "<html>" + Environment.NewLine +
                "<head>" + Environment.NewLine +
                "<style>body { background-color: #333333; color: #FFF; width: 100%; height: 100%; } .csharpcode, .csharpcode pre { font-size: small; color: black; font-family: Consolas, \"Courier New\", Courier, Monospace; background-color: #ffffff; /*white-space: pre;*/ } .csharpcode pre { margin: 0em; } .csharpcode .rem { color: #008000; } .csharpcode .kwrd { color: #0000ff; } .csharpcode .str { color: #006080; } .csharpcode .op { color: #0000c0; } .csharpcode .preproc { color: #cc6633; } .csharpcode .asp { background-color: #ffff00; } .csharpcode .html { color: #800000; } .csharpcode .attr { color: #ff0000; } .csharpcode .alt { background-color: #f4f4f4; width: 100%; margin: 0em; } .csharpcode .lnum { color: #606060; } .bbc-codetitle, .bbc-quotetitle { margin: 1em 1.5em 0; padding: 2px 4px; background-color: #A0B3CA; font-weight: bold; } .bbc-codecontent, .bbc-quotecontent { margin: 0 1.5em 1em; padding: 5px; border: solid 1px #A0B3CA; background-color: #fff; } .bbc-codecontent pre { margin: 0; padding: 0; } .bbc-highlight { background-color: #FFFF00; color: #333399; } .bbc-spoiler { color: #C0C0C0; background-color: #C0C0C0; } .bbc-indent { padding: 0 1em; } .bbc-list { margin: 1em; }</style>" + Environment.NewLine +
                //"<link rel=\"stylesheet\" type=\"text/css\" href=\"" + css + "\">" + Environment.NewLine +
                "</head>" + Environment.NewLine +
                "<body>" + Environment.NewLine + html + Environment.NewLine +
                "</body>" + Environment.NewLine +
                "</html>";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string clipboard = fuckme;
            string html = BbCodeProcessor.Format(clipboard);
            webBrowser1.DocumentText =
                "<html>" + Environment.NewLine +
                "<head>" + Environment.NewLine +
                "<style>body { background-color: #333333; color: #FFF; width: 100%; height: 100%; } .csharpcode, .csharpcode pre { font-size: small; color: black; font-family: Consolas, \"Courier New\", Courier, Monospace; background-color: #ffffff; /*white-space: pre;*/ } .csharpcode pre { margin: 0em; } .csharpcode .rem { color: #008000; } .csharpcode .kwrd { color: #0000ff; } .csharpcode .str { color: #006080; } .csharpcode .op { color: #0000c0; } .csharpcode .preproc { color: #cc6633; } .csharpcode .asp { background-color: #ffff00; } .csharpcode .html { color: #800000; } .csharpcode .attr { color: #ff0000; } .csharpcode .alt { background-color: #f4f4f4; width: 100%; margin: 0em; } .csharpcode .lnum { color: #606060; } .bbc-codetitle, .bbc-quotetitle { margin: 1em 1.5em 0; padding: 2px 4px; background-color: #A0B3CA; font-weight: bold; } .bbc-codecontent, .bbc-quotecontent { margin: 0 1.5em 1em; padding: 5px; border: solid 1px #A0B3CA; background-color: #fff; } .bbc-codecontent pre { margin: 0; padding: 0; } .bbc-highlight { background-color: #FFFF00; color: #333399; } .bbc-spoiler { color: #C0C0C0; background-color: #C0C0C0; } .bbc-indent { padding: 0 1em; } .bbc-list { margin: 1em; }</style>" + Environment.NewLine +
                //"<link rel=\"stylesheet\" type=\"text/css\" href=\"" + css + "\">" + Environment.NewLine +
                "</head>" + Environment.NewLine +
                "<body>" + Environment.NewLine + html + Environment.NewLine +
                "</body>" + Environment.NewLine +
                "</html>";
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.f5 = new Form5();
        }
    }
}
