using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTemplateGenerator.Classes
{
    public class GenerateHtml
    {
        public static string GenerateDivs(int max, Dictionary<int, string> divs, string returnValue)
        {
            var index = 0;
            foreach (var div in divs)
            {
                if (div.Key == max)
                {
                    var x = new Div().InjectClass(string.Format(" class='span-{0} last'", div.Key));
                    x.InjectValue(div.Value);
                    returnValue += x.htmlElement;
                }
                else
                {
                    var x = new Div().InjectClass(string.Format(" class='span-{0}'", div.Key));
                    x.InjectValue(div.Value);
                    returnValue += x.htmlElement;
                }
                index++;
            }
            return returnValue;
        }
    }
}
