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
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        passengers pass = null;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.CurrentCell = null;
            string valid = Validate();
            if (valid.Length == 0)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(passengers));
                using (FileStream fileStream = new FileStream("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab5\\Lab5\\AirPassenger.xml", FileMode.Open, FileAccess.Read))
                {
                    pass = xmlSerializer.Deserialize(fileStream) as passengers;
                    bindingSource1.DataSource = pass.passenger;
                }
            }
            else MessageBox.Show(valid);
            
            
           

         
        }
        bool a = true;
        public string Validate()
        {
            
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas.Add(null, XmlReader.Create("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab5\\Lab5\\AirPassenger.xsd"));
            XmlReader xmlReader = XmlReader.Create("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab5\\Lab5\\AirPassenger.xml", settings);
            try {
               
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(xmlReader);
                xmlReader.Close();
                return string.Empty;
            }
            catch (Exception e){
                xmlReader.Close();
                a = false;
                return e.Message;
            }
           

        }
      

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (a)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(passengers));
                using (FileStream fileStream = new FileStream("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab5\\Lab5\\AirPassenger.xml", FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fileStream, pass);
                }
            }
            else a = true;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0) button1.Enabled = true;
            else
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
               // dataGridView1.Columns[6].Visible = false; dataGridView1.Columns[7].Visible = false;

                for (int i = 0; i < pass.passenger.Count; i++)
                {


                    if (pass.passenger[i].weight_1 > Convert.ToInt32(textBox1.Text)) dataGridView1.Rows[i].Visible = true;
                    else if (pass.passenger[i].weight_2 > Convert.ToInt32(textBox1.Text)) dataGridView1.Rows[i].Visible = true;
                    else if (pass.passenger[i].weight_3 > Convert.ToInt32(textBox1.Text)) dataGridView1.Rows[i].Visible = true;
                    else dataGridView1.Rows[i].Visible = false;


                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pass.passenger.Count; i++)
            {


                dataGridView1.Rows[i].Visible = true;
            }
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = true;
            dataGridView1.Columns[6].Visible = true; 
            dataGridView1.Columns[7].Visible = true;
        }
    }
}
