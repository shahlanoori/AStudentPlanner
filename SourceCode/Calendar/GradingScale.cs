using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Planner
{
    public class GradingScale
    {
        private int _code;

        public static GradingScale ninetyThree = new GradingScale(93);
        public static GradingScale ninety = new GradingScale(90);

        public static GradingScale eightySeven = new GradingScale(87);
        public static GradingScale eightyThree = new GradingScale(83);
        public static GradingScale eighty = new GradingScale(80);

        public static GradingScale seventySeven = new GradingScale(77);
        public static GradingScale seventyThree = new GradingScale(73);
        public static GradingScale seventy = new GradingScale(70);

        public static GradingScale sixtySeven = new GradingScale(67);
        public static GradingScale sixtyThree = new GradingScale(63);
        public static GradingScale sixty = new GradingScale(60);

        private static GradingScale[] _values = { ninetyThree, ninety, eightySeven, eightyThree, eighty, seventySeven,
                                                    seventyThree, seventy, sixtySeven, sixtyThree, sixty };
        public static int Length = _values.Length;

        private GradingScale(int code)
        {
            _code = code;
        }
        public static void changeValues(decimal[] newValues)
        {
            _values = newValues.Select(a => new GradingScale(Convert.ToInt32(a))).ToArray();
        }
        public int getCode()
        {
            return _code;
        }

        public static GradingScale code(int arg)
        {
            return _values[arg];
        }
        public int ToInteger()
        {
            return getCode();
        }
    }
}
