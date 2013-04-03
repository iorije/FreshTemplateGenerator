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
            var rawData = txtTest.Text.Trim();
            var rowSpans = rawData.Split(' ');
            int max = 24;

            if (IsValidRow(rowSpans, max))
            {
                var sum = 0;
                foreach (var rowSpan in rowSpans)
                {
                    sum += Convert.ToInt32(rowSpan);
                    if (sum == max)
                    {
                        var x = new Div().InjectClass(string.Format(" class='span-{0} last'", rowSpan));
                        x.InjectValue("test");
                        txtHtmlOutput.Text += x.htmlElement;
                    }
                    else
                    {
                        var x = new Div().InjectClass(string.Format(" class='span-{0}'", rowSpan));
                        x.InjectValue("test");
                        txtHtmlOutput.Text += x.htmlElement;
                    }
                }
            }
            else
            {
                txtHtmlOutput.Text += "Do the math again.\r\n";
            }
            lblError.Text = string.Empty;
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

            if (IsValidRow(txtTest.Text.Trim().Split(' '), max))
            {
                lblError.Text = "Good";
            }
            ClearScreen();
        }
    }
}
