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

            txtHtmlOutput.Text += GenerateHtml.GenerateDivs(formContainer, txtHtmlOutput.Text); 
            
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
    }
}
