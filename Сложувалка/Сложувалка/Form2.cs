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
    public partial class gameOne : Form
    {
        public static int score;
        String word;
        List<int> index;
        GameOne g1;
        private int counter;

        public gameOne()
        {
            InitializeComponent();
            Char[] letters = { 'С', 'О', 'С', 'И', 'Т', 'М', 'Н', 'Т', 'Е', 'В', 'И', 'Р' };
            this.g1 = new GameOne(letters);
            this.btnLetter1.Text = g1.letters[0].ToString();
            this.btnLetter2.Text = g1.letters[1].ToString();
            this.btnLetter3.Text = g1.letters[2].ToString();
            this.btnLetter4.Text = g1.letters[3].ToString();
            this.btnLetter5.Text = g1.letters[4].ToString();
            this.btnLetter6.Text = g1.letters[5].ToString();
            this.btnLetter7.Text = g1.letters[6].ToString();
            this.btnLetter8.Text = g1.letters[7].ToString();
            this.btnLetter9.Text = g1.letters[8].ToString();
            this.btnLetter10.Text = g1.letters[9].ToString();
            this.btnLetter11.Text = g1.letters[10].ToString();
            this.btnLetter12.Text = g1.letters[11].ToString();
            this.word = "";
            this.lWord.Text = word;
            this.index = new List<int>();
            score = 0;
            this.counter = 0;
        }

        private void gameOne_Load(object sender, EventArgs e)
        {
            this.btnNextGame.Enabled = false;
            this.timer1.Start();
        }

        private void btnLetter1_Click(object sender, EventArgs e)
        {
            word += this.btnLetter1.Text;
            this.btnLetter1.Enabled = false;
            this.index.Add(1);
            this.lWord.Text = word;
        }

        private void btnLetter2_Click(object sender, EventArgs e)
        {
            word += this.btnLetter2.Text;
            this.btnLetter2.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(2);
        }

        private void btnLetter3_Click(object sender, EventArgs e)
        {
            word += this.btnLetter3.Text;
            this.btnLetter3.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(3);
        }

        private void btnLetter4_Click(object sender, EventArgs e)
        {
            word += this.btnLetter4.Text;
            this.btnLetter4.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(4);
        }

        private void btnLetter5_Click(object sender, EventArgs e)
        {
            word += this.btnLetter5.Text;
            this.btnLetter5.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(5);
        }

        private void btnLetter6_Click(object sender, EventArgs e)
        {
            word += this.btnLetter6.Text;
            this.btnLetter6.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(6);
        }

        private void btnLetter7_Click(object sender, EventArgs e)
        {
            word += this.btnLetter7.Text;
            this.btnLetter7.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(7);
        }

        private void btnLetter8_Click(object sender, EventArgs e)
        {
            word += this.btnLetter8.Text;
            this.btnLetter8.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(8);
        }

        private void btnLetter9_Click(object sender, EventArgs e)
        {
            word += this.btnLetter9.Text;
            this.btnLetter9.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(9);
        }

        private void btnLetter10_Click(object sender, EventArgs e)
        {
            word += this.btnLetter10.Text;
            this.btnLetter10.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(10);
        }

        private void btnLetter11_Click(object sender, EventArgs e)
        {
            word += this.btnLetter11.Text;
            this.btnLetter11.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(11);
        }

        private void btnLetter12_Click(object sender, EventArgs e)
        {
            word += this.btnLetter12.Text;
            this.btnLetter12.Enabled = false;
            this.lWord.Text = word;
            this.index.Add(12);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.index.Count > 0)
            {
                if(this.index[this.index.Count-1] == 1)
                {
                    this.btnLetter1.Enabled = true;
                    word = word.Substring(0, word.Length-1);
                    this.lWord.Text = word;
                    this.index.Remove(1);
                }
                else if (this.index[this.index.Count - 1] == 2)
                {
                    this.btnLetter2.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(2);
                }
                else if (this.index[this.index.Count - 1] == 3)
                {
                    this.btnLetter3.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(3);
                }
                else if (this.index[this.index.Count - 1] == 4)
                {
                    this.btnLetter4.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(4);
                }
                else if (this.index[this.index.Count - 1] == 5)
                {
                    this.btnLetter5.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(5);
                }
                else if (this.index[this.index.Count - 1] == 6)
                {
                    this.btnLetter6.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(6);
                }
                else if (this.index[this.index.Count - 1] == 7)
                {
                    this.btnLetter7.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(7);
                }
                else if (this.index[this.index.Count - 1] == 8)
                {
                    this.btnLetter8.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(8);
                }
                else if (this.index[this.index.Count - 1] == 9)
                {
                    this.btnLetter9.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(9);
                }
                else if (this.index[this.index.Count - 1] == 10)
                {
                    this.btnLetter10.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(10);
                }
                else if (this.index[this.index.Count - 1] == 11)
                {
                    this.btnLetter11.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(11);
                }
                else
                {
                    this.btnLetter12.Enabled = true;
                    word = word.Substring(0, word.Length - 1);
                    this.lWord.Text = word;
                    this.index.Remove(12);
                }
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            endOfGame();
        }

        private void endOfGame()
        {
            this.btnLetter1.Enabled = false;
            this.btnLetter2.Enabled = false;
            this.btnLetter3.Enabled = false;
            this.btnLetter4.Enabled = false;
            this.btnLetter5.Enabled = false;
            this.btnLetter6.Enabled = false;
            this.btnLetter7.Enabled = false;
            this.btnLetter8.Enabled = false;
            this.btnLetter9.Enabled = false;
            this.btnLetter10.Enabled = false;
            this.btnLetter11.Enabled = false;
            this.btnLetter12.Enabled = false;
            this.btnGuess.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnNextGame.Enabled = true;
            this.timer1.Stop();
            this.progressBar1.Enabled = false;
            if (g1.dictonary.Contains(word))
            {
                score += this.word.Length;
                if (score == 12)
                    score += 5;
                this.lScore.Text = score.ToString();
            }
            else
            {
                MessageBox.Show("Зборот не постои во македонскиот речник");
            }           
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MojBroj mb = new MojBroj();
            mb.Closed += (s, args) => this.Close();
            mb.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            this.counter++;
            if (counter == 101)
            {
                endOfGame();
            }
        }
    }
}
