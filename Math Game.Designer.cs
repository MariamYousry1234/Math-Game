
namespace Math_Game
{
    partial class MathGame
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnStartGame = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbOpType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbQuestionsLevel = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnMathGame = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.nudUserResult = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOperationType = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.lblNumber1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblNumberOfAllQuestions = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumberOfQuestion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnFinalResults = new System.Windows.Forms.Panel();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWrongAnswers = new System.Windows.Forms.Label();
            this.lblRightAnswers = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblOpType = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblQuestionLevel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFinalNumberOfQuestions = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPassOrFail = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnStartGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnMathGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserResult)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnFinalResults.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1053, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.pnStartGame);
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1045, 633);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start Game";
            // 
            // pnStartGame
            // 
            this.pnStartGame.BackColor = System.Drawing.Color.DarkGray;
            this.pnStartGame.Controls.Add(this.btnStart);
            this.pnStartGame.Controls.Add(this.cbOpType);
            this.pnStartGame.Controls.Add(this.label4);
            this.pnStartGame.Controls.Add(this.cbQuestionsLevel);
            this.pnStartGame.Controls.Add(this.label3);
            this.pnStartGame.Controls.Add(this.nudNumberOfQuestions);
            this.pnStartGame.Controls.Add(this.label2);
            this.pnStartGame.Controls.Add(this.label1);
            this.pnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStartGame.Location = new System.Drawing.Point(3, 3);
            this.pnStartGame.Name = "pnStartGame";
            this.pnStartGame.Size = new System.Drawing.Size(1037, 625);
            this.pnStartGame.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(420, 569);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(218, 44);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Let\'s Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbOpType
            // 
            this.cbOpType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpType.FormattingEnabled = true;
            this.cbOpType.Items.AddRange(new object[] {
            "Add",
            "Sub",
            "Mul",
            "Div",
            "Mix"});
            this.cbOpType.Location = new System.Drawing.Point(456, 449);
            this.cbOpType.Name = "cbOpType";
            this.cbOpType.Size = new System.Drawing.Size(291, 43);
            this.cbOpType.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(147, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 51);
            this.label4.TabIndex = 13;
            this.label4.Text = "Operation Type :";
            // 
            // cbQuestionsLevel
            // 
            this.cbQuestionsLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuestionsLevel.FormattingEnabled = true;
            this.cbQuestionsLevel.Items.AddRange(new object[] {
            "Easy",
            "Med",
            "Hard",
            "Mix"});
            this.cbQuestionsLevel.Location = new System.Drawing.Point(476, 351);
            this.cbQuestionsLevel.Name = "cbQuestionsLevel";
            this.cbQuestionsLevel.Size = new System.Drawing.Size(291, 43);
            this.cbQuestionsLevel.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(147, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 51);
            this.label3.TabIndex = 11;
            this.label3.Text = "Questions Level :";
            // 
            // nudNumberOfQuestions
            // 
            this.nudNumberOfQuestions.Location = new System.Drawing.Point(594, 237);
            this.nudNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfQuestions.Name = "nudNumberOfQuestions";
            this.nudNumberOfQuestions.Size = new System.Drawing.Size(120, 43);
            this.nudNumberOfQuestions.TabIndex = 10;
            this.nudNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(135, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "The Number Of Questions :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(836, 112);
            this.label1.TabIndex = 8;
            this.label1.Text = "Welcome To Math Game";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnMathGame);
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1045, 633);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Math Game";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnMathGame
            // 
            this.pnMathGame.BackColor = System.Drawing.Color.LightGray;
            this.pnMathGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMathGame.Controls.Add(this.btnCheck);
            this.pnMathGame.Controls.Add(this.nudUserResult);
            this.pnMathGame.Controls.Add(this.label8);
            this.pnMathGame.Controls.Add(this.lblOperationType);
            this.pnMathGame.Controls.Add(this.lblNumber2);
            this.pnMathGame.Controls.Add(this.lblNumber1);
            this.pnMathGame.Controls.Add(this.label7);
            this.pnMathGame.Controls.Add(this.lblNumberOfAllQuestions);
            this.pnMathGame.Controls.Add(this.label6);
            this.pnMathGame.Controls.Add(this.lblNumberOfQuestion);
            this.pnMathGame.Controls.Add(this.label5);
            this.pnMathGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMathGame.Enabled = false;
            this.pnMathGame.Location = new System.Drawing.Point(3, 3);
            this.pnMathGame.Name = "pnMathGame";
            this.pnMathGame.Size = new System.Drawing.Size(1039, 627);
            this.pnMathGame.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(576, 460);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(143, 43);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // nudUserResult
            // 
            this.nudUserResult.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudUserResult.Location = new System.Drawing.Point(376, 454);
            this.nudUserResult.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudUserResult.Name = "nudUserResult";
            this.nudUserResult.Size = new System.Drawing.Size(153, 52);
            this.nudUserResult.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(342, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(363, 58);
            this.label8.TabIndex = 8;
            this.label8.Text = "_____________";
            // 
            // lblOperationType
            // 
            this.lblOperationType.AutoSize = true;
            this.lblOperationType.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperationType.Location = new System.Drawing.Point(533, 318);
            this.lblOperationType.Name = "lblOperationType";
            this.lblOperationType.Size = new System.Drawing.Size(60, 58);
            this.lblOperationType.TabIndex = 7;
            this.lblOperationType.Text = "+";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber2.Location = new System.Drawing.Point(455, 318);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(51, 58);
            this.lblNumber2.TabIndex = 6;
            this.lblNumber2.Text = "0";
            // 
            // lblNumber1
            // 
            this.lblNumber1.AutoSize = true;
            this.lblNumber1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber1.Location = new System.Drawing.Point(455, 221);
            this.lblNumber1.Name = "lblNumber1";
            this.lblNumber1.Size = new System.Drawing.Size(51, 58);
            this.lblNumber1.TabIndex = 5;
            this.lblNumber1.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(725, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 67);
            this.label7.TabIndex = 4;
            this.label7.Text = "]";
            // 
            // lblNumberOfAllQuestions
            // 
            this.lblNumberOfAllQuestions.AutoSize = true;
            this.lblNumberOfAllQuestions.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAllQuestions.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfAllQuestions.Location = new System.Drawing.Point(628, 67);
            this.lblNumberOfAllQuestions.Name = "lblNumberOfAllQuestions";
            this.lblNumberOfAllQuestions.Size = new System.Drawing.Size(58, 67);
            this.lblNumberOfAllQuestions.TabIndex = 3;
            this.lblNumberOfAllQuestions.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(554, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 67);
            this.label6.TabIndex = 2;
            this.label6.Text = "/ ";
            // 
            // lblNumberOfQuestion
            // 
            this.lblNumberOfQuestion.AutoSize = true;
            this.lblNumberOfQuestion.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfQuestion.ForeColor = System.Drawing.Color.Blue;
            this.lblNumberOfQuestion.Location = new System.Drawing.Point(465, 68);
            this.lblNumberOfQuestion.Name = "lblNumberOfQuestion";
            this.lblNumberOfQuestion.Size = new System.Drawing.Size(58, 67);
            this.lblNumberOfQuestion.TabIndex = 1;
            this.lblNumberOfQuestion.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(196, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 67);
            this.label5.TabIndex = 0;
            this.label5.Text = "Question [";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnFinalResults);
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1045, 633);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Final Results";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnFinalResults
            // 
            this.pnFinalResults.Controls.Add(this.btnPlayAgain);
            this.pnFinalResults.Controls.Add(this.groupBox1);
            this.pnFinalResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFinalResults.Enabled = false;
            this.pnFinalResults.Location = new System.Drawing.Point(0, 0);
            this.pnFinalResults.Name = "pnFinalResults";
            this.pnFinalResults.Size = new System.Drawing.Size(1045, 633);
            this.pnFinalResults.TabIndex = 0;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(474, 581);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(170, 46);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWrongAnswers);
            this.groupBox1.Controls.Add(this.lblRightAnswers);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblOpType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblQuestionLevel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblFinalNumberOfQuestions);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblPassOrFail);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(241, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 528);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Final Results";
            // 
            // lblWrongAnswers
            // 
            this.lblWrongAnswers.AutoSize = true;
            this.lblWrongAnswers.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWrongAnswers.Location = new System.Drawing.Point(530, 471);
            this.lblWrongAnswers.Name = "lblWrongAnswers";
            this.lblWrongAnswers.Size = new System.Drawing.Size(35, 40);
            this.lblWrongAnswers.TabIndex = 11;
            this.lblWrongAnswers.Text = "0";
            // 
            // lblRightAnswers
            // 
            this.lblRightAnswers.AutoSize = true;
            this.lblRightAnswers.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRightAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRightAnswers.Location = new System.Drawing.Point(530, 411);
            this.lblRightAnswers.Name = "lblRightAnswers";
            this.lblRightAnswers.Size = new System.Drawing.Size(35, 40);
            this.lblRightAnswers.TabIndex = 10;
            this.lblRightAnswers.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Blue;
            this.label14.Location = new System.Drawing.Point(83, 471);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(412, 40);
            this.label14.TabIndex = 9;
            this.label14.Text = "Number Of Wrong Answers :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(81, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(395, 40);
            this.label13.TabIndex = 8;
            this.label13.Text = "Number Of Right Answers :";
            // 
            // lblOpType
            // 
            this.lblOpType.AutoSize = true;
            this.lblOpType.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblOpType.Location = new System.Drawing.Point(321, 340);
            this.lblOpType.Name = "lblOpType";
            this.lblOpType.Size = new System.Drawing.Size(35, 40);
            this.lblOpType.TabIndex = 7;
            this.lblOpType.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(96, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 40);
            this.label12.TabIndex = 6;
            this.label12.Text = "OpType :";
            // 
            // lblQuestionLevel
            // 
            this.lblQuestionLevel.AutoSize = true;
            this.lblQuestionLevel.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblQuestionLevel.Location = new System.Drawing.Point(381, 271);
            this.lblQuestionLevel.Name = "lblQuestionLevel";
            this.lblQuestionLevel.Size = new System.Drawing.Size(35, 40);
            this.lblQuestionLevel.TabIndex = 5;
            this.lblQuestionLevel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(95, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(236, 40);
            this.label11.TabIndex = 4;
            this.label11.Text = "Question Level :";
            // 
            // lblFinalNumberOfQuestions
            // 
            this.lblFinalNumberOfQuestions.AutoSize = true;
            this.lblFinalNumberOfQuestions.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalNumberOfQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFinalNumberOfQuestions.Location = new System.Drawing.Point(467, 206);
            this.lblFinalNumberOfQuestions.Name = "lblFinalNumberOfQuestions";
            this.lblFinalNumberOfQuestions.Size = new System.Drawing.Size(35, 40);
            this.lblFinalNumberOfQuestions.TabIndex = 3;
            this.lblFinalNumberOfQuestions.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(95, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(335, 40);
            this.label10.TabIndex = 2;
            this.label10.Text = "Number Of Questions :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(81, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(484, 49);
            this.label9.TabIndex = 1;
            this.label9.Text = "_____________________";
            // 
            // lblPassOrFail
            // 
            this.lblPassOrFail.AutoSize = true;
            this.lblPassOrFail.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassOrFail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPassOrFail.Location = new System.Drawing.Point(129, 80);
            this.lblPassOrFail.Name = "lblPassOrFail";
            this.lblPassOrFail.Size = new System.Drawing.Size(287, 52);
            this.lblPassOrFail.TabIndex = 0;
            this.lblPassOrFail.Text = "Final Results is ";
            // 
            // MathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1053, 681);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MathGame";
            this.Text = "Math Game";
            this.Load += new System.EventHandler(this.MathGame_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnStartGame.ResumeLayout(false);
            this.pnStartGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.pnMathGame.ResumeLayout(false);
            this.pnMathGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserResult)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.pnFinalResults.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnStartGame;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbOpType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbQuestionsLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudNumberOfQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnMathGame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.NumericUpDown nudUserResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOperationType;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.Label lblNumber1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNumberOfAllQuestions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumberOfQuestion;
        private System.Windows.Forms.Panel pnFinalResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPassOrFail;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblWrongAnswers;
        private System.Windows.Forms.Label lblRightAnswers;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblOpType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblQuestionLevel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFinalNumberOfQuestions;
        private System.Windows.Forms.Label label10;
    }
}

