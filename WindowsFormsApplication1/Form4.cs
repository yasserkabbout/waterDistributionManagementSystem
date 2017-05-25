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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            listView1.Items.Clear();
            XDocument clientsxml = XDocument.Load("Clients.xml");
            var users = from usr in clientsxml.Descendants("record")
                        select new
                        {
                            Name = usr.Element("name").Value,
                            Surname = usr.Element("surname").Value,
                            Mobile = usr.Element("mobile").Value,
                            Address = usr.Element("address").Value,

                        };


            foreach (var us in users)
            {
                ListViewItem lv = new ListViewItem(us.Name);
                lv.SubItems.Add(us.Surname);
                lv.SubItems.Add(us.Mobile);
                lv.SubItems.Add(us.Address);

                listView1.Items.Add(lv);

            }

        }

        private void Form4_Activated(object sender, EventArgs e)
        {
            loadData();
        }

        string mob;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0) // to prevent getting error on selecting different item!
            {
                XDocument xmlDoc = XDocument.Load("Clients.xml");
                //XElement element = xmlDoc.Root.Elements("record").Skip(listView1.SelectedIndices[0]).FirstOrDefault();
                mob = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
                XElement element = xmlDoc.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
                textBox1.Text = element.Element("name").Value;
                textBox2.Text = element.Element("surname").Value;
                textBox3.Text = element.Element("mobile").Value;
                textBox4.Text = element.Element("address").Value;
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            XDocument xmlDoc = XDocument.Load("Clients.xml");
            XElement element = xmlDoc.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
            if (element != null)
            {
                element.SetElementValue("name", textBox1.Text);
                element.SetElementValue("surname", textBox2.Text);
                element.SetElementValue("mobile", textBox3.Text);
                element.SetElementValue("address", textBox4.Text);
            }
            xmlDoc.Save("Clients.xml");
            loadData();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
