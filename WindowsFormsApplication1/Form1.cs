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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 addclient = new Form2();
            addclient.frm1 = this;
            addclient.ShowDialog();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           
        }


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
        private void Form1_Activated(object sender, EventArgs e)
        {
           
            loadData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeAClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.ShowDialog();
        }

        private void updateAClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();

        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void bySurnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.ShowDialog();
        }

        private void addANewRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.ShowDialog();
        }

        private void showAllRequestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.ShowDialog();
        }

        private void updateARequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.ShowDialog();


        }

        private void cancelARequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.ShowDialog();
        }

        private void listAllRequestsByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.ShowDialog();
        }

        private void contactUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.ShowDialog();
        }

       
    }
}
