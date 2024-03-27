using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (chipperRadio.Checked)
            {
                string encyrpted = "";
                bool status = false;
                int code = 1;
                TextBox textBox = (TextBox)this.Controls.Find("newTextBox", true).FirstOrDefault();
                if (textBox.Text != "")
                {
                    try
                    {
                        code = Int32.Parse(textBox.Text);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Please enter a number");
                        return;
                    }
                }

                Encrypt.Encipher(textBox1.Text.ToCharArray(), code, out status, successLabel, ref encyrpted);
                if (status)
                {
                    successLabel.BackColor = Color.Green;
                    resultLabel.Text = "Chipper : " + encyrpted;
                }
                else
                {
                    successLabel.BackColor = System.Drawing.Color.Red;
                    resultLabel.Text = "Please enter more than 2 characters";
                }
                Task.Delay(2000).Wait();
                successLabel.Text = "";
                successLabel.BackColor = Color.Transparent;
            }
            else if (rot2RadioButton.Checked)
            {
                string exnrpyted = Encrypt.Rot2(textBox1.Text);
                successLabel.Text = "Success";
                successLabel.BackColor = Color.Green;   
                resultLabel.Text = " ROT2 : " + exnrpyted;
                Task.Delay(2000).Wait();
                successLabel.Text = "";
                successLabel.BackColor = Color.Transparent;
            }
        }

        private void chipperRadio_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name == "newTextBoxNameLabel" || item.Name == "newTextBox")
                {
                    return;
                }
            }
            TextBox newTextBox = new TextBox();
            Label newTextBoxNameLabel = new Label();

            newTextBoxNameLabel.Name = "newTextBoxNameLabel";
            newTextBox.Name = "newTextBox";

            newTextBoxNameLabel.Text = "Chiper Code : ";
            
            newTextBox.Location = new Point(textBox1.Location.X, textBox1.Location.Y + 50);
            newTextBoxNameLabel.Location = new Point(textBox1.Location.X, newTextBox.Location.Y - 15);

            this.Controls.Add(newTextBox);
            this.Controls.Add(newTextBoxNameLabel);
            foreach (Control item in this.Controls)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n\n");
        }

        private void rot2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!chipperRadio.Checked)
            {
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Console.WriteLine(this.Controls[i].Name);
                    if (this.Controls[i].Name[0] == 'n')
                    {
                        this.Controls.RemoveAt(i);
                        break;
                    }
                }
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    Console.WriteLine(this.Controls[i].Name);
                    if (this.Controls[i].Name[0] == 'n')
                    {
                        this.Controls.RemoveAt(i);
                        break;
                    }
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
