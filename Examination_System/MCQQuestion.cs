using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_C__OOP_EX02.Examination_System
{
    internal class MCQQuestion : Question
    {

        #region Constructor
        public MCQQuestion()
            {
                AnswerList = new Answer[4]; 
                for (int i = 0; i < AnswerList.Length; i++)
                {
                    AnswerList[i] = new Answer();
                }
            }
        #endregion

    }
}
