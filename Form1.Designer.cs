namespace X_O_Game
{
    partial class Form1
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
            this.laPlayerTurn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laWinner = new System.Windows.Forms.Label();
            this.bRestart = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laPlayerTurn
            // 
            this.laPlayerTurn.AutoSize = true;
            this.laPlayerTurn.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPlayerTurn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laPlayerTurn.Location = new System.Drawing.Point(95, 168);
            this.laPlayerTurn.Name = "laPlayerTurn";
            this.laPlayerTurn.Size = new System.Drawing.Size(145, 48);
            this.laPlayerTurn.TabIndex = 10;
            this.laPlayerTurn.Tag = "1";
            this.laPlayerTurn.Text = "Player 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(95, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 48);
            this.label1.TabIndex = 11;
            this.label1.Tag = "1";
            this.label1.Text = "Turn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(95, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 48);
            this.label2.TabIndex = 12;
            this.label2.Tag = "1";
            this.label2.Text = "Winner";
            // 
            // laWinner
            // 
            this.laWinner.AutoSize = true;
            this.laWinner.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laWinner.ForeColor = System.Drawing.Color.Lime;
            this.laWinner.Location = new System.Drawing.Point(95, 307);
            this.laWinner.Name = "laWinner";
            this.laWinner.Size = new System.Drawing.Size(207, 48);
            this.laWinner.TabIndex = 13;
            this.laWinner.Tag = "1";
            this.laWinner.Text = "In Progress";
            // 
            // bRestart
            // 
            this.bRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRestart.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bRestart.Location = new System.Drawing.Point(103, 370);
            this.bRestart.Name = "bRestart";
            this.bRestart.Size = new System.Drawing.Size(240, 60);
            this.bRestart.TabIndex = 14;
            this.bRestart.Text = "Restart Game";
            this.bRestart.UseVisualStyleBackColor = false;
            this.bRestart.Click += new System.EventHandler(this.bRestart_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(407, 89);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(105, 96);
            this.btn1.TabIndex = 15;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn4.Location = new System.Drawing.Point(407, 208);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(105, 87);
            this.btn4.TabIndex = 16;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn7.Location = new System.Drawing.Point(407, 316);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(105, 96);
            this.btn7.TabIndex = 17;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn8.Location = new System.Drawing.Point(544, 316);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(105, 96);
            this.btn8.TabIndex = 20;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn5.Location = new System.Drawing.Point(544, 208);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(105, 87);
            this.btn5.TabIndex = 19;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(544, 89);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(105, 96);
            this.btn2.TabIndex = 18;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn9.Location = new System.Drawing.Point(680, 316);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(105, 96);
            this.btn9.TabIndex = 23;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn6.Location = new System.Drawing.Point(680, 208);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(105, 87);
            this.btn6.TabIndex = 22;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = global::X_O_Game.Properties.Resources.question_mark_96;
            this.btn3.Location = new System.Drawing.Point(680, 89);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(105, 96);
            this.btn3.TabIndex = 21;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.Clicked_Boutton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(396, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 63);
            this.label3.TabIndex = 24;
            this.label3.Tag = "1";
            this.label3.Text = "Tic_Tac_Toe Game";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(932, 474);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.bRestart);
            this.Controls.Add(this.laWinner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.laPlayerTurn);
            this.Name = "Form1";
            this.Text = "Game Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PrintGame);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label laPlayerTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laWinner;
        private System.Windows.Forms.Button bRestart;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label3;
    }
}

