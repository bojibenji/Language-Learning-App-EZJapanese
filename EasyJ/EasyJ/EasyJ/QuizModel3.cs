using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EasyJ
{
	public class QuizModel3 : INotifyPropertyChanged
    {

        public IList<radioButtonHelper> MyList { get; set; }
        public static int currentQuestionIndex = 1;
        public static int numberRight = 0;
        private radioButtonHelper _selectedItem;
        private string _myProperty;
        private string _currentScore;

        //questions array list
        public string[] questions = {
            null,
           "1. What is the japanese word for I want to drink juice.",
            "2. What is the japanese word for I don’t know",
            "3. What is the japanese word for I forgot",
            "4. What is the japanese word for Could you say that one more time?",
            "5. What is the japanese word for Where is it?",
            "6. What is the japanese word for What do you want?",
            "7. What is the japanese word for Please call the police!",
            "8. What is the japanese word for Never",
            "9. What is the japanese word for Usually",
            "10. What is the japanese word for That’s okay"
        };

        string q1Choices = "ジュース を/が 飲みたいです。( ju-su wo/ga nomitai desu), (Mou ichido kudasai)もう一度下さい,(Wasuremashita)忘れました ,(Taitei) たいてい ";
        int[] q1IDS = { 2, 3, 1, 4 };
        string q2Choices = "ジュース を/が 飲みたいです。( ju-su wo/ga nomitai desu) ,(Shirimasen)知りません,(Mou ichido kudasai)もう一度下さい , (Wasuremashita)忘れました";
        int[] q2IDS = {1,2,3,4};
        string q3Choices = " (Shirimasen)知りません, (Doko desu ka?)どこですか,(Wasuremashita)忘れました,ジュース を/が 飲みたいです。( ju-su wo/ga nomitai desu) ";
        int[] q3IDS = { 3,1,2,4 };
        string q4Choices = "(Mou ichido kudasai)もう一度下さい,(Doko desu ka?)どこですか , (Shirimasen)知りません, (Taitei) たいてい";
        int[] q4IDS = { 2, 1, 4, 3 };
        string q5Choices = " (Shirimasen)知りません,ジュース を/が 飲みたいです。( ju-su wo/ga nomitai desu) ,(Doko desu ka?)どこですか, (Mou ichido kudasai)もう一度下さい";
        int[] q5IDS = { 1, 4, 2, 3 };
        string q6Choices = " (Wasuremashita)忘れました,あなたは何 が ほしいですか。(anata wa nani ga hoshii desu ka),(Mou ichido kudasai)もう一度下さい , (Taitei) たいてい";
        int[] q6IDS = { 1, 2, 4, 3 };
        string q7Choices = " (Wasuremashita)忘れました,(Keisatsu o yonde kudasai!) 警察を読んで下さい,(Taitei) たいてい ,(Daijoubu desu) 大丈夫です ";
        int[] q7IDS = { 1, 2, 4, 3 };
        string q8Choices = "(Daijoubu desu) 大丈夫です ,(Wasuremashita)忘れました , (Taitei) たいてい,(Zenzen) 全然";
        int[] q8IDS = { 1, 3, 4, 2 };
        string q9Choices = "(Mou ichido kudasai)もう一度下さい , (Wasuremashita)忘れました,(Taitei) たいてい,(Daijoubu desu) 大丈夫です ";
        int[] q9IDS = { 1, 4, 2, 3 };
        string q10Choices = "(Mou ichido kudasai)もう一度下さい ,(Daijoubu desu) 大丈夫です,(Wasuremashita)忘れました ,(Taitei) たいてい ";
        int[] q10IDS = { 1, 2, 4, 3 };

        public QuizModel3()
        {
            MyList = new ObservableCollection<radioButtonHelper>();
            FillData();
            currentQuestion = questions[currentQuestionIndex];
            currentScore = "Your current score is 0%";
        }

        public radioButtonHelper SelectedItem
        {
            get => _selectedItem;
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
                checkAnswer();
            }

        }

        public string currentQuestion
        {
            get
            {
                return _myProperty;
            }
            set
            {
                if (_myProperty != value)
                {
                    _myProperty = value;
                    OnPropertyChanged();
                }
            }
        }

        public string currentScore
        {
            get
            {
                return _currentScore;
            }
            set
            {
                if (_currentScore != value)
                {
                    _currentScore = value;
                    OnPropertyChanged();
                }
            }
        }

        void FillData()
        {
            char splitter = ',';
            string[] currentChoices = null;
            int[] currentids = null;
            switch (currentQuestionIndex)
            {
                case 1:
                    currentChoices = q1Choices.Split(splitter);
                    currentids = q1IDS;
                    break;
                case 2:
                    currentChoices = q2Choices.Split(splitter);
                    currentids = q2IDS;
                    break;
                case 3:
                    currentChoices = q3Choices.Split(splitter);
                    currentids = q3IDS;
                    break;
                case 4:
                    currentChoices = q4Choices.Split(splitter);
                    currentids = q4IDS;
                    break;
                case 5:
                    currentChoices = q5Choices.Split(splitter);
                    currentids = q5IDS;
                    break;
                case 6:
                    currentChoices = q6Choices.Split(splitter);
                    currentids = q6IDS;
                    break;
                case 7:
                    currentChoices = q7Choices.Split(splitter);
                    currentids = q7IDS;
                    break;
                case 8:
                    currentChoices = q8Choices.Split(splitter);
                    currentids = q8IDS;
                    break;
                case 9:
                    currentChoices = q9Choices.Split(splitter);
                    currentids = q9IDS;
                    break;
                case 10:
                    currentChoices = q10Choices.Split(splitter);
                    currentids = q10IDS;
                    break;
                default:

                    break;
            }



            for (int i = 0; i < 4; i++)
            {
                MyList.Add(new radioButtonHelper { Id = currentids[i], Name = currentChoices[i] });
            }
        }

        void checkAnswer()
        {
            //choice with id of 2 is always the right answer 
            if (_selectedItem.Id == 2)
            {
                numberRight++;
                double score = ((double)numberRight / currentQuestionIndex) * 100;
                currentScore = "Your score is " + Math.Floor(score).ToString() + "%";
                MyList.Clear();
                currentQuestionIndex++;
                if (currentQuestionIndex > questions.Length - 1)
                {
                    currentQuestionIndex = 1;
                    numberRight = 0;
                    currentScore = "Your current score is 0%";
                    // or end the quiz
                }
                //System.Threading.Thread.Sleep(2000);
                FillData();
                currentQuestion = questions[currentQuestionIndex];
            }
            else
            {
                //picked the wrong answer choice 
                double score = ((double)numberRight / currentQuestionIndex) * 100;
                currentScore = "Your score is " + Math.Floor(score).ToString() + "%";
                MyList.Clear();
                currentQuestionIndex++;
                if (currentQuestionIndex > questions.Length - 1)
                {
                    currentQuestionIndex = 1;
                    numberRight = 0;
                    currentScore = "Your current score is 0%";
                    // or end the quiz
                }
               // System.Threading.Thread.Sleep(5000);
                FillData();
                currentQuestion = questions[currentQuestionIndex];
            }
        }


        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        #endregion

    }
}