using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_C__OOP_EX02.Examination_System
{
    public class Answer
    {
        #region Property
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        #endregion

        #region Constructor
        public Answer()
        {
            AnswerId = 0;
            AnswerText = string.Empty;
        }
        #endregion
    }
}
