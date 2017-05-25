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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Total=0;
            listView1.Items.Clear();
            XDocument waterxml = XDocument.Load("waterrequests.xml");
            var users = from usr in waterxml.Descendants("record")

                        where ((DateTime.Parse(usr.Element("date").Value) >= monthCalendar1.SelectionRange.Start) && (DateTime.Parse(usr.Element("date").Value) <= monthCalendar1.SelectionRange.End ))

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
            
            Total = int.Parse(listView1.Items.Count.ToString());
            Total *= 2;

          MessageBox.Show("The Total Bill for the selected Month is:  "+ "$"+ Total.ToString());
         
  
        }
    }
}
