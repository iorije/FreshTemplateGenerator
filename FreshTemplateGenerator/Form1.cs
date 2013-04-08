using FreshTemplateGenerator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;

namespace FreshTemplateGenerator
{
    public partial class FreshTemplateGenerator : Form
    {
        public FreshTemplateGenerator()
        {
            InitializeComponent();
            ClearScreen();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearScreen();

            var formContainer = FormContainer.FillFormContainer(dgvInput);

            var max = 24;
            txtHtmlOutput.Text += GenerateHtml.GenerateDivs(max, formContainer, txtHtmlOutput.Text); 
            
            txtHtmlOutput.Focus();
        }

        private string[] createArrayAtChar(string array, char atIndex)
        {
            return array.Trim().Split(atIndex);
        }

        private void ClearScreen()
        {
            txtHtmlOutput.Text = string.Empty;
            lblValidate.Text = string.Empty;
        }

        private bool IsValidRow(List<int> rowSpans, int max)
        {
            var sum = 0;
            foreach (var nr in rowSpans)
            {
                try
                {
                    sum += nr;
                }
                catch
                {
                    sum += max + 1;
                    txtHtmlOutput.Text += "wrong input format\r\n";
                }
            }
            if (sum == max)
            {
                return true;
            }
            else
            {
                lblValidate.Text = string.Format("{0} columns left", max - sum);
                return false;
            }
        }

        private void dgvInput_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var max = 24;
            if (IsValidRow(FormContainer.GetRowList(dgvInput), max))
            {
                lblValidate.Text = "Correct";
            }
        }
    }
}
