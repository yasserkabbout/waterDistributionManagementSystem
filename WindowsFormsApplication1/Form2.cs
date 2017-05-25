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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( textBox1.Text != "" && textBox2.Text!="" && textBox3.Text!="" && textBox4.Text!="")
            {
                XElement usr = XElement.Load(@"Clients.xml");

                XElement nusr = new XElement("record",
                    new XElement("name", textBox1.Text),
                    new XElement("surname", textBox2.Text),
                    new XElement("mobile", textBox3.Text),
                    new XElement("address", textBox4.Text),
                    new XElement("requests",
                        new XElement("date", "")
                        )
                    );

                usr.Add(nusr);
                usr.Save("Clients.xml");


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                Close();
            }

            else
                MessageBox.Show("it can't be empty!");
        }
    }
}
