using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        List<Panel> arr = new List<Panel>();
        List<Panel> arr1 = new List<Panel>();
        Color color;
        bool figure = false;

        public Form1()
        {
            InitializeComponent();
            arr.Add(s11) ; arr.Add(s12); arr.Add(s13); arr.Add(s14); arr.Add(s21); arr.Add(s22); arr.Add(s23); arr.Add(s24); arr.Add(s31); arr.Add(s32); arr.Add(s33); arr.Add(s34);



        }

        private void Form1_Shown(object sender, EventArgs e)
        {


        }

        private void g1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++) {
                if (table.GetColumn(arr[i]) == 0)
                    arr1.Add(arr[i]);
                }
            int j = 0;
           /* do
            {
                Console.WriteLine(arr1[j].Name);
                j++;
            } while (j < arr1.Count); */
        }

        private void g2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetColumn(arr[i]) == 1)
                    arr1.Add(arr[i]);
            }
        }

        private void g3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetColumn(arr[i]) == 2)
                    arr1.Add(arr[i]);
            }
        }

        private void g4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetColumn(arr[i]) == 3)
                    arr1.Add(arr[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetRow(arr[i]) == 0)
                    arr1.Add(arr[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetRow(arr[i]) == 1)
                    arr1.Add(arr[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (table.GetRow(arr[i]) == 2)
                    arr1.Add(arr[i]);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Results.Text = null;
            for (int i = 0; i < arr1.Count; i++) {
                if (arr1[i].BackColor == color)
                    Results.Text += arr1[i].Name + "\n";
            }
            arr1.Clear();
            figure = false;
            for (int i = 0; i < arr.Count; i++) {
                arr[i].BorderStyle = BorderStyle.None;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            color = radioButton1.ForeColor;
            Console.WriteLine(color);
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            color = radioButton2.ForeColor;
            Console.WriteLine(color);
        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            color = radioButton3.ForeColor;
            Console.WriteLine(color);
        }

        private void FigureButton_Click(object sender, EventArgs e)
        {
            figure = true;
        }

      
        private void s11_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s11.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s11);
            }
        }

        private void s12_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s12.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s12);
            }
        }

        private void s13_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s13.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s13);
            }
        }

        private void s21_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s21.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s21);
            }
        }

        private void s14_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s14.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s14);
            }
        }

        private void s22_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s22.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s22);
            }
        }

        private void s23_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s23.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s23);
            }
        }

        private void s24_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s24.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s24);
            }
        }

        private void s31_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s31.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s31);
            }
        }

        private void s32_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s21.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s32);
            }
        }

        private void s33_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s33.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s33);
            }
        }

        private void s34_Click(object sender, EventArgs e)
        {
            if (figure)
            {
                s34.BorderStyle = BorderStyle.Fixed3D;
                arr1.Add(s34);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            arr1.Add(s11); arr1.Add(s12); arr1.Add(s22); arr1.Add(s23); arr1.Add(s33); arr1.Add(s34);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            arr1.Add(s31); arr1.Add(s32); arr1.Add(s22); arr1.Add(s23); arr1.Add(s13); arr1.Add(s14);
        }
    }
}
