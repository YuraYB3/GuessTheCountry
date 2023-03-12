using System;
using System.Collections.Generic;
using System.Text;

namespace GuessTheCountry
{
    public static class PointControl
    {
        public static int rightAnswers = 0;
        public static int wrongAnswers = 0;
        public static int allAnswers = 0;

        public static void IncreaseRightAnswers()
        {
            rightAnswers++;
            IncreaseAllAnswers();
        }
        public static void IncreaseWrongAnswers()
        {
            wrongAnswers++;
            IncreaseAllAnswers();
        }
        private static void IncreaseAllAnswers() => allAnswers++;
    }
}
