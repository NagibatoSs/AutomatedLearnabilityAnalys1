using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALA1.Models
{
    public class AssessmentData
    {
        public int СontrolsCount { get; set; }
        public int RepeatingCount { get; set; }
        public int WordsCount{ get; set; }
        public int LongParagraphsCount { get; set; }
        public double PatternMatch { get; set; } 
        public double GroupsSize { get; set; } 

        public AssessmentData()
        {
            СontrolsCount = 7;
            RepeatingCount = 0;
            WordsCount = 100;
            LongParagraphsCount = 0;
            PatternMatch = 1;
            GroupsSize = 0.3;//30%
        }
    }
}
