using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALA1.Models
{
    public class PointsData
    {
        //Возможно поменять позже на согласованностьПоинт/запоминаемостьПоинт и тд.

        //Не может быть меньше 0 и больше 10
        public int ControlsCountPoint { get; set; }
        public int RepeatingCountPoint { get; set; }
        public int WordsCountPoint { get; set; }
        public int LongParagraphsCountPoint { get; set; }
        public int PatternMatchPoint { get; set; }
        public int GroupsSizePoint { get; set; }
    }
}
