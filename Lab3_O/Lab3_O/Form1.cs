using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab3_O
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            dataGridView1.Columns[7].Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
          
        }
        private string Path; 
        private void button1_Click(object sender, EventArgs e)
        {
            Button A = sender as Button;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
                A.Enabled = true;
            else
            {
                DataRow dataRow = dataTable1.NewRow();
                dataRow["Name"] = textBox1.Text;
                dataRow["Author"] = textBox2.Text;
                dataRow["Publishing house"] = textBox6.Text; ;
                
                dataRow["Number"] = textBox3.Text;
                dataRow["Year of p."] = textBox8.Text;
                dataRow["term"] = textBox5.Text;
                DateTime dateTime = new DateTime(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox7.Text));
                dataRow["Date of issue"] = dateTime.ToString();


                dataTable1.Rows.Add(dataRow);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedindex = e.RowIndex;
            DataRow dataRow = dataTable1.NewRow();
            dataRow = dataTable1.Rows[selectedindex];
            textBox3.Text = Convert.ToString(dataRow[0]);
            textBox2.Text = Convert.ToString(dataRow[1]);
            textBox1.Text = Convert.ToString(dataRow[2]);
            textBox8.Text = Convert.ToString(dataRow[4]);
            textBox6.Text = Convert.ToString(dataRow[3]);
            textBox5.Text = Convert.ToString(dataRow[6]);
            textBox7.Text = Convert.ToString(dataRow[5]).Substring(0, 2);
            textBox4.Text = Convert.ToString(dataRow[5]).Substring(3, 2);
            textBox9.Text = Convert.ToString(dataRow[5]).Substring(6, 4);
            button2.Visible = true;
            button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataTable1.Rows[index]["Number"] = textBox3.Text;
            dataTable1.Rows[index]["Name"] = textBox1.Text;
            dataTable1.Rows[index]["Author"] = textBox2.Text;
            
            dataTable1.Rows[index]["Publishing house"] = textBox6.Text;
            dataTable1.Rows[index]["Year of p."] = textBox8.Text;
            dataTable1.Rows[index]["term"] = textBox5.Text;
            DateTime dateTime = new DateTime(Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox7.Text));
            dataTable1.Rows[index]["Date of issue"] = dateTime.ToString();


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int index = dataGridView1.CurrentCell.RowIndex;
            dataTable1.Rows[index].Delete();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            button2.Visible = false;
            button3.Visible = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.FileOk += Ofd_FileOk;
            ofd.Filter = "tab data|*.data";
            ofd.ShowDialog();
        }

        private void Ofd_FileOk(object sender, CancelEventArgs e)
        {
            Path = (sender as OpenFileDialog).FileName;
            using (FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {

                BinaryFormatter binaryFormatter = new BinaryFormatter();
                DataTable dataTable = binaryFormatter.Deserialize(fileStream) as DataTable;
                dataTable1.Rows.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    dataTable1.ImportRow(item);
                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "tab data|*.data";
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
            saveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (FileStream fileStream = new FileStream((sender as SaveFileDialog).FileName, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                binaryFormatter.Serialize(fileStream, dataTable1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dataTable1.Rows.Count; i++)
                {
                    DateTime dateTime = DateTime.Today;
                    DateTime dateTime1 = new DateTime(Convert.ToInt32(Convert.ToString(dataTable1.Rows[i][5]).Substring(6, 4)), Convert.ToInt32(Convert.ToString(dataTable1.Rows[i][5]).Substring(3, 2)), Convert.ToInt32(Convert.ToString(dataTable1.Rows[i][5]).Substring(0, 2)));
                   
                    int z = (dateTime - dateTime1).Duration().Days;
                    dataTable1.Rows[i][7] = z;
                   

                }
                bindingSource1.Filter = $"Days-term>={form2.day}";

            }
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            button5.Visible = false;

        }
    }
    }

