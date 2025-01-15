using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_C__OOP_EX02.Examination_System
{
    public class Subject : Exam
    {

        #region Property
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam examOFSubject { get; set; }

        int TypeOfExam, TimeOfExam, NumberOfQuestions, typeOfQuestion;

        #endregion


        #region Constructor

        List<Question> questions = new List<Question>();
        List<int> answeruser = new List<int>();
        DateTime startTime;
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        #endregion

        #region Method
        public void CreateExam()
        {
            startTime = DateTime.Now;
            do
            {
                Console.Write(" Enter The Type Of Exam You Want To Create ( ( 1 ) for Practical and ) || ( ( 2 ) for Final ):  ");

            } while (!int.TryParse(Console.ReadLine(), out TypeOfExam));
            Console.WriteLine("                   ");

            do
            {
                Console.Write(" Enter The Time Of the Exam ( Miuntes ):  ");
                
            } while (!int.TryParse(Console.ReadLine(), out TimeOfExam));
            Console.WriteLine("                   ");
            do
            {
                Console.Write(" Enter The Number Of Questions You Wanted To Create :  ");

            } while (!int.TryParse(Console.ReadLine(), out NumberOfQuestions));





            Console.Clear(); 




            if (TypeOfExam == 2)
            {

                for (int i = 0; i < NumberOfQuestions; i++)
                {

                    do
                    {
                        Console.Write($" Choose The Type Of Question Number({i + 1}) ( ( 1 ) for True Or False ) || ( ( 2 ) For Mcq ) :   ");
                    } while (!int.TryParse(Console.ReadLine(), out typeOfQuestion));


                     Console.Clear();


                    if (typeOfQuestion == 1)
                    {
                        TrueOrFalse TOFQuestion = new TrueOrFalse();

                        Console.WriteLine("( True || False ) Qusetion");
                        TOFQuestion.Header = "( True || False ) Qusetion";

                        do
                        {
                            Console.WriteLine(" Enter The Body of Question:  ");
                           
                           
                            TOFQuestion.Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(TOFQuestion.Body));
                        Console.WriteLine("                   ");

                        int mark;
                        do
                        {
                            Console.Write(" Enter The Marks of Question:  ");
                           
                            

                        } while (!int.TryParse(Console.ReadLine(), out mark));
                        Console.WriteLine("                   ");
                        TOFQuestion.Mark = mark;

                        int ans;
                        do
                        {

                            Console.Write(" Enter The Right Answer of Question ( 1 for True ) || ( 2 for False):  ");
                        } while (!int.TryParse(Console.ReadLine(), out ans));

                        TOFQuestion.RightAnswer = ans;



                        questions.Add(TOFQuestion);
                        
                        
                        Console.Clear();
                     }
                   
                    
                    else
                  
                    {
                        MCQQuestion mCQAndChoices = new MCQQuestion();

                        Console.WriteLine("Choose the Right Answer Question");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("                   ");
                        mCQAndChoices.Header = "Choose the Right Answer Question";

                        Console.Write(" Enter The Body of Question: ");
                        Console.WriteLine("                   ");

                        mCQAndChoices.Body = Console.ReadLine()!;

                        int mark;
                        do
                        {
                            Console.Write(" Enter The Marks of Question:  ");
                            
                        } while (!int.TryParse(Console.ReadLine(), out mark));
                        Console.WriteLine("                   ");
                        mCQAndChoices.Mark = mark;

                        Console.WriteLine("The Choices Of Question: ");
                  

                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("                   ");
                            Console.Write($" Enter The Choice Number {j + 1}:  ");
                            

                            string answer = Console.ReadLine()!;
                            mCQAndChoices.AnswerList[j].AnswerText = answer!;
                        }
                      

                        int rightChoice;
                        do
                        {
                            Console.WriteLine("                   ");
                            Console.Write(" Specify The Right Choice of Question :  ");
                        } while (!int.TryParse(Console.ReadLine(), out rightChoice) || rightChoice < 1 || rightChoice > 4);
                        mCQAndChoices.RightAnswer = rightChoice;

                        questions.Add(mCQAndChoices);

                        Console.Clear();
                    }
                }
            }

            else
           
            {
                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    MCQQuestion mCQAndChoices = new MCQQuestion();

                    Console.WriteLine("Choose One Answer Question:  ");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("                   ");
                    mCQAndChoices.Header = "Choose One Answer Question";

                    Console.WriteLine(" Enter The Body of Question");
                    mCQAndChoices.Body = Console.ReadLine()!;
                  

                    int mark;
                    do
                    {
                        Console.Write(" Enter The Marks of Question :  ");  
                        

                    } while (!int.TryParse(Console.ReadLine(), out mark));
                  
                    mCQAndChoices.Mark = mark;

                    Console.WriteLine("The Choices Of Question:  ");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write($" Enter The Choice Number {j + 1}: ");
                     
                        string answer = Console.ReadLine()!;
                        mCQAndChoices.AnswerList[j].AnswerText = answer;
                    }
                    

                    int rightChoice;
                    do
                    {
                        Console.Write(" Specify The Right Choice of Question: ");
                    } while (!int.TryParse(Console.ReadLine(), out rightChoice) || rightChoice < 1 || rightChoice > 4);
                    mCQAndChoices.RightAnswer = rightChoice;

                    questions.Add(mCQAndChoices);
                    Console.Clear();
                }
            }
        }


        public override void ShowExam()
        {

            foreach (Question question in questions)
            {
                Console.Write(question.Header);
                Console.Write($"  {question.Mark} Mark:  ");
                Console.WriteLine("                   ");
                Console.WriteLine(question.Body);

                if (question.Header == "( True || False ) Qusetion")
                {  
                    Console.Write("( 1 for True ) || ( 2 for False): ");
                }

                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{i + 1}.{question.AnswerList[i].AnswerText}:    ");
                    }
                }

               

                int answer = Convert.ToInt32(Console.ReadLine());
                answeruser.Add(answer);

            }

            Console.Clear();


            Console.WriteLine($"Your Answers:   ");
            Console.WriteLine("-----------------");
            int grade = 0;
            int totalgrade = 0;
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                Console.Writeline($"Q : {i + 1}   , [ Your Answer is ] : {questions[i].Body}  ");
                Console.WriteLine("                     ");
                if (questions[i].RightAnswer == answeruser[i])
                {
                    Console.WriteLine("true");
                  
                    grade += questions[i].Mark;
                }

                else
                {
                    Console.WriteLine("false");
     
                }
                totalgrade += questions[i].Mark;
            }
            Console.WriteLine($"Your Grade is : {grade} from {totalgrade} ");
            Console.WriteLine("                   ");

            DateTime endTime = DateTime.Now;
            TimeSpan SpanTime = endTime - startTime;

            Console.WriteLine($"Time taken: {SpanTime.TotalSeconds} seconds");
            

            #endregion
        }
    }
}
