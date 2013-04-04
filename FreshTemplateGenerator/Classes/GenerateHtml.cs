using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTemplateGenerator.Classes
{
    public class GenerateHtml
    {
        public static string GenerateDivs(int max, List<FormContainer> formContainer, string returnValue)
        {
            var index = 0;
            foreach (var div in formContainer)
            {
                if (div.rowSpan == max)
                {
                    var x = new Div().InjectClass(string.Format(" class='span-{0} last'", div.rowSpan));
                    x.InjectValue(div.value);
                    x.InjectAttribute(" style='background-color:#999999;margin:4px;'");
                    returnValue += x.htmlElement;
                }
                else
                {
                    var x = new Div().InjectClass(string.Format(" class='span-{0}'", div.rowSpan));
                    x.InjectValue(div.value);
                    x.InjectAttribute(" style='background-color:#999999;margin:4px;'");
                    returnValue += x.htmlElement;
                }
                index++;
            }
            return returnValue;
        }
    }
}
