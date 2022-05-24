using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Linq;
using System.IO;


namespace Lab1_Visual_programming_
{
    public partial class Form1 : Form
    {
        private double _r;
        private double _h;
        private Control activeField = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ReadSettings();

        }

         

        private void ReadSettings()
        {
            XDocument xDocument = XDocument.Load("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab1(Visual programming)\\Lab1(Visual programming)\\config.xml");
           
            Location = new Point {
                X = (int)xDocument.Root.Element("Location").Element("X"),
                Y = (int)xDocument.Root.Element("Location").Element("Y")
        };

           
            Size = new Size
            {
                Width = (int)xDocument.Root.Element("Size").Element("X"),
                Height = (int)xDocument.Root.Element("Size").Element("Y")
            };

            Volume.Text = (string)xDocument.Root.Element("Values").Element("V");
            lSquare.Text = (string)xDocument.Root.Element("Values").Element("IS");
            fSquare.Text = (string)xDocument.Root.Element("Values").Element("FS");
            radius_field.Text = (string)xDocument.Root.Element("Values").Element("R");
            height_field.Text = (string)xDocument.Root.Element("Values").Element("H");
        }

      
        private void CloseSettings()
        {
            XDocument xDocument = XDocument.Load("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab1(Visual programming)\\Lab1(Visual programming)\\config.xml");
            xDocument.Root.Element("Location").Element("X").SetValue(Location.X);
            xDocument.Root.Element("Location").Element("Y").SetValue(Location.Y);
            xDocument.Root.Element("Size").Element("X").SetValue(Size.Width);
            xDocument.Root.Element("Size").Element("X").SetValue(Size.Height);
            xDocument.Root.Element("Values").Element("R").SetValue(radius_field.Text);
            xDocument.Root.Element("Values").Element("H").SetValue(height_field.Text);
            xDocument.Root.Element("Values").Element("V").SetValue(Volume.Text);
            xDocument.Root.Element("Values").Element("IS").SetValue(lSquare.Text);
            xDocument.Root.Element("Values").Element("FS").SetValue(fSquare.Text);
            xDocument.Save("C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\Lab1(Visual programming)\\Lab1(Visual programming)\\config.xml");
        }

        private void cone_button_Click(object sender, EventArgs e)
        {
            if (convert()) cone(_r, _h);
            else
            {
                Volume.Text = "ERROR!";
                lSquare.Text = "Input is incorrect";
                fSquare.Text = "Try again";
            }

           
        }

        private void pyramid_button_Click(object sender, EventArgs e)
        {
            if (convert()) pyramid(_r, _h);
            else
            {
                Volume.Text = "ERROR!";
                lSquare.Text = "Input is incorrect";
                fSquare.Text = "Try again";
            }
        }

        private void cylinder_button_Click(object sender, EventArgs e)
        {
            convert();
            if (convert()) cylinder(_r, _h);
            else
            {
                Volume.Text = "ERROR!";
                lSquare.Text = "Input is incorrect";
                fSquare.Text = "Try again";
            }
        }

        private bool check(string r, string h)
        {
            if (String.IsNullOrEmpty(r) || String.IsNullOrEmpty(h)) return false;
            if( r[0] == ',' || h[0] == ',' || r == "0" || h == "0") return false;
            for (int i = 0; i < r.Length; i++)
            {
                if (!Char.IsDigit(r[i]) && r[i] != ',') return false;
            }

            for (int i = 0; i < h.Length; i++)
            {
                if (!Char.IsDigit(h[i]) && h[i] != ',') return false;
            }
            return true;
        }


        private bool convert()
        {
            String r = radius_field.Text;
            String h = height_field.Text;
            if (check(r, h))
            {
                _r = Convert.ToDouble(r);
                _h = Convert.ToDouble(h);
                return true;
            }
            else return false;

        }

    
        private void pyramid(double r, double h)
        {
            double v = (1 / 3.0) * 4 * Math.Pow(r, 2) * h;
            double l = Math.Pow(r, 2) + Math.Pow(h, 2);
            double ls = 4 * r * Math.Pow(l, 1 / 2.0);
            double fs = ls + 4 * Math.Pow(r, 2);
            Volume.Text = Math.Round(v, 4).ToString();
            lSquare.Text = Math.Round(ls, 4).ToString();
            fSquare.Text = Math.Round(fs, 4).ToString();
        }

        private void cone(double r, double h)
        {
            double v = (1 / 3.0) * Math.PI * Math.Pow(r, 2) * h;
            double l = Math.Pow(r, 2) + Math.Pow(h, 2);
            double ls = Math.PI * r * Math.Pow(l, 1 / 2.0);
            double fs = ls + Math.PI * Math.Pow(r, 2);
            Volume.Text = Math.Round(v, 4).ToString();
            lSquare.Text = Math.Round(ls, 4).ToString();
            fSquare.Text = Math.Round(fs, 4).ToString();
        }

        private void cylinder(double r, double h)
        {
            double v = Math.PI * Math.Pow(r, 2) * h;
            double ls = 2 * Math.PI * r * h;
            double fs = ls + 2 * Math.PI * Math.Pow(r, 2);
            Volume.Text = Math.Round(v, 4).ToString();
            lSquare.Text = Math.Round(ls, 4).ToString();
            fSquare.Text = Math.Round(fs, 4).ToString();

        }

  
        // active field choise
        private void radius_field_MouseUp(object sender, MouseEventArgs e)
        {
            activeField = radius_field;
        }
        private void height_field_MouseUp(object sender, MouseEventArgs e)
        {
            activeField = height_field;
        }

        //virtual keyboard
        private void button_1_Click(object sender, EventArgs e)
        {
            activeField.Text += "1";
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            activeField.Text += "2";
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            activeField.Text += "3";
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            activeField.Text += "4";
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            activeField.Text += "5";
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            activeField.Text += "6";
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            activeField.Text += "7";
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            activeField.Text += "8";
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            activeField.Text += "9";
        }

        private void mini_clean_Click(object sender, EventArgs e)
        {
            activeField.Text = activeField.Text.Substring(0, activeField.Text.Length - 1);
        }

        private void clean_Click(object sender, EventArgs e)
        {
            activeField.Text = null;
        }

     

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseSettings();
            
        }
    }
}
