using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void loadWaterData()
        {
            listView1.Items.Clear();
            XDocument waterxml = XDocument.Load("waterrequests.xml");
            var users = from usr in waterxml.Descendants("record")
                        select new
                        {
                            Name = usr.Element("name").Value,
                            Surname = usr.Element("surname").Value,
                            Mobile = usr.Element("mobile").Value,
                            Address = usr.Element("address").Value,
                            Water = usr.Element("date").Value,

                        };


            foreach (var us in users)
            {
                ListViewItem lv = new ListViewItem(us.Name);
                lv.SubItems.Add(us.Surname);
                lv.SubItems.Add(us.Mobile);
                lv.SubItems.Add(us.Address);
                lv.SubItems.Add(us.Water);

                listView1.Items.Add(lv);

            }

        }
        string mob;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices[0] != -1)
            {
                XDocument waterxml = XDocument.Load("waterrequests.xml");
                mob = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
                XElement element = waterxml.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
                if (element != null)
                {
                    element.Remove();
                    waterxml.Save("waterrequests.xml");
                    MessageBox.Show("Record has been Removed!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadWaterData();
                }
                else
                {
                    MessageBox.Show("Selected Record do not Exists!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void Form10_Activated(object sender, EventArgs e)
        {
            loadWaterData();
        }
    }
}
