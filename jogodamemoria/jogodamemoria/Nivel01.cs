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
    public partial class Nivel01 : Form
    {
        Form1 jogo = new Form1();
        int nivel = 1;
        public Nivel01()
        {
            InitializeComponent();
        }

        private void Nivel01_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            jogo.ShowDialog();
            this.Close();
            for (i = 0; i < 4; i++)
            {
                imagem[i] = sorteio.aleatorio(semente);
            }

        }
    }
}
