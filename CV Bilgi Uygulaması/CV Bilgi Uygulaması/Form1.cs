using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV_Bilgi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Tc_No = "", Ad_Soyad = "", Cinsiyet = "", Mezuniyet = "", Diller = "", Uzmanlik = "";
            Tc_No = textBox1.Text;
            Ad_Soyad = textBox2.Text;

            if (radioButton6.Checked==true)
            {
                Cinsiyet = radioButton6.Text;
            }
            else if (radioButton5.Checked == true)
            {
                Cinsiyet = radioButton5.Text;
            }


            if (radioButton1.Checked == true)
            {
                Mezuniyet = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                Mezuniyet = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                Mezuniyet = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                Mezuniyet = radioButton4.Text;
            }


            if (checkBox1.Checked == true)
            {
                Diller = Diller + ", " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                Diller = Diller + ", " +  checkBox2.Text;
            }
            if (checkBox3.Checked == true)
            {
                Diller = Diller + ", " +  checkBox3.Text;
            }
            if (checkBox4.Checked == true)
            {
                Diller = Diller + ", " +  checkBox4.Text;
            }
            if (checkBox5.Checked == true)
            {
                Diller = Diller + ", " +  checkBox5.Text;
            }
            if (checkBox6.Checked == true)
            {
                Diller = Diller + ", " +  checkBox6.Text;
            }
            Diller = Diller.Substring(2);


            if (checkBox7.Checked == true)
            {
                Uzmanlik = Uzmanlik+ ", " + checkBox7.Text;
            }
            if (checkBox8.Checked == true)
            {
                Uzmanlik = Uzmanlik + ", " +  checkBox8.Text;
            }
            if (checkBox9.Checked == true)
            {
                Uzmanlik = Uzmanlik + ", " +  checkBox9.Text;
            }
            if (checkBox10.Checked == true)
            {
                Uzmanlik = Uzmanlik + ", " +  checkBox10.Text;
            }
            if (checkBox11.Checked == true)
            {
                Uzmanlik = Uzmanlik + ", " +  checkBox11.Text;
            }
            if (checkBox12.Checked == true)
            {
                Uzmanlik = Uzmanlik + ", " +  checkBox12.Text;
            }
            Uzmanlik = Uzmanlik.Substring(2);

            listBox1.Items.Add("TC Kimlik No : " + Tc_No + " | " + "Adı Soyadı : " + Ad_Soyad + " | " + "Cinsiyeti : " + Cinsiyet + " | " + "Mezuniyeti : " + Mezuniyet + " | " + "Bildiği Yabancı Diller : " + Diller + " | " + "Uzmanlık Alanları : " + Uzmanlik);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            
        }
    }
}
