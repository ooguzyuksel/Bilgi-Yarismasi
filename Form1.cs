using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiYarismasiKendiDenemem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }


        int soru = 0, dogru = 0, yanlis = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            lblBenimCevap.Text = btnB.Text;


            if(lblBenimCevap.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;



            lblBenimCevap.Text = btnC.Text;

            if(lblBenimCevap.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;


            lblBenimCevap.Text = btnD.Text;

            if(lblBenimCevap.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnBasla.Visible = false;
            btnSonraki.Text = "Soruyu Gör";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            btnB.Enabled = false;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnSonraki.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;


            lblBenimCevap.Text = btnA.Text;
            if(lblBenimCevap.Text == lblDogruCevap.Text)
            {
                dogru++;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
                
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soru++;

            btnSonraki.Text = "Sonraki Soru";
            btnSonraki.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            button1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;



            lblSoru.Text = soru.ToString();

            // Birinci Soru
            if (soru == 1)
            {
                richTextBox1.Text = "Türkiye'nin Başkenti Neresidir ?";
                btnA.Text = "Ankara";
                btnB.Text = "İstanbul";
                btnC.Text = "Ordu";
                btnD.Text = "Antalya";
                lblDogruCevap.Text = "Ankara";
            }

            //İkinci Soru
            if(soru == 2)
            {

                richTextBox1.Text = "Antalya'nın Plakası hangisidir ? ";
                btnA.Text = "35";
                btnB.Text = "20";
                btnC.Text = "07";
                btnD.Text = "52";
                lblDogruCevap.Text = "07";
            }

            //Üçüncü Soru
            if(soru == 3)
            {
                richTextBox1.Text = "Fındık hangi ilimizin gıdasıdır ?";
                btnA.Text = "Malatya";
                btnB.Text = "Kayseri";
                btnC.Text = "Denizli";
                btnD.Text = "Ordu";
                lblDogruCevap.Text = "Ordu";
                btnSonraki.Text = "Sonuçlar";
            }

            if(soru == 4)
            {
                btnSonraki.Visible = false;
                btnA.Visible = false;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD.Visible = false;
                button1.Visible = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış: " + yanlis);
            }
        }
    }
}
