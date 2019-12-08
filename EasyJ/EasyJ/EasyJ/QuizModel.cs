using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EasyJ
{
    public class QuizModel : INotifyPropertyChanged
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
            "1. What is the japanese word for I don't understand?",
            "2. What is the japanese word for Stop it!?",
            "3. What is the japanese word for Amazing?",
            "4. What is the japanese word for College?",
            "5. What is the japanese word for Teacher?",
            "6. What is the japanese word for Student?",
            "7. What is the japanese word for When?",
            "8. What is the japanese word for Clothes?",
            "9. What is the japanese word for Dangerous?",
            "10. What is the japanese word for Why?"
        };

        string q1Choices = "わかりません(wakarimasen),服(fuku), スーパー(suupaa),Taitei(たいてい)";
        int[] q1IDS = {2,3,1,4};
        string q2Choices = "英語(eigo), どうして？(doushite?), わかりません (wakarimasen), やめて！(yamete!)";
        int[] q2IDS = { 1, 3, 4, 2 };
        string q3Choices = "服(fuku),すごい(sugoi),どうして？(doushite?) , やめて！(yamete!)";
        int[] q3IDS = { 4,2,1,3 };
        string q4Choices = "死にそう(shinisou),大学 (daigaku), 英語(eigo), どうして？(doushite?)";
        int[] q4IDS = { 1,2,3,4 };
        string q5Choices = "警察(keisatsu), やめて！(yamete!),先生 (sensei?), どうして？(doushite?)";
        int[] q5IDS = { 4,3,2,1 };
        string q6Choices = "トイレ(toire),学生 (gakusei?) , どうして？(doushite?),わかりません (wakarimasen) ";
        int[] q6IDS = { 1, 2, 4, 3 };
        string q7Choices = "手洗い(tearai), どうして？(doushite?), いつ？(itsu?), やめて！(yamete!)";
        int[] q7IDS = { 1,3,2,4};
        string q8Choices = "服(fuku),ありがとうございます(arigatougozaimasu), 英語(eigo),やめて！(yamete!) ";
        int[] q8IDS = { 2,4,3,1 };
        string q9Choices = "英語(eigo) , どうして？(doushite?), すみません(sumimasen),危ない(abunai?)";
        int[] q9IDS = { 1, 3, 4, 2 };
        string q10Choices = "ごめんなさい(gomennasai),どうして？(doushite?) ,わかりません(wakarimasen),スーパー(suupaa)";
        int[] q10IDS = { 1, 2, 4, 3 };
        

        public QuizModel()
        {
            MyList = new ObservableCollection<radioButtonHelper>();
            FillData();
            currentQuestion = questions[currentQuestionIndex];
            currentScore = "Your current score is 0%";
        }

        public radioButtonHelper SelectedItem
        {
            get => _selectedItem;
            set { _selectedItem = value;
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
                    _currentScore= value;
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



            for (int i = 0; i <4 ; i++)
            {
                MyList.Add(new radioButtonHelper { Id = currentids[i], Name = currentChoices[i] });
            }
        }

        void checkAnswer()
        {
            //choice with id of 2 is always the right answer 
          if (_selectedItem.Id== 2)
            {
                numberRight++;
                double score = ((double) numberRight / currentQuestionIndex) * 100;
                currentScore = "Your score is " + Math.Floor(score).ToString() + "%";
                MyList.Clear();
                currentQuestionIndex++;
                if (currentQuestionIndex > questions.Length-1)
                {
                    currentQuestionIndex = 1;
                    numberRight = 0;
                    currentScore = "Your current score is 0%";
                    // or end the quiz
                }
              //  System.Threading.Thread.Sleep(2000);
                FillData();
                currentQuestion = questions[currentQuestionIndex];
            }
          else
            {
                //picked the wrong answer choice 
                double score = ((double) numberRight / currentQuestionIndex) * 100;
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
              //  System.Threading.Thread.Sleep(5000);
                FillData();
                currentQuestion = questions[currentQuestionIndex];
            }
        }

        
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propName = "" ) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

        #endregion

    }

  
}
