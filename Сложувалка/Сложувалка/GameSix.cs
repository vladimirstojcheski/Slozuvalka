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
    public partial class GameSix : Form
    {
        private Asocijacii asocijacija;
        private Dictionary<String[], String[]> A;
        private Dictionary<String[], String[]> B;
        private Dictionary<String[], String[]> V;
        private Dictionary<String[], String[]> G;
        private String[] finals;
        private int aPoints;
        private int bPoints;
        private int vPoints;
        private int gPoints;
        private int finalPoints;

        private bool aEnter;
        private bool bEnter;
        private bool vEnter;
        private bool gEnter;
        private bool finalEnter;

        private bool aDone;
        private bool bDone;
        private bool vDone;
        private bool gDone;
        private int counter;
        TextBox tb;
        public GameSix()
        {
            InitializeComponent();
            String[] aComponents = new String[4] { "ГОЛМАН", "МИНИСТЕР", "ЗАШТИТА", "НАПАД" };
            String[] aFinals = new String[] { "ОДБРАНА", "ЗАШТИТА" };
            this.A = new Dictionary<string[], string[]>();
            A.Add(aComponents, aFinals);

            String[] bComponents = new String[4] { "ПЕКОЛ", "ЛУЦИФЕР", "ЗЛОБА", "РОГОВИ" };
            String[] bFinals = new String[] { "ЃАВОЛ", "ЃАОЛ", "ГАВОЛ" };
            this.B = new Dictionary<string[], string[]>();
            B.Add(bComponents, bFinals);

            String[] vComponents = new String[4] { "КРИМИНАЛ", "ЏУНГЛА", "СОБРАНИЕ", "ДУПКА" };
            String[] vFinals = new String[] { "ЗАКОН", "ЗАКОНИ"};
            this.V = new Dictionary<string[], string[]>();
            V.Add(vComponents, vFinals);

            String[] gComponents = new String[4] { "ПОДДРЖУВАЧ", "ФИРМА", "ПРЕТСТАВНИК", "ПРАТЕНИК" };
            String[] gFinals = new String[] { "ЗАСТАПНИК", "ЗАСТАПНИЦИ"};
            this.G = new Dictionary<string[], string[]>();
            G.Add(gComponents, gFinals);

            this.finals = new string[] { "АДВОКАТ", "АДВОКАТИ" };

            this.aPoints = 10;
            this.bPoints = 10;
            this.vPoints = 10;
            this.gPoints = 10;
            this.finalPoints = 10;

            this.aEnter = false;
            this.bEnter = false;
            this.vEnter = false;
            this.gEnter = false;
            this.finalEnter = false;

            this.aDone = false;
            this.bDone = false;
            this.vDone = false;
            this.gDone = false;
            this.counter = 0;

            this.tb = new TextBox();
        }

        private void updateScore()
        {
            this.lScore.Text = gameOne.score.ToString();
        }

        private void GameSix_Load(object sender, EventArgs e)
        {
            this.lScore.Text = gameOne.score.ToString();
            this.timer.Start();
            this.btnRestart.Enabled = false;
        }

        private void enableA1()
        {
            this.btnA1.Enabled = false;
            this.btnA1.BackColor = Color.White;
            this.aPoints -= 2;
            this.btnA1.Text = this.A.Keys.First()[0];
        }
        private void btnA1_Click(object sender, EventArgs e)
        {
            enableA1();
        }

        private void enableA2()
        {
            this.btnA2.Enabled = false;
            this.btnA2.BackColor = Color.White;
            this.aPoints -= 2;
            this.btnA2.Text = this.A.Keys.First()[1];
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            enableA2();
        }

        private void enableA3()
        {
            this.btnA3.Enabled = false;
            this.btnA3.BackColor = Color.White;
            this.aPoints -= 2;
            this.btnA3.Text = this.A.Keys.First()[2];
        }
        private void btnA3_Click(object sender, EventArgs e)
        {
            enableA3();
        }

        private void enableA4()
        {
            this.btnA4.Enabled = false;
            this.btnA4.BackColor = Color.White;
            this.aPoints -= 2;
            this.btnA4.Text = this.A.Keys.First()[3];
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            enableA4();
        }

        private void enableB1()
        {
            this.btnB1.Enabled = false;
            this.btnB1.BackColor = Color.White;
            this.bPoints -= 2;
            this.btnB1.Text = this.B.Keys.First()[0];
        }
        private void btnB1_Click(object sender, EventArgs e)
        {
            enableB1();
        }

        private void enableB2()
        {
            this.btnB2.Enabled = false;
            this.btnB2.BackColor = Color.White;
            this.bPoints -= 2;
            this.btnB2.Text = this.B.Keys.First()[1];
        }

        private void enableB3()
        {
            this.btnB3.Enabled = false;
            this.btnB3.BackColor = Color.White;
            this.bPoints -= 2;
            this.btnB3.Text = this.B.Keys.First()[2];
        }

        private void enableB4()
        {
            this.btnB4.Enabled = false;
            this.btnB4.BackColor = Color.White;
            this.bPoints -= 2;
            this.btnB4.Text = this.B.Keys.First()[3];
        }

        private void enableV1()
        {
            this.btnV1.Enabled = false;
            this.btnV1.BackColor = Color.White;
            this.vPoints -= 2;
            this.btnV1.Text = this.V.Keys.First()[0];
        }

        private void enableV2()
        {
            this.btnV2.Enabled = false;
            this.btnV2.BackColor = Color.White;
            this.vPoints -= 2;
            this.btnV2.Text = this.V.Keys.First()[1];
        }

        private void enableV3()
        {
            this.btnV3.Enabled = false;
            this.btnV3.BackColor = Color.White;
            this.vPoints -= 2;
            this.btnV3.Text = this.V.Keys.First()[2];
        }

        private void enableV4()
        {
            this.btnV4.Enabled = false;
            this.btnV4.BackColor = Color.White;
            this.vPoints -= 2;
            this.btnV4.Text = this.V.Keys.First()[3];
        }

        private void enableG1()
        {
            this.btnG1.Enabled = false;
            this.btnG1.BackColor = Color.White;
            this.gPoints -= 2;
            this.btnG1.Text = this.G.Keys.First()[0];
        }

        private void enableG2()
        {
            this.btnG2.Enabled = false;
            this.btnG2.BackColor = Color.White;
            this.gPoints -= 2;
            this.btnG2.Text = this.G.Keys.First()[1];
        }

        private void enableG3()
        {
            this.btnG3.Enabled = false;
            this.btnG3.BackColor = Color.White;
            this.gPoints -= 2;
            this.btnG3.Text = this.G.Keys.First()[2];
        }

        private void enableG4()
        {
            this.btnG4.Enabled = false;
            this.btnG4.BackColor = Color.White;
            this.gPoints -= 2;
            this.btnG4.Text = this.G.Keys.First()[3];
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            enableB2();
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            enableB3();
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            enableB4();
        }

        private void btnV1_Click(object sender, EventArgs e)
        {
            enableV1();
        }

        private void btnV2_Click(object sender, EventArgs e)
        {
            enableV2();
        }

        private void btnV3_Click(object sender, EventArgs e)
        {
            enableV3();
        }

        private void btnV4_Click(object sender, EventArgs e)
        {
            enableV4();
        }

        private void btnG1_Click(object sender, EventArgs e)
        {
            enableG1();
        }

        private void btnG2_Click(object sender, EventArgs e)
        {
            enableG2();
        }

        private void btnG3_Click(object sender, EventArgs e)
        {
            enableG3();
        }

        private void btnG4_Click(object sender, EventArgs e)
        {
            enableG4();
        }

        private void txtAFinal_Enter(object sender, EventArgs e)
        {
            if (this.txtAFinal.Enabled)
            {
                if (this.txtAFinal.Text.Equals("А")) //Буквата „А“ е кирилична (внимавај ако менуваш)
                {
                    this.txtAFinal.Text = "";
                    this.aEnter = true;
                }
            }         
        }

        private void txtAFinal_Leave(object sender, EventArgs e)
        {
            if (this.txtAFinal.Text.Equals(""))
            {
                this.txtAFinal.Text = "А"; //Буквата „А“ е кирилична (внимавај ако менуваш)
                this.aEnter = false;
                checkDisabledB();
                checkDisabledV();
                checkDisabledG();
            }
            else
            {
                this.txtBFinal.Enabled = false;
                this.txtVFinal.Enabled = false;
                this.txtGFinal.Enabled = false;
            }
        }

        private void GameSix_Click(object sender, EventArgs e)
        {
            if (this.txtAFinal.Enabled)
            {
                this.txtAFinal.Enabled = false;
                this.txtAFinal.Enabled = true;
            }
            if (this.txtBFinal.Enabled)
            {
                this.txtBFinal.Enabled = false;
                this.txtBFinal.Enabled = true;
            }
            if (this.txtVFinal.Enabled)
            {
                this.txtVFinal.Enabled = false;
                this.txtVFinal.Enabled = true;
            }
            if (this.txtGFinal.Enabled)
            {
                this.txtGFinal.Enabled = false;
                this.txtGFinal.Enabled = true;
            }
            if(this.txtFinal.Enabled)
            {
                this.txtFinal.Enabled = false;
                this.txtFinal.Enabled = true;
            }
        }

        private void checkDisabledA()
        {
            if (this.aDone == false)
            {
                this.txtAFinal.Enabled = true;
            }
        }

        private void checkDisabledB()
        {
            if (this.bDone == false)
            {
                this.txtBFinal.Enabled = true;
            }
        }

        private void checkDisabledV()
        {
            if (this.vDone == false)
            {
                this.txtVFinal.Enabled = true;
            }
        }

        private void checkDisabledG()
        {
            if (this.gDone == false)
            {
                this.txtGFinal.Enabled = true;
            }
        }

        private void txtAFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(!this.txtAFinal.Text.Equals(""))
                {
                    String answer = this.txtAFinal.Text;
                    List<String> answers = this.A.Values.SelectMany(x => x).ToList();
                    if(answers.Contains(answer.ToUpper()))
                    {
                        gameOne.score += aPoints;
                        updateScore();
                        this.aPoints = 0;

                        enableA1();
                        enableA2();
                        enableA3();
                        enableA4();
                        this.aDone = true;
                        this.txtAFinal.Enabled = false;
                        this.txtAFinal.Text = answers[0];
                        checkDisabledB();
                        checkDisabledV();
                        checkDisabledG();
                    }
                    else
                    {
                        this.txtAFinal.Text = "";
                    }
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }

        }

        private void txtBFinal_Enter(object sender, EventArgs e)
        {
            if (this.txtBFinal.Enabled)
            {
                if (this.txtBFinal.Text.Equals("Б")) //Буквата „Б“ е кирилична (внимавај ако менуваш)
                {
                    this.txtBFinal.Text = "";
                    this.bEnter = true;
                }
            }
        }

        private void txtBFinal_Leave(object sender, EventArgs e)
        {
            if (this.txtBFinal.Text.Equals(""))
            {
                this.txtBFinal.Text = "Б"; //Буквата „Б“ е кирилична (внимавај ако менуваш)
                this.bEnter = false;
                checkDisabledA();
                checkDisabledV();
                checkDisabledG();
            }
            else
            {
                this.txtAFinal.Enabled = false;
                this.txtVFinal.Enabled = false;
                this.txtGFinal.Enabled = false;
            }
        }

        private void txtBFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.txtBFinal.Text.Equals(""))
                {
                    String answer = this.txtBFinal.Text;
                    List<String> answers = this.B.Values.SelectMany(x => x).ToList();
                    if (answers.Contains(answer.ToUpper()))
                    {
                        gameOne.score += bPoints;
                        updateScore();
                        this.bPoints = 0;

                        enableB1();
                        enableB2();
                        enableB3();
                        enableB4();
                        this.bDone = true;
                        this.txtBFinal.Enabled = false;
                        this.txtBFinal.Text = answers[0];
                        checkDisabledA();
                        checkDisabledV();
                        checkDisabledG();
                    }
                    else
                    {
                        this.txtBFinal.Text = "";
                    }
                }
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtVFinal_Enter(object sender, EventArgs e)
        {
            if (this.txtVFinal.Enabled)
            {
                if (this.txtVFinal.Text.Equals("В")) //Буквата „В“ е кирилична (внимавај ако менуваш)
                {
                    this.txtVFinal.Text = "";
                    this.vEnter = true;
                }
            }
        }

        private void txtVFinal_Leave(object sender, EventArgs e)
        {
            if (this.txtVFinal.Text.Equals(""))
            {
                this.txtVFinal.Text = "В"; //Буквата „В“ е кирилична (внимавај ако менуваш)
                this.vEnter = false;
                checkDisabledA();
                checkDisabledB();
                checkDisabledG();
            }
            else
            {
                this.txtAFinal.Enabled = false;
                this.txtBFinal.Enabled = false;
                this.txtGFinal.Enabled = false;
            }
        }

        private void txtVFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.txtVFinal.Text.Equals(""))
                {
                    String answer = this.txtVFinal.Text;
                    List<String> answers = this.V.Values.SelectMany(x => x).ToList();
                    if (answers.Contains(answer.ToUpper()))
                    {
                        gameOne.score += vPoints;
                        updateScore();
                        this.vPoints = 0;

                        enableV1();
                        enableV2();
                        enableV3();
                        enableV4();
                        this.vDone = true;
                        this.txtVFinal.Enabled = false;
                        this.txtVFinal.Text = answers[0];
                        checkDisabledA();
                        checkDisabledB();
                        checkDisabledG();
                    }
                    else
                    {
                        this.txtVFinal.Text = "";
                    }
                }
                
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtGFinal_Enter(object sender, EventArgs e)
        {
            if (this.txtGFinal.Enabled)
            {
                if (this.txtGFinal.Text.Equals("Г")) //Буквата „Г“ е кирилична (внимавај ако менуваш)
                {
                    this.txtGFinal.Text = "";
                    this.gEnter = true;
                }
            }
        }

        private void txtGFinal_Leave(object sender, EventArgs e)
        {
            if (this.txtGFinal.Text.Equals(""))
            {
                this.txtGFinal.Text = "Г"; //Буквата „Г“ е кирилична (внимавај ако менуваш)
                this.gEnter = false;
                checkDisabledA();
                checkDisabledB();
                checkDisabledV();
            }
            else
            {
                this.txtAFinal.Enabled = false;
                this.txtBFinal.Enabled = false;
                this.txtVFinal.Enabled = false;
            }
        }

        private void txtGFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.txtGFinal.Text.Equals(""))
                {
                    String answer = this.txtGFinal.Text;
                    List<String> answers = this.G.Values.SelectMany(x => x).ToList();
                    if (answers.Contains(answer.ToUpper()))
                    {
                        gameOne.score += gPoints;
                        updateScore();
                        this.gPoints = 0;

                        enableG1();
                        enableG2();
                        enableG3();
                        enableG4();
                        this.gDone = true;
                        this.txtGFinal.Enabled = false;
                        this.txtGFinal.Text = answers[0];
                        checkDisabledA();
                        checkDisabledB();
                        checkDisabledV();
                    }
                    else
                    {
                        this.txtGFinal.Text = "";
                    }
                }
                
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtFinal_Enter(object sender, EventArgs e)
        {
            if (this.txtFinal.Text.Equals("???"))
            {
                this.txtFinal.Text = "";
                this.finalEnter = true;
            }
        }

        private void txtFinal_Leave(object sender, EventArgs e)
        {
            if (this.txtFinal.Text.Equals(""))
            {
                this.txtFinal.Text = "???";
                this.finalEnter = false;
                checkDisabledA();
                checkDisabledB();
                checkDisabledV();
                checkDisabledG();
            }
            else
            {
                this.txtAFinal.Enabled = false;
                this.txtBFinal.Enabled = false;
                this.txtVFinal.Enabled = false;
                this.txtGFinal.Enabled = false;
            }
        }

        private void txtFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!this.txtFinal.Text.Equals(""))
                {
                    String answer = this.txtFinal.Text;
                    List<String> answers = this.finals.ToList();
                    if (answers.Contains(answer.ToUpper()))
                    {
                        int final = 0;
                        if (this.aDone == false)
                        {
                            final += aPoints;
                        }
                        if (this.bDone == false)
                        {
                            final += bPoints;
                        }
                        if (this.vDone == false)
                        {
                            final += vPoints;
                        }
                        if (this.gDone == false)
                        {
                            final += gPoints;
                        }
                        final += this.finalPoints;
                        gameOne.score += final;
                        updateScore();

                        enableA1();
                        enableA2();
                        enableA3();
                        enableA4();
                        this.txtAFinal.Text = this.A.Values.ToList()[0][0];

                        enableB1();
                        enableB2();
                        enableB3();
                        enableB4();
                        this.txtBFinal.Text = this.B.Values.ToList()[0][0];

                        enableV1();
                        enableV2();
                        enableV3();
                        enableV4();
                        this.txtVFinal.Text = this.V.Values.ToList()[0][0];

                        enableG1();
                        enableG2();
                        enableG3();
                        enableG4();
                        this.txtGFinal.Text = this.G.Values.ToList()[0][0];

                        this.txtFinal.Enabled = false;
                        this.txtAFinal.Enabled = false;
                        this.txtBFinal.Enabled = false;
                        this.txtVFinal.Enabled = false;
                        this.txtGFinal.Enabled = false;
                        this.txtFinal.Text = answers[0];
                        this.timer.Stop();
                        this.btnRestart.Enabled = true;
                        this.btnSurrender.Enabled = false;
                    }
                    else
                    {
                        this.txtFinal.Text = "";
                    }
                }

                // remove error sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            endGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.counter++;
            if (counter == 121)
            {
                endGame();
            }
        }

        private void endGame()
        {
            List<String> answers = this.finals.ToList();

            enableA1();
            enableA2();
            enableA3();
            enableA4();
            this.txtAFinal.Text = this.A.Values.ToList()[0][0];

            enableB1();
            enableB2();
            enableB3();
            enableB4();
            this.txtBFinal.Text = this.B.Values.ToList()[0][0];

            enableV1();
            enableV2();
            enableV3();
            enableV4();
            this.txtVFinal.Text = this.V.Values.ToList()[0][0];

            enableG1();
            enableG2();
            enableG3();
            enableG4();
            this.txtGFinal.Text = this.G.Values.ToList()[0][0];

            this.txtFinal.Enabled = false;
            this.txtAFinal.Enabled = false;
            this.txtBFinal.Enabled = false;
            this.txtVFinal.Enabled = false;
            this.txtGFinal.Enabled = false;
            this.txtFinal.Text = answers[0];

            this.btnRestart.Enabled = true;
            this.btnSurrender.Enabled = false;
            this.timer.Stop();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Closed += (s, args) => this.Close();
            f1.Show();
        }
    }
}