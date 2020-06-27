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
    public partial class GameFive : Form
    {
        private Dictionary<String, Question> questions;
        private List<String> quest;
        private List<Question> answers;
        private int index;
        private int counter;

        public GameFive()
        {
            InitializeComponent();
            this.questions = new Dictionary<String, Question>();
            this.questions.Add("Која година се случи авионската несреќа во која загина" +
                " поранешниот македонски претседател Борис Трајковски?", 
                new Question("2001", "2002", "2003", "2004", "2004"));
            this.questions.Add("Која фудбалска репрезентација и беше противник на Франција" +
                " во финалето на светското првенство во фудбал кое се одржа во Русија " +
                "во 2018 година?",
                new Question("Германија", "Шпанија", "Хрватска", "Белгија", "Хрватска"));
            this.questions.Add("Кој е главен град на Авганистан?",
                new Question("Кабул", "Техеран", "Багдад", "Дамаск", "Кабул"));
            this.questions.Add("Која година започнал средниот век?",
                new Question("622", "476", "1385", "1452", "476"));
            this.questions.Add("Кој познат холивудски актер ја игра главната улога во " +
                "филмската драма „Мирисот на Жената“ (Scent of a Woman)?",
                new Question("Ал Пачино", "Ричард Гир", "Роберт де Ниро", "Џорџ Клуни", "Ал Пачино"));
            this.questions.Add("Кој пејач, пред да ја започне својата соло кариера, " +
                "беше фронтмен на групата „Морал“?",
                new Question("Ѓоко Танески", "Јован Јованов", "Влатко Илиевски", "Елвир Мекиќ", 
                "Влатко Илиевски"));
            this.questions.Add("Со помош на кој орган дишат инсектите?",
                new Question("Овариум", "Тарзус", "Кокса", "Трахеи", "Трахеи"));
            this.questions.Add("Кој е автор на романот „Чичко Горио“?",
                new Question("Виктор Иго", "Оноре де Балзак", "Жан Батист Молиер", "Жан-Жак Русо", "Оноре де Балзак"));
            this.questions.Add("Кој произведувач на автомобили ги произведува моделите “CENTENARIO” и “ASTERION”?",
                new Question("Порше", "Бугати", "Ламборџини", "Ферари", "Ламборџини"));
            this.questions.Add("Која од следните телевизиски емисии ја нема водено Игор Џамбазов?",
                new Question("Пирамида", "Земи или остави", "Тркало на среќата", "Среќни луѓе", "Среќни луѓе"));

            this.quest = this.questions.Keys.ToList<String>();
            this.answers = this.questions.Values.ToList<Question>();
            this.index = 0;
            this.counter = 0;
        }

        private void loadQuestion()
        {
            setQuestionPosition();
            this.btnAnswer1.Text = answers[this.index].answerOne;
            this.btnAnswer2.Text = answers[this.index].answerTwo;
            this.btnAnswer3.Text = answers[this.index].answerThree;
            this.btnAnswer4.Text = answers[this.index].answerFour;
            this.btnNextQuestion.Enabled = false;
        }

        private void setQuestionPosition()
        {
            this.lQuestion.Text = quest[this.index];
            int width = int.Parse(this.lQuestion.Size.Width.ToString());
            int positionX = (841 - width) / 2;
            this.lQuestion.Left = positionX;

            this.lNumOfQuestion.Text = (this.index + 1).ToString() + ".";

            int widthNum = int.Parse(this.lNumOfQuestion.Size.Width.ToString());
            this.lNumOfQuestion.Left = positionX - widthNum;
        }

        private void GameFive_Load(object sender, EventArgs e)
        {
            loadQuestion();
            this.lScore.Text = gameOne.score.ToString();
            this.btnNextGame.Enabled = false;
            this.timer.Start();
        }

        private void updateScore()
        {
            this.lScore.Text = gameOne.score.ToString();
        }

        private void findCorrectAnswer()
        {
            String temp = this.lQuestion.Text;
            String correct = this.questions[temp].correctAnswer;
            if(this.btnAnswer1.Text.Equals(correct))
            {
                this.btnAnswer1.BackColor = Color.Green;
            }
            else if (this.btnAnswer2.Text.Equals(correct))
            {
                this.btnAnswer2.BackColor = Color.Green;
            }
            else if (this.btnAnswer3.Text.Equals(correct))
            {
                this.btnAnswer3.BackColor = Color.Green;
            }
            else
            {
                this.btnAnswer4.BackColor = Color.Green;
            }
        }

        private void setDefaultButtonColor()
        {
            this.btnAnswer1.BackColor = default(Color);
            this.btnAnswer2.BackColor = default(Color);
            this.btnAnswer3.BackColor = default(Color);
            this.btnAnswer4.BackColor = default(Color);
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer4.UseVisualStyleBackColor = true;
        }

        private void disableAllAnswerButtons()
        {
            this.btnAnswer1.Enabled = false;
            this.btnAnswer2.Enabled = false;
            this.btnAnswer3.Enabled = false;
            this.btnAnswer4.Enabled = false;
        }

        private void enableAllAnswerButtons()
        {
            this.btnAnswer1.Enabled = true;
            this.btnAnswer2.Enabled = true;
            this.btnAnswer3.Enabled = true;
            this.btnAnswer4.Enabled = true;
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            disableAllAnswerButtons();
            String answer = this.btnAnswer4.Text;
            if(this.questions[this.lQuestion.Text].correctAnswer.Equals(answer))
            {
                this.btnAnswer4.BackColor = Color.Green;
                gameOne.score += 5;
                updateScore();
                reset();
            }
            else
            {
                this.btnAnswer4.BackColor = Color.Red;
                findCorrectAnswer();
                gameOne.score -= 3;
                updateScore();
                reset();
            }
            this.btnNextQuestion.Enabled = true;
            this.btnSurrender.Enabled = false;
            if (index == 9)
            {
                this.btnNextGame.Enabled = true;
                this.btnNextQuestion.Enabled = false;
            }
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            disableAllAnswerButtons();
            String answer = this.btnAnswer1.Text;
            if (this.questions[this.lQuestion.Text].correctAnswer.Equals(answer))
            {
                this.btnAnswer1.BackColor = Color.Green;
                gameOne.score += 5;
                updateScore();
                reset();
            }
            else
            {
                this.btnAnswer1.BackColor = Color.Red;
                findCorrectAnswer();
                gameOne.score -= 3;
                updateScore();
                reset();
            }
            this.btnNextQuestion.Enabled = true;
            this.btnSurrender.Enabled = false;
            if (index == 9)
            {
                this.btnNextGame.Enabled = true;
                this.btnNextQuestion.Enabled = false;
            }
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            disableAllAnswerButtons();
            String answer = this.btnAnswer2.Text;
            if (this.questions[this.lQuestion.Text].correctAnswer.Equals(answer))
            {
                this.btnAnswer2.BackColor = Color.Green;
                gameOne.score += 5;
                updateScore();
                reset();
            }
            else
            {
                this.btnAnswer2.BackColor = Color.Red;
                findCorrectAnswer();
                gameOne.score -= 3;
                updateScore();
                reset();
            }
            this.btnNextQuestion.Enabled = true;
            this.btnSurrender.Enabled = false;
            if (index == 9)
            {
                this.btnNextGame.Enabled = true;
                this.btnNextQuestion.Enabled = false;
            }
        }

        private void reset()
        {
            this.timer.Stop();
            this.counter = 0;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            disableAllAnswerButtons();
            String answer = this.btnAnswer3.Text;
            if (this.questions[this.lQuestion.Text].correctAnswer.Equals(answer))
            {
                this.btnAnswer3.BackColor = Color.Green;
                gameOne.score += 5;
                updateScore();
                reset();
            }
            else
            {
                this.btnAnswer3.BackColor = Color.Red;
                findCorrectAnswer();
                gameOne.score -= 3;
                updateScore();
                reset();
            }
            this.btnNextQuestion.Enabled = true;
            this.btnSurrender.Enabled = false;
            if (index == 9)
            {
                this.btnNextGame.Enabled = true;
                this.btnNextQuestion.Enabled = false;
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            this.index++;
            if (index < 10)
            {
                loadQuestion();
                enableAllAnswerButtons();
                setDefaultButtonColor();
                this.btnSurrender.Enabled = true;
                this.progressBar.Value = 0;
                this.timer.Start();
            }

        }

        private void btnSurrender_Click(object sender, EventArgs e)
        {
            surrender();
        }

        private void surrender()
        {
            findCorrectAnswer();
            disableAllAnswerButtons();
            this.btnNextQuestion.Enabled = true;
            this.btnSurrender.Enabled = false;
            this.timer.Stop();
            this.counter = 0;
            if (index == 9)
            {
                this.btnNextGame.Enabled = true;
                this.btnNextQuestion.Enabled = false;
            }
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameSix gs = new GameSix();
            gs.Closed += (s, args) => this.Close();
            gs.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(1);
            this.counter++;
            if(counter == 11)
            {
                surrender();
            }
        }
    }
}
