using System;
using System.Windows.Forms;

namespace veri_biçimlendirme_algoritması
{                                              // started by Fatih Işılgan
                                               
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "biçimlendirici";
            ShowIcon = false;
            MaximumSize = Size;
            MaximizeBox = false;
            listBox1.Text = "";

            panel1.Visible = false;
            verisayısı.Enabled = true;

            verisayısı.Interval = 1;

        }

        private void button1_Click(object sender, EventArgs e)//biçimlendir //formating
        {
            try
            {
              
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   string liste ="";
                if (radioButton1.Checked == true)//virgülle sırala //sort by comma
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (i != listBox1.Items.Count-1)
                        {
                            liste += listBox1.Items[i].ToString().ToString() + ",";
                        }
                        else
                        {
                            liste += listBox1.Items[i].ToString().ToString();
                        }
                    }
                    textBox1.Text = liste;// show new format

                    MessageBox.Show("biçimlendirildi");
                }
                else if(radioButton2.Checked==true)//string için c#  dizisi dönüştürücü //make c# array for string
                {
                    liste += "string [] dizi={";
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (i != listBox1.Items.Count - 1)
                        {
                            liste += @""""+ listBox1.Items[i].ToString().ToString() + @""""  + ","; 
                        }
                        else
                        {
                            liste +=  @"""" + listBox1.Items[i].ToString().ToString()+@""""  + "}";
                        }
                    }
                    textBox1.Text = liste;// show new format

                    MessageBox.Show("biçimlendirildi");


                }
                else if (radioButton3.Checked == true)//int için c#  dizisi dönüştürücü //make c# array for int
                {
                    liste += "int [] dizi={";

                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (i != listBox1.Items.Count - 1)
                        {
                            liste +=   listBox1.Items[i].ToString().ToString()  + ",";
                        }
                        else
                        {
                            liste +=  listBox1.Items[i].ToString().ToString()  + "}";
                        }
                    }
                    textBox1.Text = liste;// show new format

                    MessageBox.Show("biçimlendirildi");
                  
                }
                else
                {
                    MessageBox.Show("bir biçimlendirme yöntemi seçiniz");// if  user dont choose for formating method 
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)//tamam //ok
        {
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)//ekle butonu //add button
        {
            for(int i = 0; i < textBox2.Lines.Length; i++)
            {
                if (textBox2.Lines[i].ToString() != "")
                {
                    listBox1.Items.Add(textBox2.Lines[i].ToString());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)//veri ekle //add data
        {
            panel1.Visible = true;
        }

        private void verisayısı_Tick(object sender, EventArgs e)
        {
            Text = "veri sayısı:"+listBox1.Items.Count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)//sil
        {
            try
            {
                if (listBox1.SelectedIndex>-1)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)//hepsini sil// clear all
        {
            try
            {
                listBox1.Items.Clear();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }
    }
}
