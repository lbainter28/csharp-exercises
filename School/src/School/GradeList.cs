using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class GradeList : List<Grade>
    {
        public int Credits
        {
            get
            {
                int totalCredits = 0;
                foreach (Grade grade in this)
                {
                    totalCredits += grade.Credits;
                }
                return totalCredits;
            }
        }

        public double QualityScore
        {
            get
            {
                double totalQualityScore = 0;
                foreach (Grade grade in this)
                {
                    totalQualityScore += grade.QualityScore;
                }
                return totalQualityScore;
            }
        }

        public double Gpa
        {
            get { return QualityScore / Credits; }
        }
    }
}
