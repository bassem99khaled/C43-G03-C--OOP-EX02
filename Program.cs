using static System.Net.Mime.MediaTypeNames;
using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using C43_G03_C__OOP_EX02.Examination_System;

namespace C43_G03_C__OOP_EX02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(1 , "Programing");

            subject.CreateExam();

            Console.WriteLine("Do you want to start the exam? ( Y OR N )");

            string startExam = Console.ReadLine();

            if (startExam.ToUpper() == "Y")
            {
                subject.ShowExam();
            }


        }
    }
}