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
            End,
        };

        public static string GenerateDivs(List<FormContainer> formContainer, string returnValue)
        {
            var last = 0;
            var attribute = " style='background-color:#999999;'";
            for(var i = 0; formContainer.Count > i; i++)
            {
                var currentNode = formContainer[i].node;
                var tabs = GenerateTabs(currentNode);
                var htmlTag = SetEnum(formContainer, currentNode, i);
                if (htmlTag == HtmlTag.None)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);
                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.InjectValue(tabs + formContainer[i].value);
                    htmlDiv.InjectAttribute(attribute);
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs + "<");
                    htmlDiv = null;
                }
                else if (htmlTag == HtmlTag.Close)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0} last'", formContainer[i].rowSpan);

                    if(formContainer[i].rowSpan == 24)
                        classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);

                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.InjectValue(tabs + formContainer[i].value);
                    htmlDiv.InjectAttribute(attribute);
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs+ "<");
                    tabs = GenerateTabs(currentNode - 1);

                    returnValue += string.Format("\r\n{0}</div>\r\n", tabs);

                    htmlDiv = null;
                }
                else if (htmlTag == HtmlTag.End)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0} last'", formContainer[i].rowSpan);

                    if (formContainer[i].rowSpan == 24)
                        classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);

                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.InjectValue(tabs + formContainer[i].value);
                    htmlDiv.InjectAttribute(attribute);
                    returnValue += htmlDiv.htmlElement.Replace("<", tabs + "<");
                    tabs = GenerateTabs(currentNode - 1);

                    for (var t = 0; t < currentNode-1; t++)
                    {

                        tabs = GenerateTabs(currentNode - (t + 1));
                        returnValue += string.Format("\r\n{0}</div>\r\n", tabs);
                    }

                    htmlDiv = null;
                }
                else if (htmlTag == HtmlTag.Open)
                {
                    last += formContainer[i].rowSpan;
                    var classToInject = string.Format(" class='span-{0}'", formContainer[i].rowSpan);
                    var htmlDiv = new Div().InjectClass(classToInject);
                    htmlDiv.htmlElement = htmlDiv.htmlElement.Replace("</div>", "");

                    if(!string.IsNullOrEmpty(formContainer[i].value))
                        htmlDiv.InjectValue(tabs + formContainer[i].value);

                    htmlDiv.InjectAttribute(attribute);
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
                        return HtmlTag.End;
                    }
                }
            }
            return HtmlTag.None;
        }
    }
}
