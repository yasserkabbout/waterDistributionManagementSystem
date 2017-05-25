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


    public partial class Form3 : Form
    {
        public Form1 frm1;

        public void loadDataAll()
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
                            Request = usr.Element("requests").Element("date").Value,



                        };


            foreach (var us in users)
            {
                ListViewItem lv = new ListViewItem(us.Name);
                lv.SubItems.Add(us.Surname);
                lv.SubItems.Add(us.Mobile);
                lv.SubItems.Add(us.Address);
                lv.SubItems.Add(us.Request);


                listView1.Items.Add(lv);

            }
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
        public Form3()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           
        }

       

        private void Form3_Activated(object sender, EventArgs e)
        {
            loadData();
        }
        string mob;
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices[0] != -1)
            {
                XDocument xmlDoc = XDocument.Load("Clients.xml");
                mob = listView1.Items[listView1.SelectedIndices[0]].SubItems[2].Text;
                XElement element = xmlDoc.Root.Elements("record").Where(r => (string)r.Element("mobile") == mob).FirstOrDefault();
                if (element != null)
                {
                    element.Remove();
                    xmlDoc.Save("Clients.xml");
                    MessageBox.Show("Record has been Removed!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Selected Record do not Exists!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
