using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oop_Exp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int[] ary1 = new int[] { 1, 1 };
            textBox2.Text = "";
            try
            {
                int n = Int32.Parse(textBox1.Text);
                if (n < 1)
                {
                    textBox2.Text = " Value can not be smaller than 1.";
                    return;
                }else if (n < 3)
                {
                    if (n == 1)
                    {
                        textBox2.Text = "1";
                        return;
                    }
                    else
                    {
                        textBox2.Text = "1, 1";
                        return;
                    }
                }
                int start1 = 1;
                int start2 = 1;
                Array.Resize<int>(ref ary1, n );
                ary1[0] = start1;
                ary1[1] = start2;
                int i = 2;
                if (n > 50)
                {
                    textBox2.Text = "Write a number smaller than 50.";
                    return;
                }
                while(i < n)
                {
                    int newvalue = start1 + start2;
                    start1 = start2;
                    start2 = newvalue;
                    ary1[i] = newvalue;
                    i++;
                }
                foreach (var item in ary1)
                {
                    textBox2.Text += item.ToString()+ "\r\n";
                }
                if(checkBox1.Checked)
                {
                    double avarage=0;
                    foreach (var item in ary1)
                    {
                        avarage +=item;
                    }
                    avarage /= n;
                    label2.Text = "Avarage: " + avarage.ToString();
                }
            }
            catch (Exception ex)
            {
                textBox2.Text= ex.Message;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                button1.Text = "GENERATE AND CALCULATE";
            }
            else
            {
                button1.Text = "GENERATE";
            }
        }
    }
}
