using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
    public partial class MathGame : Form
    {
        public MathGame()
        {
            InitializeComponent();
        }

      
        enum enLevel { 
             Easy,
             Med,
             Hard,
             Mix,
             None
        }

        enum enOptype
        {
            Add,
            Sub,
            Mul,
            Div,
            Mix,
            None
        }
      
        struct stQuestion
        {
            public byte Number1;
            public byte Number2;
            public enOptype optype;
            public enLevel QuestionLevel;
            public short RightAnswer;  
        }
        struct stGameInfo
        {
            public byte NumberOfQuestions;
            public enLevel QuestionsLevel;
            public enOptype OperationType;
            public stQuestion[] arrQuestions;
            public byte NumberOfCurrentQuestion;
            public byte RightAnswers;
            public byte WrongAnswers;
        }
        stGameInfo GameInfo = new stGameInfo();
        Random rand = new Random();
       

        void FillData()
        {
            GameInfo.NumberOfQuestions =(byte) nudNumberOfQuestions.Value;
            GameInfo.QuestionsLevel =(enLevel) cbQuestionsLevel.SelectedIndex;
            GameInfo.OperationType =(enOptype) cbOpType.SelectedIndex;
        }

        void SetNumbers(ref stQuestion Question)
        {
            switch(Question.QuestionLevel)
            {
                case enLevel.Easy:
                    Question.Number1 =(byte) rand.Next(1, 11);
                    Question.Number2 = (byte)rand.Next(1, 11);
                    break;

                case enLevel.Med:
                    Question.Number1 = (byte)rand.Next(11, 50);
                    Question.Number2 = (byte)rand.Next(11, 50);
                    break;

                case enLevel.Hard:
                    Question.Number1 = (byte)rand.Next(50, 100);
                    Question.Number2 = (byte)rand.Next(50, 100);
                    break;
            }
        }

        int GetRightAnswer(byte Number1,byte Number2,enOptype OpType)
        {
            switch(OpType)
            {
                case enOptype.Add:
                    return Number1 + Number2;


                case enOptype.Sub:
                    return Number1 - Number2;


                case enOptype.Div:
                    return Number1 / Number2;

                case enOptype.Mul:
                    return Number1 *  Number2;

                default:
                    return Number1 + Number2;
            }
        }
        void CreateQuestion(ref stGameInfo GameInfo,ref stQuestion Question)
        {
            Question.optype = (GameInfo.OperationType == enOptype.Mix)?
                (enOptype)rand.Next(0, 4): GameInfo.OperationType;


            Question.QuestionLevel = (GameInfo.QuestionsLevel == enLevel.Mix) ?
                (enLevel)rand.Next(0, 3) : GameInfo.QuestionsLevel;


            SetNumbers(ref Question);

            Question.RightAnswer =
                (short)GetRightAnswer(Question.Number1, Question.Number2, Question.optype);
        }
        void CreateMathQuestions()
        {
            GameInfo.arrQuestions = new stQuestion[GameInfo.NumberOfQuestions];

            for (int i = 0; i < GameInfo.NumberOfQuestions; i++)
            {
                CreateQuestion(ref GameInfo, ref GameInfo.arrQuestions[i]);
            }
        }


        string GetStringOperationType(enOptype OpType)
        {
            switch(OpType)
            {
                case enOptype.Add:
                    return "+";

                case enOptype.Sub:
                    return "-";

                case enOptype.Mul:
                    return "x";

                case enOptype.Div:
                    return "/";

                default:
                    return "+";
            }
        }
        void ShowQuestion(ref stGameInfo GameInfo)
        {
            lblNumberOfQuestion.Text = (GameInfo.NumberOfCurrentQuestion + 1).ToString();
            lblNumberOfAllQuestions.Text = GameInfo.NumberOfQuestions.ToString();

            lblNumber1.Text = (GameInfo.arrQuestions[GameInfo.NumberOfCurrentQuestion].Number1).ToString();
            lblNumber2.Text = (GameInfo.arrQuestions[GameInfo.NumberOfCurrentQuestion ].Number2).ToString();
            lblOperationType.Text = GetStringOperationType(GameInfo.arrQuestions[GameInfo.NumberOfCurrentQuestion].optype);
            GameInfo.NumberOfCurrentQuestion++;
        }

        void StartGame()
        {
            FillData();
            pnStartGame.Enabled = false;
        
            CreateMathQuestions();
            tabControl1.SelectedTab = tabPage2;
            pnMathGame.Enabled = true;

            ShowQuestion(ref GameInfo);
        }

        string PassOrFail(stGameInfo GameInfo)
        {
            return GameInfo.RightAnswers >= GameInfo.WrongAnswers ? "Pass" : "Fail";
        }

        string GetQuestionLevel(enLevel Level)
        {
            switch(Level)
            {
                case enLevel.Easy:
                    return "Easy";
                case enLevel.Med:
                    return "Med";
                case enLevel.Hard:
                    return "Hard";
                case enLevel.Mix:
                    return "Mix";
                default:
                    return "None";
            }
        }

        string GetOpType(enOptype OpType)
        {
            switch (OpType)
            {
                case enOptype.Add:
                    return "Add";
                case enOptype.Sub:
                    return "Sub";
                case enOptype.Div:
                    return "Div";
                case enOptype.Mul:
                    return "Mul";
                case enOptype.Mix:
                    return "Mix";
                default:
                    return "None";
            }
        }
        void ShowFinalResults(stGameInfo GameInfo)
        {
            pnMathGame.Enabled = false;
            tabControl1.SelectedTab = tabPage3;
            pnFinalResults.Enabled = true;

            string passorfail = PassOrFail(GameInfo);
            lblPassOrFail.Text = $"Final Results is {passorfail}";
            if (passorfail == "Pass") lblPassOrFail.ForeColor = Color.Green;
            else lblPassOrFail.ForeColor = Color.Red;

            lblFinalNumberOfQuestions.Text = GameInfo.NumberOfQuestions.ToString();
            lblQuestionLevel.Text = GetQuestionLevel(GameInfo.QuestionsLevel);
            lblOpType.Text = GetOpType(GameInfo.OperationType);
            lblRightAnswers.Text = GameInfo.RightAnswers.ToString();
            lblWrongAnswers.Text = GameInfo.WrongAnswers.ToString();

        }
        void CheckResult()
        {
            short RightResult = 
                GameInfo.arrQuestions[GameInfo.NumberOfCurrentQuestion - 1].RightAnswer;
            if (nudUserResult.Value == RightResult)  
            {
                pnMathGame.BackColor = Color.LightGreen;
                MessageBox.Show("Right answer-)");
                GameInfo.RightAnswers++;
            }
            else
            {
                pnMathGame.BackColor = Color.Red;
                MessageBox.Show($"Wrong answer-(\nThe Right Answer is {RightResult}");
                GameInfo.WrongAnswers++;
            }

            pnMathGame.BackColor = Color.LightGray;
            nudUserResult.Value = 0;

            if (GameInfo.NumberOfCurrentQuestion < GameInfo.NumberOfQuestions)
                ShowQuestion(ref GameInfo);

            else
                ShowFinalResults(GameInfo);

        }

        void ResetGame()
        {
            GameInfo = new stGameInfo();
            nudUserResult.Minimum = -10000;
            nudUserResult.Maximum = 10000;
            nudNumberOfQuestions.Maximum = 100;
            pnStartGame.Enabled = true;
            tabControl1.SelectedTab = tabPage1;
            nudNumberOfQuestions.Value = 1;
            cbQuestionsLevel.SelectedIndex = 0;
            cbOpType.SelectedIndex = 0;
            pnMathGame.Enabled = false;
            lblNumberOfQuestion.Text = "0";
            lblNumberOfAllQuestions.Text = "0";
            lblNumber1.Text = "0";
            lblNumber2.Text = "0";
            lblOperationType.Text = "+";
            nudUserResult.Value = 0;
            pnFinalResults.Enabled = false;
            lblPassOrFail.Text = "Final Results is";
            lblFinalNumberOfQuestions.Text = "0";
            lblQuestionLevel.Text = "None";
            lblOpType.Text = "None";
            lblRightAnswers.Text = "0";
            lblWrongAnswers.Text = "0";

        }
        private void MathGame_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckResult();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
