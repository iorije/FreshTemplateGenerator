using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTemplateGenerator.Classes
{
    public class GenerateHtml
    {
        public enum HtmlTag
        {
            None,
            Open,
            Close,
        };

        public static string GenerateDivs(int max, List<FormContainer> formContainer, string returnValue)
        {
            var last = 0;
            for(var i = 0; formContainer.Count > i; i++)
            {
                var currentNode = formContainer[i].node;
                var tabs = GenerateTabs(currentNode);
                var htmlTag = SetEnum(formContainer, currentNode, i);
                if (htmlTag == HtmlTag.None)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);
                    if (last == max)
                    {
                        classToInject = string.Format(" class='span-{0} last'", formContainer[i].rowSpan);
                    }
                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.InjectValue(tabs + formContainer[i].value);
                    htmlDiv.InjectAttribute(" style='background-color:#999999;'");
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs + "<");
                    htmlDiv = null;
                }
                else if (htmlTag == HtmlTag.Close)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);
                    if (last == max)
                    {
                        classToInject = string.Format(" class='span-{0} last'", formContainer[i].rowSpan);
                    }
                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.InjectValue(tabs + formContainer[i].value);
                    htmlDiv.InjectAttribute(" style='background-color:#999999;'");
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs+ "<");
                    tabs = GenerateTabs(currentNode - 1);

                    returnValue += "\r\n" + tabs + "</div>\r\n";

                    htmlDiv = null;
                }
                else
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);
                    if (last == max)
                    {
                        classToInject = string.Format(" class='span-{0} last'", formContainer[i].rowSpan);
                    }
                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.htmlElement = htmlDiv.htmlElement.Replace("</div>", "");
                    htmlDiv.InjectValue(tabs+ formContainer[i].value);
                    htmlDiv.InjectAttribute(" style='background-color:#999999;'");
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs + "<");
                    htmlDiv = null;
                }
            }
            return returnValue;
        }

        private static object GenerateTabs(int currentNode)
        {
            var tabs = "";
            currentNode--;
            for (var i = 0; currentNode > i; i++)
            {
                tabs += "\t";
            }
            return tabs;
        }

        private static HtmlTag SetEnum(List<FormContainer> formContainer, int currentNode, int currentDiv)
        {
            for (var i = 0; formContainer.Count() > i; i++)
            {
                if (i.Equals(currentDiv))
                {
                    try 
                    { 
                        var tempNode = formContainer[i + 1].node;
                        if (tempNode > currentNode)
                        {
                            return HtmlTag.Open;
                        }
                        if (tempNode < currentNode)
                        {
                            return HtmlTag.Close;
                        }
                        break;
                    }
                    catch 
                    {
                        return HtmlTag.Close;
                    }
                }
            }
            return HtmlTag.None;
        }
    }
}
