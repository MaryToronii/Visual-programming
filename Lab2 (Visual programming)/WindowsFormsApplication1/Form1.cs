using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [Serializable]
        public struct data
        {
            public double a;
            public double b;
            public double points;
            public int type;
            public double tStart;
            public double tEnd;
        }
        public Form1()
        {
            InitializeComponent();
            
        }

        data _data = new data() ;
        string name;

        private double xFromt(double t) {
            
            double res = Math.Pow(t, 2) / (1 - Math.Pow(t, 2));
            return res;
        }

        private double yFromt(double t)
        {
            double res = t / ( Math.Pow(t, 2) - 1);
            return res;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //  data _data = new data();
            _data.a = Convert.ToDouble(aField.Text);
            _data.b = Convert.ToDouble(bField.Text);
            _data.points = Convert.ToDouble(pointsField.Text);
            
           

            CheckBox[] checkList = new[] { checkExp, yFromX, xFromY, yFromT, xFromT};

            for (int i = 0; i < 5; i++)
                if (checkList[i].Checked) _data.type = i;

            if (_data.type > 0) {
                _data.tStart = Convert.ToDouble(tS.Text);
                _data.tEnd = Convert.ToDouble(tE.Text);
            }

            chartBuilding(_data);
        }

        private void checkParam_CheckedChanged(object sender, EventArgs e)
        { 
            checkExp.Checked = false;
            panel2.Visible = true;
        }

        private void checkExp_CheckedChanged(object sender, EventArgs e)
        {
            checkParam.Checked = false;
            panel2.Visible = false;
        }

        private double explicity(double x) {
            double res = Math.Pow(x, 2) * Math.Sin(1 / x);
            return res;
        }

        private void chartBuilding(data date) {
            
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.Minimum = date.a;
            objChart.AxisX.Maximum = date.b;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            var xy = new List<Revenue>();
            revenueBindingSource.DataSource = xy;
            double _max = double.MinValue, _min = double.MaxValue;
            double x = date.a, y = 0, vr = date.tStart, h = Math.Round((date.tStart-date.tEnd)/date.points, 5);
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            switch (date.type)
            {
                case 0 :
                    for (int i = 0; i <= date.points; i++) {
                        vr = Math.Pow(x, 2) * Math.Sin(1.0 / x);
                        y = Math.Round(vr, 3);
                        xy.Add(new Revenue(x, y));
                        chart1.Series[0].Points.AddXY(x, y);
                        if (y > _max) _max = y;
                        if (y < _min) _min = y;
                        x = x + (date.b - date.a) / date.points;
                    } break;

                case 1:
                    for (int i = 0; i <= date.points; i++)
                    {
                        if (i>0)
                        vr = Math.Round( vr + (date.tEnd - date.tStart) / date.points, 6);
                        if (1 - Math.Pow(vr, 2) == 0.00) continue;
                     
                        y = Math.Sqrt(vr*vr+vr);
                        //if (vr >= -1 && vr <= 0) y = 0;
                        double y1 = -Math.Sqrt(vr * vr + vr);
                        Console.WriteLine(i + "   " + vr + "   " + x + "    " + y);
                        if(vr >= date.a || vr <= date.b) { 
                        xy.Add(new Revenue(vr, y));
                        chart1.Series[0].Points.AddXY(vr, y);
                        if (y > _max) _max = y;
                        if (y < _min) _min = y;

                            xy.Add(new Revenue(vr, y));
                            chart1.Series[1].Points.AddXY(vr, y1);
                            if (y > _max) _max = y;
                            if (y < _min) _min = y;

                            
                        }


                    }  break;

                case 2 :
                    for (int i = 0; i <= date.points; i++)
                    {
                        if (i > 0)
                            vr = Math.Round(vr + (date.tEnd - date.tStart) / date.points, 6);
                        if (1 - Math.Pow(vr, 2) == 0.00) continue;

                        y = ( Math.Sqrt(4 * vr * vr + 1) + 1) / 2;
                        //if (vr >= -1 && vr <= 0) y = 0;
                        double y1 = -y;
                        Console.WriteLine(i + "   " + vr + "   " + x + "    " + y);
                        if (vr >= date.a || vr <= date.b)
                        {
                            xy.Add(new Revenue(vr, y));
                            chart1.Series[0].Points.AddXY(vr, y);
                            if (y > _max) _max = y;
                            if (y < _min) _min = y;

                            xy.Add(new Revenue(vr, y));
                            chart1.Series[1].Points.AddXY(vr, y1);
                        
                            if (y > _max) _max = y;
                            if (y < _min) _min = y;
                            
                        }


                    }
                    break;

                case 3:
                    for (int i = 0; i <= date.points; i++)
                    {
                        vr = Math.Round(vr + (date.tEnd - date.tStart) / date.points, 6);
                        x = Math.Round(vr, 4);
                        if (Math.Pow(x, 2) - 1 == 0.00) continue;
                        y = Math.Round(yFromt(x), 4);
                        Console.WriteLine(i + "   " + vr + "   " + x + "    " + y);
                        if (x >= date.a || x <= date.b)
                        {
                            xy.Add(new Revenue(x, y));
                            chart1.Series[0].Points.AddXY(x, y);
                            if (y > _max) _max = y;
                            if (y < _min) _min = y;
                        }

                    }
                    break;

                case 4:
                    for (int i = 0; i <= date.points; i++)
                    {
                        vr = Math.Round(vr + (date.tEnd - date.tStart) / date.points, 6);
                        x = Math.Round(vr, 4);
                        if (Math.Pow(x, 2) - 1 == 0.00) continue;
                        y = Math.Round(xFromt(x), 4);
                        Console.WriteLine(i + "   " + vr + "   " + x + "    " + y);
                        if (x >= date.a || x <= date.b)
                        {
                            xy.Add(new Revenue(x, y));
                            chart1.Series[0].Points.AddXY(x, y);
                            if (y > _max) _max = y;
                            if (y < _min) _min = y;
                        }

                    }
                    break;

            }
            dataGridView1.DataSource = xy;
            max.Text = Math.Round(_max, 3).ToString();
            min.Text = Math.Round(_min, 3).ToString();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (Stream file = ofd.OpenFile())
                {
                    var reader = new BinaryFormatter();
                    _data = (data)reader.Deserialize(file);

                }
                chartBuilding(_data);
            }


        }

       

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CreatePrompt = true;
            sfd.OverwritePrompt = true;
            sfd.DefaultExt = "bin";
            sfd.InitialDirectory = "C:\\Users\\j\\Documents\\Visual Studio 2015\\Projects\\WindowsFormsApplication1\\files";
            DialogResult result = sfd.ShowDialog();
            if(result == DialogResult.OK) { 
            using (Stream file = sfd.OpenFile())
            {
                var writer = new BinaryFormatter();
                writer.Serialize(file, _data);
                  
            }
            }
        }

       
    }
}
