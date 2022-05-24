using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_O
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int day;

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            day = Convert.ToInt32(textBox1.Text);
        }
    }
}
