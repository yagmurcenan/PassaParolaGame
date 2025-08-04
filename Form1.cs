using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassaParola
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

        private void button23_Click(object sender, EventArgs e)
        {
            if (soruno == 22)
            {
                button23.Text = "Oyun Sonu";
            }
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                switch(soruno)
                {
                case 1: if(textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                            break;



                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                        }
                        break;
                    
                    case 3:
                        if (textBox1.Text == "ceviz")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;


                    case 4:
                        if (textBox1.Text == "domuz")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text == "emzik")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text == "fesleğen")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text == "görümce")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text == "horoz")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text == "irmik")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text == "kalem")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text == "leylek")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;


                    case 12:
                        if (textBox1.Text == "mayonez")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text == "nil")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text == "osman")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text == "pazartesi")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text == "ramazan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text == "saksı")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text == "tam")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text == "uslu")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text == "van")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text == "yağmur")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;

                    case 22:
                        if (textBox1.Text == "zelzele")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label2.Text = dogru.ToString();

                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label4.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;

            this.Text = soruno.ToString();

            if(soruno== 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Pink;
            }
            if(soruno == 2)
            {
                richTextBox1.Text = "İskenderi ile ünlü olan ilimiz?";
                button2.BackColor = Color.Pink;
            }
            if(soruno ==3)
            {
                richTextBox1.Text = "Dışı sert kabukla çevrili olan yemiş? ";
                button3.BackColor = Color.Pink;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Müslüman dininde tüketilmesi günah olan hayvan? ";
                button4.BackColor = Color.Pink;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Bebeklere ağladığında verilen eşya?";
                button5.BackColor = Color.Pink;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Reyhanın diğer ismi? ";
                button6.BackColor = Color.Pink;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Gelinin eşinin kız kardeşi gelinin neyi olur?";
                button7.BackColor = Color.Pink;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Tavuğun erkek hali nedir?";
                button8.BackColor = Color.Pink;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Sert durum buğdayının öğütülmesiyle elde edilen besin?";
                button9.BackColor = Color.Pink;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Yazmak için kullanılan araç:";
                button10.BackColor = Color.Pink;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Marteniçkayı çıkarmak için hangi hayvanı görmemiz gerekir?";
                button11.BackColor = Color.Pink;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Yumurtanın beyazı ile elde edilen bir sos:";
                button12.BackColor = Color.Pink;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Bir nehir ismi:";
                button13.BackColor = Color.Pink;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Osmanlı devletini kuran kişinin ismi?";
                button14.BackColor = Color.Pink;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Haftanın ilk günü nedir?";
                button15.BackColor = Color.Pink;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Oruç hangi bayram geldiğinde tutulur?";
                button16.BackColor = Color.Pink;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çiçeği dikmek için kullandığımız eşya:";
                button17.BackColor = Color.Pink;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Bütün anlamına gelen kelime:";
                button18.BackColor = Color.Pink;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "Akıllı anlamına gelen kelime";
                button19.BackColor = Color.Pink;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Kedisiyle ünlü ilimiz";
                button20.BackColor = Color.Pink;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Sıvı su damlaları şeklindeki yağış:";
                button21.BackColor = Color.Pink;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Deprem kelimesinin eş anlamlısı?";
                button22.BackColor = Color.Pink;
            }

        }
    }
}
