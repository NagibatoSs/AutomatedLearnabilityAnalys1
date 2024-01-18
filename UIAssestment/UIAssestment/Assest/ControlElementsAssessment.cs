using System.Globalization;
using UIAssestment.TextReading;

namespace UIAssestment.Assest
{
    public class ControlElementsAssessment : Assessment
    {
        private int elementsCount;
        private string[] tags;
        //new[] { "a", "b", "c" }.Any(c => s.Contains(c))
        public override void DoAssessment(string xamlText)
        {
            tags = new string[] { "Button", "CheckBox", "RadioButton", "Expander", "Calendar" };
            elementsCount = 0;
            if (tags.Any(tag => xamlText.Contains(tag)))
                elementsCount++;
            if (elementsCount > 9)
            {
                Rate = 5;
                RateMessage = "Слишком много элементов - " + elementsCount;
            }
            if (elementsCount < 5)
            {
                Rate = 7;
                RateMessage = "Слишком мало элементов - " + elementsCount;
            }
            if (elementsCount >= 5 && elementsCount <= 9)
            {
                Rate = 10;
                RateMessage = "Элементов самый раз - " + elementsCount;
            }
        }
    }
}
