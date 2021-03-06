﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradStatistics
    {
        public GradStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    //if the student scores 89.99 should be rounded to 90 n considered A
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                    result = "F";
                return result;
            }
        }

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Work hard";
                        break;
                    case "D":
                        result = "Work harder";
                        break;
                    case "F":
                        result = "Try again! Don't give up.";
                        break;
                    default:
                        result = "No Grade available";
                        break;
                }
                return result;
            }
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}