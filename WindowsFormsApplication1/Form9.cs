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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        string mob;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count != 0) // to prevent getting error on selecting different item!
            {
                XDocument waterxml = XDocument.Load("waterrequests.xml");
                
                mob = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
                XElement element = waterxml.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
                textBox1.Text = element.Element("name").Value;
                textBox2.Text = element.Element("surname").Value;
                textBox3.Text = element.Element("mobile").Value;
                textBox4.Text = element.Element("address").Value;
            }
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
        private void Form9_Activated(object sender, EventArgs e)
        {
            loadWaterData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToShortDateString();

            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                XDocument xmlDoc = XDocument.Load("waterrequests.xml");
                XElement element = xmlDoc.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
                if (element != null)
                {
                    element.SetElementValue("name", textBox1.Text);
                    element.SetElementValue("surname", textBox2.Text);
                    element.SetElementValue("mobile", textBox3.Text);
                    element.SetElementValue("address", textBox4.Text);
                    element.SetElementValue("date", date);
                }
                xmlDoc.Save("waterrequests.xml");
                loadWaterData();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
                MessageBox.Show("It can't be Empty!");
        }

        
    }
}
