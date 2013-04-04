using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace FreshTemplateGenerator.Classes
{
    public class FormContainer
    {
        public int rowSpan { get; set; }
        public string value { get; set; }

        public FormContainer(int rowSpanInput, string valueInput)
        {
            rowSpan = rowSpanInput;
            value = valueInput;
        }

        internal static List<FormContainer> FillFormContainer(DataGridView dgvInput)
        {
            var formContainer = new List<FormContainer>();
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    formContainer.Add(new FormContainer(Convert.ToInt32(row.Cells[0].Value.ToString()), HttpUtility.HtmlEncode(row.Cells[1].Value.ToString())));
                }
            }
            return formContainer;
        }

        internal static List<int> GetRowList(DataGridView dgvInput) 
        {
            var rowList = new List<int>();
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    rowList.Add(Convert.ToInt32(row.Cells[0].Value.ToString()));
                }
            }
            return rowList;
        }
    }
}
