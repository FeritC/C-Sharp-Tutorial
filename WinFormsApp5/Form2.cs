using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

namespace Exp6
{
    
    public partial class Form2 : Form
    {

        int wrongCount = 0;

        List<string> words = new List<string> { "paradoks", "kalem", "pencere", "merhaba", "algoritma"};
        List<string> tips = new List<string> {
            "Bir durumun çelişkili veya mantıksız\n görünmesi.",
            "Kağıda yazı yazmak için kullanılan\n bir araç.",
            "Bir odanın dış dünyayla bağlantısını\n sağlayan, genellikle camlı açıklık.",
            "İnsanlar arasında selamlaşmak için\n kullanılan bir kelime.",
            "Belirli bir amaca ulaşmak için tasarlanmış\n prosedürlerin adım adım tanımlanması."
        };

        private string word;
        private int index;
        private List<Label> labelList = new List<Label>();
        public Form2()
        {

            InitializeComponent();

            Random rnd = new Random();
            index = rnd.Next(0, words.Count);
            word = words[index];

            label10.Text = word.Length.ToString();

            int x = 10;
            int y = -10;

            int i = 0;
            foreach (char letter in word)
            {
                Label charLabel = new Label();
                charLabel.Text = " ";
                charLabel.Name = "label" + i.ToString();
                charLabel.Font = new Font("Rockwell", 48);
                charLabel.AutoSize = true;
                charLabel.Font = new Font(charLabel.Font, FontStyle.Bold);
                charLabel.Font = new Font(charLabel.Font, FontStyle.Underline);
                charLabel.Location = new Point(x,y);
                charLabel.Parent = this.panel1;
                charLabel.Visible = true;
                
                x += 90;
                this.panel1.Controls.Add(charLabel);
                i++;
                labelList.Add(charLabel);
            }
            
            Label tipLabel = new Label();
            tipLabel.Text = tips[index];
            tipLabel.Font = new Font("Rockwell", 12);
            tipLabel.AutoSize = true;
            tipLabel.Location = new Point(10, 130);
            tipLabel.Visible = false;
            tipLabel.Name = "tipLabel";
            this.box1.Controls.Add(tipLabel);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
                
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-ZğüşıöçĞÜŞİÖÇ]+$";

            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text[0].ToString();
                return;
            }
            if (!Regex.IsMatch(textBox1.Text, pattern)){ 
                textBox1.Text = "";
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text.ToLower();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 1)
            {
                return;
            }
            
            List<Image> imageList = new List<Image> { Properties.Resources.man_02, Properties.Resources.man_03, Properties.Resources.man_04, Properties.Resources.man_05, Properties.Resources.man_06, Properties.Resources.man_07, Properties.Resources.man_08, Properties.Resources.man_09, Properties.Resources.man_10 };
            if (word.Contains(textBox1.Text[0]))
            {
                List<int> indexes = new List<int>();

                int i = 0;
                foreach (char ch in word)
                {
                    if (ch == textBox1.Text[0])
                    {
                        indexes.Add(i);
                    }
                    i++;
                }
                foreach (int index in indexes)
                {
                    labelList[index].Text = word[index].ToString();
                }
            }
            else
            {
                wrongCount++;
                pointLabel.Text = (int.Parse(pointLabel.Text) - 10).ToString();
                if (wrongLabel.Text.Length> 0)
                {
                    wrongLabel.Text += ", " + textBox1.Text;
                }
                else
                {
                    wrongLabel.Text = textBox1.Text;
                }
                pictureBox1.Image = imageList[wrongCount - 1];
                if (wrongCount == 9)
                {
                    this.BackColor = Color.Red;
                    MessageBox.Show("Oyunu Kaybettiniz!");
                }
            }

            //Check if the word is completed
            bool isCompleted = true;
            foreach (Label label in labelList)
            {
                if (label.Text == " ")
                {
                    isCompleted = false;
                    break;
                }else if (label.Text == "")
                {
                    isCompleted = false;
                    break;
                }
            }
            if (isCompleted)
            {
                this.BackColor = Color.Green;
                MessageBox.Show("Tebrikler, kelimeyi buldunuz!");
            }
            textBox1.Text = "";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun Bitti");
            this.Close();
        }

        private void tipButton_Click(object sender, EventArgs e)
        {
            this.Controls.Find("tipLabel", true)[0].Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
