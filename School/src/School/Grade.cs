using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School
{
    public class Grade
    {
        private readonly int credits;
        private readonly double pointScore;

        public Grade(int credits, double pointScore)
        {
            this.credits = credits;
            this.pointScore = pointScore;
        }

        public int Credits
        {
            get { return credits; }
        }

        public double QualityScore
        {
            get { return credits * pointScore; }
        }
    }
}
