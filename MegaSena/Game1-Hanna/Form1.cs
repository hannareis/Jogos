using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game1_Hanna
{
    public partial class Form1 : Form
    {
        Form2 Game = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(progressBar1.Step);//esou incrementando o valor do step
            label2.Text = progressBar1.Value.ToString() + '%';
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Game.ShowDialog();
                this.Close();
               
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
          
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
    }
}
