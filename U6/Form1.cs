using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        double radie;
        public void button1_Click(object sender, EventArgs e)
        {
            bool ok = double.TryParse(textBox1.Text, out radie);
            if (ok)
            {
                string ans = "";
                double area = BeräknaArea(radie);
                double omkrets = BeräknaOmkrets(radie);
                SkrivUtResultat(area.ToString(), omkrets.ToString(), ans);
            }
            else
            {
                label1.Text = "fel";
            }
        }
        private double BeräknaArea(double a)
        {
            a = radie * radie * 3.14159265359;
            return a;
        }
        private double BeräknaOmkrets(double o)
        {
            o = radie * 2 * 3.14159265359;
            return o;
        }

        private string SkrivUtResultat(string area, string omkrets, string ans)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                label1.Text = $"{area.ToString()} area {omkrets.ToString()} omkrets";
                ans = label1.Text;
            }
            if (checkBox1.Checked == true && checkBox2.Checked == false)
            {
                label1.Text = $"{area.ToString()} area";
                ans = label1.Text;
            }
            if (checkBox1.Checked == false && checkBox2.Checked == true)
            {
                label1.Text = $"{omkrets.ToString()} omkrets";
                ans = label1.Text;
            }
            return ans;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label1.Text = "tryck på visa";
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label1.Text = "tryck på visa";
            }
        }
    }
}