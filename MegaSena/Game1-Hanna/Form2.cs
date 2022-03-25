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
 
    public partial class Form2 : Form
    {
        int nivel;
        int semente = 2;
        int numerosorteado;
        int palpite = 0;
        int tentativas = 0;
        Sorteio jogo = new Sorteio();
        Palpite palpites = new Palpite();


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            this.AcceptButton = button1;
            textBox1.Enabled = false;
            timer1.Enabled = true;
            button1.Enabled = false;
            label7.Enabled = false;
            label6.Enabled = false;
            MessageBox.Show("1° você deve escolher o nível:\n\t-Se escolher o nível  'Fácil' os números \nserão sorteados de 1 a 5 \n\t-Se escolher o nível  'Médio' os números \nserão sorteados de 1 a 10 \n\t-Se escolher o nível  'Difícil' os números \nserão sorteados de 1 a 1000 \n2° Você digita um numero e possui 3 tentativas para acertar\n3° Para ganhar o jogo você deve acertar os três digitos\n\t-toda vez que você acertar o digito terá direito\n a 3 tentativas novamete para acertar o proximo", "Regras do Jogo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            semente+=1;
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 novamenente = new Form1();
            timer1.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            this.Hide();
           novamenente.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.All(char.IsDigit) || textBox1.Text == "")

            {
                MessageBox.Show("Digite um valor numerio", "Mensagem de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                palpite = Convert.ToInt32(textBox1.Text);
                tentativas++;
                textBox1.Text = "";
                int chance = 3 - tentativas;
                int caso = palpites.verificacao(tentativas, numerosorteado, palpite);
                int dica = palpites.dica(numerosorteado, palpite);
                if (caso==1)
                {
                    MessageBox.Show("Reinicie o jogo para tentar novamente...", "Infelizmente vc não vai ser milionario agora!! ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Enabled = false;
                    button1.Enabled = false;
                   
                    label7.Enabled = false;
                    label6.Enabled = false;
                }
                else
                {
                    if (caso == 2)
                    {
                     
                        if (label2.Text == "")
                        {
                            label2.Text = numerosorteado.ToString();
                            numerosorteado = jogo.aleatorio(nivel, semente);
                            MessageBox.Show("Vc acertou com  " + tentativas + " tentativas!!", "Parabens!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (label3.Text == "")
                            {
                                label3.Text = numerosorteado.ToString();
                                numerosorteado = jogo.aleatorio(nivel, semente);
                                MessageBox.Show("Vc acertou com   " + tentativas + " tentativas!!", "Parabens!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                if (label4.Text == "")
                                {
                                    label4.Text = numerosorteado.ToString();
                                    MessageBox.Show("Apartir de agora vc é milionário e seu patrimônio acumulado é sorte!^\n Obrigada e jogue novamente é sempre bom acumular patrimônio! ", "Parabéns Grande Milionário!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }

                        }
                        tentativas = 0;
                        numerosorteado = jogo.aleatorio(nivel, semente);


                    }
                    else
                    {

                        if (dica == 3)
                        {


                            MessageBox.Show("Agora só tem mais  " + chance + "  tentativas...\n" + "Tente um Maior !!", "Vc errou!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            textBox1.Focus();

                        }
                        else
                        {
                            MessageBox.Show("Agora só tem mais  " + chance + "  tentativas...\n" + "Tente um Menor !!", "Vc errou!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            textBox1.Focus();

                        }

                    }
                }

            }



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            numerosorteado = jogo.aleatorio(nivel, semente);
            textBox1.Enabled = true;
            label7.Enabled = true;
            label6.Enabled = true;
            label5.Text = " ";
        
            button1.Enabled = true;
        }

        private void fácilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nivel = 1;
            numerosorteado = jogo.aleatorio(nivel, semente);


        }

        private void médioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nivel = 2;
            numerosorteado = jogo.aleatorio(nivel, semente);
        }

        private void dificilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            nivel = 3;
            numerosorteado = jogo.aleatorio(nivel, semente);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
