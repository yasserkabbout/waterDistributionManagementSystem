﻿using System;
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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            XDocument waterxml = XDocument.Load("waterrequests.xml");
            var users = from usr in waterxml.Descendants("record")
                        where usr.Element("date").Value == dateTimePicker1.Value.ToShortDateString()
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
    }
}
