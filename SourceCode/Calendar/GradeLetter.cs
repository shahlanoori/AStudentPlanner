using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planner
{
    public class GradeLetter
    {
        private string _code;
        public static GradeLetter A = new GradeLetter("A");
        public static GradeLetter A_Minus = new GradeLetter("A-");

        public static GradeLetter B_Plus = new GradeLetter("B+");
        public static GradeLetter B = new GradeLetter("B");
        public static GradeLetter B_Minus = new GradeLetter("B-");


        public static GradeLetter C_Plus = new GradeLetter("C+");
        public static GradeLetter C = new GradeLetter("C");
        public static GradeLetter C_Minus = new GradeLetter("C-");

        public static GradeLetter D_Plus = new GradeLetter("D+");
        public static GradeLetter D = new GradeLetter("D");
        public static GradeLetter D_Minus = new GradeLetter("D-");


        private static GradeLetter[] _values = { A, A_Minus, B_Plus, B, B_Minus, C_Plus, C, C_Minus, D_Plus, D, D_Minus };

        private GradeLetter(string code)
        {
            _code = code;
        }
        public string getCode()
        {
            return _code;
        }
        public static GradeLetter code(int arg)
        {
            return _values[arg];
        }
        public override string ToString()
        {
            return getCode();
        }
    }
}
