using FreshTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshTemplateGenerator.Interfaces
{
    public interface IElement
    {
        string htmlElement { get; set; }
        string value { get; set; }

        IElement InjectClass(string p);
        IElement InjectValue(string p);
    }
}
