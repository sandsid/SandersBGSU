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

namespace LINQ_to_XML
{
    public partial class Form1 : Form
    {
        // TODO: add private data member Element
        private XElement xelement;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRawXML_Click(object sender, EventArgs e)
        {
            
            var employees = xelement.Elements();

            lstDisplay.Items.Clear();

            // TODO: add elements to the list box
            foreach (var x in employees) 
            {
                lstDisplay.Items.Add(x); 
            }
        }

        private void btnFemales_Click(object sender, EventArgs e)
        {
            var females = from nm in xelement.Elements("Employee")
                      where(string)nm.Element("Sex") == "Female"
                      select nm;

            lstDisplay.Items.Clear();
            foreach (var x in females.Descendants("Name"))
            {
                lstDisplay.Items.Add(x);
                lstDisplay.Items.Add(x.Value);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: xelement = ???
            xelement = XElement.Load("employees.xml");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // TODO: show elements with city of Alta
            var addresses = from ad in xelement.Elements("Employee")
                            where(string)ad.Element("Address").Element("City") == "Alta"
                            select ad;

            lstDisplay.Items.Clear(); 
            foreach (var x in addresses.Descendants("City")) 
            {
                lstDisplay.Items.Add(x.Value); 
            }
        }

        private void cmtHome_Click(object sender, EventArgs e)
        {
            // TODO: show all home phone numbers
            var homePhone = from ph in xelement.Elements("Employee")
                            where (string)ph.Element("Phone").Attribute("Type") == "Home"
                            select ph;
            lstDisplay.Items.Clear();
            foreach (var x in homePhone)
            {
                lstDisplay.Items.Add(x.Element("Phone").Value);
            }
        }
    }
}
