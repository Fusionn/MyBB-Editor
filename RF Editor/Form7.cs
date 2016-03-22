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
using System.Xml;
using System.Xml.Linq;

namespace RF_Editor
{
    public partial class Form7 : MaterialForm
    {
        MaterialSkinManager materialSkinManager;
        public string preset;
        string xmlPath = "templates.xml";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.rf1, Primary.rf2, Primary.rf1, Accent.rf1, TextShade.WHITE);
            materialListView1.Items.Clear();
            XDocument doc = XDocument.Load(xmlPath);

            foreach (var dm in doc.Descendants("template"))
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    dm.Element("name").Value,
                    dm.Element("desc").Value,
                    dm.Element("temp").Value
                });
                materialListView1.Items.Add(item);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            preset = materialListView1.SelectedItems[0].SubItems[2].Text;
            Console.WriteLine(preset);
            this.Hide();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            XDocument xDocument = XDocument.Load(xmlPath);
            XElement root = xDocument.Element("templates");
            IEnumerable<XElement> rows = root.Descendants("template");
            XElement firstRow = rows.First();
            firstRow.AddBeforeSelf(
               new XElement("template",
               new XElement("name", f8.name),
               new XElement("desc", f8.desc),
               new XElement("temp", f8.temp)));
            xDocument.Save(xmlPath);
        }
    }
}
