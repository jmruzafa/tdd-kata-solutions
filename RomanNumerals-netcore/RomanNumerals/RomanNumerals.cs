using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    public class RomanNumeralsConverter
    {
        private Dictionary<String, int> dic = new Dictionary<String, int>()
                                        {
                                            { "C",100 },{ "XC",90 },{ "L",50 },{ "XL", 40 },{ "X",10 },{ "IX",9 },{ "V",5 },{ "IV",4 },{ "I",1 },
                                        };


        public String ConvertToRoman(int num)
        {
            var roman = String.Empty;
            foreach (var kvp in dic)
            {
                while (num >= kvp.Value)
                {
                    num -= kvp.Value;
                    roman = kvp.Key;
                    return roman + this.ConvertToRoman(num);
                }
                
            }
            return roman;
        }

    }
}
