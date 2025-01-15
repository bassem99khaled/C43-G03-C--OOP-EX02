using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_C__OOP_EX02.Examination_System
{
    public abstract class Exam
    {
        #region Property
        public int TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }

        #endregion

        #region Method
        public abstract void ShowExam();
        #endregion

    }
}
