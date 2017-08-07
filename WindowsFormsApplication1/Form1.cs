using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Data;

namespace WindowsFormsApplication1
{
    public partial class Principale : Form
    {
        public Principale()
        {
            InitializeComponent();
            i = -1;
            j = -1;
            ft = 1;
            rt = 0;
            resultat = 0;
            trouver = false;
            musik = false;
        }
        int i;//pour gerer les panels
        int j;//pour aider à gerer l'apparition des panels
        int resultat;
        Random rnd = new Random();
        Color[] tabcolor = new Color[9];
        int[] tab = new int[9];
        Button[] position = new Button[50];
        bool trouver;
        SoundPlayer sp = new SoundPlayer();
        SoundPlayer sp1 = new SoundPlayer();
        SoundPlayer sp2 = new SoundPlayer();
        bool musik;
        int ft , rt;
        
        private void chnagerDeLangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construction");
        }

        private void color2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton49_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton48_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Principale_Load(object sender, EventArgs e)
        {
 
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void c1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void red1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b8.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b15.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b22.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b29.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b36.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b43.BackColor = Color.Red;
            }
        }

        private void blue1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b8.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b15.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b22.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b29.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b36.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b43.BackColor = Color.Blue;
            }
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yellow1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b8.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b15.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b22.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b29.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b36.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b43.BackColor = Color.Yellow;
            }
        }

        private void green1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b8.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b15.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b22.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b29.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b36.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b43.BackColor = Color.Green;
            }

        }

        private void ciel1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b8.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b15.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b22.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b29.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b36.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b43.BackColor = ciel1.BackColor;
            }
        }

        private void viollette1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b8.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b15.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b22.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b29.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b36.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b43.BackColor = viollette1.BackColor;
            }
        }

        private void orange1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b8.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b15.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b22.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b29.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b36.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b43.BackColor = orange1.BackColor;
            }
        }

        private void red2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b9.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b16.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b23.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b30.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b37.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b44.BackColor = Color.Red;
            }
        }

        private void blue2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b9.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b16.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b23.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b30.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b37.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b44.BackColor = Color.Blue;
            }
        }

        private void yellow2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b9.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b16.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b23.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b30.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b37.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b44.BackColor = Color.Yellow;
            }
        }

        private void green2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b9.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b16.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b23.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b30.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b37.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b44.BackColor = Color.Green;
            }
        }

        private void ciel2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b9.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b16.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b23.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b30.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b37.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b44.BackColor = ciel1.BackColor;
            }
        }

        private void viollette2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b9.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b16.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b23.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b30.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b37.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b44.BackColor = viollette1.BackColor;
            }
        }

        private void orange2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b9.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b16.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b23.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b30.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b37.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b44.BackColor = orange1.BackColor;
            }
        }

        private void red3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b10.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b17.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b24.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b31.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b38.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b45.BackColor = Color.Red;
            }
        }

        private void blue3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b10.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b17.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b24.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b31.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b38.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b45.BackColor = Color.Blue;
            }
        }

        private void yellow3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b10.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b17.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b24.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b31.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b38.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b45.BackColor = Color.Yellow;
            }
        }

        private void green3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b10.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b17.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b24.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b31.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b38.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b45.BackColor = Color.Green;
            }
        }

        private void ciel3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b10.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b17.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b24.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b31.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b38.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b45.BackColor = ciel1.BackColor;
            }
        }

        private void viollette3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b10.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b17.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b24.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b31.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b38.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b45.BackColor = viollette1.BackColor;
            }
        }

        private void orange3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b10.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b17.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b24.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b31.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b38.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b45.BackColor = orange1.BackColor;
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b11.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b18.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b25.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b32.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b39.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b46.BackColor = Color.Red;
            }
        }

        private void blue4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b11.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b18.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b25.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b32.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b39.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b46.BackColor = Color.Blue;
            }
        }

        private void yellow4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b11.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b18.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b25.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b32.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b39.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b46.BackColor = Color.Yellow;
            }
        }

        private void green4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b11.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b18.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b25.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b32.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b39.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b46.BackColor = Color.Green;
            }
        }

        private void ciel4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b11.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b18.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b25.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b32.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b39.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b46.BackColor = ciel1.BackColor;
            }
        }

        private void viollette4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b11.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b18.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b25.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b32.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b39.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b46.BackColor = viollette1.BackColor;
            }
        }

        private void orange4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b11.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b18.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b25.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b32.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b39.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b46.BackColor = orange1.BackColor;
            }
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            if (j >= 0)
            {
                i++;
                
            }
           if(i>=0)
           {
               correspondance(b1, 0, 1);
               correspondance(b2, 1, 2);
               correspondance(b3, 2, 3); 
               correspondance(b4, 3, 4);
               correspondance(b5, 4, 5);
               correspondance(b6, 5, 6);
               correspondance(b7, 6, 7);
               if (i == 1)
               {
                   bingo(1, 2, 3, 4, 5, 6, 7, 0);
                   calcul(ind1);
                   calcul(ind2);
                   calcul(ind3);
                   calcul(ind4);
                   calcul(ind5);
                   calcul(ind6);
                   calcul(ind7);
               }               
               
           }
            if (i >= 1 & !trouver)
            {
                p2.Show();
                correspondance(b8, 0, 8); 
                correspondance(b9, 1, 9); 
                correspondance(b10, 2, 10); 
                correspondance(b11, 3, 11); 
                correspondance(b12, 4, 12);
                correspondance(b13, 5, 13);
                correspondance(b14, 6, 14);
                if (i == 2)
                {
                    bingo(8, 9, 10, 11, 12, 13, 14, 1);
                    calcul(ind8);
                    calcul(ind9);
                    calcul(ind10);
                    calcul(ind11);
                    calcul(ind12);
                    calcul(ind13);
                    calcul(ind14);
                }           
            }
            if (i >= 2 & !trouver)
            {
                p3.Show();
                correspondance(b15, 0, 15);
                correspondance(b16, 1, 16); 
                correspondance(b17, 2, 17); 
                correspondance(b18, 3, 18); 
                correspondance(b19, 4, 19);
                correspondance(b20, 5, 20);
                correspondance(b21, 6, 21);
                if (i == 3)
                {
                    bingo(15, 16, 17, 18, 19, 20, 21, 2);
                    calcul(ind15);
                    calcul(ind16);
                    calcul(ind17);
                    calcul(ind18);
                    calcul(ind19);
                    calcul(ind20);
                    calcul(ind21); 
                }
            }
            if (i >= 3 & !trouver)
            {
                p4.Show();
                correspondance(b22, 0, 22); 
                correspondance(b23, 1, 23); 
                correspondance(b24, 2, 24);
                correspondance(b25, 3, 25); 
                correspondance(b26, 4, 26);
                correspondance(b27, 5, 27); 
                correspondance(b28, 6, 28);
                if (i == 4)
                {
                    bingo(22, 23, 24, 25, 26, 27, 28, 3);
                    calcul(ind22);
                    calcul(ind23);
                    calcul(ind24);
                    calcul(ind25);
                    calcul(ind26);
                    calcul(ind27);
                    calcul(ind28); 
                }
            }
            if (i >= 4 & !trouver)
            {
                p5.Show();
                correspondance(b29, 0, 29); 
                correspondance(b30, 1, 30); 
                correspondance(b31, 2, 31); 
                correspondance(b32, 3, 32); 
                correspondance(b33, 4, 33);
                correspondance(b34, 5, 34); 
                correspondance(b35, 6, 35);
                if (i == 5)
                {
                    bingo(29, 30, 31, 32, 33, 34, 35, 4);
                    calcul(ind29);
                    calcul(ind30);
                    calcul(ind31);
                    calcul(ind32);
                    calcul(ind33);
                    calcul(ind34);
                    calcul(ind35); 
                }
            }
            if (i >= 5 & !trouver)
            {
                p6.Show();
                correspondance(b36, 0, 36); 
                correspondance(b37, 1, 37); 
                correspondance(b38, 2, 38); 
                correspondance(b39, 3, 39); 
                correspondance(b40, 4, 40); 
                correspondance(b41, 5, 41); 
                correspondance(b42, 6, 42);
                if (i == 6)
                {

                    bingo(36, 37, 38, 39, 40, 41, 42, 5);
                    calcul(ind36);
                    calcul(ind37);
                    calcul(ind38);
                    calcul(ind39);
                    calcul(ind40);
                    calcul(ind41);
                    calcul(ind42); 
                }
            }
            if (i >= 6 & !trouver)
            {
                p7.Show();
                correspondance(b43, 0, 43);
                correspondance(b44, 1, 44);
                correspondance(b45, 2, 45); 
                correspondance(b46, 3, 46);
                correspondance(b47, 4, 47);
                correspondance(b48, 5, 48); 
                correspondance(b49, 6, 49);
                if (i == 7)
                {
                    bingo(43, 44, 45, 46, 47, 48, 49, 6);
                    calcul(ind43);
                    calcul(ind44);
                    calcul(ind45);
                    calcul(ind46);
                    calcul(ind47);
                    calcul(ind48);
                    calcul(ind49); 
                }          
            }
            if (i > 6 | trouver)
            {
                devine1.BackColor = tabcolor[tab[0]];
                devine2.BackColor = tabcolor[tab[1]];
                devine3.BackColor = tabcolor[tab[2]];
                devine4.BackColor = tabcolor[tab[3]];
                devine5.BackColor = tabcolor[tab[4]];
                devine6.BackColor = tabcolor[tab[5]];
                devine7.BackColor = tabcolor[tab[6]];
                sp.Stream = Properties.Resources.bravo;
                sp2.Stream = Properties.Resources._535;
                if (trouver == true)
                {
                    sp.Play();
                    MessageBox.Show("Felicitation vous avez gagné avec un score de :" + resultat);
                    //code pour envoyer le score à la bd
 


                    // formulaire d'envoi du pseudo lorsque le score peut integrer le top 5
                    Form2 envoi = new Form2(resultat);
                    envoi.Show();
                }
                else
                {
                    sp2.Play();
                    MessageBox.Show("Vous avez perdu avec un score de :" + resultat);
                }              
                Valider.Enabled = false;

            }





        }

        private void b21_Click(object sender, EventArgs e)
        {
        }

        private void bingo(int i1,int i2,int i3,int i4,int i5,int i6,int i7,int cmp)
        {
            if (position[i1].BackColor.Equals(Color.Black))
            {
                if (position[i2].BackColor.Equals(Color.Black))
                {
                    if (position[i3].BackColor.Equals(Color.Black))
                    {
                        if (position[i4].BackColor.Equals(Color.Black))
                        {
                            if (position[i5].BackColor.Equals(Color.Black))
                            {
                                if (position[i6].BackColor.Equals(Color.Black))
                                {
                                    if (position[i7].BackColor.Equals(Color.Black))
                                    {
                                        resultat = resultat + (14*(7-cmp));
                                        trouver = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void calcul(Button i1)
        {
            if (trouver == false)
            {
                if (i1.BackColor.Equals(Color.Black)) { resultat = resultat + 2; }
                if (i1.BackColor.Equals(Color.White)) { resultat = resultat + 1; }
            }
        }
        private void savecolor()
        {
            position[1] = ind1; position[2] = ind2; position[3] = ind3; position[4] = ind4; position[5] = ind5;
            position[6] = ind6; position[7] = ind7; position[8] = ind8; position[9] = ind9; position[10] = ind10;
            position[11] = ind11; position[12] = ind12; position[13] = ind13; position[14] = ind14; position[15] = ind15;
            position[16] = ind16; position[17] = ind17; position[18] = ind18; position[19] = ind19; position[20] = ind20;
            position[21] = ind21; position[22] = ind22; position[23] = ind23; position[24] = ind24; position[25] = ind25;
            position[26] = ind26; position[27] = ind27; position[28] = ind28; position[29] = ind29; position[30] = ind30;
            position[31] = ind31; position[32] = ind32; position[33] = ind33; position[34] = ind34; position[35] = ind35;
            position[36] = ind36; position[37] = ind37; position[38] = ind38; position[39] = ind39; position[40] = ind40;
            position[41] = ind41; position[42] = ind42; position[43] = ind43; position[44] = ind44; position[45] = ind45;
            position[46] = ind46; position[47] = ind47; position[48] = ind48; position[49] = ind49;
            tabcolor[0] = Color.Red;
            tabcolor[1] = Color.Blue;
            tabcolor[2] = yellow1.BackColor;
            tabcolor[3] = green1.BackColor;
            tabcolor[4] = ciel1.BackColor;
            tabcolor[5] = viollette1.BackColor;
            tabcolor[6] = orange1.BackColor;
            tabcolor[7] = olive1.BackColor;
            tabcolor[8] = rose1.BackColor;
            for (j = 0; j <= 6; j++)
            {
                tab[j] = rnd.Next(0, 9);
            }
        }


        private void correspondance(Button bouton,int pos,int indicateur)
        {
           int parcours;
            if (bouton.BackColor.Equals(tabcolor[tab[pos]]))
            {
                position[indicateur].BackColor = Color.Black;
            }
            else
            {
                for (parcours = 0; parcours <= 6; parcours++)
                {
                    if (bouton.BackColor.Equals(tabcolor[tab[parcours]]))
                    {
                        position[indicateur].BackColor = Color.White;
                    }
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {

        }

        private void red5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b12.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b19.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b26.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b33.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b40.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b47.BackColor = Color.Red;
            }
        }

        private void blue5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b12.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b19.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b26.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b33.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b40.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b47.BackColor = Color.Blue;
            }
        }

        private void yellow5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b12.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b19.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b26.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b33.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b40.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b47.BackColor = Color.Yellow;
            }
        }

        private void green5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b12.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b19.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b26.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b33.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b40.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b47.BackColor = Color.Green;
            }
        }

        private void ciel5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b12.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b19.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b26.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b33.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b40.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b47.BackColor = ciel1.BackColor;
            }
        }

        private void viollette5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b12.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b19.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b26.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b33.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b40.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b47.BackColor = viollette1.BackColor;
            }
        }

        private void orange5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b12.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b19.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b26.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b33.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b40.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b47.BackColor = orange1.BackColor;
            }
        }

        private void red6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b13.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b20.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b27.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b34.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b41.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b48.BackColor = Color.Red;
            }
        }

        private void blue6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b13.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b20.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b27.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b34.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b41.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b48.BackColor = Color.Blue;
            }
        }

        private void yellow6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b13.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b20.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b27.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b34.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b41.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b48.BackColor = Color.Yellow;
            }
        }

        private void green6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b13.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b20.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b27.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b34.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b41.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b48.BackColor = Color.Green;
            }
        }

        private void ciel6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b13.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b20.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b27.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b34.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b41.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b48.BackColor = ciel1.BackColor;
            }
        }

        private void viollette6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b13.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b20.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b27.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b34.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b41.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b48.BackColor = viollette1.BackColor;
            }
        }

        private void orange6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b13.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b20.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b27.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b34.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b41.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b48.BackColor = orange1.BackColor;
            }
        }

        private void red7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = Color.Red;
            }
            if (i == 1)
            {
                b14.BackColor = Color.Red;
            }
            if (i == 2)
            {
                b21.BackColor = Color.Red;
            }
            if (i == 3)
            {
                b28.BackColor = Color.Red;
            }
            if (i == 4)
            {
                b35.BackColor = Color.Red;
            }
            if (i == 5)
            {
                b42.BackColor = Color.Red;
            }
            if (i == 6)
            {
                b49.BackColor = Color.Red;
            }
        }

        private void blue7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = Color.Blue;
            }
            if (i == 1)
            {
                b14.BackColor = Color.Blue;
            }
            if (i == 2)
            {
                b21.BackColor = Color.Blue;
            }
            if (i == 3)
            {
                b28.BackColor = Color.Blue;
            }
            if (i == 4)
            {
                b35.BackColor = Color.Blue;
            }
            if (i == 5)
            {
                b42.BackColor = Color.Blue;
            }
            if (i == 6)
            {
                b49.BackColor = Color.Blue;
            }
        }

        private void yellow7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = Color.Yellow;
            }
            if (i == 1)
            {
                b14.BackColor = Color.Yellow;
            }
            if (i == 2)
            {
                b21.BackColor = Color.Yellow;
            }
            if (i == 3)
            {
                b28.BackColor = Color.Yellow;
            }
            if (i == 4)
            {
                b35.BackColor = Color.Yellow;
            }
            if (i == 5)
            {
                b42.BackColor = Color.Yellow;
            }
            if (i == 6)
            {
                b49.BackColor = Color.Yellow;
            }
        }

        private void green7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = Color.Green;
            }
            if (i == 1)
            {
                b14.BackColor = Color.Green;
            }
            if (i == 2)
            {
                b21.BackColor = Color.Green;
            }
            if (i == 3)
            {
                b28.BackColor = Color.Green;
            }
            if (i == 4)
            {
                b35.BackColor = Color.Green;
            }
            if (i == 5)
            {
                b42.BackColor = Color.Green;
            }
            if (i == 6)
            {
                b49.BackColor = Color.Green;
            }
        }

        private void ciel7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = ciel1.BackColor;
            }
            if (i == 1)
            {
                b14.BackColor = ciel1.BackColor;
            }
            if (i == 2)
            {
                b21.BackColor = ciel1.BackColor;
            }
            if (i == 3)
            {
                b28.BackColor = ciel1.BackColor;
            }
            if (i == 4)
            {
                b35.BackColor = ciel1.BackColor;
            }
            if (i == 5)
            {
                b42.BackColor = ciel1.BackColor;
            }
            if (i == 6)
            {
                b49.BackColor = ciel1.BackColor;
            }
        }

        private void viollette7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = viollette1.BackColor;
            }
            if (i == 1)
            {
                b14.BackColor = viollette1.BackColor;
            }
            if (i == 2)
            {
                b21.BackColor = viollette1.BackColor;
            }
            if (i == 3)
            {
                b28.BackColor = viollette1.BackColor;
            }
            if (i == 4)
            {
                b35.BackColor = viollette1.BackColor;
            }
            if (i == 5)
            {
                b42.BackColor = viollette1.BackColor;
            }
            if (i == 6)
            {
                b49.BackColor = viollette1.BackColor;
            }
        }

        private void orange7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = orange1.BackColor;
            }
            if (i == 1)
            {
                b14.BackColor = orange1.BackColor;
            }
            if (i == 2)
            {
                b21.BackColor = orange1.BackColor;
            }
            if (i == 3)
            {
                b28.BackColor = orange1.BackColor;
            }
            if (i == 4)
            {
                b35.BackColor = orange1.BackColor;
            }
            if (i == 5)
            {
                b42.BackColor = orange1.BackColor;
            }
            if (i == 6)
            {
                b49.BackColor = orange1.BackColor;
            }
        }

        private void Jouer_Click(object sender, EventArgs e)
        {
            j++;
            i = 0;
            p1.Show();
            savecolor();
            Lancer.Enabled = false;
        }

        private void p1_Paint(object sender, PaintEventArgs e)
        {
            if (i < 0) 
            {
                p1.Hide(); 
            }
        }

        private void p2_Paint(object sender, PaintEventArgs e)
        {
            if (i < 1)
            {
                p2.Hide();
            }
        }

        private void p3_Paint(object sender, PaintEventArgs e)
        {
            if (i <2)
            {
                p3.Hide();
            }
        }

        private void p4_Paint(object sender, PaintEventArgs e)
        {
            if (i <3)
            {
                p4.Hide();
            }
        }

        private void p5_Paint(object sender, PaintEventArgs e)
        {
            if (i <4)
            {
                p5.Hide();
            }
        }

        private void p6_Paint(object sender, PaintEventArgs e)
        {
            if (i <5)
            {
                p6.Hide();
            }
        }

        private void p7_Paint(object sender, PaintEventArgs e)
        {
            if (i <6)
            {
                p7.Hide();
            }
        }

        private void Aide_Click(object sender, EventArgs e)
        {
           MessageBox.Show("en maintenance...la date d'aujourd'hui est" + DateTime.Today.ToLongDateString());
        }

        private void Niveaux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void proposer_Click(object sender, EventArgs e)
        {
            string message = "voulez vous recommencer la partie ?";
            string message2 = "Vous allez Commencer une nouvelle partie?";
            string caption = "RECOMMENCER LA PARTIE";
            MessageBoxButtons init = MessageBoxButtons.YesNo;
            DialogResult reponse;
            
            if (i < 6)
            {
                proposer.Text = "Recommencer";
                reponse = MessageBox.Show(this, message, caption, init);
                if (reponse == DialogResult.Yes)
                {
                    this.Hide();
                    Principale nouvelle_partie = new Principale();
                    nouvelle_partie.FormClosed += new FormClosedEventHandler(ferme_FormClosed);
                    nouvelle_partie.Show();
                }
            }
            else
            {
               proposer.Text = "Nlle Partie";
                reponse = MessageBox.Show(this, message2, caption, init);
                if (reponse == DialogResult.Yes)
                {
                    this.Hide();
                    Principale nouvelle_partie = new Principale();
                    nouvelle_partie.FormClosed += new FormClosedEventHandler(ferme_FormClosed);
                    nouvelle_partie.Show();
                }
            }
          
        }
        private void ferme_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Retour_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construction");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ft++;
            rt=ft % 2;
            sp1.Stream = Properties.Resources.vlc_record_2017_07_10_11h24m54s_Booba___Mr__Kopp___MUSIC_VIDEO___mp4_;
            if (rt == 0)
            {
                musik = true;
                sp1.PlayLooping();
            }
            else
            {
                musik = false;
                sp1.Stop();
            }
        }

        private void meilleursScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("base de données En construction");
            //connexion à la base de données

            Class1 cl = new Class1();
            OleDbConnection connex = cl.ouvrirconnect();
            string req = "select * from Joueur";
            OleDbCommand cmd = new OleDbCommand(req, connex);
            OleDbDataAdapter oldb = new OleDbDataAdapter();
            DataTable tables = new DataTable();
           // dataGridView1 dataGridView1 = new dataGridView1();
            try
            {
                cmd = new OleDbCommand(req, connex);
                cmd.CommandType = CommandType.Text;
                oldb.SelectCommand = cmd;
               // oldb.Fill(tables,SchemaType.Source);
                oldb.Fill(tables);
                dataGridView1.DataSource = tables;
                //pour l'affichage
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Orange;
                    dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
                    dataGridView1.RowsDefaultCellStyle.Font = new Font("Perpetua Titling MT", 10, FontStyle.Regular);
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGray;
                    DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                    columnHeaderStyle.BackColor = Color.LightCyan;
                    columnHeaderStyle.Font = new Font("Perpetua Titling MT", 12, FontStyle.Regular);
                    dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                    dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
                    dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightCyan;
                    dataGridView1.EnableHeadersVisualStyles = false;

                }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void olive1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b8.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b15.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b22.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b29.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b36.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b43.BackColor = olive1.BackColor;
            }
        }

        private void rose1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b1.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b8.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b15.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b22.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b29.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b36.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b43.BackColor = rose1.BackColor;
            }
        }

        private void olive2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = olive2.BackColor;
            }
            if (i == 1)
            {
                b9.BackColor = olive2.BackColor;
            }
            if (i == 2)
            {
                b16.BackColor = olive2.BackColor;
            }
            if (i == 3)
            {
                b23.BackColor = olive2.BackColor;
            }
            if (i == 4)
            {
                b30.BackColor = olive2.BackColor;
            }
            if (i == 5)
            {
                b37.BackColor = olive2.BackColor;
            }
            if (i == 6)
            {
                b44.BackColor = olive2.BackColor;
            }
        }

        private void rose2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b2.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b9.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b16.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b23.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b30.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b37.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b44.BackColor = rose1.BackColor;
            }
        }

        private void olive3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b10.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b17.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b24.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b31.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b38.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b45.BackColor = olive1.BackColor;
            }
        }

        private void rose3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b3.BackColor =rose1.BackColor;
            }
            if (i == 1)
            {
                b10.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b17.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b24.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b31.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b38.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b45.BackColor = rose1.BackColor;
            }
        }

        private void olive4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b11.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b18.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b25.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b32.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b39.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b46.BackColor = olive1.BackColor;
            }
        }

        private void rose4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b4.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b11.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b18.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b25.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b32.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b39.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b46.BackColor = rose1.BackColor;
            }
        }

        private void olive5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b12.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b19.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b26.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b33.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b40.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b47.BackColor = olive1.BackColor;
            }
        }

        private void rose5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b5.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b12.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b19.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b26.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b33.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b40.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b47.BackColor = rose1.BackColor;
            }
        }

        private void olive6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b13.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b20.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b27.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b34.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b41.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b48.BackColor = olive1.BackColor;
            }
        }

        private void rose6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b6.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b13.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b20.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b27.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b34.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b41.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b48.BackColor = rose1.BackColor;
            }
        }

        private void olive7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = olive1.BackColor;
            }
            if (i == 1)
            {
                b14.BackColor = olive1.BackColor;
            }
            if (i == 2)
            {
                b21.BackColor = olive1.BackColor;
            }
            if (i == 3)
            {
                b28.BackColor = olive1.BackColor;
            }
            if (i == 4)
            {
                b35.BackColor = olive1.BackColor;
            }
            if (i == 5)
            {
                b42.BackColor = olive1.BackColor;
            }
            if (i == 6)
            {
                b49.BackColor = olive1.BackColor;
            }
        }

        private void rose7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                b7.BackColor = rose1.BackColor;
            }
            if (i == 1)
            {
                b14.BackColor = rose1.BackColor;
            }
            if (i == 2)
            {
                b21.BackColor = rose1.BackColor;
            }
            if (i == 3)
            {
                b28.BackColor = rose1.BackColor;
            }
            if (i == 4)
            {
                b35.BackColor = rose1.BackColor;
            }
            if (i == 5)
            {
                b42.BackColor = rose1.BackColor;
            }
            if (i == 6)
            {
                b49.BackColor = rose1.BackColor;
            }
        }


    }
           
}
