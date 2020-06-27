using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Сложувалка
{
    public partial class Form1 : Form
    {
        private String rules;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            this.rules = File.ReadAllText("./pravila.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameOne g1 = new gameOne();
            this.Hide();
            g1.Closed += (s, args) => this.Close();
            g1.Show();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel.Visible = false;
            this.btnRulesBack.Visible = false;
            this.btnStart.TabStop = false;
            this.btnRules.TabStop = false;
            this.btnExit.TabStop = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            this.btnExit.Visible = false;
            this.btnStart.Visible = false;
            this.btnRules.Visible = false;
            this.label1.Visible = false;
            this.flowLayoutPanel.Visible = true;
            this.lRules.Text = rules;
            this.btnRulesBack.Visible = true;
        }

        private void btnRulesBack_Click(object sender, EventArgs e)
        {
            this.btnExit.Visible = true;
            this.btnStart.Visible = true;
            this.btnRules.Visible = true;
            this.label1.Visible = true; ;
            this.flowLayoutPanel.Visible = false;
            this.lRules.Text = this.rules;
            this.btnRulesBack.Visible = false;
        }
    }
}
