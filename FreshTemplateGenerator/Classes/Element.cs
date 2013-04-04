using FreshTemplateGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FreshTemplateGenerator.Classes
{
    public class Element : IElement
    {
        protected string _tag { get; set; }
        protected int _index { get; set; }
        public string htmlElement { get; set; }
        public string value { get; set; }

        public IElement InjectClass(string classToInject)
        {
            htmlElement = _tag.Insert(_index, classToInject);
            return this;
        }

        public IElement InjectValue(string valueToInject)
        {
            htmlElement = htmlElement.Insert(htmlElement.IndexOf(">") + 1, "\r\n\t" + valueToInject);
            return this;
        }

        public IElement InjectAttribute(string attributeToInject)
        {
            htmlElement = htmlElement.Insert(htmlElement.IndexOf(">"), attributeToInject);
            return this;
        }
    }
}
