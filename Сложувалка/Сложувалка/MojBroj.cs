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
    public partial class MojBroj : Form
    {
        String expression;
        List<int> index;
        private int counter;

        public MojBroj()
        {
            InitializeComponent();
            this.expression = "";
            this.index = new List<int>();
            this.counter = 0;
        }

        private void MojBroj_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.lNumber.Text = rand.Next(100, 999).ToString();
            this.btnNumber1.Text = rand.Next(1, 9).ToString();
            this.btnNumber2.Text = rand.Next(1, 9).ToString();
            this.btnNumber3.Text = rand.Next(1, 9).ToString();
            this.btnNumber4.Text = rand.Next(1, 9).ToString();
            int[] niza = { 10, 15, 20 };
            this.btnNumber5.Text = niza[rand.Next(0, 2)].ToString();
            int[] niza2 = { 25, 50, 75, 100 };
            this.btnNumber6.Text = niza2[rand.Next(0, 3)].ToString();
            this.btnAdd.Text = "+";
            this.btnSubtract.Text = "-";
            this.btnMultiply.Text = "*";
            this.btnDivide.Text = "/";
            this.btnLeftBracket.Text = "(";
            this.btnRightBracket.Text = ")";
            this.lScore.Text = gameOne.score.ToString();
            this.btnNextGame.Enabled = false;
            this.timer.Start();
        }

        private void btnNumber1_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber1.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber1.Enabled = false;
            this.index.Add(1);
        }

        private void btnNumber2_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber2.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber2.Enabled = false;
            this.index.Add(2);
        }

        private void btnNumber3_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber3.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber3.Enabled = false;
            this.index.Add(3);
        }

        private void btnNumber4_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber4.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber4.Enabled = false;
            this.index.Add(4);
        }

        private void btnNumber5_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber5.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber5.Enabled = false;
            this.index.Add(5);
        }

        private void btnNumber6_Click(object sender, EventArgs e)
        {
            this.expression += this.btnNumber6.Text + " ";
            this.lExpression.Text = this.expression;
            this.btnNumber6.Enabled = false;
            this.index.Add(6);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.expression += this.btnAdd.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(7);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.expression += this.btnSubtract.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(8);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.expression += this.btnMultiply.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(9);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.expression += this.btnDivide.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(10);
        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            this.expression += this.btnLeftBracket.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(11);
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            this.expression += this.btnRightBracket.Text + " ";
            this.lExpression.Text = this.expression;
            this.index.Add(12);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.index.Count > 0)
            {
                if (this.index[this.index.Count - 1] == 1)
                {
                    this.btnNumber1.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(1);
                }
                else if (this.index[this.index.Count - 1] == 2)
                {
                    this.btnNumber2.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(2);
                }
                else if (this.index[this.index.Count - 1] == 3)
                {
                    this.btnNumber3.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(3);
                }
                else if (this.index[this.index.Count - 1] == 4)
                {
                    this.btnNumber4.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(4);
                }
                else if (this.index[this.index.Count - 1] == 5)
                {
                    this.btnNumber5.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 3);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(5);
                }
                else if (this.index[this.index.Count - 1] == 6)
                {
                    this.btnNumber6.Enabled = true;
                    this.expression = this.expression.Substring(0, this.expression.Length - 3);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(6);
                }
                else if (this.index[this.index.Count - 1] == 7)
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(7);
                }
                else if (this.index[this.index.Count - 1] == 8)
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(8);
                }
                else if (this.index[this.index.Count - 1] == 9)
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(9);
                }
                else if (this.index[this.index.Count - 1] == 10)
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(10);
                }
                else if (this.index[this.index.Count - 1] == 11)
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(11);
                }
                else
                {
                    this.expression = this.expression.Substring(0, this.expression.Length - 2);
                    this.lExpression.Text = this.expression;
                    this.index.Remove(12);
                }
            }
        }

        private void caluclateScore()
        {
            int evaluated = int.Parse(this.lEvaluated.Text);
            int number = int.Parse(this.lNumber.Text);
            if (evaluated == number)
            {
                gameOne.score += 30;
            }
            else if (Math.Abs(evaluated - number) == 1)
            {
                gameOne.score += 15;
            }
            else if (Math.Abs(evaluated - number) > 1 && Math.Abs(evaluated - number) <= 10)
            {
                gameOne.score += 10;
            }
            else if (Math.Abs(evaluated - number) > 10 && Math.Abs(evaluated - number) <= 50)
            {
                gameOne.score += 5;
            }
            else
            {
                gameOne.score += 1;
            }
        }

        private void lockButtons()
        {
            this.btnNumber1.Enabled = false;
            this.btnNumber2.Enabled = false;
            this.btnNumber3.Enabled = false;
            this.btnNumber4.Enabled = false;
            this.btnNumber5.Enabled = false;
            this.btnNumber6.Enabled = false;
            this.btnAdd.Enabled = false;
            this.btnSubtract.Enabled = false;
            this.btnMultiply.Enabled = false;
            this.btnDivide.Enabled = false;
            this.btnLeftBracket.Enabled = false;
            this.btnRightBracket.Enabled = false;
            this.btnRemove.Enabled = false;
            this.btnEvaluate.Enabled = false;
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            endOfGame();
        }

        private void endOfGame()
        {
            String tempExpression = this.expression;
            try
            {
                tempExpression = this.expression.Substring(0, this.expression.Length - 1);
                this.lEvaluated.Text = EvaluateString.evaluate(tempExpression).ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Изразот не е валиден");
                return;
            }
            caluclateScore();
            this.lScore.Text = gameOne.score.ToString();
            lockButtons();
            this.btnNextGame.Enabled = true;
            this.timer.Stop();
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spojki sp = new Spojki();
            sp.Closed += (s, args) => this.Close();
            sp.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.counter++;
            if (counter == 101)
            {
                endOfGame();
                this.timer.Stop();
                lockButtons();
                this.btnNextGame.Enabled = true;
            }
        }
    }
}
