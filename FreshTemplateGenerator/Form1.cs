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

namespace FreshTemplateGenerator
{
    public partial class FreshTemplateGenerator : Form
    {
        public FreshTemplateGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ClearScreen();

            var atIndex = ' ';
            var rowSpans = createArrayAtChar(txtRows.Text, atIndex);

            atIndex = '\\';
            var values = createArrayAtChar(txtValues.Text ,atIndex);
            int max = 24;

            var divs = new Dictionary<int,string>();
            int i = 0;
            foreach (var rowSpan in rowSpans)
            {
                //change values and key's from position
                divs.Add(Convert.ToInt32(rowSpan), values[i]);
                i++;
            }
            
            if (IsValidRow(rowSpans, max))
            {
                txtHtmlOutput.Text += GenerateHtml.GenerateDivs(max, divs, txtHtmlOutput.Text); 
            }
            else
            {
                txtHtmlOutput.Text += "Do the math again.\r\n";
            }
            lblError.Text = string.Empty;
            txtHtmlOutput.Focus();
        }

        private string[] createArrayAtChar(string array, char atIndex)
        {
            return array.Trim().Split(atIndex);
        }

        private void ClearScreen()
        {
            txtHtmlOutput.Text = string.Empty;
        }

        private bool IsValidRow(string[] rowSpans, int max)
        {
            var sum = 0;
            foreach (var nr in rowSpans)
            {
                try
                {
                    sum += Convert.ToInt32(nr);
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
                lblError.Text = string.Format("{0} columns left", max - sum);
                return false;
            }
        }

        private void txtTest_TextChanged(object sender, EventArgs e)
        {
            int max = 24;

            if (IsValidRow(createArrayAtChar(txtRows.Text, ' '), max))
            {
                lblError.Text = "Good";
            }
            ClearScreen();
        }
    }
}
