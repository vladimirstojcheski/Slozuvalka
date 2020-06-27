using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Сложувалка
{
    public partial class Skocko : Form
    {
        private int numOfTry;
        private int [] comb;
        private int indeks;
        private int right;
        private int exist;
        int[] finalCombination;
        private String combination;
        private int counter;
        public Skocko()
        {
            InitializeComponent();
            this.numOfTry = 1;
            this.comb = new int[4] { 0, 0, 0, 0 };
            this.indeks = 0;
            this.right = 0;
            this.exist = 0;
            this.finalCombination = new int[4];
            this.combination = "";
            this.counter = 0;

        }

        private void Skocko_Load(object sender, EventArgs e)
        {
            this.lScore.Text = gameOne.score.ToString();
            Random rand = new Random();
            for(int i=0; i<4; i++)
            {
                this.finalCombination[i] = rand.Next(1, 7);
                this.combination += this.finalCombination[i].ToString();
            }
            this.btnNextGame.Enabled = false;
            this.timer.Start();
        }

        private bool checkIndex()
        {
            if (this.indeks == 4)
            {
                return true;
            }
            return false;
        }

        private void picSkocko_Click(object sender, EventArgs e)
        {
            if(checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/skocko.bmp";
                    this.comb[indeks] = 1;
                    this.indeks += 1;
                }
            }
        }

        private void picDetelina_Click(object sender, EventArgs e)
        {
            if (checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/detelina.bmp";
                    this.comb[indeks] = 2;
                    this.indeks += 1;
                }
            }
        }

        private void picList_Click(object sender, EventArgs e)
        {
            if (checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/list.bmp";
                    this.comb[indeks] = 3;
                    this.indeks += 1;
                }
            }
        }

        private void picSrce_Click(object sender, EventArgs e)
        {
            if (checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/srce.bmp";
                    this.comb[indeks] = 4;
                    this.indeks += 1;
                }
            }
        }

        private void picLokum_Click(object sender, EventArgs e)
        {
            if (checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/lokum.bmp";
                    this.comb[indeks] = 5;
                    this.indeks += 1;
                }
            }
        }

        private void picZvezda_Click(object sender, EventArgs e)
        {
            if (checkIndex())
            {
                return;
            }
            if (this.numOfTry == 1)
            {
                if (this.indeks == 0)
                {
                    this.picg11.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg12.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg13.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg14.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 0)
                {
                    this.picg21.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg22.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg23.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg24.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 0)
                {
                    this.picg31.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg32.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg33.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg34.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 0)
                {
                    this.picg41.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg42.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg43.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg44.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 0)
                {
                    this.picg51.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg52.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg53.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg54.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
            else
            {
                if (this.indeks == 0)
                {
                    this.picg61.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 1)
                {
                    this.picg62.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg63.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
                else
                {
                    this.picg64.ImageLocation = "../../Resources/zvezda.bmp";
                    this.comb[indeks] = 6;
                    this.indeks += 1;
                }
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (checkZeroValues())
            {
                MessageBox.Show("Missing values");
                return;
            }

            List<int> markedComb = new List<int>();
            List<int> markedFinalComb = new List<int>();

            for (int k=0; k<4; k++)
            {
                if (this.comb[k] == this.finalCombination[k])
                {
                    this.right++;
                    markedComb.Add(k);
                    markedFinalComb.Add(k);
                }
            }

            for (int i=0; i<4; i++)
            {
                if (markedComb.Contains(i))
                {
                    continue;
                }
                for (int j=0; j<4; j++)
                {
                    if (markedFinalComb.Contains(j))
                    {
                        continue;
                    }
                    if(this.comb[i] == this.finalCombination[j])
                    {
                        markedFinalComb.Add(j);
                        this.exist++;
                        break;
                    }
                }
            }

            if (this.right == 4)
            {
                reveal();
                win();
                this.lScore.Text = gameOne.score.ToString();
                this.btnNextGame.Enabled = true;
                this.timer.Stop();
            }

            if (this.numOfTry == 1)
            {
                if (this.right > 0)
                {
                    this.picGuess11.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else
                {
                    if (this.exist > 0)
                    {
                        this.picGuess11.ImageLocation = "../../Resources/exist.bmp";
                        this.exist--;
                    }
                }
                if (this.right > 0)
                {
                    this.picGuess12.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else 
                {
                    if (this.exist > 0)
                    {
                        this.picGuess12.ImageLocation = "../../Resources/exist.bmp";
                        this.exist--;
                    }
                }
                if (this.right > 0)
                {
                    this.picGuess13.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else
                {
                    if (this.exist > 0)
                    {
                        this.picGuess13.ImageLocation = "../../Resources/exist.bmp";
                        this.exist--;
                    }
                }
                if (this.right > 0)
                {
                    this.picGuess14.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else
                {
                    if (this.exist > 0)
                    {
                        this.picGuess14.ImageLocation = "../../Resources/exist.bmp";
                        this.exist--;
                    }
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.right > 0)
                {
                    this.picGuess21.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess21.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess22.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess22.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess23.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess23.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess24.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess24.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.right > 0)
                {
                    this.picGuess31.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess31.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess32.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess32.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess33.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess33.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess34.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess34.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.right > 0)
                {
                    this.picGuess41.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess41.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess42.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess42.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess43.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess43.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess44.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess44.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.right > 0)
                {
                    this.picGuess51.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess51.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess52.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess52.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess53.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess53.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess54.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess54.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
            }
            else
            {
                if (this.right > 0)
                {
                    this.picGuess61.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess61.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess62.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess62.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess63.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess63.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                if (this.right > 0)
                {
                    this.picGuess64.ImageLocation = "../../Resources/right.bmp";
                    this.right--;
                }
                else if (this.exist > 0)
                {
                    this.picGuess64.ImageLocation = "../../Resources/exist.bmp";
                    this.exist--;
                }
                reveal();
                this.btnGuess.Enabled = false;
                this.btnRemove.Enabled = false;
                this.btnNextGame.Enabled = true;
                this.timer.Stop();
            }
            this.numOfTry += 1;
            this.indeks = 0;
            resetValues();
        }

        private void resetValues()
        {
            this.comb[0] = 0;
            this.comb[1] = 0;
            this.comb[2] = 0;
            this.comb[3] = 0;
        }
        private bool checkZeroValues()
        {
            for (int i=0; i<4; i++)
            {
                if(this.comb[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void win()
        {
            gameOne.score += 30;
            this.btnGuess.Enabled = false;
            this.btnRemove.Enabled = false;
        }

        private void reveal()
        {
            //skocko
            if (this.finalCombination[0] == 1)
            {
                this.picRev1.ImageLocation = "../../Resources/skocko.bmp";
            }
            if (this.finalCombination[1] == 1)
            {
                this.picRev2.ImageLocation = "../../Resources/skocko.bmp";
            }
            if (this.finalCombination[2] == 1)
            {
                this.picRev3.ImageLocation = "../../Resources/skocko.bmp";
            }
            if (this.finalCombination[3] == 1)
            {
                this.picRev4.ImageLocation = "../../Resources/skocko.bmp";
            }

            // detelina
            if (this.finalCombination[0] == 2)
            {
                this.picRev1.ImageLocation = "../../Resources/detelina.bmp";
            }
            if (this.finalCombination[1] == 2)
            {
                this.picRev2.ImageLocation = "../../Resources/detelina.bmp";
            }
            if (this.finalCombination[2] == 2)
            {
                this.picRev3.ImageLocation = "../../Resources/detelina.bmp";
            }
            if (this.finalCombination[3] == 2)
            {
                this.picRev4.ImageLocation = "../../Resources/detelina.bmp";
            }

            // list
            if (this.finalCombination[0] == 3)
            {
                this.picRev1.ImageLocation = "../../Resources/list.bmp";
            }
            if (this.finalCombination[1] == 3)
            {
                this.picRev2.ImageLocation = "../../Resources/list.bmp";
            }
            if (this.finalCombination[2] == 3)
            {
                this.picRev3.ImageLocation = "../../Resources/list.bmp";
            }
            if (this.finalCombination[3] == 3)
            {
                this.picRev4.ImageLocation = "../../Resources/list.bmp";
            }

            // srce
            if (this.finalCombination[0] == 4)
            {
                this.picRev1.ImageLocation = "../../Resources/srce.bmp";
            }
            if (this.finalCombination[1] == 4)
            {
                this.picRev2.ImageLocation = "../../Resources/srce.bmp";
            }
            if (this.finalCombination[2] == 4)
            {
                this.picRev3.ImageLocation = "../../Resources/srce.bmp";
            }
            if (this.finalCombination[3] == 4)
            {
                this.picRev4.ImageLocation = "../../Resources/srce.bmp";
            }

            // lokum
            if (this.finalCombination[0] == 5)
            {
                this.picRev1.ImageLocation = "../../Resources/lokum.bmp";
            }
            if (this.finalCombination[1] == 5)
            {
                this.picRev2.ImageLocation = "../../Resources/lokum.bmp";
            }
            if (this.finalCombination[2] == 5)
            {
                this.picRev3.ImageLocation = "../../Resources/lokum.bmp";
            }
            if (this.finalCombination[3] == 5)
            {
                this.picRev4.ImageLocation = "../../Resources/lokum.bmp";
            }

            // zvezda
            if (this.finalCombination[0] == 6)
            {
                this.picRev1.ImageLocation = "../../Resources/zvezda.bmp";
            }
            if (this.finalCombination[1] == 6)
            {
                this.picRev2.ImageLocation = "../../Resources/zvezda.bmp";
            }
            if (this.finalCombination[2] == 6)
            {
                this.picRev3.ImageLocation = "../../Resources/zvezda.bmp";
            }
            if (this.finalCombination[3] == 6)
            {
                this.picRev4.ImageLocation = "../../Resources/zvezda.bmp";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.numOfTry == 1)
            {
                if (this.indeks == 1)
                {
                    this.picg11.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg12.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg13.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg14.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
            else if (this.numOfTry == 2)
            {
                if (this.indeks == 1)
                {
                    this.picg21.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg22.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg23.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg24.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
            else if (this.numOfTry == 3)
            {
                if (this.indeks == 1)
                {
                    this.picg31.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg32.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg33.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg34.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
            else if (this.numOfTry == 4)
            {
                if (this.indeks == 1)
                {
                    this.picg41.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg42.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg43.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg44.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
            else if (this.numOfTry == 5)
            {
                if (this.indeks == 1)
                {
                    this.picg51.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg52.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg53.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg54.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
            else
            {
                if (this.indeks == 1)
                {
                    this.picg61.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 2)
                {
                    this.picg62.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 3)
                {
                    this.picg63.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
                else if (this.indeks == 4)
                {
                    this.picg64.ImageLocation = "../../Resources/sino.bmp";
                    this.comb[indeks-1] = 0;
                    this.indeks -= 1;
                }
            }
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameFive gp = new GameFive();
            gp.Closed += (s, args) => this.Close();
            gp.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.counter++;
            if (counter == 101)
            {
                reveal();
                this.btnNextGame.Enabled = true;
                this.btnGuess.Enabled = false;
                this.btnRemove.Enabled = false;
                this.timer.Stop();
            }
        }
    }
}
