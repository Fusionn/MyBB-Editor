using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RF_Editor
{
    public partial class Form1 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        bool focus;
        public Form5 f5 = new Form5();
        Form7 f7 = new Form7();
        Form6 f6 = new Form6();
        string version = "1.01b";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
            WebClient wc = new WebClient();
            string remoteVersion = wc.DownloadString("https://raw.githubusercontent.com/Fusionn/versioncontrol/master/README.md");
            if(remoteVersion.Contains(version))
            {

            }
            else
            {
                WebClient wcc = new WebClient();
                string link = wcc.DownloadString("https://raw.githubusercontent.com/Fusionn/versioncontrol/master/link.md");
                f6.link = link;
                f6.ShowDialog();
            }
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[b]" + text + "[/b]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[b][/b]");
            }
        }

        private void buttonItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[i]" + text + "[/i]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[i][/i]");
            }
        }

        private void buttonUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[u]" + text + "[/u]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[u][/u]");
            }
        }

        private void buttonStrike_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[s]" + text + "[/s]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[s][/s]");
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            string font = f2.fontStyle;
            if (font == "nochange")
            {

            }
            else
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    string text = richTextBox1.SelectedText;
                    string newText = "[font=" + font + "]" + text + "[/font]";
                    richTextBox1.SelectedText = newText;
                }
                else
                {
                    richTextBox1.AppendText("[font=" + font + "][/font]");
                }
            }
        }

        private void buttonFSize_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            string font = f3.fontSize;
            if (font == "none")
            {

            }
            else
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    string text = richTextBox1.SelectedText;
                    string newText = "[size=" + font + "]" + text + "[/size]";
                    richTextBox1.SelectedText = newText;
                }
                else
                {
                    richTextBox1.AppendText("[size=" + font + "][/size]");
                }
            }
        }

        private void buttonFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                string HexColor = string.Format("0x{0:X6}", colorDialog1.Color.ToArgb()).ToLower();
                HexColor = HexColor.Replace("0xff", "#");
                if (richTextBox1.SelectionLength > 0)
                {
                    string text = richTextBox1.SelectedText;
                    string newText = "[color=" + HexColor + "]" + text + "[/color]";
                    richTextBox1.SelectedText = newText;
                }
                else
                {
                    richTextBox1.AppendText("[color=" + HexColor + "][/color]");
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[align=left]" + text + "[/align]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[align=left][/align]");
            }
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[align=center]" + text + "[/align]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[align=center][/align]");
            }
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[align=right]" + text + "[/align]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[align=right][/align]");
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[list]" + Environment.NewLine + "[*]" + text + Environment.NewLine + "[/list]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[list]" + Environment.NewLine + "[*]" + Environment.NewLine + "[/list]");
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[list=1]" + Environment.NewLine + "[*]" + text + Environment.NewLine + "[/list]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[list=1]" + Environment.NewLine + "[*]" + Environment.NewLine + "[/list]");
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("[hr]");
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[img]" + text + "[/img]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[img][/img]");
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string text = richTextBox1.SelectedText;
                string newText = "[video=youtube]" + text + "[/video]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[video=youtube][/video]");
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            string text = f4.text;
            string link = f4.link;
            if (text == "" || link == "")
            {

            }
            else
            {
                if (richTextBox1.SelectionLength > 0)
                {
                    string oldText = richTextBox1.SelectedText;
                    string newText = "[url=" + link + "]" + text + "[/url]" + oldText;
                    richTextBox1.SelectedText = newText;
                }
                else
                {
                    richTextBox1.AppendText("[url=" + link + "]" + text + "[/url]");
                }
            }
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string oldText = richTextBox1.SelectedText;
                string newText = "[code]" + Environment.NewLine + oldText + Environment.NewLine + "[/code]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[code]" + Environment.NewLine + "[/code]");
            }
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string oldText = richTextBox1.SelectedText;
                string newText = "[php]" + Environment.NewLine + oldText + Environment.NewLine + "[/php]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[php]" + Environment.NewLine + "[/php]");
            }
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                string oldText = richTextBox1.SelectedText;
                string newText = "[quote]" + Environment.NewLine + oldText + Environment.NewLine + "[/quote]";
                richTextBox1.SelectedText = newText;
            }
            else
            {
                richTextBox1.AppendText("[quote]" + Environment.NewLine + "[/quote]");
            }
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            string alltext = richTextBox1.Text;
            Clipboard.SetText(alltext);
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                f5.Show();
            }
            else
            {

            }
            //System.Diagnostics.Process.Start("http://www.realforums.org/newthread.php?fid=112");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (lp_on.Checked)
            {
                f5.on = true;
                f5.fuckme = richTextBox1.Text;
            }
            else
            {
                f5.on = false;
            }
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Document|*.txt";
            saveFileDialog1.Title = "Save BB Code to File";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
                for (int i = 0; i < richTextBox1.Lines.Count(); i++)
                {
                    writer.WriteLine(richTextBox1.Lines[i]);
                }
                writer.Dispose();
                writer.Close();
            }

        }

        private void materialRaisedButton13_Click(object sender, EventArgs e)
        {
            f7.ShowDialog();
            if (f7.preset == null)
            {

            }
            else
            {
                string[] test = f7.preset.Split(new[] { " + Enviornment.NewLine + " }, StringSplitOptions.None);
                for (int i = 0, n = test.Length; i < n; i++)
                {
                    richTextBox1.AppendText(test[i] + Environment.NewLine);
                }
            }
        }
    }
}
