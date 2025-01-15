using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_C__OOP_EX02.Examination_System
{
    public class Question
    {
        #region Property
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public int RightAnswer { get; set; }

        public List<int> ChoiceUser { get; set; }

        #endregion

        #region Constructor
        public Question()
        {
            Header = string.Empty;
            Body = string.Empty;
            Mark = 0;
            AnswerList = new Answer[0]; 
        }
        #endregion
    }
}
