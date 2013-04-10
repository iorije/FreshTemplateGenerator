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
        //When you add a value that needs to be filled from the DataGridView,
        //also update FillFomrcontainer();
        public int rowSpan { get; set; }
        public int node { get; set; }
        public string value { get; set; }

        public FormContainer() { }

        public FormContainer(int rowSpanInput, int nodeInput, string valueInput)
        {
            rowSpan = rowSpanInput;
            node = nodeInput;
            value = valueInput;
        }

        internal static List<FormContainer> FillFormContainer(DataGridView dgvInput)
        {
            var formContainer = new List<FormContainer>();
            foreach (DataGridViewRow row in dgvInput.Rows)
            {
                var tempFormContainer = new FormContainer();
                tempFormContainer.rowSpan = Convert.ToInt32(row.Cells[0].Value);
                tempFormContainer.node = Convert.ToInt32(row.Cells[1].Value);
                tempFormContainer.value = HttpUtility.HtmlEncode(row.Cells[2].Value);

                if(tempFormContainer.node != 0)
                    formContainer.Add(tempFormContainer);

                tempFormContainer = null;
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
