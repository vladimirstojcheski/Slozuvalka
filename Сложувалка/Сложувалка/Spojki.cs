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
    public partial class Spojki : Form
    {
        private GameThree spojki;
        private int indeks;
        private int counter;
        public Spojki()
        {
            InitializeComponent();
            String topic = "Држави и нивните главни градови";
            Dictionary<String, String> dic = new Dictionary<string, string>();
            dic.Add("Канада", "Отава");
            dic.Add("Чиле", "Сантијаго");
            dic.Add("Исланд", "Рејкјавик");
            dic.Add("Брег на Слонова Коска", "Абиџан");
            dic.Add("Индонезија", "Куала Лумпур");
            dic.Add("Австралија", "Канбера");
            dic.Add("Грузија", "Тбилиси");
            dic.Add("Монголија", "Улан Батор");
            this.spojki = new GameThree(topic, dic);
            this.indeks = 1;
            this.counter = 0;
        }

        private void loadPairs()
        {
            List<String> names = new List<String>(this.spojki.pairs.Keys);
            List<String> na = new List<string>(names);
            Random rand = new Random();
            this.btnLeft1.Text = na[rand.Next(0,na.Count)];
            na.Remove(this.btnLeft1.Text);
            this.btnLeft2.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft2.Text);
            this.btnLeft3.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft3.Text);
            this.btnLeft4.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft4.Text);
            this.btnLeft5.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft5.Text);
            this.btnLeft6.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft6.Text);
            this.btnLeft7.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft7.Text);
            this.btnLeft8.Text = na[rand.Next(0, na.Count)];
            na.Remove(this.btnLeft8.Text);

            List<String> lastNames = new List<string>(this.spojki.pairs.Values);
            List<String> nl = new List<string>(lastNames);
            this.btnRight1.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight1.Text);
            this.btnRight2.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight2.Text);
            this.btnRight3.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight3.Text);
            this.btnRight4.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight4.Text);
            this.btnRight5.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight5.Text);
            this.btnRight6.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight6.Text);
            this.btnRight7.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight7.Text);
            this.btnRight8.Text = nl[rand.Next(0, nl.Count)];
            nl.Remove(this.btnRight8.Text);
        }

        private void Spojki_Load(object sender, EventArgs e)
        {
            this.lScore.Text = gameOne.score.ToString();
            this.lTopic.Text = this.spojki.topic;
            loadPairs();
            this.btnLeft1.BackColor = Color.Yellow;
            this.btnLeft1.Enabled = false;
            this.btnLeft2.Enabled = false;
            this.btnLeft3.Enabled = false;
            this.btnLeft4.Enabled = false;
            this.btnLeft5.Enabled = false;
            this.btnLeft6.Enabled = false;
            this.btnLeft7.Enabled = false;
            this.btnLeft8.Enabled = false;
            this.btnNextGame.Enabled = false;
            this.timer.Start();
        }

        private void neutralize()
        {
            this.btnRight1.Enabled = false;
            this.btnRight2.Enabled = false;
            this.btnRight3.Enabled = false;
            this.btnRight4.Enabled = false;
            this.btnRight5.Enabled = false;
            this.btnRight6.Enabled = false;
            this.btnRight7.Enabled = false;
            this.btnRight8.Enabled = false;
        }

        private bool guess(String surname)
        {
            bool temp = false;
            if(this.indeks == 1)
            {
                if (this.spojki.pairs[this.btnLeft1.Text].Equals(surname))
                {
                    this.btnLeft1.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft1.BackColor = Color.Red;
                }
                this.btnLeft2.BackColor = Color.Yellow;
                this.indeks = 2;
                return temp;
            }
            else if (this.indeks == 2)
            {
                if (this.spojki.pairs[this.btnLeft2.Text].Equals(surname))
                {
                    this.btnLeft2.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft2.BackColor = Color.Red;
                }
                this.btnLeft3.BackColor = Color.Yellow;
                this.indeks = 3;
                return temp;
            }
            else if (this.indeks == 3)
            {
                if (this.spojki.pairs[this.btnLeft3.Text].Equals(surname))
                {
                    this.btnLeft3.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft3.BackColor = Color.Red;
                }
                this.btnLeft4.BackColor = Color.Yellow;
                this.indeks = 4;
                return temp;
            }
            else if (this.indeks == 4)
            {
                if (this.spojki.pairs[this.btnLeft4.Text].Equals(surname))
                {
                    this.btnLeft4.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft4.BackColor = Color.Red;
                }
                this.btnLeft5.BackColor = Color.Yellow;
                this.indeks = 5;
                return temp;
            }
            else if (this.indeks == 5)
            {
                if (this.spojki.pairs[this.btnLeft5.Text].Equals(surname))
                {
                    this.btnLeft5.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft5.BackColor = Color.Red;
                }
                this.btnLeft6.BackColor = Color.Yellow;
                this.indeks = 6;
                return temp;
            }
            else if (this.indeks == 6)
            {
                if (this.spojki.pairs[this.btnLeft6.Text].Equals(surname))
                {
                    this.btnLeft6.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft6.BackColor = Color.Red;
                }
                this.btnLeft7.BackColor = Color.Yellow;
                this.indeks = 7;
                return temp;
            }
            else if (this.indeks == 7)
            {
                if (this.spojki.pairs[this.btnLeft7.Text].Equals(surname))
                {
                    this.btnLeft7.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft7.BackColor = Color.Red;
                }
                this.btnLeft8.BackColor = Color.Yellow;
                this.indeks = 8;
                return temp;
            }
            else
            {
                if (this.spojki.pairs[this.btnLeft8.Text].Equals(surname))
                {
                    this.btnLeft8.BackColor = Color.Green;
                    gameOne.score += 2;
                    this.lScore.Text = gameOne.score.ToString();
                    temp = true;
                }
                else
                {
                    this.btnLeft8.BackColor = Color.Red;
                }
                this.indeks = 9;
                neutralize();
                this.timer.Stop();
                this.btnNextGame.Enabled = true;
                return temp;
            }
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight1.Text))
            {
                this.btnRight1.BackColor = Color.Green;
                this.btnRight1.Enabled = false;
            }
        }

        private void btnRight7_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight7.Text))
            {
                this.btnRight7.BackColor = Color.Green;
                this.btnRight7.Enabled = false;
            }
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight2.Text))
            {
                this.btnRight2.BackColor = Color.Green;
                this.btnRight2.Enabled = false;
            }
        }

        private void btnRight3_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight3.Text))
            {
                this.btnRight3.BackColor = Color.Green;
                this.btnRight3.Enabled = false;
            }
        }

        private void btnRight4_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight4.Text))
            {
                this.btnRight4.BackColor = Color.Green;
                this.btnRight4.Enabled = false;
            }
        }

        private void btnRight5_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight5.Text))
            {
                this.btnRight5.BackColor = Color.Green;
                this.btnRight5.Enabled = false;
            }
        }

        private void btnRight6_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight6.Text))
            {
                this.btnRight6.BackColor = Color.Green;
                this.btnRight6.Enabled = false;
            }
        }

        private void btnRight8_Click(object sender, EventArgs e)
        {
            if (guess(this.btnRight8.Text))
            {
                this.btnRight8.BackColor = Color.Green;
                this.btnRight8.Enabled = false;
            }
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Skocko sk = new Skocko();
            sk.Closed += (s, args) => this.Close();
            sk.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.counter++;
            if (counter == 61)
            {
                neutralize();
                this.btnNextGame.Enabled = true;
                this.timer.Stop();
            }
        }
    }
}
