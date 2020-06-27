namespace Сложувалка
{
    partial class GameSix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSix));
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.txtAFinal = new System.Windows.Forms.TextBox();
            this.txtBFinal = new System.Windows.Forms.TextBox();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.txtVFinal = new System.Windows.Forms.TextBox();
            this.btnV4 = new System.Windows.Forms.Button();
            this.btnV3 = new System.Windows.Forms.Button();
            this.btnV2 = new System.Windows.Forms.Button();
            this.btnV1 = new System.Windows.Forms.Button();
            this.txtGFinal = new System.Windows.Forms.TextBox();
            this.btnG4 = new System.Windows.Forms.Button();
            this.btnG3 = new System.Windows.Forms.Button();
            this.btnG2 = new System.Windows.Forms.Button();
            this.btnG1 = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSurrender = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnA1
            // 
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.Location = new System.Drawing.Point(56, 115);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(186, 27);
            this.btnA1.TabIndex = 0;
            this.btnA1.Text = "А1";
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(91, 148);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(186, 27);
            this.btnA2.TabIndex = 1;
            this.btnA2.Text = "А2";
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA3
            // 
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(124, 181);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(186, 27);
            this.btnA3.TabIndex = 2;
            this.btnA3.Text = "А3";
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click);
            // 
            // btnA4
            // 
            this.btnA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA4.Location = new System.Drawing.Point(165, 214);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(186, 27);
            this.btnA4.TabIndex = 3;
            this.btnA4.Text = "А4";
            this.btnA4.UseVisualStyleBackColor = true;
            this.btnA4.Click += new System.EventHandler(this.btnA4_Click);
            // 
            // txtAFinal
            // 
            this.txtAFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFinal.Location = new System.Drawing.Point(201, 247);
            this.txtAFinal.Name = "txtAFinal";
            this.txtAFinal.Size = new System.Drawing.Size(186, 26);
            this.txtAFinal.TabIndex = 4;
            this.txtAFinal.Text = "А";
            this.txtAFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAFinal.Enter += new System.EventHandler(this.txtAFinal_Enter);
            this.txtAFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAFinal_KeyDown);
            this.txtAFinal.Leave += new System.EventHandler(this.txtAFinal_Leave);
            // 
            // txtBFinal
            // 
            this.txtBFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBFinal.Location = new System.Drawing.Point(393, 247);
            this.txtBFinal.Name = "txtBFinal";
            this.txtBFinal.Size = new System.Drawing.Size(186, 26);
            this.txtBFinal.TabIndex = 9;
            this.txtBFinal.Text = "Б";
            this.txtBFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBFinal.Enter += new System.EventHandler(this.txtBFinal_Enter);
            this.txtBFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBFinal_KeyDown);
            this.txtBFinal.Leave += new System.EventHandler(this.txtBFinal_Leave);
            // 
            // btnB4
            // 
            this.btnB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB4.Location = new System.Drawing.Point(452, 214);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(186, 27);
            this.btnB4.TabIndex = 8;
            this.btnB4.Text = "Б4";
            this.btnB4.UseVisualStyleBackColor = true;
            this.btnB4.Click += new System.EventHandler(this.btnB4_Click);
            // 
            // btnB3
            // 
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(500, 181);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(186, 27);
            this.btnB3.TabIndex = 7;
            this.btnB3.Text = "Б3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // btnB2
            // 
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(543, 148);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(186, 27);
            this.btnB2.TabIndex = 6;
            this.btnB2.Text = "Б2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB1
            // 
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(579, 115);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(186, 27);
            this.btnB1.TabIndex = 5;
            this.btnB1.Text = "Б1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // txtVFinal
            // 
            this.txtVFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVFinal.Location = new System.Drawing.Point(201, 323);
            this.txtVFinal.Name = "txtVFinal";
            this.txtVFinal.Size = new System.Drawing.Size(186, 26);
            this.txtVFinal.TabIndex = 14;
            this.txtVFinal.Text = "В";
            this.txtVFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVFinal.Enter += new System.EventHandler(this.txtVFinal_Enter);
            this.txtVFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVFinal_KeyDown);
            this.txtVFinal.Leave += new System.EventHandler(this.txtVFinal_Leave);
            // 
            // btnV4
            // 
            this.btnV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV4.Location = new System.Drawing.Point(165, 355);
            this.btnV4.Name = "btnV4";
            this.btnV4.Size = new System.Drawing.Size(186, 27);
            this.btnV4.TabIndex = 13;
            this.btnV4.Text = "В4";
            this.btnV4.UseVisualStyleBackColor = true;
            this.btnV4.Click += new System.EventHandler(this.btnV4_Click);
            // 
            // btnV3
            // 
            this.btnV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV3.Location = new System.Drawing.Point(124, 388);
            this.btnV3.Name = "btnV3";
            this.btnV3.Size = new System.Drawing.Size(186, 27);
            this.btnV3.TabIndex = 12;
            this.btnV3.Text = "В3";
            this.btnV3.UseVisualStyleBackColor = true;
            this.btnV3.Click += new System.EventHandler(this.btnV3_Click);
            // 
            // btnV2
            // 
            this.btnV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV2.Location = new System.Drawing.Point(91, 421);
            this.btnV2.Name = "btnV2";
            this.btnV2.Size = new System.Drawing.Size(186, 27);
            this.btnV2.TabIndex = 11;
            this.btnV2.Text = "В2";
            this.btnV2.UseVisualStyleBackColor = true;
            this.btnV2.Click += new System.EventHandler(this.btnV2_Click);
            // 
            // btnV1
            // 
            this.btnV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV1.Location = new System.Drawing.Point(56, 454);
            this.btnV1.Name = "btnV1";
            this.btnV1.Size = new System.Drawing.Size(186, 27);
            this.btnV1.TabIndex = 10;
            this.btnV1.Text = "В1";
            this.btnV1.UseVisualStyleBackColor = true;
            this.btnV1.Click += new System.EventHandler(this.btnV1_Click);
            // 
            // txtGFinal
            // 
            this.txtGFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGFinal.Location = new System.Drawing.Point(393, 323);
            this.txtGFinal.Name = "txtGFinal";
            this.txtGFinal.Size = new System.Drawing.Size(186, 26);
            this.txtGFinal.TabIndex = 19;
            this.txtGFinal.Text = "Г";
            this.txtGFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGFinal.Enter += new System.EventHandler(this.txtGFinal_Enter);
            this.txtGFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGFinal_KeyDown);
            this.txtGFinal.Leave += new System.EventHandler(this.txtGFinal_Leave);
            // 
            // btnG4
            // 
            this.btnG4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG4.Location = new System.Drawing.Point(452, 355);
            this.btnG4.Name = "btnG4";
            this.btnG4.Size = new System.Drawing.Size(186, 27);
            this.btnG4.TabIndex = 18;
            this.btnG4.Text = "Г4";
            this.btnG4.UseVisualStyleBackColor = true;
            this.btnG4.Click += new System.EventHandler(this.btnG4_Click);
            // 
            // btnG3
            // 
            this.btnG3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG3.Location = new System.Drawing.Point(500, 388);
            this.btnG3.Name = "btnG3";
            this.btnG3.Size = new System.Drawing.Size(186, 27);
            this.btnG3.TabIndex = 17;
            this.btnG3.Text = "Г3";
            this.btnG3.UseVisualStyleBackColor = true;
            this.btnG3.Click += new System.EventHandler(this.btnG3_Click);
            // 
            // btnG2
            // 
            this.btnG2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG2.Location = new System.Drawing.Point(543, 421);
            this.btnG2.Name = "btnG2";
            this.btnG2.Size = new System.Drawing.Size(186, 27);
            this.btnG2.TabIndex = 16;
            this.btnG2.Text = "Г2";
            this.btnG2.UseVisualStyleBackColor = true;
            this.btnG2.Click += new System.EventHandler(this.btnG2_Click);
            // 
            // btnG1
            // 
            this.btnG1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnG1.Location = new System.Drawing.Point(579, 454);
            this.btnG1.Name = "btnG1";
            this.btnG1.Size = new System.Drawing.Size(186, 27);
            this.btnG1.TabIndex = 15;
            this.btnG1.Text = "Г1";
            this.btnG1.UseVisualStyleBackColor = true;
            this.btnG1.Click += new System.EventHandler(this.btnG1_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(235, 279);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(312, 38);
            this.txtFinal.TabIndex = 20;
            this.txtFinal.Text = "???";
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFinal.Enter += new System.EventHandler(this.txtFinal_Enter);
            this.txtFinal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFinal_KeyDown);
            this.txtFinal.Leave += new System.EventHandler(this.txtFinal_Leave);
            // 
            // lScore
            // 
            this.lScore.AutoSize = true;
            this.lScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScore.Location = new System.Drawing.Point(758, 26);
            this.lScore.Name = "lScore";
            this.lScore.Size = new System.Drawing.Size(29, 31);
            this.lScore.TabIndex = 22;
            this.lScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Поени:";
            // 
            // btnSurrender
            // 
            this.btnSurrender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSurrender.Location = new System.Drawing.Point(12, 272);
            this.btnSurrender.Name = "btnSurrender";
            this.btnSurrender.Size = new System.Drawing.Size(142, 53);
            this.btnSurrender.TabIndex = 23;
            this.btnSurrender.Text = "СЕ ОТКАЖУВАМ";
            this.btnSurrender.UseVisualStyleBackColor = true;
            this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(645, 536);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(142, 53);
            this.btnRestart.TabIndex = 24;
            this.btnRestart.Text = "ОД ПОЧЕТОК";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 555);
            this.progressBar.Maximum = 120;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(626, 23);
            this.progressBar.TabIndex = 25;
            // 
            // GameSix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 630);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnSurrender);
            this.Controls.Add(this.lScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtGFinal);
            this.Controls.Add(this.btnG4);
            this.Controls.Add(this.btnG3);
            this.Controls.Add(this.btnG2);
            this.Controls.Add(this.btnG1);
            this.Controls.Add(this.txtVFinal);
            this.Controls.Add(this.btnV4);
            this.Controls.Add(this.btnV3);
            this.Controls.Add(this.btnV2);
            this.Controls.Add(this.btnV1);
            this.Controls.Add(this.txtBFinal);
            this.Controls.Add(this.btnB4);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.txtAFinal);
            this.Controls.Add(this.btnA4);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnA1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(841, 669);
            this.MinimumSize = new System.Drawing.Size(841, 669);
            this.Name = "GameSix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asocijacii";
            this.Load += new System.EventHandler(this.GameSix_Load);
            this.Click += new System.EventHandler(this.GameSix_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.TextBox txtAFinal;
        private System.Windows.Forms.TextBox txtBFinal;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.TextBox txtVFinal;
        private System.Windows.Forms.Button btnV4;
        private System.Windows.Forms.Button btnV3;
        private System.Windows.Forms.Button btnV2;
        private System.Windows.Forms.Button btnV1;
        private System.Windows.Forms.TextBox txtGFinal;
        private System.Windows.Forms.Button btnG4;
        private System.Windows.Forms.Button btnG3;
        private System.Windows.Forms.Button btnG2;
        private System.Windows.Forms.Button btnG1;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}