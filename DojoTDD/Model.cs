using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DojoTDD
{
    public class Model
    {
        private IDisplay m_display;

        private List<string> m_lessThanTwentyTranslations;
        private List<string> m_tens;

        private const string HUNDRED = "hundred";
        private const string THOUSAND = "thousand";
        private const string MILLION = "million";

        public Model(IDisplay display)
        {
            m_display = display;
            m_lessThanTwentyTranslations = new List<string>() { 
                "zero", 
                "one", 
                "two", 
                "three", 
                "four", 
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen", 
                "fourteen", 
                "fifteen", 
                "sixteen", 
                "seventeen", 
                "eighteen", 
                "nineteen"
            };

            m_tens = new List<string>()
            {
                "twenty",
                "thirty",
                "fourty",
                "fifty",
                "sixty",
                "seventy",
                "eighty",
                "ninety"
            };
        }

        public void SpellOutNumber(int number)
        {
            string spellOut = "";

            if(number < 19)
            {
                spellOut = m_lessThanTwentyTranslations[number];
                
            }
            else
            {
                spellOut = m_tens[number / 10 - 2];
                
                int module = number % 10;
                if (module != 0)
                {
                    spellOut += " " + m_lessThanTwentyTranslations[module];
                }
            }

            m_display.display(spellOut);

            
        }
    }
}
