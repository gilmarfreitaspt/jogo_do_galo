using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_4_Jogo_do_Galo
{
    public partial class Form1 : Form
    {
        int jog = 1; //vez do jogador
        int jog1 = 0; //pontuação jogador
        int jog2 = 0; //pontuação jogador
        int[,] j1 = new int[3, 3]; //matriz do jogador 1
        int[,] j2 = new int[3, 3]; //matriz do jogador 2


        public Form1()
        {
            InitializeComponent();
        }

        public int soma()
        {
            int soma = 0;
            for (int i=0; i<3; i++)
                for (int j=0; j <3; j ++)
                    soma=soma + j1[i, j] + j2[i, j];
            return soma;
        }

        public void ganhou()
        {
            if (jog == 2)
            {
                //verificar a primeira linha
                if ((j1[0, 0] + j1[0, 1] + j1[0, 2] == 3) ||
                 // verifica a segunda linha
                 (j1[1, 0] + j1[1, 1] + j1[1, 2] == 3) ||
                 // verifica a terceira linha
                 (j1[2, 0] + j1[2, 1] + j1[2, 2] == 3) ||
                 // verifica a primeira coluna
                 (j1[0, 0] + j1[1, 0] + j1[2, 0] == 3) ||
                 // verifica a segunda coluna
                 (j1[0, 1] + j1[1, 1] + j1[2, 1] == 3) ||
                 // verifica a terceira coluna
                 (j1[0, 2] + j1[1, 2] + j1[2, 2] == 3) ||
                 // verifica a diagonal
                 (j1[0, 0] + j1[1, 1] + j1[2, 2] == 3) ||
                 // verifica a outra diagonal
                 (j1[0, 2] + j1[1, 1] + j1[2, 0] == 3)
                 )
                {
                    MessageBox.Show("vitoria", "Ganhou o Jogador 1");
                    jog1++; //acrescenta um ponto de vitória
                    lbl_j1.Text = jog1 + "";
                }
                else
                    if (soma()==9)
                {
                    MessageBox.Show("Empate");
                }
            }
            else

            {
                //verificar a primeira linha
                if ((j1[0, 0] + j1[0, 1] + j1[0, 2] == 3) ||
                 // verifica a segunda linha
                 (j2[1, 0] + j2[1, 1] + j2[1, 2] == 3) ||
                 // verifica a terceira linha
                 (j2[2, 0] + j2[2, 1] + j2[2, 2] == 3) ||
                 // verifica a primeira coluna
                 (j2[0, 0] + j2[1, 0] + j2[2, 0] == 3) ||
                 // verifica a segunda coluna
                 (j2[0, 1] + j2[1, 1] + j2[2, 1] == 3) ||
                 // verifica a terceira coluna
                 (j2[0, 2] + j2[1, 2] + j2[2, 2] == 3) ||
                 // verifica a diagonal
                 (j2[0, 0] + j2[1, 1] + j2[2, 2] == 3) ||
                 // verifica a outra diagonal
                 (j2[0, 2] + j2[1, 1] + j2[2, 0] == 3)
                 )
                {
                    MessageBox.Show("Vitoria", "Ganhou o Jogador 2");
                    jog2++; //acrescenta um ponto de vitoria
                    lbl_j2.Text = jog2 + "";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btt1.Image = null;
            btt2.Image = null;
            btt3.Image = null;
            btt4.Image = null;
            btt5.Image = null;
            btt6.Image = null;
            btt7.Image = null;
            btt8.Image = null;
            btt9.Image = null;


            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    j1[i, j] = 0;
                    j2[i, j] = 0;
                }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt1.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[0, 0] = 1;
            }
            else
            {
                btt1.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[0, 0] = 1;
            }

            ganhou();
        }

   

        private void btt2_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt2.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[0, 1] = 1;
            }
            else
            {
                btt2.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[0, 1] = 1;
            }
            ganhou();
        }
        private void btt3_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt3.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[0, 2] = 1;
            }
            else
            {
                btt3.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[0, 2] = 1;
            }
            ganhou();
        }


        private void btt4_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt4.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[1, 0] = 1;
            }
            else
            {
                btt4.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[1, 0] = 1;
            }
            ganhou();
        }


        private void btt5_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt5.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[1, 1] = 1;
            }
            else
            {
                btt5.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[1, 1] = 1;
            }
            ganhou();
        }

        private void btt6_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt6.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[1, 2] = 1;
            }
            else
            {
                btt6.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[1, 2] = 1;
            }
            ganhou();
        }

        private void btt7_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt7.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[2, 0] = 1;
            }
            else
            {
                btt7.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[2, 0] = 1;
            }
            ganhou();
        }

        private void btt8_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt8.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[2, 1] = 1;
            }
            else
            {
                btt8.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[2, 1] = 1;
            }
            ganhou();
        }

        private void btt9_Click(object sender, EventArgs e)
        {
            if (jog == 1)
            {
                btt9.Image = Properties.Resources.x_6060;
                jog++;
                label3.Image = Properties.Resources.o_6060;
                j1[2, 2] = 1;
            }
            else
            {
                btt9.Image = Properties.Resources.o_6060;
                jog--;
                label3.Image = Properties.Resources.x_6060;
                j2[2, 2] = 1;
            }
            ganhou();
        }

     

        private void button11_Click(object sender, EventArgs e)
        {
            btt1.Image = null;
            btt2.Image = null;
            btt3.Image = null;
            btt4.Image = null;
            btt5.Image = null;
            btt6.Image = null;
            btt7.Image = null;
            btt8.Image = null;
            btt9.Image = null;

            jog1 = 0;
            jog2 = 0;
            lbl_j1.Text = "0";
            lbl_j2.Text = "0";


            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    j1[i, j] = 0;
                    j2[i, j] = 0;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
