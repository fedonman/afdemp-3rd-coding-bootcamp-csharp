using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAssesment
{
    class RatingStats
    {
        // This class is responsible for the statistical information
        // The purpose of this class is to collect all data together into a single object and to expose it
        // So we create public fields
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        // Initialize highest and lowest Rating. RatingStats responsibility
        public RatingStats()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
    }
}
