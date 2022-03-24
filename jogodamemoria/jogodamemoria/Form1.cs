using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodamemoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Imagemsorteio sorteio = new Imagemsorteio();
        int [] imagem = new int[8];
        int semente = 0;
        int i;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            pictureBox1.BackgroundImage = imageList1.Images[imagem[0]];
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
        
            pictureBox9.BackgroundImage = imageList1.Images[imagem[1]];
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           
            pictureBox11.BackgroundImage = imageList1.Images[imagem[2]];
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
         
            pictureBox10.BackgroundImage = imageList1.Images[imagem[3]];
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
       
            pictureBox6.BackgroundImage = imageList1.Images[imagem[3]];
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            pictureBox2.BackgroundImage = imageList1.Images[1];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            pictureBox3.BackgroundImage = imageList1.Images[1];

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = imageList1.Images[2];

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(progressBar1.Step);//esou incrementando o valor do step
           
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
               
                this.Close();

            }
         
            semente++;
           

        }
    }
}
